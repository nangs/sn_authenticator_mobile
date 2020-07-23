﻿// Copyright 2020 MaidSafe.net limited.
//
// This SAFE Network Software is licensed to you under the MIT license <LICENSE-MIT
// http://opensource.org/licenses/MIT> or the Modified BSD license <LICENSE-BSD
// https://opensource.org/licenses/BSD-3-Clause>, at your option. This file may not be copied,
// modified, or distributed except according to those terms. Please review the Licences for the
// specific language governing permissions and limitations relating to use of the SAFE Network
// Software.

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafeAuthenticatorApp.Helpers
{
    public interface IFileOps
    {
        string ConfigFilesPath { get; }

        Task TransferAssetsAsync(List<(string, string)> fileList);
    }
}
