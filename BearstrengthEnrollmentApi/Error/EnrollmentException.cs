﻿using System;
using System.Collections.Generic;

namespace BearstrengthEnrollmentApi.Error
{
    public class EnrollmentException : Exception
    {
        private static List<string> _messages;
        public List<string> Messages { get { return _messages; } }
        public EnrollmentException(List<string> messages)
            : base(string.Join(";", messages))
        {
            _messages = messages;
        }
        public EnrollmentException(List<string> messages, Exception exception)
            : base(string.Join(";", messages, exception)) { }
    }

    public class ConflictException : EnrollmentException
    {
        public ConflictException(List<string> messages)
            : base(messages) { }
        public ConflictException(List<string> messages, Exception exeption)
            : base(messages, exeption) { }
    }

}