namespace SinglePattern
{
    public class SinglePattern
    {
        private static readonly object locker = new object();
        private SinglePattern()
        {

        }

        private static SinglePattern _singlePattern;
        public static SinglePattern singlePattern
        {
            get
            {
                if (_singlePattern == null)
                {
                    lock (locker)
                    {
                        if (_singlePattern == null)
                        {
                            _singlePattern = new SinglePattern();
                        }
                    }
                }
                return _singlePattern;
            }

        }

        public void Console(string msg)
        {
            System.Console.WriteLine(msg);
        }
    }
}
