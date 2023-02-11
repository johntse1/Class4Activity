using System:

namespace zoo{
    interface Animal
    {
        //Interface for all animals
        private string name;
        private string description;
        private int quantity;

        //has both setter and getter
        public string name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string description
        {
            get { return description; }
            set { description = value; }
        }
        public int quantity
        {
            get { return quantity; }
            set { quanitty = value; }
        }
    }
    class lion : Animal
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            lion l1 = new lion();

        }
    }
}