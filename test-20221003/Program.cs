
using test_20221003;

Leader leader = new Leader("Jelena", "Tufekovic", "1234567890");
Internship internship = new Internship("Mono", leader);
//Console.WriteLine("How many students are attending the internship?");
//int numberOfStudents = int.Parse(Console.ReadLine());
//for(int i = 0; i < numberOfStudents; i++)
//{
//    Console.WriteLine("Student number " + (i+1));
//    Console.Write("Name: ");
//    string name = Console.ReadLine();
//    Console.Write("Surname: ");
//    string surname = Console.ReadLine();
//    Console.Write("OIB: ");
//    string oib = Console.ReadLine();
//    Student student = new Student(name, surname, oib);
//    internship.AddStudent(student);
//}
string entry;
do
{
    Console.WriteLine("Are you a leader or a student?\n For leader write 1 and press enter \n For student write 2 and press enter");
    entry = Console.ReadLine();
} while (!(entry == "1" || entry == "2"));
switch (entry)
{
    case "1": DoLeaderWork();
        break;
    case "2": Console.WriteLine("Hello student!"); break;
    default: break;
}
void DoLeaderWork()
{
    string entry;
    do
    {
        Console.WriteLine("What do you want to do?" +
            "\n For adding a student write 1 and press enter" +
            "\n For removing a student write 2 and press enter" +
            "\n For giving tasks write 3 and press enter");
        entry = Console.ReadLine();
    } while (!(entry == "1" || entry == "2" || entry == "3"));
    switch (entry)
    {
        case "1":
            DoAddStudent();
            break;
        case "2": DoRemoveStudent(); break;
        case "3": DoGiveTasks(); break;
        default: break;
    }
}
void DoAddStudent()
{

}

void DoRemoveStudent()
{

}
void DoGiveTasks()
{

}