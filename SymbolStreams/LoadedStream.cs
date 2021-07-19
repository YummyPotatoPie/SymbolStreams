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
        protected readonly T[] LoadedStreamData;

        /// <summary>
        /// Current position at stream
        /// </summary>
        protected int Position = 0;

        /// <summary>
        /// Sets the loaded information as a stream
        /// </summary>
        /// <param name="loadedStream">Loaded stream input</param>
        public LoadedStream(T[] loadedStream) => LoadedStreamData = loadedStream;

        public virtual T Peek() => EndOfStream() ? default : LoadedStreamData[Position];

        public virtual T Next() => Position == LoadedStreamData.Length - 1 ? default : LoadedStreamData[++Position];

        public virtual bool EndOfStream() => Position == LoadedStreamData.Length;

        public virtual void Reset() => Position = 0;
    }
}
