﻿using System;
using EloBuddy;
using EloBuddy.SDK;
using T2IN1_Lib;

using static T2IN1_Teemo.Menus;

namespace T2IN1_Teemo
{
    internal class ModeManager
    {
        public static void InitializeModes()
        {
            Game.OnTick += Game_OnTick;
        }

        private static void Game_OnTick(EventArgs args)
        {
            var orbMode = Orbwalker.ActiveModesFlags;
            var playerMana = Player.Instance.ManaPercent;

            Active.Execute();

            if (orbMode.HasFlag(Orbwalker.ActiveModes.Combo))
            {
                Combo.Execute1();
            }

            if (orbMode.HasFlag(Orbwalker.ActiveModes.Combo) && playerMana > ComboMenu.GetSliderValue("manaSlider"))
            {
                Combo.Execute2();
            }

            if (orbMode.HasFlag(Orbwalker.ActiveModes.LastHit) && playerMana > LastHitMenu.GetSliderValue("manaSlider"))
            {
                LastHit.Execute();
            }

            if (orbMode.HasFlag(Orbwalker.ActiveModes.LaneClear) && playerMana > LaneClearMenu.GetSliderValue("manaSlider"))
            {
                LaneClear.Execute();
            }

            if (orbMode.HasFlag(Orbwalker.ActiveModes.Flee) && playerMana > LastHitMenu.GetSliderValue("manaSlider"))
            {
                Flee.Execute();
            }
        }
    }
}