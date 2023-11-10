using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLOT5
{
    class Generic
    {
        static void Main(string[] args)
        {
            ClassService<String,String> service = new ClassService<String,String>() { Value = "hi"};
            Console.WriteLine(service.ToString());
            ClassService<float,String> service1 = new ClassService<float,String>() { Value = 1.0f ,Detail="asdadas"};
            Console.WriteLine(service1.ToString());
            ServiceOparator service2 = new ServiceOparator();
            Console.WriteLine(service2.Display<int, float>(1, 2));

            AddClass add = new AddClass();
            AddClassFloat addClassFloat = new AddClassFloat();

            Console.WriteLine(add.Add(1,5));
            Console.Write(addClassFloat.Add(1.0F,2.3F));

            List<Person> person = new List<Person>()
            {
                new Person {FirstName ="huy", LastName="hUY" , Age=20},
                  new Person {FirstName ="hu2y", LastName="hU5Y" , Age=20},
                  new Person {FirstName ="h3y", LastName="h1UY" , Age=20}

            };

            foreach(Person p in person)
            {
                Console.WriteLine(p);
            }

            SortedSet<int> test = new SortedSet<int> { 5, 2, 5, 2, 5, 1, 5, 2, 5, 2, 12, 6, 5, 58, 8, 46 };
            foreach(int i in test)
            {
                Console.WriteLine($"{i,10}");    
            }

            
        }
    }

    public class ClassService<T,U>
    {
        private T data; 
        private U detail;
        
        public U Detail
        {
            get => detail;
            set => detail = value;
        }
        public T Value
        {
              get =>data; set => data = value;
        }

        public override string ToString()
        {
            return $"data={data} + detail={detail}";

        }

    }

    class ServiceOparator 
    {
        public T  Display<T,U>(T floatData,U intData )
        {
            Console.WriteLine($"data1 ={floatData} data2 ={intData}");
          
            return floatData ;
        }
    }

    interface IOperator<T> where T: struct { 
        T Add(T a,T b);
    }

    class AddClass : IOperator<int>
    {
        public int Add(int a,int b)
        {
            return a + b;
        }

    }

    class AddClassFloat : IOperator<float> { 
        public float Add(float a,float b) {
            return a + b;

        }
    }

    class Person
    {
       public int Age
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        { get; set; }

        public override string ToString()
        {
            return $"{Age} + {FirstName} + {LastName}";
        }

    }



}
