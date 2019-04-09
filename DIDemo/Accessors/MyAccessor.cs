using System;
namespace DIDemo.Accessors
{
    public interface IMyAccessor
    {
        string Test(string input);
    }

    public class MyAccessor : IMyAccessor
    {
        public MyAccessor()
        {
        }

        public string Test(string input)
        {
            return " Accessor : " + input;
        }
    }
}
