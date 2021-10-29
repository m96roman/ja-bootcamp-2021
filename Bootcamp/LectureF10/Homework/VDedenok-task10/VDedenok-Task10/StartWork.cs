using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VDedenok_Task10
{
    class StartWork
    {
        public async Task Start(List<Task> users, List<string> commits)
        {
            for (int i = 0; i < 8; i++)
            {
                Git gitUser = new Git();

                users.Add(Task.Run(() =>
                {
                    for (int i = 0; i < 88; i++)
                    {
                        gitUser.Push($"Commit # {i}.", commits);
                    }
                }
              ));
            }
        }
    }
}
