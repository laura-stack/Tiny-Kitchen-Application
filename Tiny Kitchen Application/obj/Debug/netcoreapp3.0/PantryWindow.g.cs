﻿#pragma checksum "..\..\..\PantryWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "778C3EF522258A1DB77A1954CFD7BA9086CC2D26"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using Tiny_Kitchen_Application;


namespace Tiny_Kitchen_Application {
    
    
    /// <summary>
    /// PantryWindow
    /// </summary>
    public partial class PantryWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\PantryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup Pantry_Popup;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\PantryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pantryItem;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\PantryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup RemoveItem_Popup;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\PantryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox removeItem;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
<<<<<<< HEAD
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.16.0")]
=======
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
>>>>>>> 1e19d9d7a2278e5962c252473edc0574b778c044
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tiny Kitchen Application;component/pantrywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PantryWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
<<<<<<< HEAD
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.16.0")]
=======
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
>>>>>>> 1e19d9d7a2278e5962c252473edc0574b778c044
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 16 "..\..\..\PantryWindow.xaml"
            ((System.Windows.Controls.Primitives.ToggleButton)(target)).Click += new System.Windows.RoutedEventHandler(this.AddToPantry_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Pantry_Popup = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 3:
            this.pantryItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 24 "..\..\..\PantryWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveItem_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 28 "..\..\..\PantryWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExitPantryAdd_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 34 "..\..\..\PantryWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewPantry_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 35 "..\..\..\PantryWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeletePantryItem_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RemoveItem_Popup = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 9:
            this.removeItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 41 "..\..\..\PantryWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveRemoval_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 45 "..\..\..\PantryWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExitPantryRemoval_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

