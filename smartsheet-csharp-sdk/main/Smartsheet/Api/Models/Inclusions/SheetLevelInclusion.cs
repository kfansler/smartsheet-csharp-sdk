﻿//    #[license]
//    SmartsheetClient SDK for C#
//    %%
//    Copyright (C) 2014 SmartsheetClient
//    %%
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        
//            http://www.apache.org/licenses/LICENSE-2.0
//        
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//    %[license]

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Smartsheet.Api.Models
{
    /// <summary>
    /// Represents specific elements to include in a response.
    /// </summary>
    public enum SheetLevelInclusion
    {
        /// <summary>
        /// Includes sheet-level and row-level attachments.
        /// </summary>
        ATTACHMENTS,

        /// <summary>
        /// Includes columnType attribute in the row’s cells indicating the type of the column the cell resides in.
        /// </summary>
        COLUMN_TYPE,

        /// <summary>
        /// contact references
        /// </summary>
        CONTACT_REFERENCES,

        /// <summary>
        /// cross sheet references
        /// </summary>
        CROSS_SHEET_REFERENCES,

        /// <summary>
        /// Includes sheet-level and row-level discussions.
        /// </summary>
        DISCUSSIONS,

        /// <summary>
        /// Includes column filters and row.filteredOut attribute.
        /// </summary>
        FILTERS,

        /// <summary>
        /// Includes column filter definitions
        /// </summary>
        FILTER_DEFINITIONS,

        /// <summary>
        /// Includes column, row, and cell formatting.
        /// </summary>
        FORMAT,

        /// <summary>
        /// object representation of cell value
        /// </summary>
        OBJECT_VALUE,

        /// <summary>
        /// Includes the owner’s email address and user Id for each sheet.
        /// </summary>
        OWNER_INFO,

        /// <summary>
        /// Includes a permalink attribute for each row. A row permalink represents a direct link to the row in the Smartsheet application.
        /// </summary>
        ROW_PERMALINK,

        /// <summary>
        /// (DEPRECATED: use WRITER_INFO) Includes createdBy and modifiedBy attributes on the row, indicating the row’s creator and last modifier.
        /// </summary>
        ROW_WRITER_INFO,

        /// <summary>
        /// Includes the source object indicating which sheet or template the sheet was created from, if any.
        /// </summary>
        SOURCE,

        /// <summary>
        /// Includes SheetSummary object.
        /// </summary>
        SUMMARY,

        /// <summary>
        /// Includes createdBy and modifiedBy attributes on the row or summary fields, indicating the row or summary field's creator, 
        /// and last modifier.
        /// </summary>
        WRITER_INFO
    }
}
