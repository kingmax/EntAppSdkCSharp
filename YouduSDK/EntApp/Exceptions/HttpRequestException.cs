﻿

namespace YouduSDK.EntApp.Exceptions
{
    public class HttpRequestException : System.Exception
    {
        public HttpRequestException(int statusCode, string message, System.Exception innerException)
            : base(message, innerException)
        {
            m_statusCode = statusCode;
        }

        private int m_statusCode;

        public int StatusCode
        {
            get
            {
                return m_statusCode;
            }
        }
    }
}
