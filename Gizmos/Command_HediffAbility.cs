// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Gizmos.Command_HediffAbility
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using HediffsAbilities.Verbs;
using System;
using Verse;

namespace HediffsAbilities.Gizmos
{
    public class Command_HediffAbility : Command_VerbTarget
    {
        public Verb_AbilityHediff Verb => this.verb as Verb_AbilityHediff;

        public virtual string GetTopRightLabel()
        {
            return Math.Round(Verb.Props.powerCost, 1).ToString() + " ";
        }
    }
}
