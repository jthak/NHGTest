using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using TechnicalTest.Service;

namespace TechnicalTest
{
    public class LocationClient
    {
        private readonly RestService _resrService;
        private readonly ConfigurationProvider _configurationProvider;
        private RestResponse Response;

        public LocationClient(RestService restService, ConfigurationProvider configurationProvider)
        {
            _resrService = restService;
            _configurationProvider = configurationProvider;
        }

        public void GetLocationInformation(string countryCode, string postCode)
        {
            var url = _configurationProvider.GetUrl();
        }

        public void VerifyRequestStatus(string isSuccessful)
        {

        }
    }
}

