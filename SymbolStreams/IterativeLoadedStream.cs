using System.Collections;
using System.Collections.Generic;
using System;

namespace SymbolStreams
{
    /// <summary>
    /// Iterative version of LoadedStream
    /// </summary>
    /// <typeparam name="T">A type that represents characters in a stream</typeparam>
    public class IterativeLoadedStream<T> : LoadedStream<T>, IEnumerator<T>, IEnumerable
    {
        /// <summary>
        /// Current symbol at the stream
        /// </summary>
        private T _currentSymbol;

        object IEnumerator.Current 
        {
            get => Current;
        }

        public T Current
        {
            get => _currentSymbol;
        }

        /// <summary>
        /// Sets the loaded information as a stream
        /// </summary>
        /// <param name="loadedStream">Loaded stream input</param>
        public IterativeLoadedStream(T[] loadedStreamData) : base(loadedStreamData) => Position = -1;

        public override bool EndOfStream() => Position == LoadedStreamData.Length;

        public IEnumerator GetEnumerator() => this;

        public bool MoveNext()
        {
            ++Position;
            if (EndOfStream()) return false;
            _currentSymbol = LoadedStreamData[Position];
            return true;
        }

        public override void Reset() => Position = -1;
        
        public void Dispose() => GC.SuppressFinalize(this);
    }
}
