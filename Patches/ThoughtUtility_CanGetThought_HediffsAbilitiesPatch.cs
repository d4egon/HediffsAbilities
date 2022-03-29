// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Patches.ThoughtUtility_CanGetThought_HediffsAbilitiesPatch
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using HarmonyLib;
using RimWorld;
using Verse;

namespace HediffsAbilities.Patches
{
  [HarmonyPatch(typeof (ThoughtUtility))]
  [HarmonyPatch("CanGetThought")]
  public class ThoughtUtility_CanGetThought_HediffsAbilitiesPatch
  {
    private static void Postfix(
      Pawn pawn,
      ThoughtDef def,
      ref bool checkIfNullified,
      ref bool __result)
    {
      if (!__result || ((Thing) pawn).def != ThingDefOfLocal.DivineEater)
        return;
      __result = false;
    }
  }
}
