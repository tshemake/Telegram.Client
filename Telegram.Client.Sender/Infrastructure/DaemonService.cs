﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace Telegram.Client.Sender.Infrastructure
{
    using Microsoft.Extensions.Configuration;

    internal class DaemonService : IHostedService, IDisposable
    {
        bool disposed = false;
        private readonly IConfiguration _config;

        public DaemonService(IConfiguration config)
        {
            _config = config;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Debug.WriteLine("Starting daemon: " + _config[EnvironmentVariables.DaemonName]);
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Debug.WriteLine("Stopping daemon.");
            return Task.CompletedTask;
        }

        #region Implementing the dispose pattern for a base class

        public void Dispose()
        {
            Debug.WriteLine("Disposing....");
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        ~DaemonService()
        {
            Dispose(false);
        }

        #endregion
    }
}
