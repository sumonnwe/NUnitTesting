﻿using StudentGrades;
var gradeCalculator = new GradeCalculator();
Console.Write("Enter the percentage : ");
var percentage = Convert.ToInt32(Console.ReadLine());
var grade = gradeCalculator.GetGradeByPercentage(percentage);
Console.WriteLine($"Student Grade : {grade}");