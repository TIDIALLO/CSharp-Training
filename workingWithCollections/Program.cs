Base x = new Base();
Base y = new Derived();
x.DoSomthing();
y.DoSomthing();
//y.DoMore();   Error
Derived z = new Derived();
Console.WriteLine("-----------------------");
z.DoMore();
Console.WriteLine("-----------------------");


// ============  convariant  ====================
IProducer<Base> prodOfBase = null!;
IProducer<Derived> prodOfDerived = null!;

Base a = prodOfBase.Produce();
Derived b = prodOfDerived.Produce(); //
Base c = prodOfDerived.Produce();// covariance

// ============  contravariant  ====================

IConsumer<Base> consOfBase = null!;
consOfBase.Consumer(new Base());
consOfBase.Consumer(new Derived());

IConsumer<Derived> consOfDerived = null!;
consOfDerived.Consumer(new Derived());
//consOfDerived.Consumer(new Base()); Error: conversion impossible Base en Derived

interface IProducer<out T>
{
    T Produce();
}

interface IConsumer<in T>
{
    void Consumer(T obj);
}

class Base
{
    public void DoSomthing() => Console.WriteLine($"Doing from {this.GetType().Name}");
}

class Derived: Base
{
    public void DoMore() => Console.WriteLine($"Doing from {this.GetType().Name}");

}