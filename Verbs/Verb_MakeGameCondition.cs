// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Verbs.Verb_MakeGameCondition
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using RimWorld;
using UnityEngine;
using Verse;

namespace HediffsAbilities.Verbs
{
  public class Verb_MakeGameCondition : Verb_AbilityHediff
  {
    public override void WarmupComplete()
    {
      if (((Verb) this).CasterPawn.Dead)
        return;
      base.WarmupComplete();
      ((Thing) ((Verb) this).CasterPawn).Map.GameConditionManager.RegisterCondition(GameConditionMaker.MakeCondition(this.Props.gameConditionDef, Mathf.RoundToInt(((FloatRange) ref this.Props.conditionDaysRange).RandomInRange * 60000f)));
      Find.LetterStack.ReceiveLetter(TaggedString.op_Implicit(((Def) this.Props.gameConditionDef).label), TaggedString.op_Implicit(((Def) this.Props.gameConditionDef).description), LetterDefOf.ThreatBig, (string) null);
    }
  }
}
