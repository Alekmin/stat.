﻿
using System;
using System.ComponentModel.Design;
using stat_;

Console.WriteLine("Zadanie domowe dzień 7");
Console.WriteLine("");

Employee employee1 = new Employee("Natalia","Nowak","1234","26");
Employee employee2 = new Employee("Aleksander","Kowalski","4321", "42");
Employee employee3 = new Employee("Krzysztof", "Walaszek", "3241","30");

employee1.Addscore(3);
employee1.Addscore(4);
employee1.Addscore(6);
employee1.Addscore(8);
employee1.Addscore(9);

employee2.Addscore(7);
employee2.Addscore(6);
employee2.Addscore(3);
employee2.Addscore(2);
employee2.Addscore(1);

employee3.Addscore(3);
employee3.Addscore(4);
employee3.Addscore(7);
employee3.Addscore(8);
employee3.Addscore(4);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResoult = -1;
Employee employeeWithmaxResoult = null;

foreach(var employee in employees)
{
    if (employee1.Resoult > maxResoult)
    {
        employeeWithmaxResoult = employee1;
        maxResoult = employee1.Resoult;
    }
    else if (employee2.Resoult > maxResoult)
    {
        employeeWithmaxResoult = employee2;
        maxResoult = employee2.Resoult;
    }
    else if (employee3.Resoult > maxResoult)
    {
        employeeWithmaxResoult = employee3;
        maxResoult = employee3.Resoult;
    }
}

Console.WriteLine("Pracownik x max ilośćią punktów: " + employeeWithmaxResoult.Name + " " + employeeWithmaxResoult.Surname);
Console.WriteLine("Wiek:" + employeeWithmaxResoult.Age + " " + "lat");
Console.WriteLine("Wynik:" + employeeWithmaxResoult.Resoult);