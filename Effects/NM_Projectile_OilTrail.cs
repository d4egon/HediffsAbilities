using ExplosiveTrailsEffect;
using RimWorld;
using Verse;

namespace NarutoMod.Effects
{
    public class NM_Projectile_OilTrail : Projectile_Explosive
    {
        private int TicksforAppearence = 1;

        public override void Tick()
        {
            base.Tick();
            def = RimWorld.ThingDefOf.Filth_Fuel;
            TicksforAppearence--;
            if (TicksforAppearence == 0 && Map != null)
            {
                SmokeThrowher.ThrowSmokeTrail(Position.ToVector3Shifted(), 0.1f, Map, "NM_Mote_OiltrailSoft");
                FilthMaker.TryMakeFilth(DestinationCell, Map, def, 1);
                TicksforAppearence = 1;
            }
        }
    }
}