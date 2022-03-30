// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Verbs.Verb_MapTeleport
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using HediffsAbilities.GUI;
using Verse;

namespace HediffsAbilities.Verbs
{
<<<<<<< HEAD
    public class Verb_MapTeleport : Verb_AbilityHediff
    {
        public override void WarmupComplete()
        {
            base.WarmupComplete();
            Find.WindowStack.Add(new Window_MapTeleport(CasterPawn));
        }
    }
=======
  public class Verb_MapTeleport : Verb_AbilityHediff
  {
    public override void WarmupComplete()
    {
      base.WarmupComplete();
      Find.WindowStack.Add((Window) new Window_MapTeleport(((Verb) this).CasterPawn));
    }
  }
>>>>>>> e92050d7e21e101c22fa4209e396d0084c1c39e2
}
