﻿using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class GuestList : Control
    {
        #region DefaultStyleKey

        static GuestList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GuestList), new FrameworkPropertyMetadata(typeof(GuestList)));
        }
        #endregion
    }
}
