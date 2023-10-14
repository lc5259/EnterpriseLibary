﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.Configuration.EnvironmentalOverrides.Console.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.Configuration.EnvironmentalOverrides.Consol" +
                            "e.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration Error: {0}.
        /// </summary>
        internal static string ConfigurationErrorFmt {
            get {
                return ResourceManager.GetString("ConfigurationErrorFmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration Merge File &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string ConfigurationMergeFileNotFound {
            get {
                return ResourceManager.GetString("ConfigurationMergeFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to attach Environment Configuration Node..
        /// </summary>
        internal static string ErrorNoEnvironmentContainer {
            get {
                return ResourceManager.GetString("ErrorNoEnvironmentContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}
        ///{1}.
        /// </summary>
        internal static string ExceptionFmt {
            get {
                return ResourceManager.GetString("ExceptionFmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occurred.
        /// </summary>
        internal static string GenericExceptionMessage {
            get {
                return ResourceManager.GetString("GenericExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration File &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string MainConfigurationFileNotFound {
            get {
                return ResourceManager.GetString("MainConfigurationFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Merging the configuration file failed.
        /// </summary>
        internal static string MergeFailed {
            get {
                return ResourceManager.GetString("MergeFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Succesfully merged the configuration files in {0}.
        /// </summary>
        internal static string MergeSucceeded {
            get {
                return ResourceManager.GetString("MergeSucceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unhandeld Exception occurred.
        /// </summary>
        internal static string UnhandledExceptionMessage {
            get {
                return ResourceManager.GetString("UnhandledExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To merge configuration files, you must provide both the main Configuration File and Configuration Merge File.
        ///
        ///Usage: MergeConfiguration.exe ConfigFile DeltaFile [MergedFile]
        ///
        ///ConfigFile - The main configuration file (.config), which will be merged
        ///DeltaFile  - The Environment Delta File (.dconfig) that contains the information that should be merged into the main configuration file.
        ///The resulting file 
        ///[MergedFile] – The output file this is generated after merging the ConfigFile and DeltaFile. If not [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Usage {
            get {
                return ResourceManager.GetString("Usage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Validation Error on configuration Node {0}, property {1}
        ///Message: {0}.
        /// </summary>
        internal static string ValidationErrorFmt {
            get {
                return ResourceManager.GetString("ValidationErrorFmt", resourceCulture);
            }
        }
    }
}
