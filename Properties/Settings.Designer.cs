﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HdbPoet.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SelectedHdbHost {
            get {
                return ((string)(this["SelectedHdbHost"]));
            }
            set {
                this["SelectedHdbHost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string OracleUsername {
            get {
                return ((string)(this["OracleUsername"]));
            }
            set {
                this["OracleUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>reservoir</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection SelectedObjectTypes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SelectedObjectTypes"]));
            }
            set {
                this["SelectedObjectTypes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>day</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection SelectedIntervals {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SelectedIntervals"]));
            }
            set {
                this["SelectedIntervals"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>host:ecohdb.bor.doi.net service:ecohdb.bor.doi.net timezone:MST</string>
  <string>host:uchdb2.uc.usbr.gov service:uchdb2.uc.usbr.gov timezone:MST</string>
  <string>host:albhdb.uc.usbr.gov service:albhdb   timezone: MDT</string>
  <string>host:ibr3river.bor.doi.net  service:lchdb2.usbr.gov  timezone:MST</string>
  <string>host:ibr3rwatr.lc.usbr.gov service:lctest  timezone:MST</string>
  <string>host:www.troa.net service:troahdb timezone:PDT</string>
  <string>host:ibr3yaohdb.bor.doi.net service:yaohdb  timezone:MST</string>
  <string>host:uchdbdev.uc.usbr.gov service:uchdbdev.uc.usbr.gov  timezone:MST</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection HdbServers {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["HdbServers"]));
            }
            set {
                this["HdbServers"] = value;
            }
        }
    }
}
