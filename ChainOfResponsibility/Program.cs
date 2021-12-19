// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;

HandlerChain chain = new();
chain.AddHandler(new HandlerA());
chain.AddHandler(new HandlerB());
chain.Handle();
Console.ReadLine();
