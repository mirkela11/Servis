﻿#pragma checksum "..\..\..\Dijalozi\korisnicixaml.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "348F947EC770084953C68D028BEA480E1538D7722A9263CE78A9090EF7F6DF62"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Servis.Dijalozi;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Servis.Dijalozi {
    
    
    /// <summary>
    /// korisnicixaml
    /// </summary>
    public partial class korisnicixaml : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Dijalozi\korisnicixaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox id_textBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Dijalozi\korisnicixaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox brojTelefona_textBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Dijalozi\korisnicixaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox prezime_textBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Dijalozi\korisnicixaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ime_textBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Dijalozi\korisnicixaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sacuvaj;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Servis;component/dijalozi/korisnicixaml.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dijalozi\korisnicixaml.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.id_textBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.brojTelefona_textBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.prezime_textBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ime_textBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.sacuvaj = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Dijalozi\korisnicixaml.xaml"
            this.sacuvaj.Click += new System.Windows.RoutedEventHandler(this.Sacuvaj_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 56 "..\..\..\Dijalozi\korisnicixaml.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

