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

namespace Smartsheet.Api.OAuth
{
    /// <summary>
    /// Represents OAuth token.
    /// </summary>
    public class Token
    {
        /// <summary>
        /// Represents the access token.
        /// </summary>
        private string accessToken;

        /// <summary>
        /// Represents the token Type.
        /// </summary>
        private string tokenType;

        /// <summary>
        /// Represents the refresh token.
        /// </summary>
        private string refreshToken;

        /// <summary>
        /// Represents the expiration time in seconds.
        /// </summary>
        private long? expiresInSeconds;

        /// <summary>
        /// Gets the access token.
        /// </summary>
        /// <returns> the access token </returns>
        public string AccessToken
        {
            get { return accessToken; }
            set { accessToken = value; }
        }

        /// <summary>
        /// Gets the token Type.
        /// </summary>
        /// <returns> the token Type </returns>
        public string TokenType
        {
            get { return tokenType; }
            set { tokenType = value; }
        }

        /// <summary>
        /// Gets the refresh token.
        /// </summary>
        /// <returns> the refresh token </returns>
        public string RefreshToken
        {
            get { return refreshToken; }
            set { refreshToken = value; }
        }

        /// <summary>
        /// Gets the expires in seconds.
        /// </summary>
        /// <returns> the expires in seconds </returns>
        public long? ExpiresInSeconds
        {
            get { return expiresInSeconds; }
            set { expiresInSeconds = value; }
        }
    }
}