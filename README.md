# FactoryDesignPattern

What is Factory Design Pattern?

“A factory is an object which is used for creating other objects”. 

In technical terms, we can say that a factory is a class with a method. That method will create and return different types of objects based on the input parameter, it received.

In the Factory Design pattern, we create an object without exposing the creation logic to the client and the client will refer to the newly created object using a common interface.

In simple words, if we have a superclass and n number of subclasses, and based on the data provided, if we have to create and return the object of one of the subclasses, then we need to use the factory design pattern.

Explaination of Code example

We have three credit card classes i.e. MoneyBack, Titanium, and Platinum and these three classes are the subclasses of CreditCard superclass or super interface. The CreditCard superclass or super interface has three methods i.e. GetCardType, GetCreditLimit, and GetAnnualCharge. The subclasses i.e. MoneyBack, Titanium, and Platinum have implemented the above three methods.
Our requirement is, we will ask the user to select the credit card. Once the user selects the credit card then we need to display the required information of that selected card.
If we add a new Credit Card, then rather than modifying the Main method by adding an extra if-else condition which not only overheads in the development but also in the testing process we are creating separeate class CreditCardfactory.cs for if-else condition and implemented Fatcory Design Pattern.

Happy Coding :)




