﻿using System.Linq;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu.Values;
using T2IN1_Sona.Base;

namespace T2IN1_Sona.Modes
{
    internal class Auto
    {
        public static void AutoW()
        {
            var healAllies = Menus.SupportMenu["HPLA"].Cast<CheckBox>().CurrentValue;
            var healHealthPercent = Menus.SupportMenu["wS"].Cast<Slider>().CurrentValue;

            if (healAllies)
            {
                var ally =
                    EntityManager.Heroes.Allies
                        .FirstOrDefault(
                            x => x.IsValidTarget(SpellsManager.W.Range) && (x.HealthPercent < healHealthPercent));

                if (ally != null)
                    SpellsManager.W.Cast();
            }
        }

        public static void Interruptererer(Obj_AI_Base sender, Interrupter.InterruptableSpellEventArgs args)
        {
            var intTarget = TargetSelector.GetTarget(SpellsManager.R.Range, DamageType.Magical);
            {
                if (SpellsManager.R.IsReady() && sender.IsValidTarget(SpellsManager.R.Range) &&
                    Menus.SupportMenu["IS"].Cast<CheckBox>().CurrentValue)
                    SpellsManager.R.Cast(intTarget.ServerPosition);
            }
        }
    }
}