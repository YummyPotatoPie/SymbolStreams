namespace SymbolStreams
{
    /// <summary>
    /// Exception throws when trying to access symbol if end of stream reached
    /// </summary>
    public class OutOfStreamException : System.Exception
    {
        /// <summary>
        /// Base constructor
        /// </summary>
        public OutOfStreamException() : base() { }

        /// <summary>
        /// Constructor sets error message
        /// </summary>
        /// <param name="message">Error message</param>
        public OutOfStreamException(string message) : base(message) { }
    }
}
