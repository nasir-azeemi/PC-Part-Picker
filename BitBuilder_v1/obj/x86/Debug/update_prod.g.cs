﻿#pragma checksum "C:\Users\Home\Documents\GitHub\DBS-Fall-19-Bitbuilder\BitBuilder_v1\update_prod.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7719641205F8D1A912063BBAD98D1ACB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BitBuilder_v1
{
    partial class update_prod : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // update_prod.xaml line 12
                {
                    this.frame1 = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 3: // update_prod.xaml line 13
                {
                    this.NavView = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.NavView).Loaded += this.NavView_Loaded;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.NavView).ItemInvoked += this.NavView_ItemInvoked;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.NavView).BackRequested += this.NavView_BackRequested;
                }
                break;
            case 4: // update_prod.xaml line 52
                {
                    this.ContentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                    ((global::Windows.UI.Xaml.Controls.Frame)this.ContentFrame).NavigationFailed += this.ContentFrame_NavigationFailed;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

