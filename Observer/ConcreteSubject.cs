namespace Observer
{
    public class ConcreteSubject : IObservable<Message>
    {
        private readonly List<IObserver<Message>> _observers = new();

        public IDisposable Subscribe(IObserver<Message> observer)
        {
            _observers.Add(observer);
            return new Unsubscriber<Message>(_observers, observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(new Message());
            }
        }
    }
}
