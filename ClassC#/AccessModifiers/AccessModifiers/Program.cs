namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Nicat Mecidov", 99);
            Group BB207 = new Group("BB207",20);
            student.GroupNo = BB207.No;
            BB207.AddStudent(student);
            student.ShowInfo();
            BB207.ShowGroup();
        }
    }
}
