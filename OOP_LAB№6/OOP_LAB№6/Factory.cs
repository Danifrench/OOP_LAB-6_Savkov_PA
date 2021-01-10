using System;

namespace OOP_LAB_6
{
    class Factory
    {
        public Product createProduct(string field)
        {
            string[] items = field.Split();
            Product newProduct = null;

            switch(items[0])
            {
                case "Greens":
                    newProduct = new Greens(Convert.ToInt32(items[2]), items[1],
                        Convert.ToDouble(items[3]), Convert.ToInt32(items[4]));
                    break;

                case "Clothes":
                    newProduct = new Clothes(Convert.ToInt32(items[2]), items[1],
                        Convert.ToChar(items[3]), items[4]);
                    break;

                case "Laptop":
                    newProduct = new Laptop(Convert.ToInt32(items[2]), items[1],
                        items[3], Convert.ToInt32(items[4]), Convert.ToInt32(items[5]));
                    break;
            }

            return newProduct;
        }
    }
}