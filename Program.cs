using System;

namespace abstr
{
    abstract class person
    {
        public string name;
        public string address;
        public int num;
        public abstract void info();
    }
    class teacher : person
    {
        public string subject="maths";
        public teacher(string name, string address, int num)
        {
            this.name = name;
            this.address = address;
            this.num = num;
        }
        public override void info()
        {
            Console.WriteLine("name of teacher is:"+name+"\nAddress of teacher :"+address+"\n Phone number:"+num+"\n Subject:"+subject); ;
    
        }
    }
    class students : person
    {
        public int Roll_no = 3;
        public students(string name, string address, int num)
        {
            this.name = name;
            this.address = address;
            this.num = num;
        }
        public override void info()
        {
            Console.WriteLine("\nname of Student is:" + name + "\nAddress of Student :" + address + "\n Phone number:" + num + "\n Roll number:"+Roll_no); 

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            teacher t = new teacher("Rutuja", "kolhapur", 555);
            t.info();
            students s = new students("Hrishikesh", "Kolhapur", 566);
            s.info();
        }
    }
}
