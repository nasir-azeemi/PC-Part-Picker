﻿#pragma checksum "C:\Users\HomeRyzen\Documents\GitHub\DBS-Fall-19-Bitbuilder\BitBuilder_v1\admin_dash.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0325779D5C348B5DE29576E30EE7B9AF"
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
    partial class admin_dash : 
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
            case 2: // admin_dash.xaml line 12
                {
                    this.welcome_txt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // admin_dash.xaml line 13
                {
                    this.upd_productbtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.upd_productbtn).Click += this.update_productbtn_Click;
                }
                break;
            case 4: // admin_dash.xaml line 14
                {
                    this.add_bttn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.add_bttn).Click += this.add_bttn_Click;
                }
                break;
            case 5: // admin_dash.xaml line 15
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element5 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element5).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 6: // admin_dash.xaml line 17
                {
                    this.view_orderbtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.view_orderbtn).Click += this.view_orderbtn_Click;
                }
                break;
            case 7: // admin_dash.xaml line 18
                {
                    this.update_orderbtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.update_orderbtn).Click += this.update_orderbtn_Click;
                }
                break;
            case 8: // admin_dash.xaml line 19
                {
                    this.update_pricebtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.update_pricebtn).Click += this.update_pricebtn_Click;
                }
                break;
            case 9: // admin_dash.xaml line 20
                {
                    this.view_prod = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.view_prod).Click += this.view_prod_Click;
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

