﻿#pragma checksum "C:\Users\Home\Documents\GitHub\DBS-Fall-19-Bitbuilder\BitBuilder_v1\accdetails.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1920E77EDA3F13C93BB3A9C0B914B70E"
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
    partial class accdetails : 
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
            case 2: // accdetails.xaml line 12
                {
                    this.welcome_txt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // accdetails.xaml line 14
                {
                    this.emailbox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // accdetails.xaml line 17
                {
                    this.oldpass_box = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // accdetails.xaml line 18
                {
                    this.newpass_box = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // accdetails.xaml line 19
                {
                    this.cancelbtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancelbtn).Click += this.cancelbtn_Click;
                }
                break;
            case 7: // accdetails.xaml line 20
                {
                    this.updatebtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.updatebtn).Click += this.updatebtn_Click;
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

