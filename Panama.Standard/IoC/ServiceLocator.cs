﻿using System;

namespace Panama.Standard.IoC
{
    public static class ServiceLocator
    {
        private static IServiceLocator _serviceLocator;
        private static readonly object _syncLock = new Object();

        public static IServiceLocator Current
        {
            get
            {
                IServiceLocator tempLocator = null;
                lock (_syncLock)
                {
                    tempLocator = _serviceLocator;
                }
                return tempLocator;
            }
        }

        public static void SetLocator(IServiceLocator locator)
        {
            lock(_syncLock)
            {
                _serviceLocator = locator;
            }
        }

    }
}
