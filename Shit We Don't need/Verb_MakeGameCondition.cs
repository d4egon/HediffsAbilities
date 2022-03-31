// Decompiled with JetBrains decompiler
// Type: NarutoMod.Verbs.Verb_MakeGameCondition
// Assembly: NarutoMod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\NarutoMod.dll
/*
using RimWorld;
using UnityEngine;
using Verse;

namespace NarutoMod.Verbs
{
    public class Verb_MakeGameCondition : Verb_AbilityHediff
    {
        public override void WarmupComplete()
        {
            if (CasterPawn.Dead)
                return;
            base.WarmupComplete();
            CasterPawn.Map.GameConditionManager.RegisterCondition(GameConditionMaker.MakeCondition(Props.gameConditionDef, Mathf.RoundToInt(Props.conditionDaysRange.RandomInRange * 60000f)));
            Find.LetterStack.ReceiveLetter(Props.gameConditionDef.label, Props.gameConditionDef.description, LetterDefOf.ThreatBig, null);
        }
    }
}
*/