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

Worker John = new Worker(null, null, "John");
Worker Mary = new Worker(null, null, "Mary");
Worker Jane = new Worker(null, null, "Jane");
List<Worker> JackSub =new List<Worker>() { John, Mary, Jane };
Supervisor Jack = new Supervisor(JackSub, null, "Jack");


Worker Rob = new Worker(null, null, "Rob");
Worker Ed = new Worker(null, null, "Ed");
Worker Rick = new Worker(null, null, "Rick");
List<Worker> JeffSub = new List<Worker>() { Rob, Ed, Rick };
Supervisor Jeff = new Supervisor(JeffSub, null, "Jeff");

Worker Joe = new Worker(null, null, "Joe");
Worker Sam = new Worker(null, null, "Sam");
Worker Greg = new Worker(null, null, "Greg");
List<Worker> ChuckSub = new List<Worker>() { Joe, Sam, Greg };
ProjectLeader Chuck = new ProjectLeader(ChuckSub, null, "Chuck");

Worker Amy = new Worker(null, null, "Amy");
Worker Wil = new Worker(null, null, "Wil");
Worker Adam = new Worker(null, null, "Adam");
List<Worker> DeniseSub = new List<Worker>() { Amy, Wil, Adam };
ProjectLeader Denise = new ProjectLeader(DeniseSub, null, "Denise");



CEO Steve = new CEO("Steve");
