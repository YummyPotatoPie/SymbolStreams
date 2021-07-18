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
            char buffer = loadedStream.PeekSymbol();
            do result += buffer; while (loadedStream.NextSymbol(out buffer));

            // Assert
            Assert.Equal(testData, result);
        }
    }
}
