// Decompiled with JetBrains decompiler
// Type: NarutoMod.Hediffs.Hediff_Fruit
// Assembly: NarutoMod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\NarutoMod.dll
/*
=======

>>>>>>> e92050d7e21e101c22fa4209e396d0084c1c39e2
using NarutoMod.Things;
using RimWorld;
using System;
using System.Collections.Generic;
using Verse;

namespace NarutoMod.Hediffs
{
  public class Hediff_Fruit : HediffWithComps
  {
    private float severityPerFruit => 0.1f;

    private float powerGain => 100f;

    private Comp_RaceComp comp_Race => ThingCompUtility.TryGetComp<Comp_RaceComp>((Thing) ((Hediff) this).pawn);

    public void Notify_FruitIngested()
    {
      ((Hediff) this).Severity = ((Hediff) this).Severity + this.severityPerFruit;
      if (this.comp_Race != null)
        this.comp_Race.Notify_PowerGain(this.powerGain);
      if (((Thing) ((Hediff) this).pawn).def == ThingDefOfLocal.DivineEater)
        ((Hediff) this).pawn.health.RemoveHediff((Hediff) this);
      if ((double) ((Hediff) this).Severity < (double) ((Hediff) this).def.maxSeverity)
        return;
      this.ChangeRace();
    }

    private void ChangeRace()
    {
      Pawn pawn = PawnGenerator.GeneratePawn(new PawnGenerationRequest(PawnKindDefOfLocal.PawnKindDef_DivineEater, (Faction) null, (PawnGenerationContext) 2, -1, false, false, false, false, true, false, 1f, false, true, true, true, false, false, false, false, 0.0f, 0.0f, (Pawn) null, 1f, (Predicate<Pawn>) null, (Predicate<Pawn>) null, (IEnumerable<TraitDef>) null, (IEnumerable<TraitDef>) null, new float?(), new float?(), new float?(), new Gender?(), new float?(), (string) null, (string) null, (RoyalTitleDef) null, (Ideo) null, false, false, false));
      pawn.ageTracker = ((Hediff) this).pawn.ageTracker;
      pawn.gender = ((Hediff) this).pawn.gender;
      pawn.skills = ((Hediff) this).pawn.skills;
      ((Thing) pawn).SetFaction(Find.FactionManager.OfPlayer, (Pawn) null);
      pawn.health.AddHediff(HediffDefOfLocal.Prostheses_HediffDef_EyeVIII, GenCollection.RandomElement<BodyPartRecord>(pawn.health.hediffSet.GetNotMissingParts((BodyPartHeight) 0, (BodyPartDepth) 0, BodyPartTagDefOf.SightSource, (BodyPartRecord) null)), new DamageInfo?(), (DamageWorker.DamageResult) null);
      GenSpawn.Spawn((Thing) pawn, ((Thing) ((Hediff) this).pawn).Position, ((Thing) ((Hediff) this).pawn).Map, (WipeMode) 0);
      ((Hediff) this).pawn.equipment.DropAllEquipment(((Thing) ((Hediff) this).pawn).Position, true);
      ((Hediff) this).pawn.apparel.DropAll(((Thing) ((Hediff) this).pawn).Position, true, true);
      ((Hediff) this).pawn.inventory.DropAllNearPawn(((Thing) ((Hediff) this).pawn).Position, false, false);
      ((Thing) ((Hediff) this).pawn).Destroy((DestroyMode) 0);
    }
  }
}

*/

