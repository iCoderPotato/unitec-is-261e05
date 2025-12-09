<<<<<<< HEAD
﻿using Xunit;
=======
using Xunit;
>>>>>>> 21527372fd43c8d1295adc15ceb3235631813e27

using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;

namespace WebApplication.IntegrationTest
{
    public class IntegrationTestPages : IClassFixture<WebApplicationFactory<WebApp.Program>>
    {
        private readonly HttpClient _client;

        public IntegrationTestPages(WebApplicationFactory<WebApp.Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Theory]
        [InlineData("/Index")]
        [InlineData("/Principal")]
        [InlineData("/Secundaria")]
        [InlineData("/Maik")]
        [InlineData("/Clashito")]
        public async Task TestGetPages(string url)
        {
            // Arrange


            // Act
            var response = await _client.GetAsync(url);
             response.EnsureSuccessStatusCode(); // Status Code 200-299

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}