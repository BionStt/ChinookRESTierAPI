using System;
using System.Linq;
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
        public async Task test_get_metadata()
        {
            // Act
            var metadata = await _client.GetMetadataDocumentAsync();

            // Assert
            Assert.NotNull(metadata);
        }
        
        [Fact]
        public async Task test_album_get_count()
        {
            // Act
            var artists = await _client.FindEntriesAsync("Artists");

            // Assert
            Assert.True(artists.Count() > 100, "Expected actualCount to be greater than 100.");
        }
    }
}