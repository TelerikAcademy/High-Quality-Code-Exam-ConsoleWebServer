        using System;using System.Linq;

        public class ParserException : Exception
        {
            public ParserException(string message)
                : base(message)
            {
            }
        }