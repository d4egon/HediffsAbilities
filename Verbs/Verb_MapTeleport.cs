// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Verbs.Verb_MapTeleport
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using HediffsAbilities.GUI;
using Verse;

namespace HediffsAbilities.Verbs
{
    public class Verb_MapTeleport : Verb_AbilityHediff
    {
        public override void WarmupComplete()
        {
            base.WarmupComplete();
            Find.WindowStack.Add(new Window_MapTeleport(CasterPawn));
        }
    }
}
