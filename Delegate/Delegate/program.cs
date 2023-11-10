using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public  delegate void UpdateHandle(String msg);
    public class program
    {

        public static void Main(string[] args)
        {
            Student student = new Student(1, "hoang");
            
        }

        
    }


    public class Student
    {
        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
        public event UpdateHandle UpdateHandle;

        public int ID { get; set; } 
        public string Name {
            get; set;
        }

        public override string? ToString()
        {
            return $"{Name}";
        }

        public Student(int id,string name)
        {
            ID = id;
            Name = name;

            UpdateHandle += Print;
            if (UpdateHandle != null) UpdateHandle(ToString()); 
        }

    }
}
