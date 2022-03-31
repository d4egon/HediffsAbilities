// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Gizmos.Command_HediffAbility
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using NarutoMod.Verbs;
using System;
using Verse;

namespace NarutoMod.Gizmos
{
    public class NM_Command_HediffAbility : Command_VerbTarget
    {
        public NM_Verb_AbilityHediff Verb => verb as NM_Verb_AbilityHediff;

        public virtual string GetTopRightLabel()
        {
            return Math.Round(Verb.Props.powerCost, 1).ToString() + " ";
        }
    }
}
