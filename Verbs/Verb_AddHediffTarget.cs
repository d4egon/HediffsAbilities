// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Verbs.Verb_AddHediffTarget
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using System;
using Verse;

namespace HediffsAbilities.Verbs
{
  public class Verb_AddHediffTarget : Verb_AbilityHediff
  {
    public virtual bool ValidateTarget(LocalTargetInfo target, bool showMessages = true) => !LocalTargetInfo.op_Equality(target, LocalTargetInfo.op_Implicit((Thing) null)) && ((LocalTargetInfo) ref target).Pawn != null && base.ValidateTarget(target, showMessages);

    public override void WarmupComplete()
    {
      if (((LocalTargetInfo) ref ((Verb) this).currentTarget).Pawn == null)
        return;
      base.WarmupComplete();
      ((Verb) this).CasterPawn.stances.stunner.StunFor(60, (Thing) ((Verb) this).CasterPawn, false, false);
      if (((LocalTargetInfo) ref ((Verb) this).currentTarget).Pawn.health.hediffSet.HasHediff(this.Props.hediffDef, false))
        ((LocalTargetInfo) ref ((Verb) this).currentTarget).Pawn.health.RemoveHediff(((Verb) this).CasterPawn.health.hediffSet.hediffs.Find((Predicate<Hediff>) (x => x.def == this.Props.hediffDef)));
      HealthUtility.AdjustSeverity(((LocalTargetInfo) ref ((Verb) this).currentTarget).Pawn, this.Props.hediffDef, this.Props.severity);
    }
  }
}
