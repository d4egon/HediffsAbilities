// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Verbs.Verb_TeleportTargetAway
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using RimWorld;
<<<<<<< HEAD
=======
using System;
>>>>>>> e92050d7e21e101c22fa4209e396d0084c1c39e2
using System.Collections.Generic;
using System.Linq;
using Verse;

namespace HediffsAbilities.Verbs
{
<<<<<<< HEAD
    public class Verb_TeleportTargetAway : Verb_AbilityHediff
    {
        public override void WarmupComplete()
        {
            base.WarmupComplete();
            AddEffecterToMaintain(EffecterDefOf.Skip_Entry.Spawn(currentTarget.Pawn.Position, CasterPawn.Map, 1f), currentTarget.Cell, 120, currentTarget.Pawn);
            AddEffecterToMaintain(EffecterDefOf.Skip_Entry.Spawn(CasterPawn.Position, CasterPawn.Map, 1f), CasterPawn.Position, 120, CasterPawn);
            List<IntVec3> list = GenRadial.RadialCellsAround(CasterPawn.Position, Props.range, false).Where(x => x.DistanceTo(CasterPawn.Position) > Props.range - 5.0 && GenGrid.Walkable(x, caster.Map)).ToList();
            if (!GenList.NullOrEmpty<IntVec3>((IList<IntVec3>)list))
            {
                currentTarget.Pawn.Position = GenCollection.RandomElement((IEnumerable<IntVec3>)list);
                ((currentTarget.Pawn.stances.stunner.StunFor(120, (Thing)((Verb)this).CasterPawn, false, false);
                ((currentTarget.Pawn.Notify_Teleported(true, true);
            }
            else
                Messages.Message(Translator.Translate("HediffsAbilities.Messages.CellsNullOrEmpty"), MessageTypeDefOf.NeutralEvent, true);
        }
    }
=======
  public class Verb_TeleportTargetAway : Verb_AbilityHediff
  {
    public override void WarmupComplete()
    {
      base.WarmupComplete();
      this.AddEffecterToMaintain(EffecterDefOf.Skip_Entry.Spawn(((Thing) ((LocalTargetInfo) ref ((Verb) this).currentTarget).Pawn).Position, ((Thing) ((Verb) this).CasterPawn).Map, 1f), ((LocalTargetInfo) ref ((Verb) this).currentTarget).Cell, 120, ((LocalTargetInfo) ref ((Verb) this).currentTarget).Pawn);
      this.AddEffecterToMaintain(EffecterDefOf.Skip_Entry.Spawn(((Thing) ((Verb) this).CasterPawn).Position, ((Thing) ((Verb) this).CasterPawn).Map, 1f), ((Thing) ((Verb) this).CasterPawn).Position, 120, ((Verb) this).CasterPawn);
      List<IntVec3> list = GenRadial.RadialCellsAround(((Thing) ((Verb) this).CasterPawn).Position, this.Props.range, false).Where<IntVec3>((Func<IntVec3, bool>) (x => (double) IntVec3Utility.DistanceTo(x, ((Thing) ((Verb) this).CasterPawn).Position) > (double) this.Props.range - 5.0 && GenGrid.Walkable(x, ((Verb) this).caster.Map))).ToList<IntVec3>();
      if (!GenList.NullOrEmpty<IntVec3>((IList<IntVec3>) list))
      {
        ((Thing) ((LocalTargetInfo) ref ((Verb) this).currentTarget).Pawn).Position = GenCollection.RandomElement<IntVec3>((IEnumerable<IntVec3>) list);
        ((LocalTargetInfo) ref ((Verb) this).currentTarget).Pawn.stances.stunner.StunFor(120, (Thing) ((Verb) this).CasterPawn, false, false);
        ((LocalTargetInfo) ref ((Verb) this).currentTarget).Pawn.Notify_Teleported(true, true);
      }
      else
        Messages.Message(TaggedString.op_Implicit(Translator.Translate("HediffsAbilities.Messages.CellsNullOrEmpty")), MessageTypeDefOf.NeutralEvent, true);
    }
  }
>>>>>>> e92050d7e21e101c22fa4209e396d0084c1c39e2
}
