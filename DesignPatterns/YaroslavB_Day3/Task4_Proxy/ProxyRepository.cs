using System;
using System.Collections.Generic;

namespace Task4_Proxy
{
    class ProxyRepository : IUserRepository
    {
        private VodafoneUserRepository _realRepository;
        private List<string> _cachedUsers;
        private readonly int _cacheLiveTimeSec = 60;
        private DateTime _lastTimeRealRequest;

        public ProxyRepository(VodafoneUserRepository realRepository)
        {
            _realRepository = realRepository;
            _cachedUsers = RealRequest();
        }

        public List<string> GetUserList()
        {
            if(IsChachActual())
            {
                Console.WriteLine("DebugMessage: got users from cache.");
                return _cachedUsers;
            }

            _cachedUsers = RealRequest();

            return _cachedUsers;
        }

        private bool IsChachActual()
        {
            var currentTime = DateTime.Now;
            var interval = (currentTime - _lastTimeRealRequest).TotalSeconds;

            Console.WriteLine($"DebugMessage: time since last external request: {interval}");

            if (interval < _cacheLiveTimeSec)
            {
                return true;
            }

            return false;
        }

        private List<string> RealRequest()
        {        
            var users = _realRepository.GetUserList();
            _lastTimeRealRequest = DateTime.Now;
            Console.WriteLine("DebugMessage: done real reaquest to DB.");

            return users;
        }
    }
}
