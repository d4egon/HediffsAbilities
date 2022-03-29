// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.GameConditions.GameCondition_MoonIllusion
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll
/*
using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace HediffsAbilities.GameConditions
{
  public class GameCondition_MoonIllusion : GameCondition
  {
    private SkyColorSet ToxicFalloutColors;

    public virtual void Init()
    {
      LessonAutoActivator.TeachOpportunity(ConceptDefOf.ForbiddingDoors, (OpportunityType) 2);
      LessonAutoActivator.TeachOpportunity(ConceptDefOf.AllowedAreas, (OpportunityType) 2);
    }

    public virtual void GameConditionTick() => this.DoPawnsDamage(this.SingleMap);

    private void DoPawnsDamage(Map map)
    {
      List<Pawn> allPawnsSpawned = map.mapPawns.AllPawnsSpawned;
      for (int index = 0; index < allPawnsSpawned.Count; ++index)
        GameCondition_MoonIllusion.DoPawnDamage(allPawnsSpawned[index]);
    }

    public static void DoPawnDamage(Pawn p)
    {
      if (((Thing) p).Spawned && GridsUtility.Roofed(((Thing) p).Position, ((Thing) p).Map) || !p.RaceProps.IsFlesh)
        return;
      float num1 = 3.3E-05f * StatExtension.GetStatValue((Thing) p, StatDefOfLocal.StatDef_IllusionResistance, true);
      if ((double) num1 == 0.0)
        return;
      float num2 = Mathf.Lerp(0.85f, 1.15f, Rand.ValueSeeded(((Thing) p).thingIDNumber ^ 74374237));
      float num3 = num1 * num2;
      HealthUtility.AdjustSeverity(p, HediffDefOfLocal.HediffDef_Illusion, num3);
    }

    public virtual float SkyTargetLerpFactor(Map map) => GameConditionUtility.LerpInOutValue((GameCondition) this, (float) this.TransitionTicks, 0.5f);

    public virtual Verse.SkyTarget? SkyTarget(Map map) => new Verse.SkyTarget?(new Verse.SkyTarget(0.85f, this.ToxicFalloutColors, 1f, 1f));

    public virtual float AnimalDensityFactor(Map map) => 0.0f;

    public virtual float PlantDensityFactor(Map map) => 0.0f;

    public virtual bool AllowEnjoyableOutsideNow(Map map) => false;

    public GameCondition_MoonIllusion()
    {
      ColorInt colorInt = new ColorInt(216, 40, 0);
      Color toColor1 = ((ColorInt) ref colorInt).ToColor;
      colorInt = new ColorInt(234, 200, (int) byte.MaxValue);
      Color toColor2 = ((ColorInt) ref colorInt).ToColor;
      Color color = new Color(0.6f, 0.4f, 0.5f);
      this.ToxicFalloutColors = new SkyColorSet(toColor1, toColor2, color, 0.85f);
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
*/