using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqStudy
{
	class Program
	{
		static void Main(string[] args)
		{

			List<Student> studentList = new List<Student>() { new Student() { StudentID = "1", StudentName = "张三", Age = 18 }, 
															  new Student() { StudentID = "2", StudentName = "李四", Age = 19 },
															  new Student() { StudentID = "3", StudentName = "王五", Age = 20 }};

			List<Cursor> cursorList = new List<Cursor>() {	  new Cursor() { StudentID = "1", CursorName = "语文", Grade = 90 }, 
															  new Cursor() { StudentID = "2", CursorName = "数学", Grade = 88 },
															  new Cursor() { StudentID = "3", CursorName = "英语", Grade = 70 }};
			Test3(studentList, cursorList);
			Console.Read();
		}

		public static void Test(string[] strs)
		{
			var selectStr = from Name in strs
							where Name.Length < 5
							select Name;
			foreach (var item in selectStr)
			{
				Console.WriteLine("长度小于5的字符串：{0}", item);
			}
		}

		public static void Test2(string[] strs)
		{
			var selectStr = from Str in strs
							where Str.Length < 5

							select Str;
		}

		public static void Test3(List<Student> list1, List<Cursor> list2)
		{
			var coll = from p in list1
					   from c in list2
					   where p.StudentID == c.StudentID && c.Grade > 80
					   select new { p, c };

			foreach (var item in coll)
			{
				Console.WriteLine("姓名：{0}，科目：{1}，成绩：{2}", item.p.StudentName, item.c.CursorName, item.c.Grade);
			}
		}
	}
}
