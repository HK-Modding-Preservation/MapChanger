﻿using MagicUI.Core;
using MagicUI.Elements;
using UnityEngine;

namespace MapChanger.UI
{
    public class Title(string mod)
    {
        public readonly string Mod = mod;
        public TextObject TitleText { get; private set; }

        public void Make()
        {
            TitleText = new(PauseMenu.Root, $"{Mod} Title")
            {
                TextAlignment = HorizontalAlignment.Left,
                ContentColor = Color.white,
                FontSize = 20,
                Font = MagicUI.Core.UI.TrajanBold,
                Padding = new(10f, 840f, 10f, 10f),
                Text = Mod,
            };

            PauseMenu.Titles.Add(this);
        }

        public virtual void Update()
        {
            TitleText.Text = Mod;

            if (Settings.MapModEnabled() && Settings.CurrentMode().Mod == Mod)
            {
                TitleText.Visibility = Visibility.Visible;
            }
            else
            {
                TitleText.Visibility = Visibility.Hidden;
            }
        }
    }
}
