﻿// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Hediffs.HediffCompProperties_Ability
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using NarutoMod.Verbs;
using System.Collections.Generic;
using Verse;

namespace NarutoMod.Hediffs
{
    public class NM_HediffCompProperties_Ability : HediffCompProperties
    {
        public List<NM_VerbProperties_Ability> verbProps = new List<NM_VerbProperties_Ability>();

        public NM_HediffCompProperties_Ability() => compClass = typeof(HediffComp_Ability);
    }
}