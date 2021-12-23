using System;

namespace encapsulation_property
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new();
            student1.Name = "Oguz";
            student1.Surname ="Demir";
            student1.StudentId = 234;
            student1.ClassYear = 3;

            Student student2 = new Student("Ilayda", "Demir", 235, 3);

            student1.GetStudentInfo();
            student1.DecreaseAddClassYear();
            student1.GetStudentInfo();
            student1.DecreaseAddClassYear();
            student1.GetStudentInfo();
            student1.DecreaseAddClassYear();
            student1.GetStudentInfo();
            student1.DecreaseAddClassYear();
            student1.GetStudentInfo();
            student1.DecreaseAddClassYear();
            student1.GetStudentInfo();
            student2.GetStudentInfo();

        }
    }

    class Student
    {
        private string name;
        private string surname;
        private int studentId;
        private int classYear;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int StudentId { get => studentId; set => studentId = value; }
        public int ClassYear 
        { 
            get => classYear;
            set 
            {
                if(value <=1){
                    Console.WriteLine("You can not decrease the class lower than 1");
                    classYear = 1;
                }
                else{
                    classYear = value;  
                }

            } 
        }

    public Student(string name, string surname, int studentId, int classYear)
    {
      Name = name;
      Surname = surname;
      StudentId = studentId;
      ClassYear = classYear;
    }

    public Student(){}

    public void GetStudentInfo(){
        Console.WriteLine("****Student Info****");
        Console.WriteLine("================\n");
        Console.WriteLine("Student Name: {0}",this.Name);
        Console.WriteLine("Student Surname: {0}",this.Surname);
        Console.WriteLine("Student Student ID: {0}",this.StudentId);
        Console.WriteLine("Student Class Year: {0}",this.ClassYear);
        Console.WriteLine("================\n");
    }

    public void IncreaseClassYear()
    {
        this.ClassYear += 1;
    }

    public void DecreaseAddClassYear()
    {
        
        this.ClassYear -= 1;
        
    }


  }
}
