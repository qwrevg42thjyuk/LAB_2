using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Class2
    {
    }
}
using System;

// Завдання 1: Клас Address
class Address
{
    public string Index { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Apartment { get; set; }

    public Address(string index, string country, string city, string street, string house, string apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        House = house;
        Apartment = apartment;
    }
}

// Завдання 2: Клас Converter
class Converter
{
    private double USD;
    private double EUR;
    private double PLN;

    public Converter(double usd, double eur, double pln)
    {
        USD = usd;
        EUR = eur;
        PLN = pln;
    }

    public double ConvertToUAH(double amount, string currency)
    {
        if (currency == "USD")
            return amount * USD;
        else if (currency == "EUR")
            return amount * EUR;
        else if (currency == "PLN")
            return amount * PLN;
        else
            return amount;
    }

    public double ConvertFromUAH(double amount, string currency)
    {
        if (currency == "USD")
            return amount / USD;
        else if (currency == "EUR")
            return amount / EUR;
        else if (currency == "PLN")
            return amount / PLN;
        else
            return amount;
    }
}

// Завдання 3: Клас Employee
class Employee
{
    public string LastName { get; set; }
    public string FirstName { get; set; }

    public Employee(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }

    public double CalculateSalary(string position, int experience)
    {
        // Приклад розрахунку окладу і податкового збору для співробітника
        double baseSalary = 0;
        switch (position)
        {
            case "Менеджер":
                baseSalary = 3000;
                break;
            case "Розробник":
                baseSalary = 4000;
                break;
                // Додайте інші посади та їх зарплати
        }

        double tax = baseSalary * 0.15; // Податок у розмірі 15% від окладу

        if (experience >= 5)
        {
            baseSalary += 500; // Додаткові 500 гривень для стажу від 5 років
        }

        return baseSalary - tax;
    }
}

// Завдання 4: Клас User
class User
{
    public string Login { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime RegistrationDate { get; }

    public User(string login, string firstName, string lastName, int age)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        RegistrationDate = DateTime.Now;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine($"Логін: {Login}");
        Console.WriteLine($"Ім'я: {FirstName}");
        Console.WriteLine($"Прізвище: {LastName}");
        Console.WriteLine($"Вік: {Age}");
        Console.WriteLine($"Дата заповнення анкети: {RegistrationDate}");
    }
}

class Programm
{
    static void Main()
    {
        // Завдання 1: Створення адреси
        Address address = new Address("12345", "Україна", "Київ", "Вулиця", "12", "34");
        Console.WriteLine("Адреса:");
        Console.WriteLine($"Індекс: {address.Index}");
        Console.WriteLine($"Країна: {address.Country}");
        Console.WriteLine($"Місто: {address.City}");
        Console.WriteLine($"Вулиця: {address.Street}");
        Console.WriteLine($"Будинок: {address.House}");
        Console.WriteLine($"Квартира: {address.Apartment}");

        // Завдання 2: Конвертація валют
        Converter converter = new Converter(27.5, 31.2, 7.8);
        double amountInUAH = 1000;
        double amountInUSD = converter.ConvertFromUAH(amountInUAH, "USD");
        Console.WriteLine($"1000 UAH = {amountInUSD} USD");
        double amountInEUR = converter.ConvertFromUAH(amountInUAH, "EUR");
        Console.WriteLine($"1000 UAH = {amountInEUR} EUR");
        double amountInPLN = converter.ConvertFromUAH(amountInUAH, "PLN");
        Console.WriteLine($"1000 UAH = {amountInPLN} PLN");

        // Завдання 3: Інформація про співробітника
        Employee employee = new Employee("Петров", "Іван");
        double salary = employee.CalculateSalary("Розробник", 7);
        Console.WriteLine("Інформація про співробітника:");
        Console.WriteLine($"Прізвище: {employee.LastName}");
        Console.WriteLine($"Ім'я: {employee.FirstName}");
        Console.WriteLine($"Посада: Розробник");
        Console.WriteLine($"Оклад: {salary} грн");

        // Завдання 4: Інформація про користувача
        User user = new User("user123", "Іван", "Петров", 30);
        user.DisplayUserInfo();
    }
}
