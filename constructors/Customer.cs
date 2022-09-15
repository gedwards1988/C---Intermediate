using System.Collections.Generic;

namespace constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        // Constructor Overload
            // Parameterless Constructor
        public Customer()
        {
            Orders = new List<Order>();
        }

            // 1 parameter for when we know id
        public Customer(int id)
            // first calls blank parameter constructor
            : this()
        {
            this.Id = id;
        }

            // 2 parameter constructor when we know id and name
        public Customer(int id, string name)
            // calls constructor with parameter id
            : this(id)
        {
            this.Name = name;
        }
    }
}