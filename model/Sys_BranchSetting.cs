namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchSetting
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool OrderConfirm_Gift { get; set; }

        public bool OrderConfirm_PriceLessInPrice { get; set; }

        public int PurchaseCollect_DefaultPurchaser { get; set; }

        public bool AutoAuditing { get; set; }

        public bool HideSaleNum { get; set; }

        public bool HidePurchaseZero { get; set; }

        public bool ReturnOrderInStoreForCheck { get; set; }

        public int AccountPeriodLimitOrder { get; set; }

        public bool IsCustomMessageSignature { get; set; }

        public bool GoodsCategory { get; set; }

        public bool GoodsDetailDisplayInventory { get; set; }

        public bool GoodsListRandom { get; set; }

        public bool Canvass { get; set; }

        public bool AddThirdPartyId { get; set; }

        public bool IsShowGrossProfit { get; set; }

        public bool IsAccountVialid { get; set; }

        public bool GroupCheckedAllOrder { get; set; }

        public bool IsCustomerDetails { get; set; }

        public bool? BranchSite { get; set; }

        public bool SingleStroe { get; set; }

        public bool? CustomerNeedApprove { get; set; }

        public bool IsRepeatGoodsSN { get; set; }

        public bool IsHideGoodsEvaluate { get; set; }

        public bool IsThird { get; set; }

        public int CustomerManageId { get; set; }

        public bool? LimitOrderForNoStock { get; set; }

        public bool IsDefaultStore { get; set; }

        public int? LimitWebOrderForNoVirtualStock { get; set; }

        public bool? FinanceAudit { get; set; }

        public bool? OnlyMallOrder { get; set; }

        [StringLength(200)]
        public string BranchIdOfHideMoney { get; set; }

        public bool? InPriceHigherThanPrice { get; set; }

        public bool? OrderRequiredMemo { get; set; }

        public bool? ModifyGoodsUnit { get; set; }

        public bool? IsShowInvalidPurchaser { get; set; }

        public bool? IsShowGoodsSaleCount { get; set; }

        public bool? OrderConfirm_ReturnDirectDelivery { get; set; }

        public bool? PurchaseCollectByStore { get; set; }

        public bool? StoreOrderUsePrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? OrderDefaultTaxRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? PurchaseDefaultTaxRate { get; set; }

        public bool SpecifySupplier { get; set; }

        public bool ShowVirtualSales { get; set; }

        public bool? OrderToDistribution { get; set; }

        public bool StoreOrderSpecifySalesman { get; set; }

        public bool StoreOrderSpicifyInventory { get; set; }

        public bool PurchaseByOwin { get; set; }

        public bool ExportByAdmin { get; set; }

        public bool StocktakingAudit { get; set; }

        public bool? HideGrossForSale { get; set; }

        public int? StoreOrderPriceStrategy { get; set; }

        public bool? OrderInnerToDistribution { get; set; }

        public bool? IsShowCustomerCounterNeedExportQuotation { get; set; }

        public bool? SupplierHideForSales { get; set; }

        public bool? CustomerHideForBuyer { get; set; }
    }
}
