// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Things.Building_FruitTree
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll
/*
using HediffsAbilities.Gizmos;
using RimWorld;
using RimWorld.Planet;
using System;
using System.Collections.Generic;
using UnityEngine;
using Verse;
using Verse.AI;

namespace HediffsAbilities.Things
{
  public class Building_FruitTree : Plant
  {
    private float fuel;
    private float fruitProgres;

    private int TicksGame => Find.TickManager.TicksGame;

    public float Fuel => this.fuel;

    private float fuelPerPawn => 100f;

    public float FuelMax => 500f;

    private float fuelPerSecond => -0.0333333f;

    public float FuelPerDay => this.fuelPerSecond * 1000f;

    public float FruitProgres => this.fruitProgres;

    public float FruitProgresMax => 100f;

    private float fruitProgresPerSecond => 0.006666666f;

    private int pawnsToFruit => (int) ((double) Math.Abs(this.fuelPerSecond) / (double) this.fruitProgresPerSecond);

    public float FruitProgresPerDay => (double) this.Fuel <= (double) Mathf.Abs(this.fuelPerSecond) ? 0.0f : this.fruitProgresPerSecond * 1000f;

    public float FruitStartProgres => 0.5f;

    public virtual void Tick()
    {
      base.Tick();
      if (this.TicksGame % 60 != 0 || (double) this.Growth <= (double) this.FruitStartProgres)
        return;
      if ((double) this.fuel > (double) Mathf.Abs(this.fuelPerSecond))
      {
        this.fuel = Mathf.Clamp(this.fuel + this.fuelPerSecond, 0.0f, this.FuelMax);
        this.fruitProgres = Mathf.Clamp(this.fruitProgres + this.fruitProgresPerSecond, 0.0f, this.FruitProgresMax);
      }
      if ((double) this.fruitProgres < (double) this.FruitProgresMax)
        return;
      this.fruitProgres = 0.0f;
      GenSpawn.Spawn(ThingDefOfLocal.ThingDef_StrangeFruit, ((Thing) this).Position, ((Thing) this).Map, (WipeMode) 0);
      for (int index = 0; index < this.pawnsToFruit; ++index)
        GenSpawn.Spawn(ThingDefOfLocal.ThingDef_PlaceholderMaterial, ((Thing) this).Position, ((Thing) this).Map, (WipeMode) 0);
    }

    public void Fill(Pawn pawn)
    {
      this.fuel = Mathf.Clamp(this.fuel + this.fuelPerPawn, 0.0f, this.FuelMax);
      ((Thing) pawn).Destroy((DestroyMode) 0);
    }

    public void Fill(Thing thing) => this.fuel = Mathf.Clamp(this.fuel + this.fuelPerPawn, 0.0f, this.FuelMax);

    public virtual IEnumerable<FloatMenuOption> GetFloatMenuOptions(
      Pawn selPawn)
    {
      Pawn pawn;
      Pawn selPawn1 = pawn;
      yield return new FloatMenuOption(TaggedString.op_Implicit(Translator.Translate("HediffsAbilities.FloatMenuOptions.Sacrifice")), (Action) (() => selPawn1.jobs.TryTakeOrderedJob(new Job(JobDefOfLocal.JobDef_SacrificeSelf, LocalTargetInfo.op_Implicit((Thing) this)), new JobTag?((JobTag) 0), false)), (MenuOptionPriority) 4, (Action<Rect>) null, (Thing) null, 0.0f, (Func<Rect, bool>) null, (WorldObject) null, true, 0);
    }

    public virtual IEnumerable<Gizmo> GetGizmos()
    {
      Building_FruitTree buildingFruitTree = this;
      yield return (Gizmo) new Gizmo_TreeFuel()
      {
        tree = buildingFruitTree
      };
      yield return (Gizmo) new Gizmo_TreeFruit()
      {
        tree = buildingFruitTree
      };
      if (Prefs.DevMode)
      {
        Command_Action commandAction1 = new Command_Action();
        ((Command) commandAction1).defaultLabel = "Debug: max fuel";
        // ISSUE: reference to a compiler-generated method
        commandAction1.action = new Action(buildingFruitTree.\u003CGetGizmos\u003Eb__30_0);
        yield return (Gizmo) commandAction1;
        Command_Action commandAction2 = new Command_Action();
        ((Command) commandAction2).defaultLabel = "Debug: min fuel";
        // ISSUE: reference to a compiler-generated method
        commandAction2.action = new Action(buildingFruitTree.\u003CGetGizmos\u003Eb__30_1);
        yield return (Gizmo) commandAction2;
        Command_Action commandAction3 = new Command_Action();
        ((Command) commandAction3).defaultLabel = "Debug: max fruit progress";
        // ISSUE: reference to a compiler-generated method
        commandAction3.action = new Action(buildingFruitTree.\u003CGetGizmos\u003Eb__30_2);
        yield return (Gizmo) commandAction3;
      }
    }
  }
}
*/