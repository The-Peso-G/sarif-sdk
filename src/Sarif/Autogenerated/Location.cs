// Copyright (c) Microsoft.  All Rights Reserved.
// Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Microsoft.CodeAnalysis.Sarif
{
    /// <summary>
    /// The location where an analysis tool produced a result.
    /// </summary>
    [DataContract]
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "0.11.0.0")]
    public partial class Location : ISarifNode, IEquatable<Location>
    {
        /// <summary>
        /// Gets a value indicating the type of object implementing <see cref="ISarifNode" />.
        /// </summary>
        public SarifNodeKind SarifNodeKind
        {
            get
            {
                return SarifNodeKind.Location;
            }
        }

        /// <summary>
        /// Identifies the file that the analysis tool was instructed to scan. This need not be the same as the file where the result actually occurred.
        /// </summary>
        [DataMember(Name = "analysisTarget", IsRequired = false, EmitDefaultValue = false)]
        public PhysicalLocation AnalysisTarget { get; set; }

        /// <summary>
        /// Identifies the file where the analysis tool produced the result.
        /// </summary>
        [DataMember(Name = "resultFile", IsRequired = false, EmitDefaultValue = false)]
        public PhysicalLocation ResultFile { get; set; }

        /// <summary>
        /// The fully qualified name of the logical location where the analysis tool produced the result.
        /// </summary>
        [DataMember(Name = "fullyQualifiedLogicalName", IsRequired = false, EmitDefaultValue = false)]
        public string FullyQualifiedLogicalName { get; set; }

        /// <summary>
        /// A string used as a key into the logicalLocations dictionary, in case the string specified by 'fullyQualifiedLogicalName' is not unique.
        /// </summary>
        [DataMember(Name = "logicalLocationKey", IsRequired = false, EmitDefaultValue = false)]
        public string LogicalLocationKey { get; set; }

        /// <summary>
        /// Key/value pairs that provide additional information about the location.
        /// </summary>
        [DataMember(Name = "properties", IsRequired = false, EmitDefaultValue = false)]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// A set of distinct strings that provide additional information about the location.
        /// </summary>
        [DataMember(Name = "tags", IsRequired = false, EmitDefaultValue = false)]
        public IList<string> Tags { get; set; }

        public override bool Equals(object other)
        {
            return Equals(other as Location);
        }

        public override int GetHashCode()
        {
            int result = 17;
            unchecked
            {
                if (AnalysisTarget != null)
                {
                    result = (result * 31) + AnalysisTarget.GetHashCode();
                }

                if (ResultFile != null)
                {
                    result = (result * 31) + ResultFile.GetHashCode();
                }

                if (FullyQualifiedLogicalName != null)
                {
                    result = (result * 31) + FullyQualifiedLogicalName.GetHashCode();
                }

                if (LogicalLocationKey != null)
                {
                    result = (result * 31) + LogicalLocationKey.GetHashCode();
                }

                if (Properties != null)
                {
                    // Use xor for dictionaries to be order-independent.
                    int xor_0 = 0;
                    foreach (var value_0 in Properties)
                    {
                        xor_0 ^= value_0.Key.GetHashCode();
                        if (value_0.Value != null)
                        {
                            xor_0 ^= value_0.Value.GetHashCode();
                        }
                    }

                    result = (result * 31) + xor_0;
                }

                if (Tags != null)
                {
                    foreach (var value_1 in Tags)
                    {
                        result = result * 31;
                        if (value_1 != null)
                        {
                            result = (result * 31) + value_1.GetHashCode();
                        }
                    }
                }
            }

            return result;
        }

        public bool Equals(Location other)
        {
            if (other == null)
            {
                return false;
            }

            if (!Object.Equals(AnalysisTarget, other.AnalysisTarget))
            {
                return false;
            }

            if (!Object.Equals(ResultFile, other.ResultFile))
            {
                return false;
            }

            if (FullyQualifiedLogicalName != other.FullyQualifiedLogicalName)
            {
                return false;
            }

            if (LogicalLocationKey != other.LogicalLocationKey)
            {
                return false;
            }

            if (!Object.ReferenceEquals(Properties, other.Properties))
            {
                if (Properties == null || other.Properties == null || Properties.Count != other.Properties.Count)
                {
                    return false;
                }

                foreach (var value_0 in Properties)
                {
                    string value_1;
                    if (!other.Properties.TryGetValue(value_0.Key, out value_1))
                    {
                        return false;
                    }

                    if (value_0.Value != value_1)
                    {
                        return false;
                    }
                }
            }

            if (!Object.ReferenceEquals(Tags, other.Tags))
            {
                if (Tags == null || other.Tags == null)
                {
                    return false;
                }

                if (Tags.Count != other.Tags.Count)
                {
                    return false;
                }

                for (int index_0 = 0; index_0 < Tags.Count; ++index_0)
                {
                    if (Tags[index_0] != other.Tags[index_0])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        public Location()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class from the supplied values.
        /// </summary>
        /// <param name="analysisTarget">
        /// An initialization value for the <see cref="P: AnalysisTarget" /> property.
        /// </param>
        /// <param name="resultFile">
        /// An initialization value for the <see cref="P: ResultFile" /> property.
        /// </param>
        /// <param name="fullyQualifiedLogicalName">
        /// An initialization value for the <see cref="P: FullyQualifiedLogicalName" /> property.
        /// </param>
        /// <param name="logicalLocationKey">
        /// An initialization value for the <see cref="P: LogicalLocationKey" /> property.
        /// </param>
        /// <param name="properties">
        /// An initialization value for the <see cref="P: Properties" /> property.
        /// </param>
        /// <param name="tags">
        /// An initialization value for the <see cref="P: Tags" /> property.
        /// </param>
        public Location(PhysicalLocation analysisTarget, PhysicalLocation resultFile, string fullyQualifiedLogicalName, string logicalLocationKey, IDictionary<string, string> properties, IEnumerable<string> tags)
        {
            Init(analysisTarget, resultFile, fullyQualifiedLogicalName, logicalLocationKey, properties, tags);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class from the specified instance.
        /// </summary>
        /// <param name="other">
        /// The instance from which the new instance is to be initialized.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="other" /> is null.
        /// </exception>
        public Location(Location other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            Init(other.AnalysisTarget, other.ResultFile, other.FullyQualifiedLogicalName, other.LogicalLocationKey, other.Properties, other.Tags);
        }

        ISarifNode ISarifNode.DeepClone()
        {
            return DeepCloneCore();
        }

        /// <summary>
        /// Creates a deep copy of this instance.
        /// </summary>
        public Location DeepClone()
        {
            return (Location)DeepCloneCore();
        }

        private ISarifNode DeepCloneCore()
        {
            return new Location(this);
        }

        private void Init(PhysicalLocation analysisTarget, PhysicalLocation resultFile, string fullyQualifiedLogicalName, string logicalLocationKey, IDictionary<string, string> properties, IEnumerable<string> tags)
        {
            if (analysisTarget != null)
            {
                AnalysisTarget = new PhysicalLocation(analysisTarget);
            }

            if (resultFile != null)
            {
                ResultFile = new PhysicalLocation(resultFile);
            }

            FullyQualifiedLogicalName = fullyQualifiedLogicalName;
            LogicalLocationKey = logicalLocationKey;
            if (properties != null)
            {
                Properties = new Dictionary<string, string>(properties);
            }

            if (tags != null)
            {
                var destination_0 = new List<string>();
                foreach (var value_0 in tags)
                {
                    destination_0.Add(value_0);
                }

                Tags = destination_0;
            }
        }
    }
}