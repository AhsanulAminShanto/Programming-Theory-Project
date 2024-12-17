using System;
using UnityEngine;

public class OOPDemo : MonoBehaviour
{
    // INHERITANCE
    // The base class (parent class)
    public class Animal
    {
        public virtual void Speak()
        {
            Debug.Log("Animal is speaking");
        }
    }

    // The derived class (child class) inheriting from Animal
    public class Dog : Animal
    {
        public override void Speak()
        {
            Debug.Log("Dog is barking"); // POLYMORPHISM (Overriding method)
        }
    }

    // ENCAPSULATION
    // A class that demonstrates encapsulation by using getter and setter
    public class BankAccount
    {
        private float balance; // Private variable to hold the balance

        // Getter method for balance
        public float GetBalance()
        {
            return balance;
        }

        // Setter method for balance
        public void SetBalance(float amount)
        {
            if (amount >= 0)
            {
                balance = amount;
            }
            else
            {
                Debug.Log("Invalid amount.");
            }
        }
    }

    // ABSTRACTION
    // A class that demonstrates abstraction by hiding the complexity
    public class CoffeeMaker
    {
        // A higher-level method to make coffee, hiding unnecessary details
        public void MakeCoffee()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
        }

        // Private methods that are hidden from the outside world
        private void BoilWater()
        {
            Debug.Log("Boiling water...");
        }

        private void BrewCoffeeGrinds()
        {
            Debug.Log("Brewing coffee grinds...");
        }

        private void PourInCup()
        {
            Debug.Log("Pouring coffee into the cup...");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Inheritance: Create an instance of Dog and call its Speak method
        Animal myDog = new Dog();
        myDog.Speak();  // Outputs: Dog is barking

        // Polymorphism: Demonstrated in the Dog class overriding the Speak method

        // Encapsulation: Create a BankAccount instance and set/get balance
        BankAccount myAccount = new BankAccount();
        myAccount.SetBalance(1000); // Set balance
        Debug.Log("Account balance: " + myAccount.GetBalance());  // Outputs: Account balance: 1000

        // Abstraction: Create an instance of CoffeeMaker and make coffee
        CoffeeMaker myCoffeeMaker = new CoffeeMaker();
        myCoffeeMaker.MakeCoffee();  // Outputs the steps to make coffee
    }
}
