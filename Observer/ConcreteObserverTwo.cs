namespace Observer
{
    public class ConcreteObserverTwo : IObserver<Message>
    {
        private readonly IDisposable _cancellation;

        public ConcreteObserverTwo(IObservable<Message> subject)
        {
            _cancellation = subject.Subscribe(this);
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Message value)
        {
            Console.WriteLine("ConcreteObserverTwo is notified.");
        }

        public virtual void Unsubscribe()
        {
            _cancellation.Dispose();
        }
    }
}
