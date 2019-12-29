using Microsoft.Win32.SafeHandles;
using StopBeingJerk.DataAccess;
using System;
using System.Runtime.InteropServices;

namespace StopBeingJerk.ApplicationLogic
{
    public class ApplicationService : IDisposable
    {
        private bool _disposed = false;
        private readonly SafeHandle _handle = new SafeFileHandle(IntPtr.Zero, true);
        protected readonly Context _context;

        public ApplicationService()
        {
            _context = new Context();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _context.Dispose();
                _handle.Dispose();
            }

            _disposed = true;
        }
    }
}
