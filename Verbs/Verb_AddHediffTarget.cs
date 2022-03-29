// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Verbs.Verb_AddHediffTarget
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using Verse;

namespace HediffsAbilities.Verbs
{
    public class Verb_AddHediffTarget : Verb_AbilityHediff
    {
        public override bool ValidateTarget(LocalTargetInfo target, bool showMessages = true) => target != null && target.Pawn != null && base.ValidateTarget(target, showMessages);

        public override void WarmupComplete()
        {
            if ((LocalTargetInfo)currentTarget.Pawn == null) ;
            return;
            base.WarmupComplete();
            CasterPawn.stances.stunner.StunFor(60, CasterPawn, false, false);
            if (currentTarget.Pawn.health.hediffSet.HasHediff(Props.hediffDef, false))
                currentTarget.Pawn.health.RemoveHediff(CasterPawn.health.hediffSet.hediffs.Find(x => x.def == Props.hediffDef));
            HealthUtility.AdjustSeverity(currentTarget.Pawn, Props.hediffDef, Props.severity));
        }
    }
}
