using System;

namespace YaroslavB_Task10
{
    class Logger
    {
        public void LogToConsole(object sender, Commmit message)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
            Console.Write(message,);
        }
    }
}
