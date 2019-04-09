using System;
using DIDemo.Engines;

namespace DIDemo.Managers
{
    public interface IMyManager
    {
        string Test(string input);
    }

    public class MyManager : IMyManager
    {
        private IMyEngine Engine { get; set; }

        public MyManager(IMyEngine engine)
        {
            Engine = engine;
        }

        public string Test(string input)
        {
            return " Manager : " + Engine.Test(input);
        }
    }
}
