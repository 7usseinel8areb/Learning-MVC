namespace Day1_Assignment.Models
{
    public class StudentList
    {
        public static List<Student> studens { get; set; }
        static StudentList()
        {
            studens = new List<Student>();
            studens.Add(new Student() { ID = 1, Name = "Hussein Mohamed Elghareb",Address = "Damietta",image = "1.png" }) ;
            studens.Add(new Student() { ID = 2, Name = "Hossam Mohamed Rashed",Address = "Mansoura",image = "2.png" }) ;
            studens.Add(new Student() { ID = 3, Name = "Khaled Abo-Elhamd",Address = "Aswan",image = "3.png" }) ;
        }
    }
}
