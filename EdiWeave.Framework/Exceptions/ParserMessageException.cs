﻿using EdiWeave.Core.Model.Edi.ErrorContexts;
using System;

namespace EdiWeave.Framework.Exceptions
{
    class ParserMessageException : Exception
    {
        public MessageErrorContext MessageErrorContext { get; private set; }

        public ParserMessageException(MessageErrorContext messageErrorContext)
            : base(messageErrorContext.Message)
        {
            MessageErrorContext = messageErrorContext;
        }
    }
}
