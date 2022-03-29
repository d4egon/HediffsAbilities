// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Hediffs.HediffComp_AddSkills
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using RimWorld;
using System;
using UnityEngine;
using Verse;

namespace HediffsAbilities.Hediffs
{
    public class HediffComp_AddSkills : HediffComp
    {
        public HediffCompProperties_AddSkills Props => props as HediffCompProperties_AddSkills;

        public virtual void CompPostPostAdd(DamageInfo? dinfo)
        {
            base.CompPostPostAdd(dinfo);
            SkillRecord skillRecord = parent.pawn.skills.skills.Find(x => x.def == Props.skillDef);
            if (skillRecord.TotallyDisabled)
                return;
            skillRecord.Level = Mathf.Clamp(skillRecord.Level + Props.levels, 0, 20);
        }

        public virtual void CompPostPostRemoved()
        {
            base.CompPostPostRemoved();
            SkillRecord skillRecord = parent.pawn.skills.skills.Find(x => x.def == Props.skillDef);
            if (skillRecord.TotallyDisabled)
                return;
            skillRecord.Level = Mathf.Clamp(skillRecord.Level - Props.levels, 0, 20);
        }
    }
}
