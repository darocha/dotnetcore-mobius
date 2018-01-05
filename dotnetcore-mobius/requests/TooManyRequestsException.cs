﻿using System;

namespace dotnetcore_mobius.requests
{
    public class TooManyRequestsException : Exception
    {
        public TooManyRequestsException(int retryAfter)
            : base("The rate limit for the requesting IP address is over its alloted limit.")
        {
            RetryAfter = retryAfter;
        }

        public int RetryAfter { get; set; }
    }
}