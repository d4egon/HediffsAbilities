// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Patches.Start
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using HarmonyLib;
using Verse;

namespace HediffsAbilities.Patches
{
    [StaticConstructorOnStartup]
    public static class Start
    {
        static Start() => new Harmony("DimonSever000.HediffsAbilities").PatchAll();
    }
}
