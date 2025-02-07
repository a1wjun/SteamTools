using BD.WTTS.UI.Views.Pages;
using WinAuth;

namespace BD.WTTS.Models;

public class AuthenticatorGoogleGeneralImport : AuthenticatorGeneralImportBase
{
    public override string Name => Strings.LocalAuth_2FAImport.Format(Strings.Google);

    public override string Description => Strings.LocalAuth_GoogleImport;

    public override ResIcon IconName => ResIcon.Attach;

    public sealed override ICommand AuthenticatorImportCommand { get; set; }

    public AuthenticatorGoogleGeneralImport()
    {
        AuthenticatorImportCommand = ReactiveCommand.Create(async () =>
        {
            if (await VerifyMaxValue())
                await IWindowManager.Instance.ShowTaskDialogAsync(
                    new AuthenticatorGeneralImportPageViewModel(SaveAuthenticator, CreateAuthenticatorValueDto),
                    Name,
                    pageContent: new AuthenticatorGeneralImportPage(), isOkButton: false);
        });
    }

    protected override async Task<IAuthenticatorValueDTO?> CreateAuthenticatorValueDto(string secretCode)
    {
        try
        {
            var privateKey = await AuthenticatorService.DecodePrivateKey(secretCode);

            if (string.IsNullOrEmpty(privateKey))
            {
                Toast.Show(ToastIcon.Error, Strings.LocalAuth_Import_DecodePrivateKeyError.Format("Google"));
                return null;
            }

            var auth = new GoogleAuthenticator();
            auth.Enroll(privateKey);

            if (auth.ServerTimeDiff == 0L)
            {
                // 可以强行添加，但无法保证令牌准确性。
                Toast.Show(ToastIcon.Error, Strings.Error_CannotConnectGoogleServer);
                return null;
            }

            return auth;
        }
        catch (Exception ex)
        {
            ex.LogAndShowT();
            return null;
        }
    }
}