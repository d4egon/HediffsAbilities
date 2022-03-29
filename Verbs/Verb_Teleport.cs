// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Verbs.Verb_Teleport
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using RimWorld;
using System;
using System.Linq;
using Verse;

namespace HediffsAbilities.Verbs
{
  public class Verb_Teleport : Verb_AbilityHediff
  {
    protected virtual float EffectiveRange => !this.Props.ignoreRange ? ((Verb) this).EffectiveRange : 999f;

    public override void WarmupComplete()
    {
      base.WarmupComplete();
      this.AddEffecterToMaintain(EffecterDefOf.Skip_Entry.Spawn(((Thing) ((Verb) this).CasterPawn).Position, ((Thing) ((Verb) this).CasterPawn).Map, 1f), ((LocalTargetInfo) ref ((Verb) this).currentTarget).Cell, 120, ((Verb) this).CasterPawn);
      this.AddEffecterToMaintain(EffecterDefOf.Skip_Entry.Spawn(((LocalTargetInfo) ref ((Verb) this).currentTarget).Cell, ((Thing) ((Verb) this).CasterPawn).Map, 1f), ((LocalTargetInfo) ref ((Verb) this).currentTarget).Cell, 120, ((Verb) this).CasterPawn);
      foreach (IntVec3 intVec3 in GenRadial.RadialCellsAround(((Thing) ((Verb) this).CasterPawn).Position, 3f, true).Where<IntVec3>((Func<IntVec3, bool>) (x => ((IntVec3) ref x).IsValid)).ToList<IntVec3>())
      {
        Pawn firstPawn = GridsUtility.GetFirstPawn(intVec3, ((Thing) ((Verb) this).CasterPawn).Map);
        if (firstPawn != null)
        {
          firstPawn.jobs.StopAll(false, true);
          firstPawn.stances.stunner.StunFor(15, (Thing) ((Verb) this).CasterPawn, false, false);
        }
      }
      ((Thing) ((Verb) this).CasterPawn).Position = ((LocalTargetInfo) ref ((Verb) this).currentTarget).Cell;
      ((Verb) this).CasterPawn.stances.stunner.StunFor(45, (Thing) ((Verb) this).CasterPawn, false, false);
      ((Verb) this).CasterPawn.Notify_Teleported(true, true);
    }

    public virtual void DrawHighlight(LocalTargetInfo target)
    {
      if (this.Props.ignoreRange)
        return;
      base.DrawHighlight(target);
    }

    public virtual bool CanHitTargetFrom(IntVec3 root, LocalTargetInfo targ)
    {
      if (((LocalTargetInfo) ref targ).Thing != null && ((LocalTargetInfo) ref targ).Thing == ((Verb) this).caster)
        return ((Verb) this).targetParams.canTargetSelf;
      return !((Verb) this).ApparelPreventsShooting();
    }
  }
}
