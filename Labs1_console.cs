public class Program
{
    public static void Main()
    {
		public int k = 1;
       // var students = new[] {
       // new Student { Name = "Маша", Grade = 4 },
    };
        
        var average = students.Average(s => s.Grade);
        
        Console.WriteLine("Средний балл: " + average);
        
        foreach (var student in students.Where(s => s.Grade >= average))
            Console.WriteLine(string.Format("{0} ({1})", student.Name, student.Grade)); 
    }
    
	public class Faculty {
	public string Name_fac { get; set; }
}

	public class Groups {
	public string Name_gr { get; set; }
}

	public class Object {
	public string Name_obj { get; set; }
}
	

    public class Student {
        public string Name_st { get; set; }
        public double Grade { get; set; }
		public Object [] Disciplines {get; set;}
			public Student ()
			{
				Disciplines = new Object [];
			}
    }


}

