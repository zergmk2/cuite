﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfMenu
    /// </summary>
    public class WpfMenu : WpfControl<CUITControls.WpfMenu>
    {
        public WpfMenu(string searchProperties = null)
            : this(new CUITControls.WpfMenu(), searchProperties)
        {
        }

        public WpfMenu(CUITControls.WpfMenu sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public UITestControlCollection Items
        {
            get { return SourceControl.Items; }
        }

        public List<WpfMenuItem> ItemsAsCUITe
        {
            get
            {
                List<WpfMenuItem> list = new List<WpfMenuItem>();
                foreach (CUITControls.WpfMenuItem item in SourceControl.Items)
                {
                    WpfMenuItem cuiteItem = new WpfMenuItem(item);
                    list.Add(cuiteItem);
                }
                return list;
            }
        }

        public List<string> ItemsAsList
        {
            get { return (from x in SourceControl.Items select ((CUITControls.WpfMenuItem)x).Header).ToList<string>(); }
        }
    }
}