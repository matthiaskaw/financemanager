﻿#pragma checksum "..\..\..\Forms\AddEntryWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EEC159B1E4EF2AD9F5471C9D4F7E14838A7436E31C603A60F5C8B8921E430ED0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

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
using financemanager;


namespace financemanager {
    
    
    /// <summary>
    /// AddEntryWindow
    /// </summary>
    public partial class AddEntryWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Forms\AddEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox entryNameBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Forms\AddEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox entryFormatComboBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Forms\AddEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem CSVComboBoxItem;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Forms\AddEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addEntryButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Forms\AddEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
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
            System.Uri resourceLocater = new System.Uri("/financemanager;component/forms/addentrywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Forms\AddEntryWindow.xaml"
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
            this.entryNameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.entryFormatComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.CSVComboBoxItem = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 4:
            this.addEntryButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Forms\AddEntryWindow.xaml"
            this.addEntryButton.Click += new System.Windows.RoutedEventHandler(this.addEntryButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Forms\AddEntryWindow.xaml"
            this.cancelButton.Click += new System.Windows.RoutedEventHandler(this.cancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

