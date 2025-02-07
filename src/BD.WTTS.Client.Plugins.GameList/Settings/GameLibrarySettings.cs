#nullable enable
#pragma warning disable IDE0079 // 请删除不必要的忽略
#pragma warning disable SA1634 // File header should show copyright
#pragma warning disable CS8601 // 引用类型赋值可能为 null。
#pragma warning disable CS0108 // 成员隐藏继承的成员；缺少关键字 new
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由包 BD.Common.Settings.V4.SourceGenerator.Tools 源生成。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using static BD.WTTS.Settings.Abstractions.IGameLibrarySettings;

// ReSharper disable once CheckNamespace
namespace BD.WTTS.Settings;

[JsonSourceGenerationOptions(WriteIndented = true, IgnoreReadOnlyProperties = true)]
[JsonSerializable(typeof(GameLibrarySettings_))]
internal partial class GameLibrarySettingsContext : JsonSerializerContext
{
    static GameLibrarySettingsContext? instance;

    public static GameLibrarySettingsContext Instance
        => instance ??= new GameLibrarySettingsContext(ISettings.GetDefaultOptions());
}

[MPObj, MP2Obj(SerializeLayout.Explicit)]
public sealed partial class GameLibrarySettings_ : IGameLibrarySettings, ISettings, ISettings<GameLibrarySettings_>
{
    public const string Name = nameof(GameLibrarySettings);

    static string ISettings.Name => Name;

    static JsonSerializerContext ISettings.JsonSerializerContext
        => GameLibrarySettingsContext.Instance;

    static JsonTypeInfo ISettings.JsonTypeInfo
        => GameLibrarySettingsContext.Instance.GameLibrarySettings_;

    static JsonTypeInfo<GameLibrarySettings_> ISettings<GameLibrarySettings_>.JsonTypeInfo
        => GameLibrarySettingsContext.Instance.GameLibrarySettings_;

    /// <summary>
    /// 已安装游戏筛选
    /// </summary>
    [MPKey(0), MP2Key(0), JsonPropertyOrder(0)]
    public bool? GameInstalledFilter { get; set; }

    /// <summary>
    /// 支持云存档游戏筛选状态
    /// </summary>
    [MPKey(1), MP2Key(1), JsonPropertyOrder(1)]
    public bool? GameCloudArchiveFilter { get; set; }

    /// <summary>
    /// 游戏类型筛选状态列表
    /// </summary>
    [MPKey(2), MP2Key(2), JsonPropertyOrder(2)]
    public List<SteamAppType>? GameTypeFiltres { get; set; }

    /// <summary>
    /// 隐藏的游戏列表
    /// </summary>
    [MPKey(3), MP2Key(3), JsonPropertyOrder(3)]
    public Dictionary<uint, string?>? HideGameList { get; set; }

    /// <summary>
    /// 挂时长游戏列表
    /// </summary>
    [MPKey(4), MP2Key(4), JsonPropertyOrder(4)]
    public Dictionary<uint, string?>? AFKAppList { get; set; }

    /// <summary>
    /// 启用自动挂机
    /// </summary>
    [MPKey(5), MP2Key(5), JsonPropertyOrder(5)]
    public bool? IsAutoAFKApps { get; set; }

}

public static partial class GameLibrarySettings
{
    /// <summary>
    /// 已安装游戏筛选
    /// </summary>
    public static SettingsStructProperty<bool, GameLibrarySettings_> GameInstalledFilter { get; }
        = new(DefaultGameInstalledFilter);

    /// <summary>
    /// 支持云存档游戏筛选状态
    /// </summary>
    public static SettingsStructProperty<bool, GameLibrarySettings_> GameCloudArchiveFilter { get; }
        = new(DefaultGameCloudArchiveFilter);

    /// <summary>
    /// 游戏类型筛选状态列表
    /// </summary>
    public static SettingsProperty<SteamAppType, List<SteamAppType>, GameLibrarySettings_> GameTypeFiltres { get; }
        = new(DefaultGameTypeFiltres);

    /// <summary>
    /// 隐藏的游戏列表
    /// </summary>
    public static SettingsProperty<uint, string?, Dictionary<uint, string?>, GameLibrarySettings_> HideGameList { get; }
        = new(DefaultHideGameList);

    /// <summary>
    /// 挂时长游戏列表
    /// </summary>
    public static SettingsProperty<uint, string?, Dictionary<uint, string?>, GameLibrarySettings_> AFKAppList { get; }
        = new(DefaultAFKAppList);

    /// <summary>
    /// 启用自动挂机
    /// </summary>
    public static SettingsStructProperty<bool, GameLibrarySettings_> IsAutoAFKApps { get; }
        = new(DefaultIsAutoAFKApps);

}
