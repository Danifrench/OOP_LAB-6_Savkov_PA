using System;
using System.Collections.Generic;

namespace OOP_LAB_6
{
    class Store
    {
        private Dictionary<int, Product> _productID = new Dictionary<int, Product>();

        private Dictionary<int, HashSet<int>> _productkkal = new Dictionary<int, HashSet<int>>();
        private Dictionary<double, HashSet<int>> _productweight = new Dictionary<double, HashSet<int>>();
        private Dictionary<int, HashSet<int>> _productCost = new Dictionary<int, HashSet<int>>();
        private Dictionary<char, HashSet<int>> _productSize = new Dictionary<char, HashSet<int>>();
        private Dictionary<string, HashSet<int>> _productMaterial = new Dictionary<string, HashSet<int>>();
        private Dictionary<int, HashSet<int>> _productRAM = new Dictionary<int, HashSet<int>>();

        public HashSet<int> FindRAM(int param)
        {
            HashSet<int> ids = new HashSet<int>();

            ids = _productRAM[param];

            return ids;
        }

        public HashSet<int> FindMaterial(string param)
        {
            HashSet<int> ids = new HashSet<int>();

            ids = _productMaterial[param];

            return ids;
        }

        public HashSet<int> FindSize(char param)
        {
            HashSet<int> ids = new HashSet<int>();

            ids = _productSize[param];

            return ids;
        }

        public HashSet<int> FindWeight(double param)
        {
            HashSet<int> ids = new HashSet<int>();

            ids = _productweight[param];

            return ids;
        }

        public HashSet<int> FindKkal(int param)
        {
            HashSet<int> ids = new HashSet<int>();

            ids = _productkkal[param];

            return ids;
        }

        public HashSet<int> FindCost(int param)
        {
            HashSet<int> ids = new HashSet<int>();

            ids = _productCost[param];

            return ids;
        }

        public List<int> GetAllIDs()
        {
            List<int> ids = new List<int>();

            foreach (var i in _productID)
            {
                ids.Add(i.Key);
            }

            return ids;
        }

        public string[] GetInfoByID(int id)
        {
            string[] buf = _productID[id].GetField();
            string[] items = new string[buf.Length + 2];

            items[0] = Convert.ToString(_productID[id].GetCost);
            items[1] = _productID[id].GetName;

            for (int i = 0; i < buf.Length; i++)
            {
                items[i + 2] = Convert.ToString(buf[i]);
            }

            return items;
        }

        public void AddProduct(string fields)
        {
            Factory newFactoryProduct = new Factory();
            Product newElement = newFactoryProduct.createProduct(fields);

            string[] items = newElement.GetField();

            switch (newElement.GetType().Name)
            {
                case "Greens":
                    // int kkal = Convert.ToInt32(items[0]);
                    // double weight = Convert.ToDouble(items[1]);

                    if (_productkkal.ContainsKey(Convert.ToInt32(items[0])) == false)
                    {
                        _productkkal.Add(Convert.ToInt32(items[0]), new HashSet<int>());
                    }

                    _productkkal[Convert.ToInt32(items[0])].Add(newElement.GetID);

                    if (_productweight.ContainsKey(Convert.ToDouble(items[1])) == false)
                    {
                        _productweight.Add(Convert.ToDouble(items[1]), new HashSet<int>());
                    }

                    _productweight[Convert.ToDouble(items[1])].Add(newElement.GetID);
                    break;

                case "Clothes":
                    // char size = Convert.ToChar(items[3]);
                    // string material = items[4];

                    if (_productSize.ContainsKey(Convert.ToChar(items[0])) == false)
                    {
                        _productSize.Add(Convert.ToChar(items[0]), new HashSet<int>());
                    }

                    _productSize[Convert.ToChar(items[0])].Add(newElement.GetID);

                    if (_productMaterial.ContainsKey(items[1]) == false)
                    {
                        _productMaterial.Add(items[1], new HashSet<int>());
                    }

                    _productMaterial[items[1]].Add(newElement.GetID);
                    break;

                case "Laptop":
                    // int ram = Convert.ToInt32(items[4]);

                    if (_productRAM.ContainsKey(Convert.ToInt32(items[1])) == false)
                    {
                        _productRAM.Add(Convert.ToInt32(items[1]), new HashSet<int>());
                    }

                    _productRAM[Convert.ToInt32(items[1])].Add(newElement.GetID);
                    break;
            }

            if (_productCost.ContainsKey(newElement.GetCost) == false)
            {
                _productCost.Add(newElement.GetCost, new HashSet<int>());
            }

            _productCost[newElement.GetCost].Add(newElement.GetID);
            _productID.Add(newElement.GetID, newElement);
        }

        public void DeleteProduct(int id) 
        {
            string[] items = _productID[id].GetField();

            switch (Convert.ToString(_productID[id].GetType().Name))
            {
                case "Greens":
                    _productkkal[Convert.ToInt32(items[0])].Remove(id);
                    _productweight[Convert.ToDouble(items[1])].Remove(id);
                    break;

                case "Clothes":
                    _productSize[Convert.ToChar(items[0])].Remove(id);
                    _productMaterial[items[1]].Remove(id);
                    break;

                case "Laptop":
                    _productRAM[Convert.ToInt32(items[1])].Remove(id);
                    break;
            }

            _productID.Remove(id);
        } 
    }
}