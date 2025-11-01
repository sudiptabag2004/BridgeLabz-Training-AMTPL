using System; public class Student {
    // Encapsulation: private variables private string name; private int age; // Constructor public Student(string 
    studentName, int studentAge) {
        name = studentName; age = studentAge;
    } // Method public void DisplayDetails() {
        Console.WriteLine($"Student Name: {name}"); Console.WriteLine($"Student Age: {age}");
    } } public class Program { public static void Main() {
        // Creating an object of Student class Student student1 = new Student("Sudipta", 20);

        student1.DisplayDetails();
    } }
