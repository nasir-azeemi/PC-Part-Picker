#pragma checksum "C:\Users\Home\Documents\GitHub\DBS-Fall-19-Bitbuilder\BitBuilder_v1\upd_price.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "351B73A8984DD4CA2FF784AAE029D2B6"
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
    partial class upd_price : 
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
            case 2: // upd_price.xaml line 12
                {
                    this.welcome_txt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // upd_price.xaml line 13
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element3 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element3).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 4: // upd_price.xaml line 14
                {
                    this.ID_box = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // upd_price.xaml line 15
                {
                    this.search_bttn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.search_bttn).Click += this.search_bttn_Click;
                }
                break;
            case 6: // upd_price.xaml line 16
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element6 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element6).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 7: // upd_price.xaml line 17
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element7 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element7).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 8: // upd_price.xaml line 18
                {
                    this.curr_priceBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.curr_priceBox).TextChanged += this.curr_priceBox_TextChanged;
                }
                break;
            case 9: // upd_price.xaml line 19
                {
                    this.new_priceBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10: // upd_price.xaml line 20
                {
                    this.upd_bttn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.upd_bttn).Click += this.upd_bttn_Click;
                }
                break;
            case 11: // upd_price.xaml line 21
                {
                    this.cancel_bttn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancel_bttn).Click += this.cancel_bttn_Click;
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

