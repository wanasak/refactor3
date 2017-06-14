namespace refractor3_demo
{
    public class Product
    {
        private string _Name = string.Empty;
        private double _Price = 0;
        private double _ShippingCost = 0;
        private int _Qty = 0;

        public string GetName()
        {
            return _Name;
        }
        public double GetPrice()
        {
            return _Price;
        }
        public double GetShippingCost()
        {
            return _ShippingCost;
        }
        public int GetQty()
        {
            return _Qty;
        }

        public Product(string name, double price, double shippingCost, int qty)
        {
            _Name = name;
            _Price = price;
            _ShippingCost = shippingCost;
            _Qty = qty;
        }

        public double GetTotalCost()
        {
            double qtyDiscount = 0;

            bool over50Products = (_Qty > 50) || (_Qty * _Price) > 500;
            bool over25Products = (_Qty > 25) || (_Qty * _Price) > 100;
            bool over10Products = (_Qty > 10) || (_Qty * _Price) > 50;

            if (over50Products)
                qtyDiscount = 0.1;
            else if (over25Products)
                qtyDiscount = 0.07;
            else if (over10Products)
                qtyDiscount = 0.05;

            // BAD CODE
            // if ((_Qty > 50) || (_Qty * _Price) > 500)
            //     qtyDiscount = 0.1;
            // else if ((_Qty > 25) || (_Qty * _Price) > 100)
            //     qtyDiscount = 0.07;
            // else if ((_Qty >= 10) || (_Qty * _Price) > 50)
            //     qtyDiscount = 0.05;
            // END BAD CODE

            double discount = ((_Qty - 1) * qtyDiscount) * _Price;
            return (_Qty * _Price) + (_ShippingCost * _Qty) - discount;
        }
    }
}
