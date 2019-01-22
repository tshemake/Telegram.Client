using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Telegram.Library.Requests
{
    public abstract class FileRequestBase : RequestWithParameters
    {
        protected FileRequestBase(string methodName)
            : base(methodName)
        { }

        protected FileRequestBase(string methodName, HttpMethod method)
            : base(methodName, method)
        { }
    }
}
