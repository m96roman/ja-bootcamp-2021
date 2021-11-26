using System;
using System.Collections.Generic;

namespace Proxy
{
    class CacheList<T>
    {
        private readonly double timeSpan;

        List<T> cachedList = new List<T>();
        DateTime cacheTime = DateTime.MinValue;

        public CacheList(double timeSpan = 1)
        {
            this.timeSpan = timeSpan;
        }

        public bool IsCached
        {
            get
            {
                return cacheTime.AddMinutes(timeSpan) > DateTime.Now;
            }
        }

        internal List<T> GetList()
        {
            return cachedList;
        }

        internal void SetCacheList(List<T> list)
        {
            cachedList = list;
            cacheTime = DateTime.Now;
        }
    }
}
