using System.Diagnostics.CodeAnalysis;

namespace ChineseSkinsPort.Displays.Quincy;

[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]

// ReSharper disable once UnusedType.Global
public class NewYearQuincyLevel1 : QuincySkinBase
{
    public override string PrefabName => "NewYearQuincyLevel3"; // Turns out the lvl 1 and lvl 3 models are the exact same. Whoops?
}