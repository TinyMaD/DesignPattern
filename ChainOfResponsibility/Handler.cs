namespace ChainOfResponsibility
{
    internal abstract class Handler
    {
        protected Handler? successor = null;

        public void SetSuccessor(Handler? successor)
        {
            this.successor = successor;
        }

        public void Handle()
        {
            bool handled = DoHandle();
            if (successor != null && !handled)
            {
                successor?.Handle();
            }
        }

        protected abstract bool DoHandle();
    }
}
