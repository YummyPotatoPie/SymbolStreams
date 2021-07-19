using Xunit;

namespace SymbolStreams.Tests
{
    public class IterativeLoadedStreamTests
    {
        [Fact]
        public void IteratorCorrectReadDataTest()
        {
            // Arrange 
            string testData = "Hello World";
            IterativeLoadedStream<char> iterativeLoadedStream = new(testData.ToCharArray());

            // Act
            string result = "";
            foreach (char ch in iterativeLoadedStream) result += ch;

            // Assert
            Assert.Equal(testData, result);
        }

    }
}
