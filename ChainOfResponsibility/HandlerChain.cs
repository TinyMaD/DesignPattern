namespace ChainOfResponsibility
{
    internal class HandlerChain
    {
        private readonly List<IHandler> handlers = new();

        public void AddHandler(IHandler handler)
        {
            this.handlers.Add(handler);
        }

        public void Handle()
        {
            foreach (IHandler? handler in handlers)
            {
                bool handled = handler.Handle();

                if (handled) break;
            }
        }
    }
}
