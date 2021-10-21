using DIvanyshyn_8.AssembliesExample;
using System;

namespace DIvanyhyn_UnitTests_Day2
{
    internal class ControllerBuilder
    {
        internal static Controller GetController(Type type, ILogger logger = null)
        {
            if (logger == null)
            {
                logger = new FakeLogger();
            }

            return (Controller)Activator.CreateInstance(type, logger);
        }
    }
}