// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Hediffs.Hediff_Illusion
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

/*
using HediffsAbilities.Things;
using RimWorld;
using System.Collections.Generic;
using Verse;

namespace HediffsAbilities.Hediffs
{
  public class Hediff_Illusion : HediffWithComps
  {
    public virtual void Notify_PawnDied()
    {
      base.Notify_PawnDied();
      CompRottable comp = ThingCompUtility.TryGetComp<CompRottable>((Thing) ((Hediff) this).pawn.Corpse);
      if (comp != null)
        comp.RotProgress = (float) comp.PropsRot.TicksToDessicated;
      List<Thing> thingList = ((Thing) ((Hediff) this).pawn.Corpse).Map.listerThings.ThingsOfDef(ThingDefOfLocal.Plant_StrangeFruitTree);
      if (GenList.NullOrEmpty<Thing>((IList<Thing>) thingList))
        return;
      ((Building_FruitTree) GenCollection.RandomElement<Thing>((IEnumerable<Thing>) thingList)).Fill((Thing) ((Hediff) this).pawn.Corpse);
    }
  }
}
*/

