// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Things.Comp_RaceComp
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using HediffsAbilities.Gizmos;
using HediffsAbilities.Hediffs;
using HediffsAbilities.Verbs;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Verse;

namespace HediffsAbilities.Things
{
<<<<<<< HEAD
    public class Comp_RaceComp : ThingComp
    {
        private float power;
        public List<Verb_AbilityHediff> verbs;

        public Pawn parentPawn => parent as Pawn;

        public CompProperties_RaceComp Props => props as CompProperties_RaceComp;

        public int Tick => Find.TickManager.TicksGame;

        public float MaxPower => Props.powerBase;

        public float PowerGain => Props.powerGain;

        public float Power => power;

        public List<Verb_AbilityHediff> AllVerbs
        {
            get
            {
                if (verbs == null || verbs.Count == 0)
                {
                    InitVerbsFromZero();
                }

                return verbs;
            }
        }

        public void InitVerbsFromZero()
        {
            verbs = new List<Verb_AbilityHediff>();
            InitVerbs((type, id) =>
           {
               Verb_AbilityHediff instance = (Verb_AbilityHediff)Activator.CreateInstance(type);
               this.verbs.Add(instance);
               return instance;
           });
        }

        private void InitVerbs(Func<Type, string, Verb_AbilityHediff> creator)
        {
            List<VerbProperties_Ability> propertiesAbilityList = new List<VerbProperties_Ability>();
            foreach (HediffComp hediffComp in parentPawn.health.hediffSet.GetAllComps().ToList<HediffComp>())
            {
                if (hediffComp is HediffComp_Ability hediffCompAbility)
                    propertiesAbilityList.AddRange(hediffCompAbility.Props.verbProps);
            }
            for (int index = 0; index < propertiesAbilityList.Count; ++index)
            {
                VerbProperties_Ability properties = propertiesAbilityList[index];
                string id = "HediffVerbOfMod_" + index.ToString();
                this.InitVerb(creator(properties.verbClass, id), properties, id);
            }
        }

        private void InitVerb(Verb_AbilityHediff verb, VerbProperties_Ability properties, string id)
        {
            verb.loadID = id;
            verb.verbProps = properties;
            verb.verbTracker = parentPawn.verbTracker;
            verb.caster = parent;
        }

        public virtual IEnumerable<Gizmo> CompGetGizmosExtra()
        {
            Comp_RaceComp compRaceComp = this;
            if (compRaceComp.AllVerbs.Count() != 0)
            {
                yield return (Gizmo)compRaceComp.CreateGizmoPower();
                if (Prefs.DevMode)
                {
                    Command_Action commandAction1 = new Command_Action();
                    ((Command)commandAction1).defaultLabel = "Debug: max power";
                    // ISSUE: reference to a compiler-generated method
                    commandAction1.action = new Action(compRaceComp.CompGetGizmosExtra <> __19_0);
                    yield return (Gizmo)commandAction1;
                    Command_Action commandAction2 = new Command_Action();
                    ((Command)commandAction2).defaultLabel = "Debug: reload verbs";
                    // ISSUE: reference to a compiler-generated method
                    commandAction2.action = new Action(compRaceComp.CompGetGizmosExtra <> __19_1);
                    yield return (Gizmo)commandAction2;
                }
            }
            foreach (Verb_AbilityHediff allVerb in compRaceComp.AllVerbs)
                yield return compRaceComp.CreateVerbTargetCommand(allVerb);
        }

