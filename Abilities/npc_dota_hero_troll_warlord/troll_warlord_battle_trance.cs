﻿// <copyright file="troll_warlord_battle_trance.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Abilities.npc_dota_hero_troll_warlord
{
    using Ensage.SDK.Abilities.Components;

    public class troll_warlord_battle_trance : RangedAbility, IHasModifier
    {
        public troll_warlord_battle_trance(Ability ability)
            : base(ability)
        {
        }

        public override UnitState AppliesUnitState { get; } = UnitState.CommandRestricted | UnitState.Unslowable;

        public string ModifierName { get; } = "modifier_troll_warlord_berserkers_rage";

    }
}