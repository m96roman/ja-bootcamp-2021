using System.Collections.Generic;

namespace Proxy
{
    class UserRepoProxy : IUserRepository
    {
        private IUserRepository userRepository;

        CacheList<string> cacheList = new CacheList<string>();

        public UserRepoProxy(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public List<string> UsersList()
        {
            if (!cacheList.IsCached)
            {
                cacheList.SetCacheList(userRepository.UsersList());
            }

            return cacheList.GetList();
        }
    }
}
