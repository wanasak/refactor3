# Refractoring
using variable to write understandable code

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
