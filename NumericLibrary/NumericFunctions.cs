namespace NumericLibrary
{
    public class NumericFunctions

    {
        public int Add (int x, int y)
        {
            return x + y;
        }

    }

    public class User
    {
        public string GetDiscount(int Age)
        {
            if (Age > 60)
                return "Discount is 60%";
            else if (Age >= 40 && Age <= 60)
                return "Discount is 40%";
            else
                return "No Discount";
        }

    }
}