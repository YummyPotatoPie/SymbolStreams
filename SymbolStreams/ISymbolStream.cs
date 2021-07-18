namespace SymbolStreams
{
    /// <summary>
    /// Interface for symbols streams
    /// </summary>
    /// <typeparam name="T">A type that represents characters in a stream</typeparam>
    public interface ISymbolStream<T>
    {
        /// <summary>
        /// Returns current symbol at the stream
        /// </summary>
        /// <returns>Current stream symbol</returns>
        public T PeekSymbol();

        /// <summary>
        /// Reads next symbol at the stream
        /// </summary>
        /// <param name="symbol">A variable for setting the value of the next symbol in it</param>
        /// <returns>True if read next symbol otherwise false</returns>
        public bool NextSymbol(out T symbol);

        /// <summary>
        /// Checks if the stream has reached the end of the file
        /// </summary>
        /// <returns>Returns true if stream reaches the end of file, otherwise returns false</returns>
        public bool EndOfStream();
    }
}
