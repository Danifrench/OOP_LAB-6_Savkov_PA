using System;

namespace OOP_LAB_6
{
    class Laptop : Product
    {
        public Laptop(int cost, string name, string procID, int ram, int hdd)
            : base(cost, name)
        {
            _procID = procID;
            _ram = ram;
            _hdd = hdd;
        }

        public override string[] GetField()
        {
            string[] items = new string[] { Convert.ToString(_procID), Convert.ToString(_ram), Convert.ToString(_hdd), "Laptop" };

            return items;
        }

        private string _procID;
        private int _ram;
        private int _hdd;
    }
}
