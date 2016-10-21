using System;

namespace SaudaMaster.Infrastructure.Common
{
    public class Disposable : IDisposable
    {
        private bool isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if(!disposing && disposing)
            {
                DisposeCore();
            }
        }

        protected virtual void DisposeCore()
        {
            throw new NotImplementedException();
        }
    }
}
