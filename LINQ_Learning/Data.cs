using System;
using System.Collections.Generic;


namespace Learning_data
{
	public class Product
    {

        public string name;
        public float price;
        public float calories;

        public Product(string Name, float Price)
        {
            name = Name;
            price = Price;
        }

    }
    
	public class Human
	{
		public string name;
		public int age;
		private int id_num;

		public int ID_Num
        {
            get { return id_num; }
        }

	}

	public class Customer : Human
    {
        public List<Product> Orders;
        private int order_id;

        public int Order_id
        {
            set { order_id = value; }
            get { return order_id; }
        }

        public Customer(string Name, int Age, int O_ID)
        {
            name = Name;
            age = Age;
        }
    }

	public class Worker : Human
    {

    }
}

