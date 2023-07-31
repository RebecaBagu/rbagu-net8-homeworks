// See https://aka.ms/new-console-template for more information
Exercise1.Ex1();
Console.WriteLine();

Exercise2.Ex2();
Console.WriteLine();

Exercise3.Ex3();
Console.WriteLine();

Exercise4.Ex4();
Console.WriteLine();

DateTime today = DateTime.Now;
Console.WriteLine(  Exercise5.ToFullDateString(today));
Console.WriteLine();

Console.WriteLine(Exercise6.ToBinary(25) );
Console.WriteLine();

Exercise7.Ex7();
Console.WriteLine();

Exercise8.Ex8();
Console.WriteLine();


//-------Ex9

var students = new List<Student> {
  new Student { Name = "Alice", Grade = "A" },
  new Student { Name = "Bob", Grade = "B" },
  new Student { Name = "Charlie", Grade = "A" },
  new Student { Name = "Dave", Grade = "C" }
};

Exercise9.Ex9(students);


Console.WriteLine();


//---------------Ex10

var products = new List<Product> {
  new Product { Name = "Product 1", Category = "Category 1", Price = 10 },
  new Product { Name = "Product 2", Category = "Category 2", Price = 20 },
  new Product { Name = "Product 3", Category = "Category 1", Price = 15 },
  new Product { Name = "Product 4", Category = "Category 3", Price = 5 },
  new Product { Name = "Product 5", Category = "Category 3", Price = 5 }
};

Exercise10.Ex10(products);
Console.WriteLine();
Exercise10.Ex11(products);

