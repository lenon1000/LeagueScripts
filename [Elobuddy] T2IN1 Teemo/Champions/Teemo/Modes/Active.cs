﻿////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                            //
//           Credits to MarioGK for his Lib & Template also Credits to Joker for Parts of his Lib             //
//                                                                                                            //
//////////////////////////////////////////////////////////////////////////////////////////////////////////////// 

using System.Threading;
using System.Threading.Tasks;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu.Values;
using EloBuddy.SDK.Enumerations;

using T2IN1_Lib;

using static T2IN1_Teemo.Menus;
using static T2IN1_Teemo.SpellsManager;
using static T2IN1_Teemo.Consumables;
using static T2IN1_Teemo.Defensive;
using static T2IN1_Teemo.Spells;

namespace T2IN1_Teemo
{
    internal class Active
    {
        #region Defensive Items Cast

        public static void Defensive()
        {
            //Zhonyas
            if (ActiveMenu["Zhonyas"].Cast<CheckBox>().CurrentValue)
            {
                if (Player.Instance.IsDead) return;

                if (Player.Instance.CountEnemiesInRange(700) >= 1 && Zhonyas.IsOwned() && Zhonyas.IsReady())
                {
                    if (Player.Instance.HealthPercent <= ActiveMenu["Item.ZyHp"].Cast<Slider>().CurrentValue)
                    {
                        Zhonyas.Cast();
                    }
                }
            }
            //Seraph
            if (ActiveMenu["Seraph"].Cast<CheckBox>().CurrentValue)
            {
                if (Player.Instance.IsDead) return;

                if (Player.Instance.CountEnemiesInRange(650) >= 1 && Seraph.IsOwned() && Seraph.IsReady())
                {
                    if (Player.Instance.HealthPercent <= ActiveMenu["Item.SeraphHp"].Cast<Slider>().CurrentValue)
                    {
                        Seraph.Cast();
                    }
                }
            }
            //Solari
            if (ActiveMenu["Solari"].Cast<CheckBox>().CurrentValue)
            {
                if (Player.Instance.IsDead) return;

                if (Player.Instance.CountEnemiesInRange(600) >= 1 && Solari.IsOwned() && Solari.IsReady())
                {
                    if (Player.Instance.HealthPercent <= ActiveMenu["Item.SolariHp"].Cast<Slider>().CurrentValue)
                    {
                        Solari.Cast();
                    }
                }
            }
        }

        #endregion Defensive Items Cast

        #region Consumables Cast
        /*

        //Cast Potions
        public static void Potions()
        {
            //Health Potion
            if (ActiveMenu["HealthPotion"].Cast<CheckBox>().CurrentValue)
            {
                if (Player.Instance.IsDead) return;

                if (Consumables.Health.IsOwned() && Consumables.Health.IsReady())
                {
                    if (Player.Instance.HealthPercent <= ActiveMenu["Item.HealthPotionHp"].Cast<Slider>().CurrentValue)
                    {
                        Consumables.Health.Cast();
                    }
                }
            }
            //Hunters Potion
            if (ActiveMenu["HuntersPotion"].Cast<CheckBox>().CurrentValue)
            {
                if (Player.Instance.IsDead) return;

                if (Consumables.Hunters.IsOwned() && Consumables.Hunters.IsReady())
                {
                    if (Player.Instance.HealthPercent <= ActiveMenu["Item.HuntersPotionHp"].Cast<Slider>().CurrentValue)
                    {
                        Consumables.Hunters.Cast();
                    }
                }
            }

            //Biscuit
            if (ActiveMenu["Biscuit"].Cast<CheckBox>().CurrentValue)
            {
                if (Player.Instance.IsDead) return;

                if (Consumables.Biscuit.IsOwned() && Consumables.Biscuit.IsReady())
                {
                    if (Player.Instance.HealthPercent <= ActiveMenu["Item.BiscuitHp"].Cast<Slider>().CurrentValue)
                    {
                        Consumables.Biscuit.Cast();
                    }
                }
            }

            //Refillable
            if (ActiveMenu["Refillable"].Cast<CheckBox>().CurrentValue)
            {
                if (Player.Instance.IsDead) return;

                if (Consumables.Refillable.IsOwned() && Consumables.Refillable.IsReady())
                {
                    if (Player.Instance.HealthPercent <= ActiveMenu["Item.RefillableHp"].Cast<Slider>().CurrentValue)
                    {
                        Consumables.Refillable.Cast();
                    }
                }
            }

            //Corrupting
            if (ActiveMenu["Corrupting"].Cast<CheckBox>().CurrentValue)
            {
                if (Player.Instance.IsDead) return;

                if (Consumables.Corrupting.IsOwned() && Consumables.Corrupting.IsReady())
                {
                    if (Player.Instance.HealthPercent <= ActiveMenu["Item.CorruptingHp"].Cast<Slider>().CurrentValue)
                    {
                        Consumables.Corrupting.Cast();
                    }
                }
            }
        }
        */
        #endregion Consumables Cast
    }
}
