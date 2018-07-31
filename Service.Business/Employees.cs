using ACME.EmplyeeBirthdayWish.CrossCutting.DTO;
using ACME.EmplyeeBirthdayWish.Service.Shared;
using Microsoft.Rest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.ServiceModel;
using System.Threading;

namespace ACME.EmplyeeBirthdayWish.Service.Business
{
    public static class Employees
    {
        public static List<Employee> GetEmployees()
        {
            const string EMPLOYEE_APIURL = "/api/Employees";
            const string MEDIA_TYPE = "application/json";
            List<Employee> _result = null;
            ConnectionProperty objConn = new ConnectionProperty();
            CancellationToken cancellationToken = default(CancellationToken);

            //connection object initialize
            objConn.Initialize();

            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, Employees.GetEmployees(), "ApiEmployeesGet", tracingParameters);
            }

            // Construct URL
            var _baseUrl = objConn.BaseUri.AbsoluteUri;
            var _url = ExtensionMethods.BuildURL(_baseUrl, EMPLOYEE_APIURL.ToString());

            using (var _httpClient = new HttpClient())
            {
                _httpClient.BaseAddress = new Uri(_url);
                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MEDIA_TYPE));
                
                try
                {
                    var _httpResponse = _httpClient.GetAsync(EMPLOYEE_APIURL).Result;

                    HttpStatusCode _statusCode = _httpResponse.StatusCode;
                    if ((int)_statusCode != 200)
                    {
                        var ex = new HttpOperationException(string.Format("ApiEmployeesGet Operation returned an invalid status code '{0}'", _statusCode));
                        throw ex;
                    }
                    if (_httpResponse.IsSuccessStatusCode)
                    {
                        var _responseContent = _httpResponse.Content;
                        try
                        {
                            _result = JsonConvert.DeserializeObject<List<Employee>>(_responseContent.ReadAsStringAsync().Result);
                        }
                        catch (Exception ex)
                        {
                            if (_httpResponse != null)
                            {
                                _httpResponse.Dispose();
                            }
                            throw new SerializationException("Unable to deserialize the response.", _httpResponse.ToString(), ex);
                        }

                    }
                    if (_shouldTrace)
                    {
                        ServiceClientTracing.Exit(_invocationId, _result);
                    }

                    return _result;
                }
                catch (FaultException ex)
                {
                    throw ex;
                }
            }

        }

    }
}
