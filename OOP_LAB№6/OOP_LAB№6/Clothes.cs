using System;

namespace OOP_LAB_6
{
    class Clothes : Product
    {
        public Clothes(int cost, string name, char size, string material)
            : base(cost, name)
        {
            _size = size;
            _material = material;
        }

        public override string[] GetField()
        {
            string[] items = new string[] { Convert.ToString(_size), Convert.ToString(_material), "Clothes" };

            return items;
        }

        private char _size;
        private string _material; 
    }
}
