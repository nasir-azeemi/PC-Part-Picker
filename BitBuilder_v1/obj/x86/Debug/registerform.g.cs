﻿#pragma checksum "C:\Users\HomeRyzen\Documents\GitHub\DBS-Fall-19-Bitbuilder\BitBuilder_v1\registerform.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A45055AADDD36EA22D5AFC46A8ADC98B"
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
    partial class registerform : 
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
            case 2: // registerform.xaml line 13
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element2).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 3: // registerform.xaml line 14
                {
                    this.emailbox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // registerform.xaml line 15
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element4 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element4).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 5: // registerform.xaml line 16
                {
                    this.namebox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // registerform.xaml line 17
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element6 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element6).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 7: // registerform.xaml line 18
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element7 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element7).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 8: // registerform.xaml line 19
                {
                    this.contactbox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // registerform.xaml line 20
                {
                    this.addressbox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10: // registerform.xaml line 21
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element10 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element10).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 11: // registerform.xaml line 22
                {
                    this.citycombobox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.citycombobox).Loaded += this.citycombobox_Loaded;
                }
                break;
            case 12: // registerform.xaml line 23
                {
                    this.cancelbtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancelbtn).Click += this.Button_Click;
                }
                break;
            case 13: // registerform.xaml line 24
                {
                    this.registerbtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.registerbtn).Click += this.registerbtn_Click;
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

