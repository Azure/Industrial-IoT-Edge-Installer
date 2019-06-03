﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IoTEdgeInstaller {
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
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("IoTEdgeInstaller.Strings", typeof(Strings).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Azure IoT Edge Installer.
        /// </summary>
        public static string AboutSubtitle {
            get {
                return ResourceManager.GetString("AboutSubtitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please restart this app as Administrator/sudo..
        /// </summary>
        public static string Admin {
            get {
                return ResourceManager.GetString("Admin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We first need to install the Azure CLI for Windows. The Web installer will now launch. Please reboot after the installation is complete..
        /// </summary>
        public static string AzureCLI {
            get {
                return ResourceManager.GetString("AzureCLI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name your IoT Edge Device:.
        /// </summary>
        public static string AzureCreateDeviceIdDesc {
            get {
                return ResourceManager.GetString("AzureCreateDeviceIdDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Devices already registered with this IoT Hub:.
        /// </summary>
        public static string AzureDeviceId {
            get {
                return ResourceManager.GetString("AzureDeviceId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This part of the installation is completed..
        /// </summary>
        public static string Completed {
            get {
                return ResourceManager.GetString("Completed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Looks like you haven’t set up an Azure IoT Hub yet..
        /// </summary>
        public static string ConnectToAzure_NoAzureIoTHub {
            get {
                return ResourceManager.GetString("ConnectToAzure_NoAzureIoTHub", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Install.
        /// </summary>
        public static string CreateEdgeButton {
            get {
                return ResourceManager.GetString("CreateEdgeButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating IoT Edge device on selected IoT Hub failed..
        /// </summary>
        public static string CreateFailed {
            get {
                return ResourceManager.GetString("CreateFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleted existing IoT Edge device successfully. Please try again..
        /// </summary>
        public static string DeletedDevice {
            get {
                return ResourceManager.GetString("DeletedDevice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deploying IoT Edge Container modules failed..
        /// </summary>
        public static string DeployFailed {
            get {
                return ResourceManager.GetString("DeployFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deploying IoT Edge Containers specified in Deployment Script....
        /// </summary>
        public static string Deployment {
            get {
                return ResourceManager.GetString("Deployment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press Enter to exit..
        /// </summary>
        public static string EnterToExist {
            get {
                return ResourceManager.GetString("EnterToExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Collecting IoT Hubs You have Access to....
        /// </summary>
        public static string GatheringIoTHubs {
            get {
                return ResourceManager.GetString("GatheringIoTHubs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installing new IoT Edge and Moby Docker instance....
        /// </summary>
        public static string Install {
            get {
                return ResourceManager.GetString("Install", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installing IoT Edge runtime failed. Please reboot and try again..
        /// </summary>
        public static string InstallFailed {
            get {
                return ResourceManager.GetString("InstallFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installing....
        /// </summary>
        public static string Installing {
            get {
                return ResourceManager.GetString("Installing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Status of IoT Edge Modules:.
        /// </summary>
        public static string IoTEdgeModules {
            get {
                return ResourceManager.GetString("IoTEdgeModules", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pick an IoT Hub:.
        /// </summary>
        public static string IoTHubs {
            get {
                return ResourceManager.GetString("IoTHubs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to login to Azure..
        /// </summary>
        public static string LoginFailedAlertMessage {
            get {
                return ResourceManager.GetString("LoginFailedAlertMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Install Azure IoT Edge on this Computer.
        /// </summary>
        public static string NewAzureDevice {
            get {
                return ResourceManager.GetString("NewAzureDevice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pick a local network interface for IoT Edge:.
        /// </summary>
        public static string Nic {
            get {
                return ResourceManager.GetString("Nic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This Operating System is unfortunately not supported..
        /// </summary>
        public static string OSNotSupported {
            get {
                return ResourceManager.GetString("OSNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Checking Prerequisits....
        /// </summary>
        public static string Prerequisits {
            get {
                return ResourceManager.GetString("Prerequisits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prerequisits to install IoT Edge not yet met. Please try again after all prerequests are met..
        /// </summary>
        public static string PreRequisitsFailed {
            get {
                return ResourceManager.GetString("PreRequisitsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please restart Windows to complete the installation..
        /// </summary>
        public static string Reboot {
            get {
                return ResourceManager.GetString("Reboot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uninstalling previous IoT Edge instance, if required....
        /// </summary>
        public static string Uninstall {
            get {
                return ResourceManager.GetString("Uninstall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uninstalling IoT Edge runtime failed..
        /// </summary>
        public static string UninstallFailed {
            get {
                return ResourceManager.GetString("UninstallFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Aborting setup of HyperV Virtual Switch &apos;host&apos; as it already exists..
        /// </summary>
        public static string VSwitchExists {
            get {
                return ResourceManager.GetString("VSwitchExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting up HyperV Virtual Switch &apos;host&apos; failed..
        /// </summary>
        public static string VSwitchSetupFailed {
            get {
                return ResourceManager.GetString("VSwitchSetupFailed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Additionally install Industrial IoT modules.
        /// </summary>
        public static string InstallIIoT
        {
            get
            {
                return ResourceManager.GetString("InstallIIoT", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Simply press Enter to use the host name.
        /// </summary>
        public static string UseHostname
        {
            get
            {
                return ResourceManager.GetString("UseHostname", resourceCulture);
            }
        }
    }
}