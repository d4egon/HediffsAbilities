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
<<<<<<< HEAD
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
=======
  public class HediffComp_AddSkills : HediffComp
  {
    public HediffCompProperties_AddSkills Props => this.props as HediffCompProperties_AddSkills;

    public virtual void CompPostPostAdd(DamageInfo? dinfo)
    {
      base.CompPostPostAdd(dinfo);
      SkillRecord skillRecord = ((Hediff) this.parent).pawn.skills.skills.Find((Predicate<SkillRecord>) (x => x.def == this.Props.skillDef));
      if (skillRecord.TotallyDisabled)
        return;
      skillRecord.Level = Mathf.Clamp(skillRecord.Level + this.Props.levels, 0, 20);
    }

    public virtual void CompPostPostRemoved()
    {
      base.CompPostPostRemoved();
      SkillRecord skillRecord = ((Hediff) this.parent).pawn.skills.skills.Find((Predicate<SkillRecord>) (x => x.def == this.Props.skillDef));
      if (skillRecord.TotallyDisabled)
        return;
      skillRecord.Level = Mathf.Clamp(skillRecord.Level - this.Props.levels, 0, 20);
    }
  }
>>>>>>> e92050d7e21e101c22fa4209e396d0084c1c39e2
}