        private Command_HediffAbility CreateVerbTargetCommand(
          Verb_AbilityHediff verb)
        {
            Command_HediffAbility commandHediffAbility = new Command_HediffAbility();
            (commandHediffAbility).defaultDesc = verb.Props.description;
            commandHediffAbility.defaultLabel = verb.Props.label;
            commandHediffAbility.verb = verb;
            commandHediffAbility.icon = ContentFinder<Texture2D>.Get(verb.verbProps.commandIcon, true);
            commandHediffAbility.order = 100f;
            Command_HediffAbility verbTargetCommand = commandHediffAbility;
            if (!parentPawn.IsColonistPlayerControlled)
            {
                verbTargetCommand.Disable(null);
            }
            else if (FireUtility.IsBurning(verb.CasterPawn))
                verbTargetCommand.Disable(TranslatorFormattedStringExtensions.Translate("HediffsAbilities.GUI.CasterIsBurning", verb.CasterPawn.LabelShort));
            else if (verb.CasterPawn.Downed)
                verbTargetCommand.Disable(TranslatorFormattedStringExtensions.Translate("HediffsAbilities.GUI.CasterIsDowned", verb.CasterPawn.LabelShort));
            else if (!verb.IsReady())
                verbTargetCommand.Disable(TranslatorFormattedStringExtensions.Translate("HediffsAbilities.GUI.PowerIsLow", verb.Props.powerCost));
            return verbTargetCommand;
        }

        private Gizmo_Power CreateGizmoPower() => new Gizmo_Power()
        {
            comp = this
        };

        public virtual void CompTick()
        {
            base.CompTick();
            if (Tick % 60 != 0 || AllVerbs == null || AllVerbs.Count == 0)
                return;
            this.PowerGainTick();
        }

        private void PowerGainTick() => power = Mathf.Clamp(power + PowerGain, 0.0f, MaxPower);

        public void Notify_PowerGain(float gain) => power = Mathf.Clamp(power + gain, 0.0f, MaxPower);

        public virtual void PostExposeData()
        {
            base.PostExposeData();
            Scribe_Values.Look(ref power, "power", 0.0f, false);
        }
    }
=======
  public class Comp_RaceComp : ThingComp
  {
    private float power;
    public List<Verb_AbilityHediff> verbs;

    public Pawn parentPawn => this.parent as Pawn;

    public CompProperties_RaceComp Props => this.props as CompProperties_RaceComp;

    public int Tick => Find.TickManager.TicksGame;

    public float MaxPower => this.Props.powerBase;

    public float PowerGain => this.Props.powerGain;

    public float Power => this.power;

    public List<Verb_AbilityHediff> AllVerbs
    {
      get
      {
        if (this.verbs == null || this.verbs.Count == 0)
          this.InitVerbsFromZero();
        return this.verbs;
      }
    }

    public void InitVerbsFromZero()
    {
      this.verbs = new List<Verb_AbilityHediff>();
      this.InitVerbs((Func<Type, string, Verb_AbilityHediff>) ((type, id) =>
      {
        Verb_AbilityHediff instance = (Verb_AbilityHediff) Activator.CreateInstance(type);
        this.verbs.Add(instance);
        return instance;
      }));
    }

    private void InitVerbs(Func<Type, string, Verb_AbilityHediff> creator)
    {
      List<VerbProperties_Ability> propertiesAbilityList = new List<VerbProperties_Ability>();
      foreach (HediffComp hediffComp in this.parentPawn.health.hediffSet.GetAllComps().ToList<HediffComp>())
      {
        if (hediffComp is HediffComp_Ability hediffCompAbility)
          propertiesAbilityList.AddRange((IEnumerable<VerbProperties_Ability>) hediffCompAbility.Props.verbProps);
      }
      for (int index = 0; index < propertiesAbilityList.Count; ++index)
      {
        VerbProperties_Ability properties = propertiesAbilityList[index];
        string id = "HediffVerbOfMod_" + index.ToString();
        this.InitVerb(creator(properties.verbClass, id), properties, id);
      }
    }

    private void InitVerb(Verb_AbilityHediff verb, VerbProperties_Ability properties, string id)
    {
      ((Verb) verb).loadID = id;
      ((Verb) verb).verbProps = (VerbProperties) properties;
      ((Verb) verb).verbTracker = this.parentPawn.verbTracker;
      ((Verb) verb).caster = (Thing) this.parent;
    }

