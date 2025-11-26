// See https://aka.ms/new-console-template for more information
using SingletonPattern;
Console.WriteLine("---- Singleton Pattern ----\n");
static void PrintTeacherDetails()
{
    //Thread-1 Calling the GetInstance() Method of the Singleton class
    Singleton fromTeacher = Singleton.GetInstance();
    fromTeacher.PrintDetails("From Teacher");
}
static void PrintStudentDetails()
{
    //At the same time, Thread-2 also Calling the GetInstance() Method of the Singleton Class
    Singleton fromStudent = Singleton.GetInstance();
    fromStudent.PrintDetails("From Student");
}

Parallel.Invoke(
               //Let us Assume PrintTeacherDetails method is Invoked by Thread-1
               () => PrintTeacherDetails(),
               //Let us Assume PrintStudentDetails method is Invoked by Thread-2
               () => PrintStudentDetails()
               );