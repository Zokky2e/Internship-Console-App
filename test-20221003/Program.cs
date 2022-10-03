﻿
using System.Diagnostics.Metrics;
using test_20221003;
using Task = test_20221003.Task;

Leader leader = new Leader("Jelena", "Tufekovic", "1234567890");
Console.WriteLine(leader.ToString());
Internship internship = new Internship("Mono", leader);
Console.WriteLine("How many students are attending the internship?");
int numberOfStudents = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfStudents; i++)
{
    Console.WriteLine("Student number " + (i + 1));
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Surname: ");
    string surname = Console.ReadLine();
    Console.Write("OIB: ");
    string oib = Console.ReadLine();
    Student student = new Student(name, surname, oib);
    internship.AddStudent(student);
}
string exit;
do
{
    string entry;
    do
    {
        Console.WriteLine("Are you a leader or a student?\n For leader write 1 and press enter \n For student write 2 and press enter");
        entry = Console.ReadLine();
    } while (!(entry == "1" || entry == "2"));
    switch (entry)
    {
        case "1":
            DoLeaderWork();
            break;
        case "2": DoStudentWork(); break;
        default: break;
    }
    Console.Write("Are you done using the app Y/N?");
    exit = Console.ReadLine();
} while (!(exit == "y" || exit == "Y"));

void DoLeaderWork()
{
    string exit;
    do
    {
        string entry;
        do
        {
            Console.WriteLine("What do you want to do?" +
                "\n1. Add a student" +
                "\n2. Remove a student" +
                "\n3. Give a task");
            entry = Console.ReadLine();
        } while (!(entry == "1" || entry == "2" || entry == "3"));
        switch (entry)
        {
            case "1":
                DoAddStudent();
                break;
            case "2": DoRemoveStudent(); break;
            case "3": DoGiveTask(); break;
            default: break;
        }
        Console.Write("Is leader work done Y/N?");
        exit = Console.ReadLine();
    } while (!(exit == "y" || exit=="Y"));
    
}
void DoAddStudent()
{
    Console.WriteLine("Enter info of the student:");
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Surname: ");
    string surname = Console.ReadLine();
    Console.Write("OIB: ");
    string oib = Console.ReadLine();
    Student student = new Student(name, surname, oib);
    internship.AddStudent(student);
}

void DoRemoveStudent()
{
    ListPrinter.PrintList(internship.Students);
    Console.Write("Enter the student from list above!\n Number: ");
    int indexOfStudent = int.Parse(Console.ReadLine());
    internship.RemoveStudent(internship.Students[indexOfStudent-1]);
}
void DoGiveTask()
{
    ListPrinter.PrintList(internship.Students);
    Console.Write("Enter the student from list above!\n Number: ");
    int indexOfStudent = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter task information:");
    Console.Write("Title: ");string title = Console.ReadLine();
    Console.Write("description: "); string description = Console.ReadLine();
    Console.Write("Due Date(format: DD/MM/YYYY): "); string dueDate = Console.ReadLine();
    Task task = new Task(title, description, dueDate);
    internship.Leader.GiveTask(internship.Students[indexOfStudent - 1], task);

}

void DoStudentWork()
{
    string exit;
    do
    {
        ListPrinter.PrintList(internship.Students);
        Console.Write("Which student are you?\n Number: ");
        int indexOfStudent = int.Parse(Console.ReadLine());
        string entry;
        do
        {
            Console.WriteLine("What do you want to do?" +
               "\n1. Do a task" +
               "\n2. Do all tasks" +
               "\n3. Play video-games");
            entry = Console.ReadLine();
        } while (!(entry == "1" || entry == "2" || entry == "3"));
        switch (entry)
        {
            case "1":
                DoATask(internship.Students[indexOfStudent-1]);
                break;
            case "2": DoAllTasks(internship.Students[indexOfStudent - 1]); break;
            case "3": PlayVideoGames(); break;
            default: break;
        }
        Console.Write("Is student work done Y/N?");
        exit = Console.ReadLine();
    } while (!(exit == "y" || exit == "Y"));
}
void DoATask(Student student)
{
    student.DoTask();
}
void DoAllTasks(Student student)
{
    student.DoAllTasks();
}
void PlayVideoGames()
{
    Console.WriteLine("Pew pew, there goes an hour of work!");
}