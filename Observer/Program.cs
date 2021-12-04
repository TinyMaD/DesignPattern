// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Observer;

ServiceCollection collection = new();
collection.AddScoped<ConcreteSubject>();
collection.AddScoped<IObservable<Message>, ConcreteSubject>(provider => provider.GetRequiredService<ConcreteSubject>());
collection.AddScoped<ConcreteObserverOne>();
collection.AddScoped<ConcreteObserverTwo>();

ServiceProvider provider = collection.BuildServiceProvider();
using IServiceScope scope = provider.CreateScope();
var observer1 = scope.ServiceProvider.GetService<ConcreteObserverOne>();
var observer2 = scope.ServiceProvider.GetService<ConcreteObserverTwo>();
var subject = scope.ServiceProvider.GetService<ConcreteSubject>();

subject?.NotifyObservers();

Console.ReadLine();