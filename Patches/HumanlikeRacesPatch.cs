// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Patches.HumanlikeRacesPatch
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using HediffsAbilities.Things;
<<<<<<< HEAD
=======
using System;
>>>>>>> e92050d7e21e101c22fa4209e396d0084c1c39e2
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace HediffsAbilities.Patches
{
<<<<<<< HEAD
    [StaticConstructorOnStartup]
    public static class HumanlikeRacesPatch
    {
        static HumanlikeRacesPatch()
        {
            List<ThingDef> list = ((IEnumerable<ThingDef>)DefDatabase<ThingDef>.AllDefsListForReading).Where(x => x.race != null && x.race.Humanlike && !x.race.IsMechanoid).ToList();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Hediff abilities races patch loaded successfully, races affected: ");
            foreach (ThingDef thingDef in list)
            {
                if (thingDef.comps.Find(c => c is CompProperties_RaceComp) == null)
                {
                    thingDef.comps.Add(new CompProperties_RaceComp(300f, 0.025f));
                    stringBuilder.Append(thingDef.defName + "; ");
                }
            }
            Log.Message(stringBuilder.ToString());
        }
    }
=======
  [StaticConstructorOnStartup]
  public static class HumanlikeRacesPatch
  {
    static HumanlikeRacesPatch()
    {
      List<ThingDef> list = ((IEnumerable<ThingDef>) DefDatabase<ThingDef>.AllDefsListForReading).Where<ThingDef>((Func<ThingDef, bool>) (x => x.race != null && x.race.Humanlike && !x.race.IsMechanoid)).ToList<ThingDef>();
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendLine("Hediff abilities races patch loaded successfully, races affected: ");
      foreach (ThingDef thingDef in list)
      {
        if (thingDef.comps.Find((Predicate<CompProperties>) (c => c is CompProperties_RaceComp)) == null)
        {
          thingDef.comps.Add((CompProperties) new CompProperties_RaceComp(300f, 0.025f));
          stringBuilder.Append(((Def) thingDef).defName + "; ");
        }
      }
      Log.Message(stringBuilder.ToString());
    }
  }
>>>>>>> e92050d7e21e101c22fa4209e396d0084c1c39e2
}
