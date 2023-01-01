using System;
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

		public void SetGrade(int grade)
		{
			this.Grade = grade;
		}
		//Yu TODO //這裡是local yu TEST
		// 幫我加上一個method, 可以設定此學生的成績, 並且在mina中做測試
	}
}
