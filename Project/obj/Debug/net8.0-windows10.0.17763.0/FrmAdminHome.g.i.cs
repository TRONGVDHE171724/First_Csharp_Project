﻿#pragma checksum "..\..\..\FrmAdminHome.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E8B0C84D5EFEACAF855DF32662777A111BCB2A47"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Project;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Project {
    
    
    /// <summary>
    /// FrmAdminHome
    /// </summary>
    public partial class FrmAdminHome : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 93 "..\..\..\FrmAdminHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgAvatar;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\FrmAdminHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbHello;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\FrmAdminHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_MyProfile;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\FrmAdminHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Dashboard;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\FrmAdminHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Customer;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\FrmAdminHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Add;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\FrmAdminHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Logout;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Project;V1.0.0.0;component/frmadminhome.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FrmAdminHome.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ImgAvatar = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.tbHello = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btn_MyProfile = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\..\FrmAdminHome.xaml"
            this.btn_MyProfile.Click += new System.Windows.RoutedEventHandler(this.btn_MyProfile_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_Dashboard = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\..\FrmAdminHome.xaml"
            this.btn_Dashboard.Click += new System.Windows.RoutedEventHandler(this.btn_Dashboard_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_Customer = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\..\FrmAdminHome.xaml"
            this.btn_Customer.Click += new System.Windows.RoutedEventHandler(this.btn_Customer_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_Add = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\..\FrmAdminHome.xaml"
            this.btn_Add.Click += new System.Windows.RoutedEventHandler(this.btn_Add_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_Logout = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\..\FrmAdminHome.xaml"
            this.btn_Logout.Click += new System.Windows.RoutedEventHandler(this.btn_Logout_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

