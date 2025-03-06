using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Assesment2
{
public interface IDiscountStrategy
    {
        double ApplyDiscount(double totalAmount);
    }
    public class NoDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double totalAmount) => totalAmount;
    }

    public class PercentageDiscount : IDiscountStrategy
    {
        private readonly double _percentage;
        public PercentageDiscount(double percentage) => _percentage = percentage;

        public double ApplyDiscount(double totalAmount) => totalAmount - (totalAmount * _percentage / 100);
    }

    public class FixedAmountDiscount : IDiscountStrategy
    {
        private readonly double _discountAmount;
        public FixedAmountDiscount(double discountAmount) => _discountAmount = discountAmount;

        public double ApplyDiscount(double totalAmount) => Math.Max(0, totalAmount - _discountAmount);
    }
    public class ShoppingCart
    {
        private IDiscountStrategy _discountStrategy;

        public ShoppingCart(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double CalculateTotal(double totalAmount)
        {
            return _discountStrategy.ApplyDiscount(totalAmount);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter total amount:");
            double totalAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose Discount Type: 1 - No Discount, 2 - 10% Discount, 3 - $50 Off");
            int choice = Convert.ToInt32(Console.ReadLine());

            IDiscountStrategy discountStrategy = choice switch
            {
                1 => new NoDiscount(),
                2 => new PercentageDiscount(10),
                3 => new FixedAmountDiscount(50),
                _ => new NoDiscount()
            };

            ShoppingCart cart = new ShoppingCart(discountStrategy);
            double finalAmount = cart.CalculateTotal(totalAmount);

            Console.WriteLine($"Final Amount after Discount: ${finalAmount}");
        }
    }

}