    public virtual IEnumerable<Gizmo> CompGetGizmosExtra()
    {
      Comp_RaceComp compRaceComp = this;
      if (compRaceComp.AllVerbs.Count<Verb_AbilityHediff>() != 0)
      {
        yield return (Gizmo) compRaceComp.CreateGizmoPower();
        if (Prefs.DevMode)
        {
          Command_Action commandAction1 = new Command_Action();
          ((Command) commandAction1).defaultLabel = "Debug: max power";
          // ISSUE: reference to a compiler-generated method
          commandAction1.action = new Action(compRaceComp.\u003CCompGetGizmosExtra\u003Eb__19_0);
          yield return (Gizmo) commandAction1;
          Command_Action commandAction2 = new Command_Action();
          ((Command) commandAction2).defaultLabel = "Debug: reload verbs";
          // ISSUE: reference to a compiler-generated method
          commandAction2.action = new Action(compRaceComp.\u003CCompGetGizmosExtra\u003Eb__19_1);
          yield return (Gizmo) commandAction2;
        }
      }
      foreach (Verb_AbilityHediff allVerb in compRaceComp.AllVerbs)
        yield return (Gizmo) compRaceComp.CreateVerbTargetCommand(allVerb);
    }

    private Command_HediffAbility CreateVerbTargetCommand(
      Verb_AbilityHediff verb)
    {
      Command_HediffAbility commandHediffAbility = new Command_HediffAbility();
      ((Command) commandHediffAbility).defaultDesc = verb.Props.description;
      ((Command) commandHediffAbility).defaultLabel = verb.Props.label;
      commandHediffAbility.verb = (Verb) verb;
      ((Command) commandHediffAbility).icon = ContentFinder<Texture2D>.Get(((Verb) verb).verbProps.commandIcon, true);
      ((Gizmo) commandHediffAbility).order = 100f;
      Command_HediffAbility verbTargetCommand = commandHediffAbility;
      if (!this.parentPawn.IsColonistPlayerControlled)
        ((Gizmo) verbTargetCommand).Disable((string) null);
      else if (FireUtility.IsBurning((Thing) ((Verb) verb).CasterPawn))
        ((Gizmo) verbTargetCommand).Disable(TaggedString.op_Implicit(TranslatorFormattedStringExtensions.Translate("HediffsAbilities.GUI.CasterIsBurning", NamedArgument.op_Implicit(((Entity) ((Verb) verb).CasterPawn).LabelShort))));
      else if (((Verb) verb).CasterPawn.Downed)
        ((Gizmo) verbTargetCommand).Disable(TaggedString.op_Implicit(TranslatorFormattedStringExtensions.Translate("HediffsAbilities.GUI.CasterIsDowned", NamedArgument.op_Implicit(((Entity) ((Verb) verb).CasterPawn).LabelShort))));
      else if (!verb.IsReady())
        ((Gizmo) verbTargetCommand).Disable(TaggedString.op_Implicit(TranslatorFormattedStringExtensions.Translate("HediffsAbilities.GUI.PowerIsLow", NamedArgument.op_Implicit(verb.Props.powerCost))));
      return verbTargetCommand;
    }

    private Gizmo_Power CreateGizmoPower() => new Gizmo_Power()
    {
      comp = this
    };

    public virtual void CompTick()
    {
      base.CompTick();
      if (this.Tick % 60 != 0 || this.AllVerbs == null || this.AllVerbs.Count == 0)
        return;
      this.PowerGainTick();
    }

    private void PowerGainTick() => this.power = Mathf.Clamp(this.power + this.PowerGain, 0.0f, this.MaxPower);

    public void Notify_PowerGain(float gain) => this.power = Mathf.Clamp(this.power + gain, 0.0f, this.MaxPower);

    public virtual void PostExposeData()
    {
      base.PostExposeData();
      Scribe_Values.Look<float>(ref this.power, "power", 0.0f, false);
    }
  }
>>>>>>> e92050d7e21e101c22fa4209e396d0084c1c39e2
}
