using System;
using System.Threading.Tasks;
using Simple.OData.Client;
using Xunit;

namespace ChinookRESTier.Tests
{
    public class Tests
    {
        private readonly ODataClient _client;

        public Tests()
        {
            _client = new ODataClient("https://localhost:44330/");
        }

        [Fact]
        public void test_album_get()
        {
            // Act
            var artists = _client.FindEntriesAsync("Artists");

            // Assert
            Assert.Equal(TaskStatus.RanToCompletion, artists.Status);
        }
    }
}