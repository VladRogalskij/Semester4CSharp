using System;

namespace Lab1
{
    class Product
    {
        private string _name;
        private float _price;
        private int _quantity;
        private DateTime _lastUpdated;

        public Product(string name, float price, int quantity)
        {
            if (name.Length <= 0)
            {
                throw new ArgumentException("Name can't be empty");
            }
            if (price < 0)
            {
                throw new ArgumentException("Price must be greater than zero");
            }
            if (quantity < 0)
            {
                throw new ArgumentException("Quantity can't be less than zero");
            }

            _name = name;
            _price = price;
            _quantity = quantity; ;

            UpdateLastUpdated();
        }


        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 0)
                {
                    _name = value;
                    UpdateLastUpdated();
                }
                else
                {
                    throw new ArgumentException("Name can't be empty");
                }
            }
        }

        public float Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                    UpdateLastUpdated();
                }
                else
                {
                    throw new ArgumentException("Price must be greater than zero");
                }
            }
        }

        public int Quantity
        {
            get { return _quantity; }
        }
        public float TotalValue
        {
            get { return _price * _quantity; }
        }
        public DateTime LastUpdated
        {
            get { return _lastUpdated; }
        }



        private void UpdateLastUpdated()
        {
            _lastUpdated = DateTime.Now;
        }
        public void Restock(int amount)
        {
            if (amount > 0)
            {
                _quantity += amount;
                UpdateLastUpdated();
            }
            else
            {
                throw new ArgumentException("Quantity to restock must be greater than zero");
            }

        }
        public void Sell(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Can't sell non-positive quantity of goods");
            }
            if (_quantity < amount)
            {
                throw new ArgumentException("Insufficient quantity of goods in stock");
            }

            _quantity -= amount;
            UpdateLastUpdated();
        }
        public string GetInfo()
        {
            return ($"Товар: {_name}, Ціна: {_price} грн, Кількість: {_quantity}," +
                    $" Загальна вартість: {TotalValue} грн, Останнє оновлення: {_lastUpdated}");
        }
    }
}
