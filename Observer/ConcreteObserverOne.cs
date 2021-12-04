namespace Observer
{
    public class ConcreteObserverOne : IObserver<Message>
    {
        private readonly IDisposable _cancellation;

        public ConcreteObserverOne(IObservable<Message> subject)
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
            Console.WriteLine("ConcreteObserverOne is notified.");
        }

        public virtual void Unsubscribe()
        {
            _cancellation.Dispose();
        }
    }
}
