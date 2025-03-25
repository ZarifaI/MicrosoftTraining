// See https://aka.ms/new-console-template for more information

/* 
The code calculates the total price of items after applying 
discounts. It initializes variables for the total, minimum spend,
item prices, and discounts. The GetDiscountedPrice method 
calculates the discounted price of an item, TotalMeetsMinimum 
checks if the total meets the minimum spend, and FormatDecimal 
formats the total to two decimal places. A loop calculates the 
total price, applying the discount to each item. If the total 
exceeds the minimum spend, $5.00 is subtracted. Finally, the 
formatted total is displayed.
*/


double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

total -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}