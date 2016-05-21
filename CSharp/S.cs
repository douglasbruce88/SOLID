using System;
namespace CSharp
{
    public class DoesTwoThings
    {
        public int NumberOfCommas (string message)
        {
            int count = 0;
            foreach (char c in message)
            {
                if (c == '/') count++;
            }
            return count;
        }

        public void Log (string message)
        {
            Console.WriteLine ($"The string you gave me has { NumberOfCommas(message) } commas");
        }
    }

    public class DoesOneThing
    {
        readonly ILogger Logger;

        public DoesOneThing (ILogger logger)
        {
            this.Logger = logger;
        }

        public int NumberOfCommas (string message)
        {
            int count = 0;
            foreach (char c in message) {
                if (c == '/') count++;
            }
            return count;
        }

        public void Log (string message)
        {
            this.Logger.Log($"The string you gave me has { NumberOfCommas (message) } commas");
        }
    }

    public interface ILogger
    {
        void Log (string message);
    }

}

