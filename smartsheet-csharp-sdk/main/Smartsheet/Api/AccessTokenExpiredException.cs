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

namespace Smartsheet.Api
{
    using Error = Api.Models.Error;
    /// <summary>
    /// <para>This is the exception to indicate that an access token expired error returned from Smartsheet REST API. This 
    /// exception will be thrown when the Smartsheet REST API generates a "1003 Your Access Token has expired" error.</para>
    /// 
    /// <para>Thread safety: Exceptions are not thread safe.</para>
    /// </summary>
    public class AccessTokenExpiredException : AuthorizationException
    {
        /// <summary>
        /// Instantiates a new access token expired exception.
        /// </summary>
        /// <param name="error"> the error </param>
        public AccessTokenExpiredException(Error error) : base(error)
        {
        }
    }
}