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

CEO Steve = new CEO("Steve");

Manager Bob = new Manager( Steve, "Bob");
Manager Rachel = new Manager(Steve, "Rachel");

Supervisor Jack = new Supervisor(JackSub, null, "Jack");
Supervisor Jeff = new Supervisor(JeffSub, null, "Jeff");
ProjectLeader Chuck = new ProjectLeader(ChuckSub, null, "Chuck");
ProjectLeader Denise = new ProjectLeader(DeniseSub, null, "Denise");



Worker John = new Worker( null, "John");
Worker Mary = new Worker( null, "Mary");
Worker Jane = new Worker(null, "Jane");


Worker Rob = new Worker(null, null, "Rob");
Worker Ed = new Worker(null, null, "Ed");
Worker Rick = new Worker(null, null, "Rick");

List<Worker> BobSub = new List<Worker>() { Jack, Jeff };



Worker Joe = new Worker(null, null, "Joe");
Worker Sam = new Worker(null, null, "Sam");
Worker Greg = new Worker(null, null, "Greg");

Worker Amy = new Worker(null, null, "Amy");
Worker Wil = new Worker(null, null, "Wil");
Worker Adam = new Worker(null, null, "Adam");



