﻿#pragma checksum "..\..\..\..\View\AdminView\EditOrderView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7E1EE649EC0F26C575D2EBF6B6DD3106"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NoweChili.View.AdminView;
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


namespace NoweChili.View.AdminView {
    
    
    /// <summary>
    /// EditOrderView
    /// </summary>
    public partial class EditOrderView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\View\AdminView\EditOrderView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView OrderListListView;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\View\AdminView\EditOrderView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OrderEditButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\View\AdminView\EditOrderView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OrderDeleteButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\View\AdminView\EditOrderView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditOrderBackButton;
        
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
            System.Uri resourceLocater = new System.Uri("/NoweChili;component/view/adminview/editorderview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\AdminView\EditOrderView.xaml"
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
            this.OrderListListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.OrderEditButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\View\AdminView\EditOrderView.xaml"
            this.OrderEditButton.Click += new System.Windows.RoutedEventHandler(this.OrderEditButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.OrderDeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\View\AdminView\EditOrderView.xaml"
            this.OrderDeleteButton.Click += new System.Windows.RoutedEventHandler(this.OrderDeleteButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EditOrderBackButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\View\AdminView\EditOrderView.xaml"
            this.EditOrderBackButton.Click += new System.Windows.RoutedEventHandler(this.EditOrderBackButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

