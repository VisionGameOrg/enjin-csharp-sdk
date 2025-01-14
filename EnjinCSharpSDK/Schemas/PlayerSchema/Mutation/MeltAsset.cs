/* Copyright 2021 Enjin Pte. Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Enjin.SDK.Graphql;
using Enjin.SDK.Models;
using Enjin.SDK.Shared;
using JetBrains.Annotations;

namespace Enjin.SDK.PlayerSchema
{
    /// <summary>
    /// Request for melting a asset.
    /// </summary>
    /// <seealso cref="IPlayerSchema"/>
    [PublicAPI]
    public class MeltAsset : GraphqlRequest<MeltAsset>, ITransactionFragmentArguments<MeltAsset>
    {
        /// <summary>
        /// Sole constructor.
        /// </summary>
        public MeltAsset() : base("enjin.sdk.player.MeltAsset")
        {
        }

        /// <summary>
        /// Sets the melts to be performed.
        /// </summary>
        /// <param name="melts">The melts.</param>
        /// <returns>This request for chaining.</returns>
        public MeltAsset Melts(params Melt[]? melts)
        {
            return SetVariable("melts", melts);
        }
    }
}