using Demo.Interface;

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
        }
    }
}
