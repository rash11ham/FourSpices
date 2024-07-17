using FourSpices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourSpices.Utility
{
    public static class SD
    {
        public const string DefaultFoodImage = "default_food.png";
        public const string ManagerUser = "Manager";
        public const string KitchenUser = "Kitchen";
        public const string FrontDeskUser = "FrontDesk";
        public const string CustomerUser = "Customer";
        public const string ssCartCount = "ssCartCount";
		public const string ssCouponCode = "ssCouponCode";

		public const string StatusSubmitted = "Submitted";
		public const string StatusInProcess = "Being Prepared";
		public const string StatusReady = "Ready for Pickup";
		public const string StatusCompleted = "Complete";
		public const string StatusCancelled = "Cancelled";

		public const string PaymentStatusPending = "Pending";
		public const string PaymentStatusApproved = "Approved";
		public const string PaymentStatusRejected = "Rejected";



		public static string ConvertToRawHtml(string source)
		{
			char[] array = new char[source.Length];
			int arrayIndex = 0;
			bool inside = false;

			for (int i = 0; i < source.Length; i++)
			{
				char let = source[i];
				if (let == '<')
				{
					inside = true;
					continue;
				}
				if (let == '>')
				{
					inside = false;
					continue;
				}
				if (!inside)
				{
					array[arrayIndex] = let;
					arrayIndex++;
				}
			}
			return new string(array, 0, arrayIndex);
		}

		//Return discounted price 
		public static double DiscountedPrice(Coupon couponFromDb, double OriginalOrderTotal)
        {
            if (couponFromDb == null)
            {
				return OriginalOrderTotal;
            }
            else
            {
				//if the price is not eligible for the discount
				if(couponFromDb.MinimumAmount > OriginalOrderTotal)
                {
					return OriginalOrderTotal;
                }
                else
                {
                    //everthing is matching for the discount to be applied
                    if (Convert.ToInt32(couponFromDb.CouponType) == (int)Coupon.ECouponType.Dollar)
                    {
						return Math.Round(OriginalOrderTotal - couponFromDb.Discount, 2);
                    }
					if (Convert.ToInt32(couponFromDb.CouponType) == (int)Coupon.ECouponType.Percent)
					{
						return Math.Round(OriginalOrderTotal - (OriginalOrderTotal * couponFromDb.Discount/100), 2);
					}

				}
            }
			return OriginalOrderTotal;
        }
	}
}
