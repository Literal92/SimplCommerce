﻿using System.Collections.Generic;

namespace SimplCommerce.Module.ShoppingCart.Areas.ShoppingCart.ViewModels
{
    public class CartVm
    {
        public long Id { get; set; }

        public string CouponCode { get; set; }

        public decimal SubTotal { get; set; }

        public string SubTotalString { get { return SubTotal.ToString("C0"); } }

        public decimal Discount { get; set; }

        public string DiscountString { get { return Discount.ToString("C0"); } }

        public string CouponValidationErrorMessage { get; set; }

        public bool IsProductPriceIncludeTax { get; set; }

        public decimal? TaxAmount { get; set; }

        public string OrderNote { get; set; }

        public string TaxAmountString
        {
            get
            {
                return TaxAmount.HasValue ? TaxAmount.Value.ToString("C0") : "-";
            }
        }

        public decimal? ShippingAmount { get; set; }

        public string ShippingAmountString
        {
            get { return ShippingAmount.HasValue ? ShippingAmount.Value.ToString("C0") : "-"; }
        }

        public decimal SubTotalWithDiscount
        {
            get
            {
                return SubTotal - Discount;
            }
        }

        public decimal SubTotalWithDiscountWithoutTax
        {
            get
            {
                if (IsProductPriceIncludeTax)
                {
                    return SubTotalWithDiscount - TaxAmount ?? 0;
                }

                return SubTotalWithDiscount;
            }
        }

        public decimal OrderTotal
        {
            get
            {
                if (IsProductPriceIncludeTax)
                {
                    return SubTotal + (ShippingAmount ?? 0) - Discount;
                }

                return SubTotal + (TaxAmount ?? 0) + (ShippingAmount ?? 0) - Discount;
            }
        }

        public string OrderTotalString { get { return OrderTotal.ToString("C0"); } }

        public IList<CartItemVm> Items { get; set; } = new List<CartItemVm>();

        public bool IsValid
        {
            get
            {
                foreach(var item in Items)
                {
                    if (!item.IsProductAvailabeToOrder)
                    {
                        return false;
                    }

                    if(item.ProductStockTrackingIsEnabled && item.ProductStockQuantity < item.Quantity)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
