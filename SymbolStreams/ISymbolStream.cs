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
        public T Peek();

        /// <summary>
        /// Reads next symbol at the stream
        /// </summary>
        /// <returns>Return default value of T if reached final symbol at the stream, otherwise return next symbol at the stream</returns>
        public T Next();

        /// <summary>
        /// Checks if the stream has reached the end of the file
        /// </summary>
        /// <returns>Returns true if stream reaches the end of file, otherwise returns false</returns>
        public bool EndOfStream();

        /// <summary>
        /// Reset stream position
        /// </summary>
        public void Reset();
    }
}
