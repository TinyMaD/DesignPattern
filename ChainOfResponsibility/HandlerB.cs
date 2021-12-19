namespace ChainOfResponsibility
{
    internal class HandlerB : IHandler
    {
        public bool Handle()
        {
            bool handled = false;

            Console.WriteLine("HandlerB do it");

            return handled;
        }
    }
}