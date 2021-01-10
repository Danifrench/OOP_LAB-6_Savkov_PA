using System;

namespace OOP_LAB_6
{
    class Greens : Product
    {
        public Greens(int cost, string name, double weight, int kkal)
            : base(cost, name)
        {
            _weight = weight;
            _kkal = kkal;
        }
        public override string[] GetField()
        {
            string[] items = new string[] { Convert.ToString(_kkal), Convert.ToString(_weight), "Greens" };

            return items;
        }

        private double _weight;
        private int _kkal;
    }
}
