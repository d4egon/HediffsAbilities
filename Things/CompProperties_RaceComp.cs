// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Things.CompProperties_RaceComp
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using Verse;

namespace HediffsAbilities.Things
{
<<<<<<< HEAD
    public class CompProperties_RaceComp : CompProperties
    {
        public float powerBase;
        public float powerGain;

        public CompProperties_RaceComp(float powerBase, float powerGain)
        {
            compClass = typeof(Comp_RaceComp);
            this.powerBase = powerBase;
            this.powerGain = powerGain;
        }
    }
=======
  public class CompProperties_RaceComp : CompProperties
  {
    public float powerBase;
    public float powerGain;

    public CompProperties_RaceComp(float powerBase, float powerGain)
    {
      this.compClass = typeof (Comp_RaceComp);
      this.powerBase = powerBase;
      this.powerGain = powerGain;
    }
  }
>>>>>>> e92050d7e21e101c22fa4209e396d0084c1c39e2
}
