﻿#pragma checksum "C:\Users\HomeRyzen\Documents\GitHub\DBS-Fall-19-Bitbuilder\BitBuilder_v1\user_dash.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8D5BD90BE1B97FD7F0482C229FB0E68F"
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
    partial class user_dash : 
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
            case 2: // user_dash.xaml line 12
                {
                    this.welcome_txt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // user_dash.xaml line 13
                {
                    this.upd_detailbtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.upd_detailbtn).Click += this.upd_detailbtn_Click;
                }
                break;
            case 4: // user_dash.xaml line 14
                {
                    this.acc_settingbtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.acc_settingbtn).Click += this.acc_settingbtn_Click;
                }
                break;
            case 5: // user_dash.xaml line 15
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element5 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element5).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 6: // user_dash.xaml line 17
                {
                    this.p_search = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.p_search).Click += this.p_search_Click;
                }
                break;
            case 7: // user_dash.xaml line 18
                {
                    this.view_cartbtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.view_cartbtn).Click += this.view_cartbtn_Click;
                }
                break;
            case 8: // user_dash.xaml line 19
                {
                    this.order_historybtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.order_historybtn).Click += this.order_historybtn_Click;
                }
                break;
            case 9: // user_dash.xaml line 20
                {
                    this.prebuiltbtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.prebuiltbtn).Click += this.Button_Click;
                }
                break;
            case 10: // user_dash.xaml line 21
                {
                    this.create_bldbtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.create_bldbtn).Click += this.create_bldbtn_Click;
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

