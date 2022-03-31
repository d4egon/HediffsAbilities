// Decompiled with JetBrains decompiler
// Type: NarutoMod.Recipes.RecipeWorker_MakePawn
// Assembly: NarutoMod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\NarutoMod.dll

using NarutoMod.ModExtensions;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using Verse;

namespace NarutoMod.Recipes
{
    public class NM_RecipeWorker_MakePawn : RecipeWorker
  {
    public override void Notify_IterationCompleted(Pawn billDoer, List<Thing> ingredients)
    {
      base.Notify_IterationCompleted(billDoer, ingredients);
      Spawn(billDoer.CurJob.targetA.Thing);
    }

    private void Spawn(Thing parent)
    {
      IntVec3 position = parent.Position;
      PawnKindDef pawnForSpawn = recipe.GetModExtension<DefModExtension_RecipeMakePawn>().pawnForSpawn;
            Pawn pawn1 = PawnGenerator.GeneratePawn(new PawnGenerationRequest(pawnForSpawn, parent.Faction, (PawnGenerationContext)2, -1, false, false, false, false, true, false, 1f, false, true, true, true, false, false, false, false, 0.0f, 0.0f, null, 1f, null, null, null, null, new float?(), new float?(((IEnumerable<LifeStageAge>)pawnForSpawn.race.race.lifeStageAges).First().minAge), new float?(), new Gender?(), new float?(), null, null, null, null, false, false, false));
      GenSpawn.Spawn( pawn1, CellFinder.RandomClosewalkCellNear(position, parent.Map, 1, null), parent.Map, 0);
      Pawn pawn2 = ((IEnumerable<Pawn>) parent.Map.mapPawns.FreeColonists).FirstOrDefault();
      if (!(pawn1 is Pawn pawn3) || pawn2 == null)
        return;
            InteractionWorker_RecruitAttempt.DoRecruit(((IEnumerable<Pawn>)pawn3.Map.mapPawns.FreeColonists).FirstOrDefault(), pawn3, out _, out _, false, false);
    }
  }
}


