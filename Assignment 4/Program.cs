using Assignment_4.Notification;
using Assignment_4.Authentication;
using Assignment_4.Shaps;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1 [Questions]
            /*
             Question 1:
             What is the primary purpose of an interface in C#?
             --a) To define a blueprint for a class

             Question 2:
             Which of the following is NOT a valid access modifier for interface members in C#?
             --a) private

            Question 3:
            Can an interface contain fields in C#?
            --d) Only if they are readonly

            Question 4:
            In C#, can an interface inherit from another interface?
            --b) Yes, interfaces can inherit from multiple interfaces

            Question 5:
            Which keyword is used to implement an interface in a class in C#?
            --d) implements

            Question 6:
            Can an interface contain static methods in C#?
            --a) Yes

            Question 7:
            In C#, can an interface have explicit access modifiers for its members?
            --b) No, all members are implicitly public

            Question 8:
            What is the purpose of an explicit interface implementation in C#?
            --c) To allow multiple classes to implement the same interface

            Question 9:
            In C#, can an interface have a constructor?
            --b) No, interfaces cannot have constructors

            Question 10:
            How can a C# class implement multiple interfaces?
            --c) By separating interface names with commas
             */
            #endregion

            #region Part 2
            //Circle circle01 = new Circle(5);
            //Circle circle02 = new Circle(3);

            //circle01.fun();
            //circle01.DisplayShapeInfo();


            //circle02.fun();
            //circle01.DisplayShapeInfo();

            //Rectangle rectangle01 = new Rectangle(2,4);
            //Rectangle rectangle02 = new Rectangle(3,5);

            //rectangle01.fun();
            //rectangle01.DisplayShapeInfo();

            //rectangle02.fun();
            //rectangle02.DisplayShapeInfo();
            #endregion

            #region Part 3
            //IAuthenticationService authenticationService ;
            //authenticationService = new BasicAuthenticationService();

            //if (authenticationService.AuthenticateUser("Admin", "Password"))
            //    Console.WriteLine("True");
            //else 
            //    Console.WriteLine("False");

            //if (authenticationService.AuthenticateUser ("fatma","0025974"))
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");

            //if (authenticationService.AuthorizeUser ("Admin","Admin"))
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");

            //if (authenticationService.AuthorizeUser ("Admin","base"))
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");

            #endregion

            #region Part 4

            //INotificationService notification = new EmailNotificationService();

            //notification.SendNotification("fatma", "Hello fatma");

            //notification = new SmsNotificationService();

            //notification.SendNotification("ahmed", "Hello ahmed");

            //notification = new PushNotificationService();

            //notification.SendNotification("ali", "Hello ali");

            #endregion

        }
    }
}
