using System.Drawing;
using Assignment07C_OOP04.Question_01;
using Assignment07C_OOP04.Question_02;
using Assignment07C_OOP04.Question_03;

namespace Assignment07C_OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {//Assignment07C#OOP04

            //Part01
            #region Question 1: What is the primary purpose of an interface in C#?
            // Answer:
            //a) To provide a way to implement multiple inheritance

            #endregion

            #region Question 2: Which of the following is NOT a valid access modifier for interface members in C#?
            // Answer:
            //a) private
            #endregion

            #region Question 3: Can an interface contain fields in C#?
            // Answer:
            //b) No
            #endregion

            #region Question 4: In C#, can an interface inherit from another interface?
            // Answer:
            //b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region Question 5:  Which keyword is used to implement an interface in a class in C#?
            // Answer:
            //d) implements
            #endregion

            #region Question 6: Can an interface contain static methods in C#?
            // Answer:
            //a) Yes
            #endregion

            #region Question 7:  In C#, can an interface have explicit access modifiers for its members?
            // Answer:
            // b) No, all members are implicitly public
            #endregion

            #region Question 8: What is the purpose of an explicit interface implementation in C#?
            // Answer:
            //c) To allow multiple classes to implement the same interface
            #endregion

            #region Question 9: In C#, can an interface have a constructor?
            // Answer:
            //b) No, interfaces cannot have constructors

            #endregion

            #region Question 10: How can a C# class implement multiple interfaces?
            // Answer:
            //c) By separating interface names with commas
            #endregion

            //Part02
            #region  Question 1 :

            //Rectanglee rect = new Rectanglee(5, 6);

            //rect.DisplayShapeInfo();

            //Circle circle = new Circle(5);
            //circle.DisplayShapeInfo();

            #endregion

            #region  Question 2 :


            //IAuthenticationService NewService = new BasicAuthenticationService("Sherouk", "12345", "admin");

            //string Username = "Sherouk";
            //string Password = "12345";

            //Console.WriteLine($"User {Username} authentication: {NewService.AuthenticateUser(Username,Password)}");

            //string role = "admin";
            //Console.WriteLine($"User {Username} authorization for role '{NewService.AuthorizeUser(Username, role)}");


            #endregion

            #region  Question 3 :

            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //emailService.SendNotification("shorouqmohy11@gmail.com", "I hope you have a good day");
            //smsService.SendNotification("01050914732", "I hope you have a good day");
            //pushService.SendNotification("user_id", "I hope you have a good day");


            #endregion


        }
    }
}
