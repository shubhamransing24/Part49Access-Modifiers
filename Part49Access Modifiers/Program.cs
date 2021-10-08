using System;

namespace Part49Access_Modifiers
{
    public class Customer
    {
        private System.Int32 _id = 32;
        protected int s=55;
        public int b=334;
        internal int a=645;
        protected void Cricket()
        {
            Console.WriteLine("Virat kohli is the best");
        }

        //properties are used to encapsulate and protect private fields
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        public virtual void Print()
        {
            Console.WriteLine("Private Id={0}", _id);
        }

    }
    public class Students : Customer
        {
            public override void Print()
        {
            Console.WriteLine("Value of s={0}", s);
            new Students().Cricket();
        }
        }
    class Program
    {
       public  int e = 44;
        public static void  PublicAcess()
        {
            Console.WriteLine("Value of B={0}", new Customer().b);
            Console.WriteLine("Value of Internle a from Customer Class is={0}", new Customer().a);
            Program p1 = new Program();
            
            Console.WriteLine(p1.e);
        }
       


        
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.Id = 432;
            c.Print();
            Console.WriteLine("id={0}", c.Id);
            Students s = new Students();
            s.Print();
            PublicAcess();
        }
    }
}
