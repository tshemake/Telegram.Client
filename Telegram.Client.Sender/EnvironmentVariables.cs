using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Client.Sender
{
    public static class EnvironmentVariables
    {
        public const string DaemonName = "DaemonName";

        public static string GetEnvironmentVariable(string variable, string defaultValue = null)
        {
            var value = Environment.GetEnvironmentVariable(variable);
            return value ?? defaultValue;
        }
    }
}
