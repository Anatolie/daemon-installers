﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace installer.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("installer.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to I Agree.
        /// </summary>
        internal static string agree {
            get {
                return ResourceManager.GetString("agree", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to cancel the installation?.
        /// </summary>
        internal static string cancel_installation_prompt {
            get {
                return ResourceManager.GetString("cancel_installation_prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to exit the installation wizard?.
        /// </summary>
        internal static string exit_message {
            get {
                return ResourceManager.GetString("exit_message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap installshield {
            get {
                object obj = ResourceManager.GetObject("installshield", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Spectero Installer.
        /// </summary>
        internal static string messagebox_title {
            get {
                return ResourceManager.GetString("messagebox_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to download release data. Are you connected to the internet?.
        /// </summary>
        internal static string release_data_error {
            get {
                return ResourceManager.GetString("release_data_error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Silent installation requires a installation path, please provide it using the --install-path argument..
        /// </summary>
        internal static string silent_install_requires_path {
            get {
                return ResourceManager.GetString("silent_install_requires_path", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://raw.githubusercontent.com/ProjectSpectero/daemon-installers/master/Windows/SOURCES.json.
        /// </summary>
        internal static string sources_url {
            get {
                return ResourceManager.GetString("sources_url", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://c.spectero.com/releases.json.
        /// </summary>
        internal static string spectero_releases_url {
            get {
                return ResourceManager.GetString("spectero_releases_url", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You attempted to specify a specific version through the command line. This flag is unsupported in GUI mode..
        /// </summary>
        internal static string version_not_silent {
            get {
                return ResourceManager.GetString("version_not_silent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting on user input.
        /// </summary>
        internal static string wait_user {
            get {
                return ResourceManager.GetString("wait_user", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please wait, the installer is gathering information..
        /// </summary>
        internal static string welcome_gathering_information {
            get {
                return ResourceManager.GetString("welcome_gathering_information", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This wizard will install Spectero on your computer. To contiunue, click Next..
        /// </summary>
        internal static string welcome_next_text {
            get {
                return ResourceManager.GetString("welcome_next_text", resourceCulture);
            }
        }
    }
}
