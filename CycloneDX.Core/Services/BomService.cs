// This file is part of CycloneDX Tool for .NET
//
// Licensed under the Apache License, Version 2.0 (the “License”);
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an “AS IS” BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// SPDX-License-Identifier: Apache-2.0
// Copyright (c) OWASP Foundation. All Rights Reserved.

using CycloneDX.Models.v1_2;
using CycloneDX.Json;
using CycloneDX.Xml;

namespace CycloneDX {
    /// <summary>
    /// Service to generate bill of materials
    /// </summary>
    public static class BomService
    {
        public static string CreateDocument(Bom bom, bool json)
        {
            if (json)
            {
                return JsonBomSerializer.Serialize(bom);
            }
            else
            {
                return XmlBomSerializer.Serialize(bom);
            }
        }
    }
}
