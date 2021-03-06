﻿// Copyright 2017 LOSTALLOY
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace LOSTALLOY.LocalHistory {
    using System;


    /// <summary>
    ///     This class is a workaround for the fact that we can't use
    ///     things like EnvDTE.Constants.vsWindowKindOutput directly.
    /// </summary>
    // ReSharper disable once IdentifierTypo
    internal class EnvDTEConstants {

        #region Constants

        public const string vsWindowKindOutput = "{34E76E81-EE4A-11D0-AE2E-00A0C90FFFC3}";

        #endregion

    }
}
