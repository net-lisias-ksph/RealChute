﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using RealChute.Extensions;

/* RealChute was made by Christophe Savard (stupid_chris). You are free to copy, fork, and modify RealChute as you see
 * fit. However, redistribution is only permitted for unmodified versions of RealChute, and under attribution clause.
 * If you want to distribute a modified version of RealChute, be it code, textures, configs, or any other asset and
 * piece of work, you must get my explicit permission on the matter through a private channel, and must also distribute
 * it through the attribution clause, and must make it clear to anyone using your modification of my work that they
 * must report any problem related to this usage to you, and not to me. This clause expires if I happen to be
 * inactive (no connection) for a period of 90 days on the official KSP forums. In that case, the license reverts
 * back to CC-BY-NC-SA 4.0 INTL.*/

namespace RealChute.UI
{
    public class LinkedToggles<T> where T : class
    {
        private class Toggle
        {
            #region Fields
            public bool toggled = false;
            public string name = string.Empty;
            public T value = default(T);
            #endregion

            #region Constructor
            public Toggle(T value, string name)
            {
                this.value = value;
                this.name = name;
            }
            #endregion
        }

        #region Properties
        public bool isToggled
        {
            get { return this.toggled != null; }
        }
        #endregion

        #region Fields
        private List<Toggle> toggles = null;
        private Toggle toggled = null;
        private GUIStyle normal = HighLogic.Skin.button, active = HighLogic.Skin.button;
        #endregion

        #region Constructor
        public LinkedToggles(GUIStyle normalStyle, GUIStyle activeStyle)
        {
            this.toggles = new List<Toggle>();
            this.normal = normalStyle;
            this.active = activeStyle;
        }

        public LinkedToggles(IEnumerable<T> collection, string[] names, GUIStyle normalStyle, GUIStyle activeStyle)
        {
            this.toggles = new List<Toggle>();
            int i = 0;
            using (IEnumerator<T> e = collection.GetEnumerator())
            {
                while (e.MoveNext())
                {
                    this.toggles.Add(new Toggle(e.Current, names[i++]));
                }
            }
            this.normal = normalStyle;
            this.active = activeStyle;
        }
        #endregion

        #region Methods
        public T RenderToggles()
        {
            T value = default(T);
            GUILayout.BeginVertical();
            for (int i = 0; i < this.toggles.Count; i++)
            {
                Toggle t = this.toggles[i];
                if (GUILayout.Toggle(t.toggled, t.name, ToggleStyle(t)))
                {
                    if (this.toggled == t)
                    {
                        value = t.value;
                    }
                    else
                    {
                        if (this.toggled != null) { this.toggled.toggled = false; }
                        this.toggled = t;
                        t.toggled = true;
                        value = t.value;
                    }
                }
                else if (this.toggled == t) { ClearToggle(); }
            }
            GUILayout.EndVertical();
            return value;
        }

        public void AddToggle(T value, string name)
        {
            this.toggles.Add(new Toggle(value, name));
        }

        public void AddFirst(T value, string name)
        {
            this.toggles.Insert(0, new Toggle(value, name));
        }

        public void RemoveToggle(T value)
        {
            Toggle toggle = this.toggles.Find(t => t.value == value);
            if (toggle != null) { this.toggles.Remove(toggle); }
        }

        private GUIStyle ToggleStyle(Toggle toggle)
        {
            return toggle.toggled ? this.active : this.normal;
        }

        public void ClearToggle()
        {
            this.toggled.toggled = false;
            this.toggled = null;
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return this.toggles.Select(t => t.name).Join("\n");
        }
        #endregion
    }
}
