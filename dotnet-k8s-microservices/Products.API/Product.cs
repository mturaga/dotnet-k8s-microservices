using System;

namespace Products.API
{
    [Serializable]
    public class Product
    {
        public string Id { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }
    }
}
