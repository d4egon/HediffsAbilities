using System.Collections.Generic;
using RimWorld;
using Verse;

namespace NarutoMod.Things
{
    public class NM_PawnKindBiosculptingCycle_Properties : CompProperties_BiosculpterPod_BaseCycle
    {
        public PawnKindDef pawnKind;

        public List<HediffDef> hediffs = new();
    }
}