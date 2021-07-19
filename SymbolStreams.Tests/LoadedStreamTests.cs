using System;
using SymbolStreams;
using Xunit;
namespace SymbolStreamsTests
{
    public class LoadedStreamTests
    {
        [Fact]
        public void CorrectDataReadTest()
        {
            // Arrange 
            string testData = "Test char array";
            LoadedStream<char> loadedStream = new(testData.ToCharArray());

            // Act
            string result = "";
            char buffer = loadedStream.Peek();
            while (buffer != default)
            {
                result += buffer;
                buffer = loadedStream.Next();
            }

            // Assert
            Assert.Equal(testData, result);
        }
    }
}
