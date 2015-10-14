        using System;using System.Linq;

        public class ParserException : Exception
        {
            public ParserException(string message, ActionDescriptor request = null)
                : base(message)
            {
            }
        }