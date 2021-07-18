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
        private readonly T[] _loadedStream;

        /// <summary>
        /// Current position at stream
        /// </summary>
        private int _position = 0;

        /// <summary>
        /// sets the loaded information as a stream
        /// </summary>
        /// <param name="loadedStream">Loaded stream input</param>
        public LoadedStream(T[] loadedStream) => _loadedStream = loadedStream;

        public virtual T PeekSymbol() => _loadedStream[_position];

        public virtual bool NextSymbol(out T symbol)
        {
            if (EndOfStream())
            {
                symbol = default;
                return false;
            }
            symbol = _loadedStream[++_position];
            return true;
        }

        public virtual bool EndOfStream() => _position == _loadedStream.Length - 1;
    }
}
