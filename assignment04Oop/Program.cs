using assignment04Oop.icloneable_interface;
using assignment04Oop.interfaceExampleTwo;
using assignment04Oop.part__three;
using assignment04Oop.part_three_q2;
using assignment04Oop.part_three_q3;
using System.Data;
using System.Runtime.Intrinsics.X86;

namespace assignment04Oop
{
    internal class Program
    {


        #region interfaceSeries
        public static void prinet10NumberFromSerias(Iserias serias)
        {
            if (serias == null)
                return;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{serias.Current} \t");
                serias.GetNext();
            }
            serias.reset();
            Console.WriteLine();
        }
        #endregion

        static void Main(string[] args)
        {
            #region interfaceSerias
            //SeriasByTwo seriesByTwo = new SeriasByTwo();
            //prinet10NumberFromSerias(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //prinet10NumberFromSerias(seriesByThree);

            #endregion

            #region interfaceExTwo
            // Airplane airplane = new Airplane();
            //airplane.Backward();
            // airplane.Forward(); xxx

            //IMoveable moveable = new Airplane();
            //moveable.Backward();
            //moveable.Forward(); 

            #endregion

            #region ShallowCopy Vs DeppCopy 
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4, 5, 6 };
            //Console.WriteLine($"HashCode of array one = {arr1.GetHashCode()}");
            //Console.WriteLine($"HashCode of array two = {arr2.GetHashCode()}");

            //arr2 = arr1;
            /// Shallow Copy [سطحي]
            /// this object{1,2,3} has 2 references [arr1 , arr2]
            /// this object {4,5,6} became unreachable object


            //Console.WriteLine("After shallow copy");
            //Console.WriteLine($"HashCode of array one = {arr1.GetHashCode()}");
            //Console.WriteLine($"HashCode of array two = {arr2.GetHashCode()}");

            //arr2[0] = 100;
            //Console.WriteLine(arr1[0]); //100

            /****************************/


            //arr2 = (int[])arr1.Clone();


            /// Deep copy
            /// clone method will generate new object with new and deffernt identity
            /// this object will have the same object state of caller object 'arr1'

            //Console.WriteLine("After Deep copy");
            //Console.WriteLine($"HashCode of array one = {arr1.GetHashCode()}");
            //Console.WriteLine($"HashCode of array two = {arr2.GetHashCode()}");

            //Console.WriteLine("************************");
            //arr2[0] = 100;
            //Console.WriteLine(arr1[0]); // 1


            #endregion

            #region Built-in interface IClonable


            //Employee employee = new Employee() 
            //{ 
            //    Id = 1, Name = "saeed", Salary=5_000 , Department = new Department()  { Id=101 , Name="sales"}

            //};
            //Employee employee02 = new Employee()
            //{
            //    Id = 2, Name = "omer", Salary = 4_000, Department = new Department() { Id = 102, Name = "Hr" }
            //};

            //Console.WriteLine($"HashCode of emp one = {employee.GetHashCode()}");
            //Console.WriteLine($"HashCode of emp two = {employee02.GetHashCode()}");

            //employee02 = (Employee) employee.Clone(); //Deep copy using clone method
            /// Deep copy
            /// clone method will generate new object with new and deffernt identity
            /// this object will have the same object state of caller object 'arr1'

            ////employee02 = new Employee(employee); // Deep copy by using copy constructor


            //Console.WriteLine($"HashCode of emp one = {employee.GetHashCode()}");
            //Console.WriteLine($"HashCode of emp two = {employee02.GetHashCode()}");
            //Console.WriteLine("***********************");
            //Console.WriteLine($"Employee one : {employee}");
            //Console.WriteLine($"Employee one : {employee02}");

            //if(employee02.Department is not null)
            //     employee02.Department.Name = "new";

            //Console.WriteLine(employee.Department.Name);

            #endregion

            #region Part Two
            //Question 1:
            /// What is the primary purpose of an interface in C#?
            /// 
            /// a) To provide a way to implement multiple inheritance 
            /// -----> b) To define a blueprint for a class 
            /// c) To declare abstract methods and properties
            /// d) To create instances of objects

            //Question 2:          
            /// Which of the following is NOT a valid access modifier for interface members in C#?
            ///
            /// ----->a) private
            ///b) protected
            ///c) internal
            ///d) public

            //Question 3:
            ///Can an interface contain fields in C#?
            ///
            ///   a) Yes
            ///   -----> b) No
            ///   c) Only if they are static
            ///   d) Only if they are readonly

            //Question 4:
            ///In C#, can an interface inherit from another interface?
            ///a) No, interfaces cannot inherit from each other
            /// ------> b) Yes, interfaces can inherit from multiple interfaces
            ///c) Yes, but only if they have the same methods 
            ///d) Only if the interfaces are in the same namespace

            //Question 5:
            ///Which keyword is used to implement an interface in a class in C#?
            ///a) inherit
            ///b) use
            ///c) extends
            /// ------> d) implements

            //Question 6:
            ///Can an interface contain static methods in C#?
            /// ------> a) Yes
            ///b) No
            ///c) Only if the interface is sealed
            ///d) Only if the methods are private

            //Question 7:
            ///In C#, can an interface have explicit access modifiers for its members?
            ///a) Yes, for all members
            /// -------> b) No, all members are implicitly public
            ///c) Yes, but only for abstract members
            ///d) Only if the interface is sealed

            //Question 8:
            ///What is the purpose of an explicit interface implementation in C#?
            ///a) To hide the interface members from outside access
            /// -------> b) To provide a clear separation between interface and class members
            ///c) To allow multiple classes to implement the same interface
            ///d) To speed up method resolution

            //Question 9:
            ///In C#, can an interface have a constructor?
            ///a) Yes, but it must be private
            /// ------> b) No, interfaces cannot have constructors
            ///c) Yes, but only if the interface is sealed
            ///d) Only if the constructor is static

            //Question 10:
            ///How can a C# class implement multiple interfaces?
            ///a) By using the "implements" keyword
            ///b) By using the "extends" keyword
            /// -------> c) By separating interface names with commas
            ///d) A class cannot implement multiple interfaces

            #endregion

            #region part three
            #region Question 1
            //Circle circle = new Circle(5);
            //circle.DisplayShapeInfo();

            //Rectangle rectangle = new Rectangle(5,6);
            //rectangle.DisplayShapeInfo();
            #endregion

            #region Question 2
            //IAuthenticationService authService = new BasicAuthenticationService();

            //string username = "saeed";
            //string password = "123";
            //string role = "user";

            //bool isAuthenticated = authService.AuthenticateUser(username, password);
            //bool isAuthorized = authService.AuthorizeUser(username, role);

            //Console.WriteLine($"User authenticated: {isAuthenticated}");
            //Console.WriteLine($"User authorized: {isAuthorized}");
            #endregion

            #region Question 3
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //string emailRecipient = "saeed@gmail.com";
            //string smsRecipient = "01050691200";
            //string pushRecipient = "saeed@gmail.com";

            //string emailMessage = " your order has been shipped and will arrive soon.";
            //string smsMessage = " your verification code is 123456.";
            //string pushMessage = " you have a new message in your inbox.";

            //emailService.SendNotification(emailRecipient, emailMessage);
            //smsService.SendNotification(smsRecipient, smsMessage);
            //pushService.SendNotification(pushRecipient, pushMessage);


         
            #endregion
            #endregion
        }
    }
}
