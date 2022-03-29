// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Verbs.Verb_TeleportToCaster
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using RimWorld;
using Verse;

namespace HediffsAbilities.Verbs
{
  public class Verb_TeleportToCaster : Verb_AbilityHediff
  {
    public override void WarmupComplete()
    {
      base.WarmupComplete();
      this.AddEffecterToMaintain(EffecterDefOf.Skip_Entry.Spawn(((Thing) ((LocalTargetInfo) ref ((Verb) this).currentTarget).Pawn).Position, ((Thing) ((Verb) this).CasterPawn).Map, 1f), ((LocalTargetInfo) ref ((Verb) this).currentTarget).Cell, 120, ((LocalTargetInfo) ref ((Verb) this).currentTarget).Pawn);
      this.AddEffecterToMaintain(EffecterDefOf.Skip_Entry.Spawn(((Thing) ((Verb) this).CasterPawn).Position, ((Thing) ((Verb) this).CasterPawn).Map, 1f), ((Thing) ((Verb) this).CasterPawn).Position, 120, ((Verb) this).CasterPawn);
      ((Thing) ((LocalTargetInfo) ref ((Verb) this).currentTarget).Pawn).Position = ((Thing) ((Verb) this).CasterPawn).Position;
      ((LocalTargetInfo) ref ((Verb) this).currentTarget).Pawn.stances.stunner.StunFor(120, (Thing) ((Verb) this).CasterPawn, false, false);
      ((LocalTargetInfo) ref ((Verb) this).currentTarget).Pawn.Notify_Teleported(true, true);
    }
  }
}
