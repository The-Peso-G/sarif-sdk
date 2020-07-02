﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.Sarif.Multitool.Rules
{
    public class ProvideSchema : SarifValidationSkimmerBase
    {
        /// <summary>
        /// SARIF2008
        /// </summary>
        public override string Id => RuleId.ProvideSchema;
        
        /// <summary>
        /// Placeholder
        /// </summary>
        public override MultiformatMessageString FullDescription => new MultiformatMessageString { Text = RuleResources.SARIF2008_ProvideSchema_FullDescription_Text };

        protected override IEnumerable<string> MessageResourceNames => new string[] {
            nameof(RuleResources.SARIF2008_ProvideSchema_Warning_Default_Text)
        };

        public override FailureLevel DefaultLevel => FailureLevel.Warning;

        protected override void Analyze(SarifLog log, string logPointer)
        {
            if (!Context.InputLogToken.HasProperty("$schema"))
            {
                // {0}: Placeholder
                LogResult(
                    logPointer, 
                    nameof(RuleResources.SARIF2008_ProvideSchema_Warning_Default_Text));
            }
        }
    }
}