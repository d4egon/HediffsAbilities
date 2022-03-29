// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.AI.JobDrivers.JobDriver_SacrificeSelf
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll
/*
using HediffsAbilities.Things;
using System;
using System.Collections.Generic;
using Verse;
using Verse.AI;

namespace HediffsAbilities.AI.JobDrivers
{
  public class JobDriver_SacrificeSelf : JobDriver
  {
    public virtual bool TryMakePreToilReservations(bool errorOnFailed) => ReservationUtility.Reserve(this.pawn, this.job.targetA, this.job, 1, -1, (ReservationLayerDef) null, errorOnFailed);

    protected virtual IEnumerable<Toil> MakeNewToils()
    {
      ToilFailConditions.FailOnDespawnedOrNull<JobDriver_SacrificeSelf>(this, (TargetIndex) 1);
      yield return Toils_Goto.GotoThing((TargetIndex) 1, (PathEndMode) 4);
      Toil toil = Toils_General.Wait(500, (TargetIndex) 0);
      ToilFailConditions.FailOnCannotTouch<Toil>(toil, (TargetIndex) 1, (PathEndMode) 4);
      ToilEffects.WithProgressBarToilDelay(toil, (TargetIndex) 1, false, -0.5f);
      yield return toil;
      Toil enter = new Toil();
      enter.initAction = (Action) (() =>
      {
        Pawn actor = enter.actor;
        Building_FruitTree tree = (Building_FruitTree) ((LocalTargetInfo) ref actor.CurJob.targetA).Thing;
        ((Action) (() => tree.Fill(actor)))();
      });
      enter.defaultCompleteMode = (ToilCompleteMode) 1;
      yield return enter;
    }
  }
}
*/