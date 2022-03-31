﻿// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Verbs.Verb_AddHediffSelf
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using Verse;

namespace HediffsAbilities.Verbs
{

    public class Verb_AddHediffSelf : Verb_AbilityHediff
    {
        public override void WarmupComplete()
        {
            if (CasterPawn.Dead)
                return;
            base.WarmupComplete();
            if (CasterPawn.health.hediffSet.HasHediff(Props.hediffDef, false))
                CasterPawn.health.RemoveHediff(CasterPawn.health.hediffSet.hediffs.Find(x => x.def == Props.hediffDef));
            HealthUtility.AdjustSeverity(CasterPawn, Props.hediffDef, Props.severity);
            CasterPawn.stances.stunner.StunFor(60, CasterPawn, false, false);
        }
    }
}
