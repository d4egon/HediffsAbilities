// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Verbs.Verb_Amaterasu
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using RimWorld;
using Verse;

namespace HediffsAbilities.Verbs
{
  public class Verb_Amaterasu : Verb_AbilityHediff
  {
    public virtual bool ValidateTarget(LocalTargetInfo target, bool showMessages = true)
    {
      if (LocalTargetInfo.op_Equality(target, LocalTargetInfo.op_Implicit((Thing) null)) || ((LocalTargetInfo) ref target).Pawn == null)
        return false;
      if (((Thing) ((LocalTargetInfo) ref target).Pawn).FlammableNow)
        return base.ValidateTarget(target, showMessages);
      Messages.Message(TaggedString.op_Implicit(Translator.Translate("HediffsAbilities.Messages.TargetUnflammable")), MessageTypeDefOf.RejectInput, false);
      return false;
    }

    public override void WarmupComplete()
    {
      if (((LocalTargetInfo) ref ((Verb) this).currentTarget).Pawn == null)
        return;
      FireUtility.TryAttachFire((Thing) ((LocalTargetInfo) ref ((Verb) this).currentTarget).Pawn, 1f);
      base.WarmupComplete();
      ((Verb) this).CasterPawn.stances.stunner.StunFor(60, (Thing) ((Verb) this).CasterPawn, false, false);
    }
  }
}
