
using Play_Store;
Console.WriteLine("My Play Store");

//how to create object for class?

//User user = new User();//object created
//user.CreateUser(); //function calling
Categories categories = new Categories(1,"abrar", "test" );
Console.WriteLine(categories.Name);
Console.WriteLine(categories.Description);  
Console.WriteLine(categories.Id);

categories.AddCategories(1, "pencil");
categories.AddCategories(2, "shapner", "using to sharp");