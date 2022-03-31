﻿// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Verbs.Verb_ThrowMeteor
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using RimWorld;

namespace HediffsAbilities.Verbs
{
    public class Verb_ThrowMeteor : Verb_AbilityHediff
    {
        public override void WarmupComplete()
        {
            base.WarmupComplete();
            SkyfallerMaker.SpawnSkyfaller(ThingDefOf.MeteoriteIncoming, currentTarget.Cell, CasterPawn.Map);
            CasterPawn.stances.stunner.StunFor(45, CasterPawn, false, false);
        }
    }
}
