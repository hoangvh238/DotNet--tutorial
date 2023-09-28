using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot4
{
    internal class OPP_Inher
    {
        class Employee
        {
            private string name;
            private int id;
            private int age;

            public Employee(string name, int id, int age)
            {
                this.name = name;
                this.id = id;
                this.age = age;
            }
            
            public string Name { 
                get { return name; }
                set { name = value; }
            } 

            public int Id
            {
                get { return id; }  
                set { id = value; }     
            }

            public int Age
            {
                    get { return age; } 
                    set { age = value; }    
            }

            protected virtual void Talk(string talk)
            {
                Console.WriteLine(talk);
            }

        }

        class Manager:Employee

        {
            private string email;

            public Manager(int id,int age, string name,string email):base(name,id,age) 
            {
                this.email = email;
            }

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public override string ToString()
            {
                Talk($"My name is {Name}");
                return $"id:{Id} name:{Name}";
            }

            protected override void Talk(string talk)
            {
                base.Talk(talk);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Manager khoa = new Manager(1, 12, "khoa gay", "khoabede@gmail.com");
                khoa.Name = "khoa be de nhat xom'";
                
                Console.Write(khoa);
               
            }
        }
    }
}
