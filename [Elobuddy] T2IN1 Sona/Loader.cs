﻿////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                            //
//           Credits to MarioGK for his Lib & Template also Credits to Joker for Parts of his Lib             //
//                                                                                                            //
//////////////////////////////////////////////////////////////////////////////////////////////////////////////// 

using System;
using EloBuddy;
using EloBuddy.SDK.Events;
using T2IN1_Sona.Base;
using T2IN1_Sona.Modes;

namespace T2IN1_Sona
{
    internal class Loader
    {
        private static void Main(string[] args)
        {
            Loading.OnLoadingComplete += Loading_OnLoadingComplete;
        }

        private static void Loading_OnLoadingComplete(EventArgs args)
        {
            //Sona
            if (Player.Instance.Hero == Champion.Sona)
            {
                SpellsManager.InitializeSpells();
                Menus.CreateMenu();
                ModeManager.InitializeModes();
                DrawingsManager.InitializeDrawings();
                EventManager.InitializeModes();

                Chat.Print("T2IN1 Sona Loaded!");
                Chat.Print("Credits to MarioGK for his Lib");
                Chat.Print("Credits to Bloodimir for some things from his Sona Script");
            }
        }
    }
}