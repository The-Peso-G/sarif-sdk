﻿// Copyright (c) Microsoft. All rights reserved. 
// Licensed under the MIT license. See LICENSE file in the project root for full license information. 

using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.CodeAnalysis.Sarif;
using System.ComponentModel;

namespace Microsoft.Sarif.Viewer.Models
{
    public class CallTreeNode : CodeLocationObject
    {
        private AnnotatedCodeLocation _location;

        [Browsable(false)]
        public AnnotatedCodeLocation Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;

                if (value?.PhysicalLocation != null)
                {
                    // If the backing AnnotatedCodeLocation has a PhysicalLocation, set the 
                    // FilePath and Region properties. The FilePath and Region properties
                    // are used to navigate to the source location and highlight the line.
                    Uri uri = value.PhysicalLocation.Uri;
                    if (uri != null)
                    {
                        string path = uri.IsAbsoluteUri ? uri.LocalPath : uri.ToString();
                        if (uri.IsAbsoluteUri && !Path.IsPathRooted(path))
                        {
                            path = uri.AbsoluteUri;
                        }

                        FilePath = path;
                    }

                    Region = value.PhysicalLocation.Region;
                }
                else
                {
                    FilePath = null;
                    Region = null;
                }
            }
        }

        [Browsable(false)]
        public List<CallTreeNode> Children { get; set; }

        public int? Step
        {
            get
            {
                return Location?.Step;
            }
        }

        [Category("Location")]
        [DisplayName("Source file")]
        public string SourceFile
        {
            get
            {
                Uri sourceUrl = Location?.PhysicalLocation?.Uri;
                
                if (sourceUrl != null)
                {
                    return Path.GetFileName(sourceUrl.LocalPath);
                }

                return null;
            }
        }

        [Category("Location")]
        [DisplayName("Start line")]
        public int? StartLine
        {
            get
            {
                return Location?.PhysicalLocation?.Region?.StartLine;
            }
        }

        [Category("Location")]
        [DisplayName("End line")]
        public int? EndLine
        {
            get
            {
                return Location?.PhysicalLocation?.Region?.EndLine;
            }
        }

        [Category("Location")]
        [DisplayName("Start column")]
        public int? StartColumn
        {
            get
            {
                return Location?.PhysicalLocation?.Region?.StartColumn;
            }
        }

        [Category("Location")]
        [DisplayName("End column")]
        public int? EndColumn
        {
            get
            {
                return Location?.PhysicalLocation?.Region?.EndColumn;
            }
        }

        public AnnotatedCodeLocationImportance? Importance
        {
            get
            {
                return Location?.Importance;
            }
        }

        public string Message
        {
            get
            {
                return Location?.Message;
            }
        }

        public string Snippet
        {
            get
            {
                return Location?.Snippet;
            }
        }
    }
}
