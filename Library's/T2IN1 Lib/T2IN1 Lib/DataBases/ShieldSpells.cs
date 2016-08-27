﻿using System.Collections.Generic;
using EloBuddy;

namespace T2IN1_Lib.DataBases
{
    public class ShieldSpell
    {
        public Champion Champ;
        public SpellSlot Slot;

        public ShieldSpell(Champion champ, SpellSlot slot)
        {
            Champ = champ;
            Slot = slot;
        }
    }

    public static class ShieldSpells
    {
        public static List<ShieldSpell> Spells = new List<ShieldSpell>
        {
            new ShieldSpell(Champion.Riven, SpellSlot.E),
            new ShieldSpell(Champion.Rumble, SpellSlot.W),
            new ShieldSpell(Champion.Skarner, SpellSlot.W),
            new ShieldSpell(Champion.Sion, SpellSlot.W),
            new ShieldSpell(Champion.TahmKench, SpellSlot.E),
            new ShieldSpell(Champion.Urgot, SpellSlot.W),
            new ShieldSpell(Champion.Yasuo, SpellSlot.W),
            new ShieldSpell(Champion.Braum, SpellSlot.E)
        };
    }
}