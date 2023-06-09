﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Permissions;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.VisualStudio.Tools.Applications.Runtime;

#pragma warning disable 414
namespace _01_TrackingTuanThuTLTT {
    
    
    /// 
    [StartupObject(0)]
    [PermissionSet(SecurityAction.Demand, Name="FullTrust")]
    public sealed partial class ThisAddIn : AddInBase {
        
        internal CustomTaskPaneCollection CustomTaskPanes;
        
        internal SmartTagCollection VstoSmartTags;
        
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "16.0.0.0")]
        private Object missing = Type.Missing;
        
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "16.0.0.0")]
        internal Application Application;
        
        /// 
        [DebuggerNonUserCode()]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ThisAddIn(ApplicationFactory factory, IServiceProvider serviceProvider) : 
                base(factory, serviceProvider, "AddIn", "ThisAddIn") {
            Globals.Factory = factory;
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "16.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void Initialize() {
            base.Initialize();
            this.Application = this.GetHostItem<Application>(typeof(Application), "Application");
            Globals.ThisAddIn = this;
            System.Windows.Forms.Application.EnableVisualStyles();
            this.InitializeCachedData();
            this.InitializeControls();
            this.InitializeComponents();
            this.InitializeData();
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "16.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void FinishInitialization() {
            this.InternalStartup();
            this.OnStartup();
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "16.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void InitializeDataBindings() {
            this.BeginInitialization();
            this.BindToData();
            this.EndInitialization();
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "16.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void InitializeCachedData() {
            if ((this.DataHost == null)) {
                return;
            }
            if (this.DataHost.IsCacheInitialized) {
                this.DataHost.FillCachedData(this);
            }
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "16.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void InitializeData() {
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "16.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void BindToData() {
        }
        
        /// 
        [DebuggerNonUserCode()]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        private void StartCaching(string MemberName) {
            this.DataHost.StartCaching(this, MemberName);
        }
        
        /// 
        [DebuggerNonUserCode()]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        private void StopCaching(string MemberName) {
            this.DataHost.StopCaching(this, MemberName);
        }
        
        /// 
        [DebuggerNonUserCode()]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        private bool IsCached(string MemberName) {
            return this.DataHost.IsCached(this, MemberName);
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "16.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void BeginInitialization() {
            this.BeginInit();
            this.CustomTaskPanes.BeginInit();
            this.VstoSmartTags.BeginInit();
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "16.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void EndInitialization() {
            this.VstoSmartTags.EndInit();
            this.CustomTaskPanes.EndInit();
            this.EndInit();
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "16.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void InitializeControls() {
            this.CustomTaskPanes = Globals.Factory.CreateCustomTaskPaneCollection(null, null, "CustomTaskPanes", "CustomTaskPanes", this);
            this.VstoSmartTags = Globals.Factory.CreateSmartTagCollection(null, null, "VstoSmartTags", "VstoSmartTags", this);
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "16.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void InitializeComponents() {
        }
        
        /// 
        [DebuggerNonUserCode()]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        private bool NeedsFill(string MemberName) {
            return this.DataHost.NeedsFill(this, MemberName);
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "16.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void OnShutdown() {
            this.VstoSmartTags.Dispose();
            this.CustomTaskPanes.Dispose();
            base.OnShutdown();
        }
    }
    
    /// 
    [DebuggerNonUserCode()]
    [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "16.0.0.0")]
    internal sealed partial class Globals {
        
        /// 
        private Globals() {
        }
        
        private static ThisAddIn _ThisAddIn;
        
        private static ApplicationFactory _factory;
        
        private static ThisRibbonCollection _ThisRibbonCollection;
        
        internal static ThisAddIn ThisAddIn {
            get {
                return _ThisAddIn;
            }
            set {
                if ((_ThisAddIn == null)) {
                    _ThisAddIn = value;
                }
                else {
                    throw new NotSupportedException();
                }
            }
        }
        
        internal static ApplicationFactory Factory {
            get {
                return _factory;
            }
            set {
                if ((_factory == null)) {
                    _factory = value;
                }
                else {
                    throw new NotSupportedException();
                }
            }
        }
        
        internal static ThisRibbonCollection Ribbons {
            get {
                if ((_ThisRibbonCollection == null)) {
                    _ThisRibbonCollection = new ThisRibbonCollection(_factory.GetRibbonFactory());
                }
                return _ThisRibbonCollection;
            }
        }
    }
    
    /// 
    [DebuggerNonUserCode()]
    [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "16.0.0.0")]
    internal sealed partial class ThisRibbonCollection : RibbonCollectionBase {
        
        /// 
        internal ThisRibbonCollection(RibbonFactory factory) : 
                base(factory) {
        }
    }
}
