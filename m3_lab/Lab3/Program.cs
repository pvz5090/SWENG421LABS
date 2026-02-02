using Lab3;

Owner craig = new Owner("Craig", 3, "Owner");
Manager john = new Manager("John", 83, "Manager", 50_000);
Manager mary = new Manager("Mary", 5, "Manager", 50_000);
Accountant jane = new Accountant("Jane", 6, "Accountant", 45_000);
Accountant joe = new Accountant("Joe", 7, "Accountant", 45_000);
Blacksmith jack = new Blacksmith("Jack", 8, "Blacksmith", 35_000);
Blacksmith katie = new Blacksmith("Katie", 9, "Blacksmith", 35_000);
Blacksmith amy = new Blacksmith("Amy", 10, "Blacksmith", 35_000);
Blacksmith lin = new Blacksmith("Lin", 11, "Blacksmith", 35_000);
Blacksmith greg = new Blacksmith("Greg", 12, "Blacksmith", 35_000);

List<Person> companyPeople = new List<Person>();
companyPeople.Add(craig);
companyPeople.Add(john);
companyPeople.Add(mary);
companyPeople.Add(jane);
companyPeople.Add(joe);
companyPeople.Add(jack);
companyPeople.Add(katie);
companyPeople.Add(amy);
companyPeople.Add(lin);
companyPeople.Add(greg);

Company myCompany = new Company(companyPeople);

List<Employee> sendEmployees = new List<Employee>();
sendEmployees.Add(john);
sendEmployees.Add(jane);
sendEmployees.Add(jack);
craig.PublicSend(sendEmployees, "Good Job");

Lab3.Task t1 = new Lab3.Task(1, "1/1/2027", "Task 1");
Lab3.Task t2 = new Lab3.Task(2, "1/2/2027", "Task 2");
Lab3.Task t3 = new Lab3.Task(3, "1/3/3037", "Task 3");

greg.PublicPerform(t1);

amy.AssignDelegate(greg);
amy.PublicPerform(t2);

jane.PublicUpdate(greg, greg.GetSalary() + 1_000);

lin.AssignDelegate(jane);
lin.PublicPerform(t3);

john.PublicEvaluate(jack, 2);
mary.PublicEvaluate(katie, 3);

john.AssignDelegate(craig);
john.PublicEvaluate(jack, 4);
