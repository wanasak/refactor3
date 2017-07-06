# Refractoring
using variable to write understandable code
```
// BAD CODE
// if ((_Qty > 50) || (_Qty * _Price) > 500)
//     qtyDiscount = 0.1;
// else if ((_Qty > 25) || (_Qty * _Price) > 100)
//     qtyDiscount = 0.07;
// else if ((_Qty >= 10) || (_Qty * _Price) > 50)
//     qtyDiscount = 0.05;

// Refractor
bool over50Products = (_Qty > 50) || (_Qty * _Price) > 500;
bool over25Products = (_Qty > 25) || (_Qty * _Price) > 100;
bool over10Products = (_Qty > 10) || (_Qty * _Price) > 50;

if (over50Products)
    qtyDiscount = 0.1;
else if (over25Products)
    qtyDiscount = 0.07;
else if (over10Products)
    qtyDiscount = 0.05;

```

### Bad code - Don't assign many values to the temp
```
double temp = totalCost / numberOfProducts;
temp = temp + shipping;
temp = temp - discount;
```

### Bad code - Don't assign values to parameters
```
public double GetTotalPrice(int qty, double price, double discount)
{
    price = price * qty;
    return price - discount;
}
```
