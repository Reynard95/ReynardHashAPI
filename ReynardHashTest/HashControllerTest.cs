using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReynardHashAPI.Controllers;

namespace ReynardHashTest
{
    public class HashControllerTest
    {
        HashController _controller;
        private readonly ILogger<HashController> _logger;

        public HashControllerTest()
        {
            _controller = new HashController(_logger);

        }

        [Fact]
        public void GetAllTest()
        {
            //Arrange
            string stringToHash = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur quis metus sed nibh blandit facilisis nec a sem. Donec eleifend, augue id euismod lacinia, mi felis pellentesque ante, in efficitur leo elit non magna. Ut sed elementum ante. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Donec quis leo risus. Curabitur nec leo metus. Pellentesque suscipit ante felis, non mattis orci consectetur at. Duis nec tortor nec eros pharetra iaculis interdum vel sapien. Donec varius ultricies venenatis.";

            //Act
            var result = _controller.Post(stringToHash);

            //Assert
            Assert.IsType<ulong>(result);
        }
    }
}