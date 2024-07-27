using Demo.Iclonable;
using Demo.Icomparer;
using Demo.Interface;
using System.Text;

namespace Demo
{
    internal class Program
    {
        #region Print10Numbers
        //public static void Print10Numbers(ISeries series)
        //{
        //    if (series is not null)
        //    {

        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.Write(" "+series.Current+" ");
        //            series.GetCurrent();
        //        }
        //        series.RestCurrent();

        //    }
        //}
 
        #endregion
        static void Main(string[] args)
        {
            #region interface
            //IType type ;
            //MyType myType = new MyType ();
            ////myType.Print(); //invalid
            //type = myType;
            //type.Id = 1;
            //type.MyFun(500);
            //type.Print();
            #endregion

            #region interface EX01

            //Series series = new Series();
            //Print10Numbers(series);
            //Console.WriteLine("\n*************************************");
            //Series3 series3 = new Series3();
            //Print10Numbers(series3);

            #endregion

            #region interface ex02
            //Car car = new Car();
            //car.Borward();

            //Aroplane aroplane = new Aroplane();
            //aroplane.Borward();

            //IMovable movable = new Aroplane ();
            //movable.Forward();

            //IFlyable movable2 = new Aroplane ();
            //movable2.Forward();
            #endregion

            #region shallow copy and deep copy
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = new int[3];

            //Console.WriteLine("HC OF ARR1 : " + arr1.GetHashCode());
            //Console.WriteLine("HC OF ARR1 : " + arr2.GetHashCode());

            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);

            //arr2 = arr1;

            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);

            //arr2 [0] = 100;

            //Console.WriteLine(arr2[0]);
            //Console.WriteLine(arr2[0]);

            //arr2 = (int[]) arr1.Clone();

            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);

            //arr2 [0] = 100;

            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);
            #endregion

            #region shallow copy and deep copy of string bilder
            //StringBuilder sb = new StringBuilder();
            //sb = new StringBuilder("fatma");


            //StringBuilder sb02 = new StringBuilder();
            //sb02 = sb;

            //Console.WriteLine(sb02);
            //Console.WriteLine(sb);

            //sb02.Append(" nassar");

            //Console.WriteLine(sb02);
            //Console.WriteLine(sb);

            #endregion

            #region deep copy of user defind data type 
            //Employee employee = new Employee();
            //employee.Id = 1;
            //employee.Name = "Tota";
            //employee.Salary = 90000;
            //Employee employee2 = new Employee();

            //employee2 = (Employee) employee.Clone();
            //employee2 = new Employee (employee);

            //Console.WriteLine(employee);
            //Console.WriteLine(employee2);
            #endregion

            #region icomparable
            //Employee[] employee = new Employee[4];
            //employee[0] = new Employee (10 , "fatma" , 7000);
            //employee[2] = new Employee (20 , "ahmed" , 6000);
            //employee[1] = new Employee (30 , "aly" , 1000);
            //employee[3] = new Employee (40 , "mohamed" , 9000);

            //Array.Sort (employee);

            //foreach (Employee emp in employee) 
            //    Console.WriteLine (emp);
            #endregion

            #region icomparer
            //Employee[] employee = new Employee[4];
            //employee[0] = new Employee (90 , "fatma" , 7000);
            //employee[2] = new Employee (20 , "ahmed" , 6000);
            //employee[1] = new Employee (30 , "aly" , 1000);
            //employee[3] = new Employee (40 , "mohamed" , 9000);

            //Array.Sort (employee,new EmployeeById());

            //foreach (Employee emp in employee) 
            //    Console.WriteLine (emp);
            #endregion



        }
    }
}
