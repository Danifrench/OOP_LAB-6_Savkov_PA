using System;

namespace OOP_LAB_6
{
	abstract class Product
	{
		public static int count;

		public Product() { }
		public Product(int cost, string name)
		{
			_cost = cost;
			_name = name;
			_id = GenerateID();
		}

		public int GetCost
		{
			get { return _cost; }
		}

		public string GetName
        {
			get { return _name; }
        }

		public int GetID
        {
			get { return _id; }
        }

		public abstract string[] GetField();
		private int GenerateID()
        {
			count++;
			return count + 100;
        }

		private int _cost;
		private int _id;
		private string _name;
	}
}
