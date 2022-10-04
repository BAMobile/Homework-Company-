
using System;
using System.Collections.Generic;


    
        Console.WriteLine("Сворення команди");
        Team t1 = new Team();
        Developer d1 = new Developer();
        Manager m1 = new Manager();     
        Console.WriteLine("Вкажіть чим повинен займатись зозробник");
        d1.WorkDay = Console.ReadLine();
        t1.Add(d1);
        Console.WriteLine("Вкажіть чим повинен займатись менеджер");
        m1.WorkDay = Console.ReadLine();
        t1.Add(m1);
        t1.DisplayTeamInfo();
        t1.DisplayDetaleTeamInfo();




abstract class Worker //створили клас Worker
    {
        public string Name;   //параметри: Name, Position, WorkDay
        public string Position;
        public string WorkDay;

        public Worker() //конструктор, який приймає на вхід ім'я
        {
            Console.WriteLine("Введіть ім'я");
            this.Name = Console.ReadLine();
        }
        protected void Call()  //методи
        { 
        }
        protected void WriteCode()
        {
        }
        protected void Relax()
        {
        }
        public abstract void FillWorkDay();//абстрактний метод

}

class Developer : Worker  // створили Dev що є нащадком Work
{
    public Developer() // конструктор в якому визначається параметр Position як "Розробник"
    {
        this.Position = "Розробник";
    }
    public override void FillWorkDay() // перевизначення метода FillWorkDay()
    {
        WriteCode();
        Call();
        Relax();
        WriteCode();
    }

}

class Manager : Worker   // створили Man що є нащадком Work
{
    public Manager() //  конструктор, в якому визначається параметр Position як "Менеджер"
    {
        this.Position = "Менеджер";
    }

    Random rnd = new Random(); // приватна змінна типу Random
    public override void FillWorkDay() //перевизначення метода FillWorkDay()
    {
        int t = rnd.Next(1,10);
        for (int i = 0; i < t; i++)
        {
            Call();
        }

        Relax();

        int k = rnd.Next(1, 5);
        for (int i = 0; i < k; i++) 
        {
            Call();
        }

    }

}
class Team  //сворили клас Team
{
    public string TeamName;
    public Team() // конструктор, який приймає на вхід ім'я
    {
        Console.WriteLine("Введіть назву команди");
        this.TeamName = Console.ReadLine();
    }
    List<Worker> listOfWorkers = new List<Worker>(); //приватна змінна з переліком співробітників
    public void Add(Worker WorkerInList) // метод додавання нового співробітника у команду
    {
        listOfWorkers.Add(WorkerInList);
    }

    public void DisplayTeamInfo() // метод виведення інформації про команду
    {
        Console.WriteLine(this.TeamName);
        for (int i = 0; i < listOfWorkers.Count; i++)
        {
            Console.WriteLine(listOfWorkers[i].Name + '\n') ;
        }
    }
    public void DisplayDetaleTeamInfo() // метод виведення детальної інформації про команду
    {
        Console.WriteLine(this.TeamName);
        for(int i = 0; i < listOfWorkers.Count; i++)
        {
            Console.WriteLine(listOfWorkers[i].Name+ "-" + listOfWorkers[i].Position + "-" + listOfWorkers[i].WorkDay + '\n');
        }
    }
}
        

   
