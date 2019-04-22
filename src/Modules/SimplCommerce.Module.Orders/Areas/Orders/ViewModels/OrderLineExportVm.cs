﻿namespace SimplCommerce.Module.Orders.Areas.Orders.ViewModels
{
    public  class OrderLineExportVm : OrderExportVm
    {
        public long OrderLineId { get; set; }

        public long ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductImage { get; set; }

        public decimal ProductPrice { get; set; }

        public int OrderLineQuantity { get; set; }

        public int OrderLineShippedQuantity { get; set; }

        public decimal OrderLineTaxAmount { get; set; }

        public decimal OrderLineTaxPercent { get; set; }

        public decimal OrderLineDiscountAmount { get; set; }

        public decimal OrderLineTotal => OrderLineQuantity * ProductPrice;

        public decimal OrderLineRowTotal => OrderLineTotal + OrderLineTaxAmount - OrderLineDiscountAmount;

        public string OrderLineTaxAmountString => OrderLineTaxAmount.ToString("C0");

        public string OrderLineProductPriceString => ProductPrice.ToString("C0");

        public string OrderLineDiscountAmountString => OrderLineDiscountAmount.ToString("C0");

        public string OrderLineTotalString => OrderLineTotal.ToString("C0");

        public string OrderLineRowTotalString => OrderLineRowTotal.ToString("C0");
    }
}