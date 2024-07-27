using Demo.Interface;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IType type ;
            MyType myType = new MyType ();
            //myType.Print(); //invalid
            type = myType;
            type.Id = 1;
            type.MyFun(500);
            type.Print();
        }
    }
}
