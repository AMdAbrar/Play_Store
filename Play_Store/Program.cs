
//how to create object for class?
//User user = new User();//object created
//user.CreateUser(); //function calling
//Categories categories = new Categories(1,"abrar", "test" );
//Console.WriteLine(categories.Name);
//Console.WriteLine(categories.Description);  
//Console.WriteLine(categories.Id);

//categories.AddCategories(1, "pencil");
//categories.AddCategories(2, "shapner", "using to sharp");

//Iuser userobject = new User();
//userobject.AddUser();


//Generics
//Report report = new Report();
//report.GenerateReport();

//Report report = new Report();
//report.GetReport<int>(123);
//report.GetReport<string>("y");

using Play_Store;

int x = 10;
object o = x; //boxing
String s = o.ToString();//unboxing

//Abstract
//AbstractTask ATS = new SavingsAccount();
//ATS.Mandetri();
//ATS.deposit();
//AbstractTask ATC=new CurrentAccount();
//ATC.Mandetri();
//ATC.deposit();


//Interface
Savingsaccount IA = new Savingsaccount();
IA.Calculate_interest();
IA.View_Balance();
IA.Withdraw();
IA.Deposit();
IA.A_No();

Currentaccount CA= new Currentaccount();
CA.Calculate_interest();
CA.View_Balance();
CA.Withdraw();
CA.Deposit();
CA.A_No2();

