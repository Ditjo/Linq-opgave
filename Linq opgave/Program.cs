using Linq_opgave;
using System.Collections.Generic;

List<int> list = new List<int> { 2, 4, 6, 8, 10 };

int tal = list.FirstOrDefault(x => x == 2);
Console.WriteLine(tal);

List<Person> list2 = new List<Person>
            {
                new Person{ Id = 1, Age = 15, Name = "Karin"},
                new Person{ Id = 2, Age = 25, Name = "Sofie"},
                new Person{ Id = 3, Age = 35, Name = "Bodil"},
            };

List<Owner> owner = new List<Owner>()
{
    new Owner{ Id = 1, Name="Egon"},
    new Owner{ Id = 2, Name="Hans"},
};

List<Car> cars = new List<Car>()
{
    new Car{Id=3, Brand="Fiat"},
    new Car{Id=4, Brand="Volvo"},
};
owner[0].Cars = cars;

List<Owner> owners = owner.Where(x => x.Name == "Egon").ToList();


AlderUnder20();
AlderOver20();
AlleSomHedderSofie();
FindSofieOgBodil();
SorterAlfabetisk();

FindFiat();
FindVolvo();
FindEjerUdenBil();
FindAlleMedBil();
FindEjerMedVolvoEllerBMW();

//Opg6

//Se Metoder

void AlderUnder20()
{
    //Opg1 - find navn og alder under 20

    List<Person> p4 = list2.Where(p => p.Age < 20).ToList();
    Console.WriteLine();
    Console.WriteLine("Opgave 1");
    foreach (var item in p4)
    {
        Console.WriteLine($"ID: {item.Id} - Name: {item.Name} - Age: {item.Age}");
    }
}

void AlderOver20()
{
    //Opg2
    Console.WriteLine();
    Console.WriteLine("Opgave 2");
    foreach (var item in list2.Where(p => p.Age > 20))
    {
        Console.WriteLine($"ID: {item.Id} - Name: {item.Name} - Age: {item.Age}");
    }
}

void AlleSomHedderSofie()
{
    //Opg3

    Console.WriteLine();
    Console.WriteLine("Opgave 3");

    foreach (var item in list2.Where(p => p.Name is not "Sofie"))
    {
        Console.WriteLine($"ID: {item.Id} - Name: {item.Name} - Age: {item.Age}");
    }
}

void FindSofieOgBodil()
{
    //Opg4

    Console.WriteLine();
    Console.WriteLine("Opgave 4");

    foreach (var item in list2.Where(p => p.Name is "Sofie" || p.Name is "Bodil"))
    {
        Console.WriteLine($"ID: {item.Id} - Name: {item.Name} - Age: {item.Age}");
    }
}

void SorterAlfabetisk()
{
    //Opg5

    Console.WriteLine();
    Console.WriteLine("Opgave 5");

    foreach (var item in list2.OrderBy(x => x.Name))
    {
        Console.WriteLine($"ID: {item.Id} - Name: {item.Name} - Age: {item.Age}");
    }
}

void FindFiat()
{
    Console.WriteLine();
    Console.WriteLine("Opgave 11");
    foreach (var item in cars.Where(x => x.Brand == "Fiat"))
    {
        Console.WriteLine($"ID: {item.Id} - Name: {item.Brand}");
    }
}
void FindVolvo()
{
    Console.WriteLine();
    Console.WriteLine("Opgave 12");
    foreach (var item in cars.Where(x => x.Brand == "Volvo"))
    {
        Console.WriteLine($"ID: {item.Id} - Name: {item.Brand}");
    }
}
void FindEjerUdenBil()
{
    Console.WriteLine();
    Console.WriteLine("Opgave 13");
    foreach (var item in owner.Where(x => x.Cars is null || x.Cars.Count() is 0))
    {
        Console.WriteLine($"ID: {item.Id} - Name: {item.Name}");
    }
}
void FindAlleMedBil()
{
    Console.WriteLine();
    Console.WriteLine("Opgave 14");
    foreach (var item in owner.Where(x => x.Cars is not null && x.Cars.Count() is not 0))
    {
        Console.WriteLine($"ID: {item.Id} - Name: {item.Name}");
    }
}
void FindEjerMedVolvoEllerBMW()
{
    Console.WriteLine();
    Console.WriteLine("Opgave 15");
    foreach (var item in owner.Where(x => x.Cars is not null && x.Cars.Count() is not 0))
    {
        if (item.Cars.Any(x => x.Brand is "Volvo" || x.Brand is "BMW"))
        {
            Console.WriteLine($"ID: {item.Id} - Name: {item.Name}");
        }
        
    }
}
