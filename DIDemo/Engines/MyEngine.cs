using System;
using DIDemo.Accessors;

namespace DIDemo.Engines
{
    public interface IMyEngine
    {
        string Test(string input);
    }

    public class MyEngine : IMyEngine
    {
        IMyAccessor Accessor { get; set; }

        public MyEngine(IMyAccessor accessor)
        {
            Accessor = accessor;
        }

        public string Test(string input)
        {
            return " Engine : " + Accessor.Test(input);
        }
    }
}
