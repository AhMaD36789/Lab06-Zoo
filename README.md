# Virtual Zoo

## intro

this is a virtual zoo console application that demonstartes inheritance in C# by showcasing the animal pyramid

## UML

![temp](../images/1.png)

## Technical Documentation

1. **Encapsulation** was used in the tiger and Lion classes to hide its properties like eats every which were flagged as protected meaning they can be called only using the current class or other derived classes
1. **Inheritance** Animal is my base class. Mammals and reptiles inherit from animal. lion and tiger inherit from Mammals. Inheritance means that the new class takes a copy from the properties and methods included in the old class and are pseudo implemented into the new class
1. **Polymorphism** Mammals has two virtual methods Nurse() and Groom() which can be overridden in derived classes. polymorphism means that one function can take multiple shapes depending on how it was called.tiger.groom(); returns different result to Mammals.Groom();
1. **Abstraction** is where i have a common property or method in base class that i want shared across derived classes and enforce it having values in derived class (abstract method is only completed in derived class not base class)


