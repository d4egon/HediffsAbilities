// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Verbs.Verb_Wallrise
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using System;
using System.Collections.Generic;
using System.Linq;
using Verse;

namespace HediffsAbilities.Verbs
{
  public class Verb_Wallrise : Verb_AbilityHediff
  {
    public override void WarmupComplete()
    {
      base.WarmupComplete();
      Map map = ((Thing) ((Verb) this).CasterPawn).Map;
      List<Thing> thingList = new List<Thing>();
      thingList.AddRange(this.AffectedCells(((Verb) this).CurrentTarget, map).SelectMany<IntVec3, Thing>((Func<IntVec3, IEnumerable<Thing>>) (c => ((IEnumerable<Thing>) GridsUtility.GetThingList(c, map)).Where<Thing>((Func<Thing, bool>) (t => t.def.category == 2)))));
      foreach (Entity entity in thingList)
        entity.DeSpawn((DestroyMode) 0);
      foreach (IntVec3 affectedCell in this.AffectedCells(((Verb) this).CurrentTarget, map))
        GenSpawn.Spawn(ThingDefOfLocal.ThingDef_RaisedWood, affectedCell, map, (WipeMode) 0);
      foreach (Thing thing in thingList)
      {
        IntVec3 intVec3_1 = IntVec3.Invalid;
        for (int index = 0; index < 9; ++index)
        {
          IntVec3 intVec3_2 = IntVec3.op_Addition(thing.Position, GenRadial.RadialPattern[index]);
          if (GenGrid.InBounds(intVec3_2, map) && GenGrid.Walkable(intVec3_2, map) && map.thingGrid.ThingsListAtFast(intVec3_2).Count <= 0)
          {
            intVec3_1 = intVec3_2;
            break;
          }
        }
        if (IntVec3.op_Inequality(intVec3_1, IntVec3.Invalid))
          GenSpawn.Spawn(thing, intVec3_1, map, (WipeMode) 0);
        else
          GenPlace.TryPlaceThing(thing, thing.Position, map, (ThingPlaceMode) 1, (Action<Thing, int>) null, (Predicate<IntVec3>) null, new Rot4());
      }
    }

    private IEnumerable<IntVec3> AffectedCells(LocalTargetInfo target, Map map)
    {
      foreach (IntVec2 intVec2 in this.Props.pattern)
      {
        LocalTargetInfo localTargetInfo;
        IntVec3 intVec3 = IntVec3.op_Addition(((LocalTargetInfo) ref localTargetInfo).Cell, new IntVec3(intVec2.x, 0, intVec2.z));
        Map map1;
        if (GenGrid.InBounds(intVec3, map1))
          yield return intVec3;
      }
    }
  }
}
