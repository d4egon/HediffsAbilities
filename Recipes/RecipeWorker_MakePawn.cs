// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Recipes.RecipeWorker_MakePawn
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll
/*
using HediffsAbilities.ModExtensions;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using Verse;

namespace HediffsAbilities.Recipes
{
  public class RecipeWorker_MakePawn : RecipeWorker
  {
    public virtual void Notify_IterationCompleted(Pawn billDoer, List<Thing> ingredients)
    {
      base.Notify_IterationCompleted(billDoer, ingredients);
      this.Spawn(((LocalTargetInfo) ref billDoer.CurJob.targetA).Thing);
    }

    private void Spawn(Thing parent)
    {
      IntVec3 position = parent.Position;
      PawnKindDef pawnForSpawn = ((Def) this.recipe).GetModExtension<DefModExtension_RecipeMakePawn>().pawnForSpawn;
      Pawn pawn1 = PawnGenerator.GeneratePawn(new PawnGenerationRequest(pawnForSpawn, parent.Faction, (PawnGenerationContext) 2, -1, false, false, false, false, true, false, 1f, false, true, true, true, false, false, false, false, 0.0f, 0.0f, (Pawn) null, 1f, (Predicate<Pawn>) null, (Predicate<Pawn>) null, (IEnumerable<TraitDef>) null, (IEnumerable<TraitDef>) null, new float?(), new float?(((IEnumerable<LifeStageAge>) pawnForSpawn.race.race.lifeStageAges).First<LifeStageAge>().minAge), new float?(), new Gender?(), new float?(), (string) null, (string) null, (RoyalTitleDef) null, (Ideo) null, false, false, false));
      GenSpawn.Spawn((Thing) pawn1, CellFinder.RandomClosewalkCellNear(position, parent.Map, 1, (Predicate<IntVec3>) null), parent.Map, (WipeMode) 0);
      Pawn pawn2 = ((IEnumerable<Pawn>) parent.Map.mapPawns.FreeColonists).FirstOrDefault<Pawn>();
      if (!(pawn1 is Pawn pawn3) || pawn2 == null)
        return;
      string str1;
      string str2;
      InteractionWorker_RecruitAttempt.DoRecruit(((IEnumerable<Pawn>) ((Thing) pawn3).Map.mapPawns.FreeColonists).FirstOrDefault<Pawn>(), pawn3, ref str1, ref str2, false, false);
    }
  }
}
*/

