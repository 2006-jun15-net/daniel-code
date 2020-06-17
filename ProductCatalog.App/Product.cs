namespace ProductCatalog.App
{
    
    class Product
    {
        public double Price { get; set; }

        public string Color { get; set; }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}