// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Prediction.
    /// </summary>
    public static partial class PredictionExtensions
    {
            /// <summary>
            /// Gets the published endpoint predictions for the given query.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='q'>
            /// The query to predict.
            /// </param>
            /// <param name='timezoneOffset'>
            /// The timezone offset for the location of the request.
            /// </param>
            /// <param name='verbose'>
            /// If true will return all intents instead of just the topscoring intent.
            /// </param>
            /// <param name='spellCheck'>
            /// Enable spell checking.
            /// </param>
            /// <param name='staging'>
            /// Use staging endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LuisResult> GetPredictionsFromEndpointViaGetAsync(this IPrediction operations, string appId, string q, double? timezoneOffset = default(double?), bool? verbose = default(bool?), bool? spellCheck = default(bool?), bool? staging = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPredictionsFromEndpointViaGetWithHttpMessagesAsync(appId, q, timezoneOffset, verbose, spellCheck, staging, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the published endpoint prediction for the given long query.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='q'>
            /// The query to predict.
            /// </param>
            /// <param name='timezoneOffset'>
            /// The timezone offset for the location of the request.
            /// </param>
            /// <param name='verbose'>
            /// If true will return all intents instead of just the topscoring intent.
            /// </param>
            /// <param name='spellCheck'>
            /// Enable spell checking.
            /// </param>
            /// <param name='staging'>
            /// Use staging endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LuisResult> GetPredictionsFromEndpointViaPostAsync(this IPrediction operations, string appId, string q, double? timezoneOffset = default(double?), bool? verbose = default(bool?), bool? spellCheck = default(bool?), bool? staging = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPredictionsFromEndpointViaPostWithHttpMessagesAsync(appId, q, timezoneOffset, verbose, spellCheck, staging, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
