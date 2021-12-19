namespace ChainOfResponsibility
{
    internal class HandlerA : IHandler
    {
        public bool Handle()
        {
            bool handled = false;

            Console.WriteLine("HandlerA do it");

            return handled;
        }
    }
}
