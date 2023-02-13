//Entity Framework
//Save Data to DataBase
//Using SQLLITE


using a;
using b;

DbCon db;
db = new DbCon();

Student stu;
stu = new Student() { Id = "123", Name = "aiden"};

db.students.Add(stu);
db.SaveChanges();


Console.WriteLine("EF");