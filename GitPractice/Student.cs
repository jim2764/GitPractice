﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPractice
{
	public class Student
	{
		public Student(string name, bool gender, int grade)
		{
			Name = name;
			Gender = gender;
			Grade = grade;
		}

		public string Name { get; set; }
		public bool Gender { get; set; }
		public int Grade { get; set; }

		public override string ToString()
		{
			string sex = "male";
			if (!Gender) sex = "female";

			return $"Name: {Name}, Sex:{sex}, Grade:{Grade}";
		}

		public void MyStudent()
		{
			Console.WriteLine(this.ToString());
		}

		//Shiun TODO
		// 幫我寫一個Method, 可以更改Gender的值, True->False, 反之亦然 
	}
}
