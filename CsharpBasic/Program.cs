
//Console.WriteLine("Hello, World!");
//Console.WriteLine("welcome to A-host");


/*int num1 = 0;
long num2 = 10;
Console.WriteLine(num1);
Console.WriteLine(num2);*/

//char mychar = '1';
//double mydouble = mychar;
//Console.WriteLine(mydouble);

/*double d1 = 700;
int d2 = Convert.ToInt32(d1);
Console.WriteLine(d2);*/

//string num1 = "1000";
//string num2 = "500";
//int num3 = int.Parse(num1);
//int num4 = int.Parse(num2);
//Console.WriteLine(num3 + num4);

//Console.WriteLine("num1 :");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("*num2 :");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

//Console.WriteLine("Enter your name : ");
//String username = Console.ReadLine();
//Console.WriteLine("Enter your");

////////////////////////////////////////////////////

//double x = 7;
//double y = 3; 

//Console.WriteLine(x++);
//Console.WriteLine(++y);
//Console.WriteLine(x--);
//Console.WriteLine(--y); 

//double x = 7;

//Console.WriteLine(x=3);
//x = 7;
//Console.WriteLine(x+=3);
//x = 7;
//Console.WriteLine(x-=3);
//x = 7;

///////////////////////////////////////

/*string Role = "Admin";
if (Role == "Admin")
{
    Console.WriteLine("Admin");
}
else if (Role == "Admin1")
{
    Console.WriteLine()
}*/

/*string Role = "User";
switch (Role)
{
    case "Admin":

}
*/
/////////////////////////////////////////


/*แลป1
using System;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;

Console.Write("Name : ");
string Name1 = Console.ReadLine();
Console.Write("Input Weight(kg) : ");
double Weight1 = double.Parse(Console.ReadLine());
Console.Write("Input Height(cm) : ");
double Height1 = double.Parse(Console.ReadLine());

Console.Write("--------2--------");
Console.Write("\n Name : ");
string Name2 = Console.ReadLine();
Console.Write("Input Weight(kg) : ");
double Weight2 = double.Parse(Console.ReadLine());
Console.Write("Input Height(cm) : ");
double Height2 = double.Parse(Console.ReadLine());

double BMI1 = Math.Round(Weight1 / Math.Pow(Height1 / 100, 2), 2);
double BMI2 = Math.Round(Weight2 / Math.Pow(Height2 / 100, 2), 2);

Console.WriteLine($"\n {Name1} BMI = {BMI1}");
Console.WriteLine($"\n {Name2} BMI = {BMI2}");
//Console.WriteLine($"\nMax BMI =  {Math.Max(BMI1,BMI2)}"); */



/*แลป2
using System;

class Program
{
    static void Main(string[] args)
    {
        string position;
        float salary;

        Console.Write("Enter your position : ");
        position = Console.ReadLine();

        Console.Write("Enter your salary: ");
        salary = float.Parse(Console.ReadLine());

        float SalaryIncrease = 0;
        switch (position)
        {
            case "Assistant Developer":
                SalaryIncrease = 1.05f;
                break;
            case "IT Support":
                SalaryIncrease = 1.07f;
                break;
            case "Senior Developer":
                SalaryIncrease = 1.1f;
                break;
            case "Administrator":
                SalaryIncrease = 1.08f;
                break;
            default:
                SalaryIncrease = 1.03f;
                break;
        }

        float bonus = salary * SalaryIncrease;
        float newSalary = salary + bonus;
        Console.WriteLine("Salary increase: {0}", bonus);
        Console.WriteLine("New salary: {0}", newSalary);
    }
}
*/



/* แลป3
using System;
class Program
{
    static void Main()
    {
        Console.Write("กรุณากรอกจำนวนนักเรียนที่ต้องการกรอกคะแนน: ");
        int numStudents = int.Parse(Console.ReadLine());

        int[] ids = new int[numStudents];
        int[] scores = new int[numStudents];

        int i = 0;
        while (i < numStudents)
        {
            Console.Write($"กรอกรหัสนักเรียนคนที่ {i + 1}: ");
            ids[i] = int.Parse(Console.ReadLine());

            Console.Write($"กรอกคะแนนของนักเรียนคนที่ {i + 1}: ");
            scores[i] = int.Parse(Console.ReadLine());

            Console.WriteLine();
            i++;
        }

        string exit;
        do
        {
            Console.Write("Exit? (Y/N): ");
            exit = Console.ReadLine().ToUpper();
        } while (exit != "Y" && exit != "N");

        if (exit == "Y")
        {
            Environment.Exit(0);
        }

        Console.WriteLine("โปรแกรมจบการทำงาน");
    }
}
*/



/* แลป 4
using System;

public class ParentClass
{
    public string Attribute1 { get; set; }
    public int Attribute2 { get; set; }

    public void ParentMethod1()
    {
        Console.WriteLine("This is parent method 1");
    }

    public void ParentMethod2()
    {
        Console.WriteLine("This is parent method 2");
    }
}

public class ChildClass : ParentClass
{
    public string Attribute3 { get; set; }

    public void ChildMethod1()
    {
        Console.WriteLine("This is child method 1");
    }

    public void ChildMethod2()
    {
        Console.WriteLine("This is child method 2");
    }

    public ChildClass(string attribute1, int attribute2, string attribute3)
    {
        Attribute1 = attribute1;
        Attribute2 = attribute2;
        Attribute3 = attribute3;
    }
}

public class Program
{
    public static void Main()
    {
        ChildClass childObject = new ChildClass("Attribute 1", 2, "Attribute 3");
        childObject.ParentMethod1();
        childObject.ParentMethod2();
        childObject.ChildMethod1();
        childObject.ChildMethod2();
        Console.WriteLine(childObject.Attribute1);
        Console.WriteLine(childObject.Attribute2);
        Console.WriteLine(childObject.Attribute3);
    }
}
*/

