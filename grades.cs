using System;
using System.Security.Cryptography.X509Certificates;

// initialize variables - graded assignments 
int examAssignments = 5;

int [] sophiaScores = [90, 86, 87, 98, 100,94,90];
int [] andrewScores = [92, 89,81,96,90,89];
int [] emmaScores = [90,85,87,98, 68,89,89,89];
int [] loganScores = [90,95,87,88,96,96];
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan","Becky", "Chris", "Eric", "Gregor"];
int [] studentScores = new int [10];
string letterGrade = "";

Console.WriteLine("Student\t\tGrade\n");
foreach (string student in studentNames){
    string currentStudent = student;
    if (currentStudent=="Sophia")
        studentScores = sophiaScores;
    else if(currentStudent=="Andrew")
        studentScores = andrewScores;
    
    else if(currentStudent=="Emma")
        studentScores = emmaScores;
    
    else if(currentStudent=="Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;
    
    int sumScores = 0;
    decimal studentGrade;
    int gradedAssignments = 0;
        //total scores
    foreach (int i in studentScores){
        gradedAssignments++;
        if(gradedAssignments <=examAssignments){
             sumScores+=i; 
        }else{
            sumScores+=i/10;
        } 
    };
    studentGrade = (decimal)sumScores / examAssignments;
    if (studentGrade>=97)
        letterGrade = "A+";
    else if(studentGrade>=93)
        letterGrade = "A";
    else if(studentGrade>=90)
        letterGrade = "A-";
    else if(studentGrade>=87)
        letterGrade = "B+";
    else if(studentGrade>=83)
        letterGrade = "B";
    else if(studentGrade>=80)
        letterGrade = "B-";
    else if(studentGrade>=77)
        letterGrade = "C+";
    else if(studentGrade>=73)
        letterGrade = "C";
    else if(studentGrade>=70)
        letterGrade = "C-";
    else if(studentGrade>=67)
        letterGrade = "D+";
    else if(studentGrade>=63)
        letterGrade = "D";
    else if(studentGrade>=60)
        letterGrade = "D-";
    else
        letterGrade ="F";
    
    Console.WriteLine($"{student}:\t\t" + studentGrade + $"\t{letterGrade}");
    
}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
