namespace Class
{


    public class Person
    {
        public string name;
        public string birth;
    }
    public class Student : Person
    {
        public int marks;
        public List<string> myTeachers = new List<string>();
        public List<string> mySubjects = new List<string>();
        public List<int> myMarks = new List<int>();
    }
    public class Teacher : Person
    {

        public List<string> subjects = new List<string>();
        public List<string> placeWorks = new List<string>();
        public List<int> stage = new List<int>();

    }
    public class Managers : Person
    {
        public string job;
    }
    public class Support : Person
    {

    }
    public class Order
    {
        public string reciever;
        public string job;
        public string sender;
        public string ordText;
    }

}