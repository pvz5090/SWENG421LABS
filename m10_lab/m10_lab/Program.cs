// See https://aka.ms/new-console-template for more information
using m10_lab;
using m10_lab.Employees;

Console.WriteLine("Hello, World!");

/*
 * CEO: Steve
Managers:
Bob (manages Jack and Jeff)
Rachel (manages Chuck and Denise)
Project Leaders: Chuck, Denise
Supervisors: Jack, Jeff

Regular Workers:
Jack supervises: John, Mary, Jane
Jeff supervises: Rob, Ed, Rick
Chuck leads: Joe, Sam, Greg
Denise leads: Amy, Wil, Adam
 */

CEO Steve = new CEO(null,"Steve");
    //emplyees under Steve

    Manager Bob = new Manager( Steve, "Bob");
        //employees under Bob

        Supervisor Jack = new Supervisor(Bob, "Jack");
            //employee under Jack
            Worker John = new Worker(Jack, "John");
            Worker Mary = new Worker(Jack, "Mary");
            Worker Jane = new Worker(Jack, "Jane");

        Supervisor Jeff = new Supervisor(Bob, "Jeff");
            //employee under Jeff
            Worker Rob = new Worker( Jeff, "Rob");
            Worker Ed = new Worker( Jeff, "Ed");
            Worker Rick = new Worker( Jeff, "Rick");

    Manager Rachel = new Manager(Steve, "Rachel");
        //employees under Rachel

        ProjectLeader Chuck = new ProjectLeader( Rachel, "Chuck");
            //employees under Chuck
            Worker Joe = new Worker(Chuck, "Joe");
            Worker Sam = new Worker(Chuck, "Sam");
            Worker Greg = new Worker(Chuck, "Greg");

        ProjectLeader Denise = new ProjectLeader(Rachel, "Denise");
            //employees under Denise
            Worker Amy = new Worker( Denise, "Amy");
            Worker Wil = new Worker( Denise, "Wil");
            Worker Adam = new Worker( Denise, "Adam");

John.SeeDanger(); // John sees danger and reports to Jack, who reports to Bob, who reports to Steve



