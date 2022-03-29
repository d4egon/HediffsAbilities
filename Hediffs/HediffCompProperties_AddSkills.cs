// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Hediffs.HediffCompProperties_AddSkills
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using RimWorld;
using Verse;

namespace HediffsAbilities.Hediffs
{
  public class HediffCompProperties_AddSkills : HediffCompProperties
  {
    public SkillDef skillDef;
    public int levels;

    public HediffCompProperties_AddSkills() => this.compClass = typeof (HediffComp_AddSkills);
  }
}
