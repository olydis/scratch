﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Rest.ClientRuntime.Properties {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Resources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Rest.ClientRuntime.Properties.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
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
        ///    Looks up a localized string similar to cannot be null.
        /// </summary>
        internal static string ValidationCannotBeNull {
            get {
                return ResourceManager.GetString("ValidationCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to cannot have value other than.
        /// </summary>
        internal static string ValidationEnum {
            get {
                return ResourceManager.GetString("ValidationEnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to is equal or exceeds maximum value of.
        /// </summary>
        internal static string ValidationExclusiveMaximum {
            get {
                return ResourceManager.GetString("ValidationExclusiveMaximum", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to is less than or equal minimum value of.
        /// </summary>
        internal static string ValidationExclusiveMinimum {
            get {
                return ResourceManager.GetString("ValidationExclusiveMinimum", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to exceeds maximum value of.
        /// </summary>
        internal static string ValidationMaximum {
            get {
                return ResourceManager.GetString("ValidationMaximum", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to exceeds maximum item count of.
        /// </summary>
        internal static string ValidationMaximumItems {
            get {
                return ResourceManager.GetString("ValidationMaximumItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to exceeds maximum length of.
        /// </summary>
        internal static string ValidationMaximumLength {
            get {
                return ResourceManager.GetString("ValidationMaximumLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to is less than minimum value of.
        /// </summary>
        internal static string ValidationMinimum {
            get {
                return ResourceManager.GetString("ValidationMinimum", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to contains less items than.
        /// </summary>
        internal static string ValidationMinimumItems {
            get {
                return ResourceManager.GetString("ValidationMinimumItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to is less than minimum length of.
        /// </summary>
        internal static string ValidationMinimumLength {
            get {
                return ResourceManager.GetString("ValidationMinimumLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to has to be multiple of.
        /// </summary>
        internal static string ValidationMultipleOf {
            get {
                return ResourceManager.GetString("ValidationMultipleOf", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to does not match expected pattern.
        /// </summary>
        internal static string ValidationPattern {
            get {
                return ResourceManager.GetString("ValidationPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to collection contains duplicate items.
        /// </summary>
        internal static string ValidationUniqueItems {
            get {
                return ResourceManager.GetString("ValidationUniqueItems", resourceCulture);
            }
        }
    }
}
