using Verse;
using RimWorld;

namespace NarutoMod.Verbs
{
    class NM_Verb_SummonThing_Dog : NM_Verb_AbilityHediff
	{
		public override bool ValidateTarget(LocalTargetInfo target, bool showMessages = true) => target != null && target.Pawn != null && base.ValidateTarget(target, showMessages);
		public PawnKindDef pawnKindToSpawn = DefOfs.NM_PawnKindDefOf.NM_SummonPawnKind_Dog;
		public override void WarmupComplete()
		{

			base.WarmupComplete();
            GenSpawn.Spawn(PawnGenerator.GeneratePawn(
							new PawnGenerationRequest(
								Props.pawnKindToSpawn,
								caster.Faction,
								newborn: false,
								allowAddictions: false)
						),
						caster.Position,
						caster.Map
					);
			return;
		}
	}

}