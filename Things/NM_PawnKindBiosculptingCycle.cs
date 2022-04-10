using RimWorld;
using Verse;

namespace NarutoMod.Things
{
    public class NM_PawnKindBiosculptingCycle : CompBiosculpterPod_Cycle
    {
        private new NM_PawnKindBiosculptingCycle_Properties Props => (NM_PawnKindBiosculptingCycle_Properties)props;

        public override void CycleCompleted(Pawn occupant)
        {
            var newPawn = (Pawn)GenSpawn.Spawn(
                PawnGenerator.GeneratePawn(new PawnGenerationRequest(Props.pawnKind, parent.Faction, newborn: true, allowAddictions: false, fixedGender: occupant.gender)),
                parent.InteractionCell,
                parent.Map
            );

            newPawn.Name = occupant.Name;
            newPawn.relations = occupant.relations;
            newPawn.ageTracker.AgeBiologicalTicks = occupant.ageTracker.AgeBiologicalTicks;
            newPawn.ageTracker.AgeChronologicalTicks = occupant.ageTracker.AgeChronologicalTicks;
            newPawn.ageTracker.DebugMakeOlder(0);

            if (newPawn.story != null)
            {
                newPawn.story.childhood = occupant.story.childhood;
                newPawn.story.adulthood = occupant.story.adulthood;
                newPawn.story.traits = occupant.story.traits;
            }

            if (newPawn.skills != null)
            {
                newPawn.skills = occupant.skills;
            }

            if (newPawn.abilities != null)
            {
                newPawn.abilities = occupant.abilities;
            }

            if (newPawn.ideo != null)
            {
                newPawn.ideo = occupant.ideo;
            }

            if (newPawn.health.hediffSet != null)
            {
                newPawn.health.hediffSet = occupant.health.hediffSet;
            }

            occupant.Destroy();
            Find.ColonistBar.MarkColonistsDirty();

            parent.TryGetComp<CompBiosculpterPod>()?.SetBiotuned(null);
        }
    }
}