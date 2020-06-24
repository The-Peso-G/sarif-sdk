﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CodeAnalysis.Sarif.Multitool.Rules {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class RuleResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RuleResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.CodeAnalysis.Sarif.Multitool.Rules.RuleResources", typeof(RuleResources).Assembly);
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
        ///   Looks up a localized string similar to {0}: The name and id properties of rule &quot;{1}&quot; are the same..
        /// </summary>
        internal static string SARIF1001_RuleIdentifiersMustBeValid_Error_Default_Text {
            get {
                return ResourceManager.GetString("SARIF1001_RuleIdentifiersMustBeValid_Error_Default_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not use the same string for a rule&apos;s id and name properties. The id property must be a stable, opaque identifer such as &quot;SARIF1001&quot;. The name property should be a string that is understandable to an end user, such as &quot;DoNotUserFriendlyNameAsRuleId&quot;..
        /// </summary>
        internal static string SARIF1001_RuleIdentifiersMustBeValid_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1001_RuleIdentifiersMustBeValid_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: &apos;{1}&apos; Placeholder_SARIF1002_UrisMustBeValid_Error_FileUrisMustNotIncludeDotDotSegments_Text.
        /// </summary>
        internal static string SARIF1002_UrisMustBeValid_Error_FileUrisMustNotIncludeDotDotSegments_Text {
            get {
                return ResourceManager.GetString("SARIF1002_UrisMustBeValid_Error_FileUrisMustNotIncludeDotDotSegments_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The string &quot;{1}&quot; is not a valid URI reference..
        /// </summary>
        internal static string SARIF1002_UrisMustBeValid_Error_UrisMustConformToRfc3986_Text {
            get {
                return ResourceManager.GetString("SARIF1002_UrisMustBeValid_Error_UrisMustConformToRfc3986_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify a valid URI reference for every URI-valued property..
        /// </summary>
        internal static string SARIF1002_UrisMustBeValid_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1002_UrisMustBeValid_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The URI &apos;{1}&apos; belonging to the &apos;{2}&apos; element of run.originalUriBaseIds is not an absolute URI..
        /// </summary>
        internal static string SARIF1004_ExpressUriBaseIdsCorrectly_Error_TopLevelUriBaseIdMustBeAbsolute_Text {
            get {
                return ResourceManager.GetString("SARIF1004_ExpressUriBaseIdsCorrectly_Error_TopLevelUriBaseIdMustBeAbsolute_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: This fileLocation object contains a &quot;uriBaseId&quot; property, which means that the value of the &quot;uri&quot; property must be a relative URI reference, but &quot;{1}&quot; is an absolute URI reference..
        /// </summary>
        internal static string SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdRequiresRelativeUri_Text {
            get {
                return ResourceManager.GetString("SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdRequiresRelativeUri_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The URI &apos;{1}&apos; belonging to the &apos;{2}&apos; element of run.originalUriBaseIds does not end with a slash..
        /// </summary>
        internal static string SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdValueMustEndWithSlash_Text {
            get {
                return ResourceManager.GetString("SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdValueMustEndWithSlash_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: &apos;{1}&apos; &apos;{2}&apos; Placeholder: SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdValueMustNotContainDotDotSegment_Text.
        /// </summary>
        internal static string SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdValueMustNotContainDotDotSegment_Text {
            get {
                return ResourceManager.GetString("SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdValueMustNotContainDotDotSegm" +
                        "ent_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: &apos;{1}&apos; &apos;{2}&apos; Placeholder: SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdValueMustNotContainQueryOrFragment_Text.
        /// </summary>
        internal static string SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdValueMustNotContainQueryOrFragment_Text {
            get {
                return ResourceManager.GetString("SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdValueMustNotContainQueryOrFra" +
                        "gment_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Placeholder_SARIF1004_ExpressUriBaseIdsCorrectly_FullDescription_Text.
        /// </summary>
        internal static string SARIF1004_ExpressUriBaseIdsCorrectly_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1004_ExpressUriBaseIdsCorrectly_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The value of this property is required to be an absolute URI, but &quot;{1}&quot; is a relative URI reference..
        /// </summary>
        internal static string SARIF1005_UriMustBeAbsolute_Error_Default_Text {
            get {
                return ResourceManager.GetString("SARIF1005_UriMustBeAbsolute_Error_Default_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certain URIs are required to be absolute..
        /// </summary>
        internal static string SARIF1005_UriMustBeAbsolute_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1005_UriMustBeAbsolute_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The end time &quot;{1}&quot; is before the start time &quot;{2}&quot;..
        /// </summary>
        internal static string SARIF1006_InvocationPropertiesMustBeConsistent_Error_EndTimeMustNotPrecedeStartTime_Text {
            get {
                return ResourceManager.GetString("SARIF1006_InvocationPropertiesMustBeConsistent_Error_EndTimeMustNotPrecedeStartTi" +
                        "me_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The end time of a run must not precede the start time. To allow for the possibility that the duration of the run is less than the resolution of the string representation of the time, the start time and the end time may be equal..
        /// </summary>
        internal static string SARIF1006_InvocationPropertiesMustBeConsistent_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1006_InvocationPropertiesMustBeConsistent_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The value of the &quot;endColumn&quot; property is {1}, which is less than the value of the &quot;startColumn&quot; property, which is {2}..
        /// </summary>
        internal static string SARIF1007_RegionPropertiesMustBeConsistent_Error_EndColumnMustNotPrecedeStartColumn_Text {
            get {
                return ResourceManager.GetString("SARIF1007_RegionPropertiesMustBeConsistent_Error_EndColumnMustNotPrecedeStartColu" +
                        "mn_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The value of the &quot;endLine&quot; property is {1}, which is less than the value of the &quot;startLine&quot; property, which is {2}..
        /// </summary>
        internal static string SARIF1007_RegionPropertiesMustBeConsistent_Error_EndLineMustNotPrecedeStartLine_Text {
            get {
                return ResourceManager.GetString("SARIF1007_RegionPropertiesMustBeConsistent_Error_EndLineMustNotPrecedeStartLine_T" +
                        "ext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Placeholder_SARIF1007_RegionPropertiesMustBeConsistent_FullDescription_Text.
        /// </summary>
        internal static string SARIF1007_RegionPropertiesMustBeConsistent_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1007_RegionPropertiesMustBeConsistent_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: This &apos;physicalLocation&apos; object contains both a &apos;region&apos; and a &apos;contextRegion&apos; property, but &apos;contextRegion&apos; is not a proper superset of &apos;region&apos;. This is invalid because the purpose of &apos;contextRegion&apos; is to provide a viewing context around the &apos;region&apos; which is the location of the result. It&apos;s possible that the tool reversed &apos;region&apos; and &apos;contextRegion&apos;. If &apos;region&apos; and &apos;contextRegion&apos; are identical, the tool must omit &apos;contextRegion&apos;..
        /// </summary>
        internal static string SARIF1008_PhysicalLocationPropertiesMustBeConsistent_Error_ContextRegionMustBeProperSupersetOfRegion_Text {
            get {
                return ResourceManager.GetString("SARIF1008_PhysicalLocationPropertiesMustBeConsistent_Error_ContextRegionMustBePro" +
                        "perSupersetOfRegion_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: This &apos;physicalLocation&apos; object contains a &apos;contextRegion&apos; property, but it does not contain a &apos;region&apos; property. This is invalid because the purpose of &apos;contextRegion&apos; is to provide a viewing context around the &apos;region&apos; which is the location of the result. If a tool associates only one region with a result, it must populate &apos;region&apos;, not &apos;contextRegion&apos;..
        /// </summary>
        internal static string SARIF1008_PhysicalLocationPropertiesMustBeConsistent_Error_ContextRegionRequiresRegion_Text {
            get {
                return ResourceManager.GetString("SARIF1008_PhysicalLocationPropertiesMustBeConsistent_Error_ContextRegionRequiresR" +
                        "egion_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ensure consistency among the properties of a &apos;physicalLocation&apos; object.
        ///
        ///A SARIF &apos;physicalLocation&apos; object has two related properties &apos;region&apos; and &apos;contextRegion&apos;. If &apos;contextRegion&apos; is present, then &apos;region&apos; must also be present, and &apos;contextRegion&apos; must be a &quot;proper superset&quot; of &apos;region&apos;. That is, &apos;contextRegion&apos; must completely contain &apos;region&apos;, and it must be larger than &apos;region&apos;. To understand why this is so we must understand the roles of the &apos;region&apos; and &apos;contextRegion&apos; properties.
        ///
        ///&apos;region&apos; allo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SARIF1008_PhysicalLocationPropertiesMustBeConsistent_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1008_PhysicalLocationPropertiesMustBeConsistent_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: This &quot;{1}&quot; object contains a property &quot;{2}&quot; with value {3}, but &quot;{4}&quot; has fewer than {5} elements..
        /// </summary>
        internal static string SARIF1009_IndexPropertiesMustBeConsistentWithArrays_Error_TargetArrayMustBeLongEnough_Text {
            get {
                return ResourceManager.GetString("SARIF1009_IndexPropertiesMustBeConsistentWithArrays_Error_TargetArrayMustBeLongEn" +
                        "ough_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: This &quot;{1}&quot; object contains a property &quot;{2}&quot; with value {3}, but &quot;{4}&quot; is absent..
        /// </summary>
        internal static string SARIF1009_IndexPropertiesMustBeConsistentWithArrays_Error_TargetArrayMustExist_Text {
            get {
                return ResourceManager.GetString("SARIF1009_IndexPropertiesMustBeConsistentWithArrays_Error_TargetArrayMustExist_Te" +
                        "xt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If an object contains a property that is used as an array index, then that array must be present and must contain at least &quot;index + 1&quot; elements..
        /// </summary>
        internal static string SARIF1009_IndexPropertiesMustBeConsistentWithArrays_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1009_IndexPropertiesMustBeConsistentWithArrays_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The result contains neither result.ruleId nor result.rule.id..
        /// </summary>
        internal static string SARIF1010_RuleIdMustBeConsistent_Error_ResultMustSpecifyRuleId_Text {
            get {
                return ResourceManager.GetString("SARIF1010_RuleIdMustBeConsistent_Error_ResultMustSpecifyRuleId_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The result contains both the ruleId property &apos;{1}&apos; and the rule.id property &apos;{2}&apos;, and they are not equal..
        /// </summary>
        internal static string SARIF1010_RuleIdMustBeConsistent_Error_ResultRuleIdMustBeConsistent_Text {
            get {
                return ResourceManager.GetString("SARIF1010_RuleIdMustBeConsistent_Error_ResultRuleIdMustBeConsistent_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In every result, at least one of the properties result.ruleId and result.rule.id must be present. If both are present, they must be equal..
        /// </summary>
        internal static string SARIF1010_RuleIdMustBeConsistent_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1010_RuleIdMustBeConsistent_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The $schema property value &apos;{1}&apos; does not refer to the final version of the SARIF 2.1.0 schema. If you are using an earlier version of the SARIF format, consider upgrading your analysis tool to produce the final version. If this file does in fact conform to the final version of the schema, upgrade the tool to populate the $schema property with a URL that refers to the final version of the schema..
        /// </summary>
        internal static string SARIF1011_ReferenceFinalSchema_Error_Default_Text {
            get {
                return ResourceManager.GetString("SARIF1011_ReferenceFinalSchema_Error_Default_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The $schema property must refer to the final version of the SARIF 2.1.0 schema. This enables IDEs to provide Intellisense for SARIF log files..
        /// </summary>
        internal static string SARIF1011_ReferenceFinalSchema_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1011_ReferenceFinalSchema_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Messages should consist of one or more complete sentences, ending with a period..
        /// </summary>
        internal static string SARIF2001_AuthorHighQualityMessages_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF2001_AuthorHighQualityMessages_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The message &quot;{1}&quot; does not end with a period..
        /// </summary>
        internal static string SARIF2001_AuthorHighQualityMessages_Warning_TerminateWithPeriod_Text {
            get {
                return ResourceManager.GetString("SARIF2001_AuthorHighQualityMessages_Warning_TerminateWithPeriod_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provide information that makes it easy to identify the name and version of your tool.
        ///
        ///The tool&apos;s &apos;name&apos; property should be no more than three words long. This makes it easy to remember and allows it to fit into a narrow column when displaying a list of results. If you need to provide more information about your tool, use the &apos;fullName&apos; property.
        ///
        ///The tool should provide either or both of the &apos;version&apos; and &apos;semanticVersion&apos; properties. This enables the log file consumer to determine whether the file was [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SARIF2005_ProvideHelpfulToolInformation_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF2005_ProvideHelpfulToolInformation_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The tool name &apos;{1}&apos; contains {2} words, which is more than the recommended maximum of {3} words. A short tool name is easy to remember and fits into a narrow column when displaying a list of results. If you need to provide more information about your tool, use the &apos;fullName&apos; property..
        /// </summary>
        internal static string SARIF2005_ProvideHelpfulToolInformation_Warning_ProvideConciseToolName_Text {
            get {
                return ResourceManager.GetString("SARIF2005_ProvideHelpfulToolInformation_Warning_ProvideConciseToolName_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The tool &apos;{1}&apos; provides neither a &apos;version&apos; property nor a &apos;semanticVersion&apos; property. Providing a version enables the log file consumer to determine whether the file was produced by an up to date version, and to avoid accidentally comparing log files produced by different tool versions..
        /// </summary>
        internal static string SARIF2005_ProvideHelpfulToolInformation_Warning_ProvideToolVersion_Text {
            get {
                return ResourceManager.GetString("SARIF2005_ProvideHelpfulToolInformation_Warning_ProvideToolVersion_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The tool &apos;{1}&apos; contains the &apos;version&apos; property &apos;{2}&apos;, which is not numeric. To facilitate comparison between versions, specify a &apos;version&apos; that starts with at least two dot-separated integer components, optionally followed by any desired characters..
        /// </summary>
        internal static string SARIF2005_ProvideHelpfulToolInformation_Warning_UseNumericToolVersions_Text {
            get {
                return ResourceManager.GetString("SARIF2005_ProvideHelpfulToolInformation_Warning_UseNumericToolVersions_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The $schema property should be present.  This enables IDEs to provide Intellisense for SARIF log files..
        /// </summary>
        internal static string SARIF2008_ProvideSchema_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF2008_ProvideSchema_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The SARIF log file does not contain a $schema property. Add a $schema property that refers to the final version of the SARIF 2.1.0 schema. This enables IDEs to provide Intellisense for SARIF log files..
        /// </summary>
        internal static string SARIF2008_ProvideSchema_Warning_Default_Text {
            get {
                return ResourceManager.GetString("SARIF2008_ProvideSchema_Warning_Default_Text", resourceCulture);
            }
        }
    }
}
