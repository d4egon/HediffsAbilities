// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Hediffs.HediffComp_Ability
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using HediffsAbilities.Things;
using Verse;

namespace HediffsAbilities.Hediffs
{
    public class HediffComp_Ability : HediffComp
    {
        public HediffCompProperties_Ability Props => props as HediffCompProperties_Ability;

        private Comp_RaceComp Comp_Race => parent.pawn.GetComp<Comp_RaceComp>();

        public virtual void CompPostPostAdd(DamageInfo? dinfo)
        {
            base.CompPostPostAdd(dinfo);
            Comp_Race.InitVerbsFromZero();
        }

        public virtual void CompPostPostRemoved()
        {
            base.CompPostPostRemoved();
            Comp_Race.InitVerbsFromZero();
        }
    }
}
