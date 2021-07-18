namespace SymbolStreams
{
    /// <summary>
    /// Unoptimized stream that loads all information from input at once
    /// </summary>
    /// <typeparam name="T">A type that represents characters in a stream</typeparam>
    public class LoadedStream<T> : ISymbolStream<T>
    {
        /// <summary>
        /// Information from input
        /// </summary>
        private T[] _loadedStream;

        /// <summary>
        /// Current position at stream
        /// </summary>
        private int _position = 0;

        public virtual T PeekSymbol() => _loadedStream[_position];

        public virtual T NextSymbol() => _loadedStream[++_position];

        public virtual bool EndOfStream() => _position == _loadedStream.Length;
    }
}
