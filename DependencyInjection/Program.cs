using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogicService myObj = new BusinessLogicService(new StudentService());
            Console.ReadKey();
        }
    }

    public class BusinessLogicService
    {
        private IService iService;

        public BusinessLogicService(IService _iService)
        {
            this.iService = _iService;
            this.iService.GetFirstName();
            this.iService.GetLastName();
        }
    }

    public interface IService
    {
        void GetFirstName();
        void GetLastName();
    }

    public class StudentService : IService
    {
        public void GetFirstName()
        {
            Console.WriteLine("Student First Name");
        }
        public void GetLastName()
        {
            Console.WriteLine("Student Last Name");
        }
    }

    public class TeacherService : IService
    {
        public void GetFirstName()
        {
            Console.WriteLine("Teacher First Name");
        }

        public void GetLastName()
        {
            Console.WriteLine("Teacher Last Name");
        }
    }

}






// The issue here is that the student class is dependent on the DataService class.
// Dependency Injection can be used to fix this issue.
public class Student
{
    DataService obj = new DataService();

    public void Get()
    {
        obj.GetName();
    }
}

public class DataService
{
    public void GetName()
    {

    }
}