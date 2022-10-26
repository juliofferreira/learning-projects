using System;
namespace bytebank_ATENDIMENTO.bytebank.Exceptions
{

    [Serializable]
    public class ByteBankException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteBankException"/> class
        /// </summary>
        public ByteBankException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteBankException"/> class
        /// </summary>
        /// <param name="message">A <see cref="T:System.String"/> that describes the exception. </param>
        public ByteBankException(string message) : base($"Aconteceu uma exceção -> {message}")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteBankException"/> class
        /// </summary>
        /// <param name="message">A <see cref="T:System.String"/> that describes the exception. </param>
        /// <param name="inner">The exception that is the cause of the current exception. </param>
        public ByteBankException(string message, System.Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteBankException"/> class
        /// </summary>
        /// <param name="context">The contextual information about the source or destination.</param>
        /// <param name="info">The object that holds the serialized object data.</param>
        protected ByteBankException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
    }
}

