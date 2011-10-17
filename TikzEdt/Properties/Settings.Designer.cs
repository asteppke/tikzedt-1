﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TikzEdt.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("pdflatex")]
        public string Path_pdflatex {
            get {
                return ((string)(this["Path_pdflatex"]));
            }
            set {
                this["Path_pdflatex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Path_externalviewer {
            get {
                return ((string)(this["Path_externalviewer"]));
            }
            set {
                this["Path_externalviewer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("800")]
        public double Window_Width {
            get {
                return ((double)(this["Window_Width"]));
            }
            set {
                this["Window_Width"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("600")]
        public double Window_Height {
            get {
                return ((double)(this["Window_Height"]));
            }
            set {
                this["Window_Height"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Editor_WordWrap {
            get {
                return ((bool)(this["Editor_WordWrap"]));
            }
            set {
                this["Editor_WordWrap"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Editor_ShowLineNumbers {
            get {
                return ((bool)(this["Editor_ShowLineNumbers"]));
            }
            set {
                this["Editor_ShowLineNumbers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6")]
        public double BB_Margin {
            get {
                return ((double)(this["BB_Margin"]));
            }
            set {
                this["BB_Margin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"\documentclass{article}
\usepackage{tikz,amsmath, amssymb,bm,color}
\usepackage[margin=0cm,nohead]{geometry}
\usepackage[active,tightpage]{preview}
\usetikzlibrary{shapes,arrows}
% needed for BB
\usetikzlibrary{calc}

\PreviewEnvironment{tikzpicture}
")]
        public string Tex_Preamble {
            get {
                return ((string)(this["Tex_Preamble"]));
            }
            set {
                this["Tex_Preamble"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\end{document}")]
        public string Tex_Postamble {
            get {
                return ((string)(this["Tex_Postamble"]));
            }
            set {
                this["Tex_Postamble"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TLB_ShowTools {
            get {
                return ((bool)(this["TLB_ShowTools"]));
            }
            set {
                this["TLB_ShowTools"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TLB_ShowFiles {
            get {
                return ((bool)(this["TLB_ShowFiles"]));
            }
            set {
                this["TLB_ShowFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TLB_ShowBB {
            get {
                return ((bool)(this["TLB_ShowBB"]));
            }
            set {
                this["TLB_ShowBB"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TLB_ShowZoom {
            get {
                return ((bool)(this["TLB_ShowZoom"]));
            }
            set {
                this["TLB_ShowZoom"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public uint RoundToDecimals {
            get {
                return ((uint)(this["RoundToDecimals"]));
            }
            set {
                this["RoundToDecimals"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("18")]
        public uint Raster_RadSteps {
            get {
                return ((uint)(this["Raster_RadSteps"]));
            }
            set {
                this["Raster_RadSteps"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public double Raster_GridWidth {
            get {
                return ((double)(this["Raster_GridWidth"]));
            }
            set {
                this["Raster_GridWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Raster_RadialOffset {
            get {
                return ((int)(this["Raster_RadialOffset"]));
            }
            set {
                this["Raster_RadialOffset"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-5")]
        public double BB_Std_X {
            get {
                return ((double)(this["BB_Std_X"]));
            }
            set {
                this["BB_Std_X"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-5")]
        public double BB_Std_Y {
            get {
                return ((double)(this["BB_Std_Y"]));
            }
            set {
                this["BB_Std_Y"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public double BB_Std_W {
            get {
                return ((double)(this["BB_Std_W"]));
            }
            set {
                this["BB_Std_W"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public double BB_Std_H {
            get {
                return ((double)(this["BB_Std_H"]));
            }
            set {
                this["BB_Std_H"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TLB_ShowMode {
            get {
                return ((bool)(this["TLB_ShowMode"]));
            }
            set {
                this["TLB_ShowMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Editor_CodeCompletion {
            get {
                return ((bool)(this["Editor_CodeCompletion"]));
            }
            set {
                this["Editor_CodeCompletion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Editor_CompleteBegins {
            get {
                return ((bool)(this["Editor_CompleteBegins"]));
            }
            set {
                this["Editor_CompleteBegins"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Snippets_ShowThumbs {
            get {
                return ((bool)(this["Snippets_ShowThumbs"]));
            }
            set {
                this["Snippets_ShowThumbs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int LeftMenuColWidthSetting {
            get {
                return ((int)(this["LeftMenuColWidthSetting"]));
            }
            set {
                this["LeftMenuColWidthSetting"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("151")]
        public int LeftToolsColWidthSetting {
            get {
                return ((int)(this["LeftToolsColWidthSetting"]));
            }
            set {
                this["LeftToolsColWidthSetting"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public global::System.Windows.GridLength OverlayCanvasColWidthSetting {
            get {
                return ((global::System.Windows.GridLength)(this["OverlayCanvasColWidthSetting"]));
            }
            set {
                this["OverlayCanvasColWidthSetting"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("300")]
        public int OverlayCanvasCol2WidthSetting {
            get {
                return ((int)(this["OverlayCanvasCol2WidthSetting"]));
            }
            set {
                this["OverlayCanvasCol2WidthSetting"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("80")]
        public int StatusFieldRowHeightSetting {
            get {
                return ((int)(this["StatusFieldRowHeightSetting"]));
            }
            set {
                this["StatusFieldRowHeightSetting"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("500")]
        public int MessageColWidth {
            get {
                return ((int)(this["MessageColWidth"]));
            }
            set {
                this["MessageColWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25")]
        public int LineColWidth {
            get {
                return ((int)(this["LineColWidth"]));
            }
            set {
                this["LineColWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25")]
        public int PosColWidth {
            get {
                return ((int)(this["PosColWidth"]));
            }
            set {
                this["PosColWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("75")]
        public int SourceColWidth {
            get {
                return ((int)(this["SourceColWidth"]));
            }
            set {
                this["SourceColWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LeftToolsColVisible {
            get {
                return ((bool)(this["LeftToolsColVisible"]));
            }
            set {
                this["LeftToolsColVisible"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public global::System.Windows.GridLength SplitterColWidthSetting {
            get {
                return ((global::System.Windows.GridLength)(this["SplitterColWidthSetting"]));
            }
            set {
                this["SplitterColWidthSetting"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FFADFF2F")]
        public global::System.Windows.Media.Color Overlay_CoordSelColor {
            get {
                return ((global::System.Windows.Media.Color)(this["Overlay_CoordSelColor"]));
            }
            set {
                this["Overlay_CoordSelColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FFFF0000")]
        public global::System.Windows.Media.Color Overlay_CoordColor {
            get {
                return ((global::System.Windows.Media.Color)(this["Overlay_CoordColor"]));
            }
            set {
                this["Overlay_CoordColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#70FF0000")]
        public global::System.Windows.Media.Color Overlay_ScopeSelColor {
            get {
                return ((global::System.Windows.Media.Color)(this["Overlay_ScopeSelColor"]));
            }
            set {
                this["Overlay_ScopeSelColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#7000FF00")]
        public global::System.Windows.Media.Color Overlay_ScopeColor {
            get {
                return ((global::System.Windows.Media.Color)(this["Overlay_ScopeColor"]));
            }
            set {
                this["Overlay_ScopeColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Compiler_Timeout {
            get {
                return ((int)(this["Compiler_Timeout"]));
            }
            set {
                this["Compiler_Timeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Compiler_SnippetTimeout {
            get {
                return ((int)(this["Compiler_SnippetTimeout"]));
            }
            set {
                this["Compiler_SnippetTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowFullPathInTitle {
            get {
                return ((bool)(this["ShowFullPathInTitle"]));
            }
            set {
                this["ShowFullPathInTitle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CompileOnCodeChangeRadioButton {
            get {
                return ((bool)(this["CompileOnCodeChangeRadioButton"]));
            }
            set {
                this["CompileOnCodeChangeRadioButton"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CompileOnCTRLPressRadioButton {
            get {
                return ((bool)(this["CompileOnCTRLPressRadioButton"]));
            }
            set {
                this["CompileOnCTRLPressRadioButton"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("htlatex")]
        public string Path_htlatex {
            get {
                return ((string)(this["Path_htlatex"]));
            }
            set {
                this["Path_htlatex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TLB_ShowToolsOther {
            get {
                return ((bool)(this["TLB_ShowToolsOther"]));
            }
            set {
                this["TLB_ShowToolsOther"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-ini -jobname=\"$JOBNAME$\" \"&pdflatex $FILENAME$\\dump\"")]
        public string PrecompiledHeaderCompileCommand {
            get {
                return ((string)(this["PrecompiledHeaderCompileCommand"]));
            }
            set {
                this["PrecompiledHeaderCompileCommand"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FolderView_ShowHidden {
            get {
                return ((bool)(this["FolderView_ShowHidden"]));
            }
            set {
                this["FolderView_ShowHidden"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowTipsTricksWindow {
            get {
                return ((bool)(this["ShowTipsTricksWindow"]));
            }
            set {
                this["ShowTipsTricksWindow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CheckForUpdates {
            get {
                return ((bool)(this["CheckForUpdates"]));
            }
            set {
                this["CheckForUpdates"] = value;
            }
        }
    }
}
