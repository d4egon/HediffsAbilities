// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Verbs.Verb_AddHediffSelf
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

<<<<<<< HEAD
=======
using System;
>>>>>>> e92050d7e21e101c22fa4209e396d0084c1c39e2
using Verse;

namespace HediffsAbilities.Verbs
{
<<<<<<< HEAD
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
=======
  public class Verb_AddHediffSelf : Verb_AbilityHediff
  {
    public override void WarmupComplete()
    {
      if (((Verb) this).CasterPawn.Dead)
        return;
      base.WarmupComplete();
      if (((Verb) this).CasterPawn.health.hediffSet.HasHediff(this.Props.hediffDef, false))
        ((Verb) this).CasterPawn.health.RemoveHediff(((Verb) this).CasterPawn.health.hediffSet.hediffs.Find((Predicate<Hediff>) (x => x.def == this.Props.hediffDef)));
      HealthUtility.AdjustSeverity(((Verb) this).CasterPawn, this.Props.hediffDef, this.Props.severity);
      ((Verb) this).CasterPawn.stances.stunner.StunFor(60, (Thing) ((Verb) this).CasterPawn, false, false);
    }
  }
>>>>>>> e92050d7e21e101c22fa4209e396d0084c1c39e2
}
