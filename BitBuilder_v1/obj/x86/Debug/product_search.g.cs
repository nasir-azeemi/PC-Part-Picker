﻿#pragma checksum "C:\Users\HomeRyzen\Documents\GitHub\DBS-Fall-19-Bitbuilder\BitBuilder_v1\product_search.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "610F55BF1AF6297B385A231636225FDB"
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
    partial class product_search : 
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
            case 2: // product_search.xaml line 13
                {
                    this.cart_view_bttn = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 3: // product_search.xaml line 14
                {
                    this.prod_namebox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // product_search.xaml line 15
                {
                    this.categ_box = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.categ_box).Loaded += this.categ_box_Loaded;
                }
                break;
            case 5: // product_search.xaml line 18
                {
                    this.search_btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.search_btn).Click += this.search_btn_Click;
                }
                break;
            case 6: // product_search.xaml line 19
                {
                    this.close_bttn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.close_bttn).Click += this.close_bttn_Click;
                }
                break;
            case 7: // product_search.xaml line 20
                {
                    this.cart_add_bttn_Copy = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 8: // product_search.xaml line 22
                {
                    this.search_grid = (global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)(target);
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

