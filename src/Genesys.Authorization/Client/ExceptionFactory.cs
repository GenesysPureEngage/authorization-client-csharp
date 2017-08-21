/* 
 * Authorization API
 *
 * Authorization API
 *
 * OpenAPI spec version: 9.0.000.00.711
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using System;
using RestSharp;

namespace Genesys.Authorization.Client
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
    public delegate Exception ExceptionFactory(string methodName, IRestResponse response);
}
