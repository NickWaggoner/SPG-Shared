﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuroraEndeavors.GameEngine
{
    public enum MenuActions
    {
        Play
    }

    public delegate void OnMenuActivated(object sender, MenuActions action);

    public interface IGameMenu
    {
        event OnMenuActivated MenuActivated;

        

        void Awake();
        void Hide();
        void Show();
    }


    

    public delegate void OnMenuItemChanged(object objectSender);
    public interface IGameMenuItem : IGameObject
    {
        event OnMenuItemChanged ItemChanged;
        string name
        {
            get;
            set;
        }
    }

    public interface IMainBackButton : IGameMenuItem
    { }
}
