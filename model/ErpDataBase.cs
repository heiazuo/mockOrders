using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ErpDataFactory
{
    public partial class ErpDataBase : DbContext
    {
        public ErpDataBase()
            : base("name=ErpDataBase")
        {
        }

        public virtual DbSet<AttachedFil> AttachedFil { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<BusinessChanceInfo> BusinessChanceInfo { get; set; }
        public virtual DbSet<BusinessFollowRecord> BusinessFollowRecord { get; set; }
        public virtual DbSet<CanvassAgreement> CanvassAgreement { get; set; }
        public virtual DbSet<CatagoryParams> CatagoryParams { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<CrawlerRequest> CrawlerRequest { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerBalanceLog> CustomerBalanceLog { get; set; }
        public virtual DbSet<CustomerCategory> CustomerCategory { get; set; }
        public virtual DbSet<CustomerInvoiceInfo> CustomerInvoiceInfo { get; set; }
        public virtual DbSet<CustomerLog> CustomerLog { get; set; }
        public virtual DbSet<CustomerPreReceiveMoney> CustomerPreReceiveMoney { get; set; }
        public virtual DbSet<CustomerSetting> CustomerSetting { get; set; }
        public virtual DbSet<DefaultStore> DefaultStore { get; set; }
        public virtual DbSet<DeliveryLine> DeliveryLine { get; set; }
        public virtual DbSet<DeliveryLineCustomer> DeliveryLineCustomer { get; set; }
        public virtual DbSet<DeliveryLineMember> DeliveryLineMember { get; set; }
        public virtual DbSet<DellOrderGoodsPo> DellOrderGoodsPo { get; set; }
        public virtual DbSet<Dept> Dept { get; set; }
        public virtual DbSet<DeptTemp> DeptTemp { get; set; }
        public virtual DbSet<DistributionCustomerInvoice> DistributionCustomerInvoice { get; set; }
        public virtual DbSet<DistributionCustomerInvoiceDetail> DistributionCustomerInvoiceDetail { get; set; }
        public virtual DbSet<DistributionCustomerReceiveMoney> DistributionCustomerReceiveMoney { get; set; }
        public virtual DbSet<DistributionCustomerReceiveMoneyDetail> DistributionCustomerReceiveMoneyDetail { get; set; }
        public virtual DbSet<DistributionInvoice> DistributionInvoice { get; set; }
        public virtual DbSet<DistributionInvoiceDetail> DistributionInvoiceDetail { get; set; }
        public virtual DbSet<DistributionOperation> DistributionOperation { get; set; }
        public virtual DbSet<DistributionOrderState> DistributionOrderState { get; set; }
        public virtual DbSet<DistributionPay> DistributionPay { get; set; }
        public virtual DbSet<DistributionPayDetail> DistributionPayDetail { get; set; }
        public virtual DbSet<DistributionReceiveInvoice> DistributionReceiveInvoice { get; set; }
        public virtual DbSet<DistributionReceiveInvoiceDetail> DistributionReceiveInvoiceDetail { get; set; }
        public virtual DbSet<DistributionReceiveMoney> DistributionReceiveMoney { get; set; }
        public virtual DbSet<DistributionReceiveMoneyDetail> DistributionReceiveMoneyDetail { get; set; }
        public virtual DbSet<DOStatement> DOStatement { get; set; }
        public virtual DbSet<DOStatementDetail> DOStatementDetail { get; set; }
        public virtual DbSet<DPStatement> DPStatement { get; set; }
        public virtual DbSet<DPStatementDetail> DPStatementDetail { get; set; }
        public virtual DbSet<EmailInvoiceSetting> EmailInvoiceSetting { get; set; }
        public virtual DbSet<EmailSetting> EmailSetting { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentLog> EquipmentLog { get; set; }
        public virtual DbSet<FinanceAudit> FinanceAudit { get; set; }
        public virtual DbSet<FinanceRecord> FinanceRecord { get; set; }
        public virtual DbSet<FinanceSubject> FinanceSubject { get; set; }
        public virtual DbSet<Franchisee> Franchisee { get; set; }
        public virtual DbSet<Gift> Gift { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<GoodsCaptcha> GoodsCaptcha { get; set; }
        public virtual DbSet<GoodsCategory> GoodsCategory { get; set; }
        public virtual DbSet<GoodsComment> GoodsComment { get; set; }
        public virtual DbSet<GoodsDefaultInfo> GoodsDefaultInfo { get; set; }
        public virtual DbSet<GoodsExtensions> GoodsExtensions { get; set; }
        public virtual DbSet<GoodsGroupDetail> GoodsGroupDetail { get; set; }
        public virtual DbSet<GoodsLog> GoodsLog { get; set; }
        public virtual DbSet<GoodsModel> GoodsModel { get; set; }
        public virtual DbSet<GoodsModelValue> GoodsModelValue { get; set; }
        public virtual DbSet<GoodsPackage> GoodsPackage { get; set; }
        public virtual DbSet<GoodsPackageLog> GoodsPackageLog { get; set; }
        public virtual DbSet<GoodsParamValue> GoodsParamValue { get; set; }
        public virtual DbSet<GoodsPhoto> GoodsPhoto { get; set; }
        public virtual DbSet<GoodsPriceLog> GoodsPriceLog { get; set; }
        public virtual DbSet<GoodsType> GoodsType { get; set; }
        public virtual DbSet<GoodsTypeParam> GoodsTypeParam { get; set; }
        public virtual DbSet<GoodsTypeParamGroup> GoodsTypeParamGroup { get; set; }
        public virtual DbSet<GoodsTypeParamOption> GoodsTypeParamOption { get; set; }
        public virtual DbSet<GoodsTypePrivateInfo> GoodsTypePrivateInfo { get; set; }
        public virtual DbSet<GoodsTypeUpdate> GoodsTypeUpdate { get; set; }
        public virtual DbSet<GroupOrderStatement> GroupOrderStatement { get; set; }
        public virtual DbSet<GroupOrderStatementDetail> GroupOrderStatementDetail { get; set; }
        public virtual DbSet<GroupPay> GroupPay { get; set; }
        public virtual DbSet<I_Analysis> I_Analysis { get; set; }
        public virtual DbSet<I_BeiJingGoods> I_BeiJingGoods { get; set; }
        public virtual DbSet<I_BeiJingGoodsMap> I_BeiJingGoodsMap { get; set; }
        public virtual DbSet<I_BeiJingProductParam> I_BeiJingProductParam { get; set; }
        public virtual DbSet<I_BeiJingZhengCaiCityList> I_BeiJingZhengCaiCityList { get; set; }
        public virtual DbSet<I_Category> I_Category { get; set; }
        public virtual DbSet<I_ChengduActivity> I_ChengduActivity { get; set; }
        public virtual DbSet<I_ChengDuActivityGoods> I_ChengDuActivityGoods { get; set; }
        public virtual DbSet<I_ChengDuCategoryExt> I_ChengDuCategoryExt { get; set; }
        public virtual DbSet<I_ChengDuCategoryParam> I_ChengDuCategoryParam { get; set; }
        public virtual DbSet<I_ChengDuParamValue> I_ChengDuParamValue { get; set; }
        public virtual DbSet<I_EfficientGoods> I_EfficientGoods { get; set; }
        public virtual DbSet<I_EGoods> I_EGoods { get; set; }
        public virtual DbSet<I_ErrLog> I_ErrLog { get; set; }
        public virtual DbSet<I_Goods> I_Goods { get; set; }
        public virtual DbSet<I_GoodsExtention> I_GoodsExtention { get; set; }
        public virtual DbSet<I_GoodsLog> I_GoodsLog { get; set; }
        public virtual DbSet<I_GoodsMap> I_GoodsMap { get; set; }
        public virtual DbSet<I_GoodsOperateLog> I_GoodsOperateLog { get; set; }
        public virtual DbSet<I_GoodsPart> I_GoodsPart { get; set; }
        public virtual DbSet<I_Message> I_Message { get; set; }
        public virtual DbSet<I_OrderDetail> I_OrderDetail { get; set; }
        public virtual DbSet<I_OrderExtension> I_OrderExtension { get; set; }
        public virtual DbSet<I_Orders> I_Orders { get; set; }
        public virtual DbSet<I_Plat> I_Plat { get; set; }
        public virtual DbSet<I_Product> I_Product { get; set; }
        public virtual DbSet<I_ProductsForZGLY> I_ProductsForZGLY { get; set; }
        public virtual DbSet<I_ProductsMapForZGLY> I_ProductsMapForZGLY { get; set; }
        public virtual DbSet<I_Project> I_Project { get; set; }
        public virtual DbSet<I_ProjectExtention> I_ProjectExtention { get; set; }
        public virtual DbSet<I_Provider> I_Provider { get; set; }
        public virtual DbSet<IContract> IContract { get; set; }
        public virtual DbSet<IContractMY> IContractMY { get; set; }
        public virtual DbSet<IntroductionInvestment> IntroductionInvestment { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<InventoryApply> InventoryApply { get; set; }
        public virtual DbSet<InventoryLog> InventoryLog { get; set; }
        public virtual DbSet<InventoryModifyAC> InventoryModifyAC { get; set; }
        public virtual DbSet<InventoryStock> InventoryStock { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceLog> InvoiceLog { get; set; }
        public virtual DbSet<InvoiceRequire> InvoiceRequire { get; set; }
        public virtual DbSet<InvoiceRequireDetail> InvoiceRequireDetail { get; set; }
        public virtual DbSet<IOrderContract> IOrderContract { get; set; }
        public virtual DbSet<KuaiPuOrder> KuaiPuOrder { get; set; }
        public virtual DbSet<KuaiPuOrderLog> KuaiPuOrderLog { get; set; }
        public virtual DbSet<LoginedIdentity> LoginedIdentity { get; set; }
        public virtual DbSet<Logistics> Logistics { get; set; }
        public virtual DbSet<LogisticsCompany> LogisticsCompany { get; set; }
        public virtual DbSet<LogisticsDetail> LogisticsDetail { get; set; }
        public virtual DbSet<LogisticsInfomation> LogisticsInfomation { get; set; }
        public virtual DbSet<LogisticsSubscribeLog> LogisticsSubscribeLog { get; set; }
        public virtual DbSet<MajorParamsDetail> MajorParamsDetail { get; set; }
        public virtual DbSet<MallFloatAd> MallFloatAd { get; set; }
        public virtual DbSet<MallSideBar> MallSideBar { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<MemberAddress> MemberAddress { get; set; }
        public virtual DbSet<MemberAddressTemp> MemberAddressTemp { get; set; }
        public virtual DbSet<MemberApplyDept> MemberApplyDept { get; set; }
        public virtual DbSet<MemberAuth> MemberAuth { get; set; }
        public virtual DbSet<MemberCart> MemberCart { get; set; }
        public virtual DbSet<MemberFav> MemberFav { get; set; }
        public virtual DbSet<MemberInvoiceInfo> MemberInvoiceInfo { get; set; }
        public virtual DbSet<MemberLog> MemberLog { get; set; }
        public virtual DbSet<MemberOrderDept> MemberOrderDept { get; set; }
        public virtual DbSet<MemberPoint> MemberPoint { get; set; }
        public virtual DbSet<MemberRole> MemberRole { get; set; }
        public virtual DbSet<MemberTemp> MemberTemp { get; set; }
        public virtual DbSet<ModifyAC> ModifyAC { get; set; }
        public virtual DbSet<NeedToPurchase> NeedToPurchase { get; set; }
        public virtual DbSet<NeedToPurchaseDetail> NeedToPurchaseDetail { get; set; }
        public virtual DbSet<NeedToPurchaseOrder> NeedToPurchaseOrder { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsType> NewsType { get; set; }
        public virtual DbSet<Notify_Msg> Notify_Msg { get; set; }
        public virtual DbSet<Notify_Setting> Notify_Setting { get; set; }
        public virtual DbSet<Notify_SmsSign> Notify_SmsSign { get; set; }
        public virtual DbSet<Notify_Templet> Notify_Templet { get; set; }
        public virtual DbSet<Open_Plat> Open_Plat { get; set; }
        public virtual DbSet<Open_Project> Open_Project { get; set; }
        public virtual DbSet<Open_Setting> Open_Setting { get; set; }
        public virtual DbSet<Open_SyncData> Open_SyncData { get; set; }
        public virtual DbSet<OrderAfterSale> OrderAfterSale { get; set; }
        public virtual DbSet<OrderAfterSaleFlow> OrderAfterSaleFlow { get; set; }
        public virtual DbSet<OrderAfterSalePhoto> OrderAfterSalePhoto { get; set; }
        public virtual DbSet<OrderArchive> OrderArchive { get; set; }
        public virtual DbSet<OrderBox> OrderBox { get; set; }
        public virtual DbSet<OrderCheckoutLog> OrderCheckoutLog { get; set; }
        public virtual DbSet<OrderDelivery> OrderDelivery { get; set; }
        public virtual DbSet<OrderDeliveryBox> OrderDeliveryBox { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<OrderDistribution> OrderDistribution { get; set; }
        public virtual DbSet<OrderDistributionDetail> OrderDistributionDetail { get; set; }
        public virtual DbSet<OrderGoodsComments> OrderGoodsComments { get; set; }
        public virtual DbSet<OrderInvoiceInfo> OrderInvoiceInfo { get; set; }
        public virtual DbSet<OrderLog> OrderLog { get; set; }
        public virtual DbSet<OrderModify> OrderModify { get; set; }
        public virtual DbSet<OrderModifyAC> OrderModifyAC { get; set; }
        public virtual DbSet<OrderPicking> OrderPicking { get; set; }
        public virtual DbSet<OrderPickingLog> OrderPickingLog { get; set; }
        public virtual DbSet<OrderReceiveMoney> OrderReceiveMoney { get; set; }
        public virtual DbSet<OrderReceiveMoneyDetail> OrderReceiveMoneyDetail { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrderSourceExt> OrderSourceExt { get; set; }
        public virtual DbSet<OrderStatement> OrderStatement { get; set; }
        public virtual DbSet<OrderStatementCrossInvoice> OrderStatementCrossInvoice { get; set; }
        public virtual DbSet<OrderStatementDetail> OrderStatementDetail { get; set; }
        public virtual DbSet<OrderStatementLog> OrderStatementLog { get; set; }
        public virtual DbSet<PageView> PageView { get; set; }
        public virtual DbSet<PageView_copy1> PageView_copy1 { get; set; }
        public virtual DbSet<ParamGather> ParamGather { get; set; }
        public virtual DbSet<PayLog> PayLog { get; set; }
        public virtual DbSet<PlatformInfo> PlatformInfo { get; set; }
        public virtual DbSet<PreGoodsPhoto> PreGoodsPhoto { get; set; }
        public virtual DbSet<PreInvoice> PreInvoice { get; set; }
        public virtual DbSet<PrintTempletDic> PrintTempletDic { get; set; }
        public virtual DbSet<Product_GoodsType> Product_GoodsType { get; set; }
        public virtual DbSet<Product_Info> Product_Info { get; set; }
        public virtual DbSet<ProGoodsType> ProGoodsType { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<PurchaseDetail> PurchaseDetail { get; set; }
        public virtual DbSet<PurchaseLog> PurchaseLog { get; set; }
        public virtual DbSet<PurchaseMerge> PurchaseMerge { get; set; }
        public virtual DbSet<PurchaseModify> PurchaseModify { get; set; }
        public virtual DbSet<PurchasePay> PurchasePay { get; set; }
        public virtual DbSet<PurchasePayDetail> PurchasePayDetail { get; set; }
        public virtual DbSet<PurchasePayLog> PurchasePayLog { get; set; }
        public virtual DbSet<PurchaseQuote> PurchaseQuote { get; set; }
        public virtual DbSet<PurchaseQuoteDetail> PurchaseQuoteDetail { get; set; }
        public virtual DbSet<PurchaseStatement> PurchaseStatement { get; set; }
        public virtual DbSet<PurchaseStatementDetail> PurchaseStatementDetail { get; set; }
        public virtual DbSet<PurchaseStatementLog> PurchaseStatementLog { get; set; }
        public virtual DbSet<Quotation> Quotation { get; set; }
        public virtual DbSet<RegisterProtocol> RegisterProtocol { get; set; }
        public virtual DbSet<SaleReportFakeData> SaleReportFakeData { get; set; }
        public virtual DbSet<SalesPlan> SalesPlan { get; set; }
        public virtual DbSet<SalesStoreMap> SalesStoreMap { get; set; }
        public virtual DbSet<ServiceOrder> ServiceOrder { get; set; }
        public virtual DbSet<ServiceOrderDelivery> ServiceOrderDelivery { get; set; }
        public virtual DbSet<ServiceOrderDeliveryDetail> ServiceOrderDeliveryDetail { get; set; }
        public virtual DbSet<ServiceOrderDetail> ServiceOrderDetail { get; set; }
        public virtual DbSet<ServiceOrderItem> ServiceOrderItem { get; set; }
        public virtual DbSet<ServiceOrderLog> ServiceOrderLog { get; set; }
        public virtual DbSet<ServiceOrderStaff> ServiceOrderStaff { get; set; }
        public virtual DbSet<SiChuanLog> SiChuanLog { get; set; }
        public virtual DbSet<SourceGoods> SourceGoods { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<StoreZone> StoreZone { get; set; }
        public virtual DbSet<Strategy_GrossProfit> Strategy_GrossProfit { get; set; }
        public virtual DbSet<StrategyItem> StrategyItem { get; set; }
        public virtual DbSet<StrategyOrigin> StrategyOrigin { get; set; }
        public virtual DbSet<StrategyRange> StrategyRange { get; set; }
        public virtual DbSet<StrategyRule> StrategyRule { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierContacts> SupplierContacts { get; set; }
        public virtual DbSet<SupplierDepartment> SupplierDepartment { get; set; }
        public virtual DbSet<SupplierInvoice> SupplierInvoice { get; set; }
        public virtual DbSet<SupplierInvoiceContacts> SupplierInvoiceContacts { get; set; }
        public virtual DbSet<SupplierInvoiceDetails> SupplierInvoiceDetails { get; set; }
        public virtual DbSet<SupplierLog> SupplierLog { get; set; }
        public virtual DbSet<SupplierPrepayment> SupplierPrepayment { get; set; }
        public virtual DbSet<SupplierSettleAccounts> SupplierSettleAccounts { get; set; }
        public virtual DbSet<SurveysFeedBack> SurveysFeedBack { get; set; }
        public virtual DbSet<Sys_Agent> Sys_Agent { get; set; }
        public virtual DbSet<Sys_Agent_Users> Sys_Agent_Users { get; set; }
        public virtual DbSet<Sys_Approve> Sys_Approve { get; set; }
        public virtual DbSet<Sys_Authorize> Sys_Authorize { get; set; }
        public virtual DbSet<Sys_Branch> Sys_Branch { get; set; }
        public virtual DbSet<Sys_Branch_CSS> Sys_Branch_CSS { get; set; }
        public virtual DbSet<Sys_BranchActivity> Sys_BranchActivity { get; set; }
        public virtual DbSet<Sys_BranchActivityContent> Sys_BranchActivityContent { get; set; }
        public virtual DbSet<Sys_BranchActivityGift> Sys_BranchActivityGift { get; set; }
        public virtual DbSet<Sys_BranchActivityRange> Sys_BranchActivityRange { get; set; }
        public virtual DbSet<Sys_BranchActivityRule> Sys_BranchActivityRule { get; set; }
        public virtual DbSet<Sys_BranchAds> Sys_BranchAds { get; set; }
        public virtual DbSet<Sys_BranchArea> Sys_BranchArea { get; set; }
        public virtual DbSet<Sys_BranchAreaDetail> Sys_BranchAreaDetail { get; set; }
        public virtual DbSet<Sys_BranchAreas> Sys_BranchAreas { get; set; }
        public virtual DbSet<Sys_BranchAuth> Sys_BranchAuth { get; set; }
        public virtual DbSet<Sys_BranchBankInfo> Sys_BranchBankInfo { get; set; }
        public virtual DbSet<Sys_BranchEmailSetting> Sys_BranchEmailSetting { get; set; }
        public virtual DbSet<Sys_BranchERPSetting> Sys_BranchERPSetting { get; set; }
        public virtual DbSet<Sys_BranchFloor> Sys_BranchFloor { get; set; }
        public virtual DbSet<Sys_BranchFloorBrandingWall> Sys_BranchFloorBrandingWall { get; set; }
        public virtual DbSet<Sys_BranchFloorBrandingWallPhotos> Sys_BranchFloorBrandingWallPhotos { get; set; }
        public virtual DbSet<Sys_BranchFloorDisplayType> Sys_BranchFloorDisplayType { get; set; }
        public virtual DbSet<Sys_BranchGoodsType> Sys_BranchGoodsType { get; set; }
        public virtual DbSet<Sys_BranchHelp> Sys_BranchHelp { get; set; }
        public virtual DbSet<Sys_BranchHelpContent> Sys_BranchHelpContent { get; set; }
        public virtual DbSet<Sys_BranchHelpGroup> Sys_BranchHelpGroup { get; set; }
        public virtual DbSet<Sys_BranchHelpGroupPrivateInfo> Sys_BranchHelpGroupPrivateInfo { get; set; }
        public virtual DbSet<Sys_BranchHelpPrivateInfo> Sys_BranchHelpPrivateInfo { get; set; }
        public virtual DbSet<Sys_BranchHotWords> Sys_BranchHotWords { get; set; }
        public virtual DbSet<Sys_BranchPay> Sys_BranchPay { get; set; }
        public virtual DbSet<Sys_BranchPayment> Sys_BranchPayment { get; set; }
        public virtual DbSet<Sys_BranchSeo> Sys_BranchSeo { get; set; }
        public virtual DbSet<Sys_BranchServicePromise> Sys_BranchServicePromise { get; set; }
        public virtual DbSet<Sys_BranchServicePromiseDetail> Sys_BranchServicePromiseDetail { get; set; }
        public virtual DbSet<Sys_BranchSetting> Sys_BranchSetting { get; set; }
        public virtual DbSet<Sys_BranchSiteFooter> Sys_BranchSiteFooter { get; set; }
        public virtual DbSet<Sys_BranchSiteSetting> Sys_BranchSiteSetting { get; set; }
        public virtual DbSet<Sys_BranchSiteSolution> Sys_BranchSiteSolution { get; set; }
        public virtual DbSet<Sys_BranchTheme> Sys_BranchTheme { get; set; }
        public virtual DbSet<Sys_BranchThemeArea> Sys_BranchThemeArea { get; set; }
        public virtual DbSet<Sys_BranchThemeAreaGoodsTab> Sys_BranchThemeAreaGoodsTab { get; set; }
        public virtual DbSet<Sys_BranchThemeAreaPhoto> Sys_BranchThemeAreaPhoto { get; set; }
        public virtual DbSet<Sys_BranchThirdParty> Sys_BranchThirdParty { get; set; }
        public virtual DbSet<Sys_BranchTopMenu> Sys_BranchTopMenu { get; set; }
        public virtual DbSet<Sys_CanvassAgreement> Sys_CanvassAgreement { get; set; }
        public virtual DbSet<Sys_Car> Sys_Car { get; set; }
        public virtual DbSet<Sys_CarLog> Sys_CarLog { get; set; }
        public virtual DbSet<Sys_CarUser> Sys_CarUser { get; set; }
        public virtual DbSet<Sys_City> Sys_City { get; set; }
        public virtual DbSet<Sys_Dept> Sys_Dept { get; set; }
        public virtual DbSet<Sys_Dictionary> Sys_Dictionary { get; set; }
        public virtual DbSet<Sys_DictionaryType> Sys_DictionaryType { get; set; }
        public virtual DbSet<Sys_Distribution> Sys_Distribution { get; set; }
        public virtual DbSet<Sys_DistributionGroup> Sys_DistributionGroup { get; set; }
        public virtual DbSet<Sys_ErrorLog> Sys_ErrorLog { get; set; }
        public virtual DbSet<Sys_Group> Sys_Group { get; set; }
        public virtual DbSet<Sys_GroupBranch> Sys_GroupBranch { get; set; }
        public virtual DbSet<Sys_GroupLoginSetting> Sys_GroupLoginSetting { get; set; }
        public virtual DbSet<Sys_MapiServer> Sys_MapiServer { get; set; }
        public virtual DbSet<Sys_Permission> Sys_Permission { get; set; }
        public virtual DbSet<Sys_PermissionGroup> Sys_PermissionGroup { get; set; }
        public virtual DbSet<Sys_Price> Sys_Price { get; set; }
        public virtual DbSet<Sys_PrintSetting> Sys_PrintSetting { get; set; }
        public virtual DbSet<Sys_PrintTemplate> Sys_PrintTemplate { get; set; }
        public virtual DbSet<Sys_PrintValidate> Sys_PrintValidate { get; set; }
        public virtual DbSet<Sys_Renew> Sys_Renew { get; set; }
        public virtual DbSet<Sys_Role> Sys_Role { get; set; }
        public virtual DbSet<Sys_RolePermission> Sys_RolePermission { get; set; }
        public virtual DbSet<Sys_SiteCSS> Sys_SiteCSS { get; set; }
        public virtual DbSet<Sys_Sms> Sys_Sms { get; set; }
        public virtual DbSet<Sys_UrlLog> Sys_UrlLog { get; set; }
        public virtual DbSet<Sys_UserLog> Sys_UserLog { get; set; }
        public virtual DbSet<Sys_UserRole> Sys_UserRole { get; set; }
        public virtual DbSet<Sys_Users> Sys_Users { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<SystemManager> SystemManager { get; set; }
        public virtual DbSet<TaxCategory> TaxCategory { get; set; }
        public virtual DbSet<TaxCategoryGoodsMap> TaxCategoryGoodsMap { get; set; }
        public virtual DbSet<ThirdCategory> ThirdCategory { get; set; }
        public virtual DbSet<ThirdPartyCategory> ThirdPartyCategory { get; set; }
        public virtual DbSet<ThirdPartyGoodsCategoryMatch> ThirdPartyGoodsCategoryMatch { get; set; }
        public virtual DbSet<ThirdPartyGoodsMatch> ThirdPartyGoodsMatch { get; set; }
        public virtual DbSet<ThirdPartyLogin> ThirdPartyLogin { get; set; }
        public virtual DbSet<ThirdPartyOrder> ThirdPartyOrder { get; set; }
        public virtual DbSet<ThirdPartyOrderDetail> ThirdPartyOrderDetail { get; set; }
        public virtual DbSet<ThirdProduct> ThirdProduct { get; set; }
        public virtual DbSet<Transfer> Transfer { get; set; }
        public virtual DbSet<TransferArchive> TransferArchive { get; set; }
        public virtual DbSet<TransferBox> TransferBox { get; set; }
        public virtual DbSet<TransferDelivery> TransferDelivery { get; set; }
        public virtual DbSet<TransferDeliveryBox> TransferDeliveryBox { get; set; }
        public virtual DbSet<TransferDetail> TransferDetail { get; set; }
        public virtual DbSet<TransferLog> TransferLog { get; set; }
        public virtual DbSet<TransferPicking> TransferPicking { get; set; }
        public virtual DbSet<TransferPickingLog> TransferPickingLog { get; set; }
        public virtual DbSet<TransferReceiveMoney> TransferReceiveMoney { get; set; }
        public virtual DbSet<TransferStatement> TransferStatement { get; set; }
        public virtual DbSet<TransferStatementDetail> TransferStatementDetail { get; set; }
        public virtual DbSet<VIPApply> VIPApply { get; set; }
        public virtual DbSet<VIPApplyDetail> VIPApplyDetail { get; set; }
        public virtual DbSet<VIPApplyInvoiceInfo> VIPApplyInvoiceInfo { get; set; }
        public virtual DbSet<VIPApplyLog> VIPApplyLog { get; set; }
        public virtual DbSet<VIPApplyModify> VIPApplyModify { get; set; }
        public virtual DbSet<VIPCounter> VIPCounter { get; set; }
        public virtual DbSet<VIPCounterCustomer> VIPCounterCustomer { get; set; }
        public virtual DbSet<VIPCounterDetail> VIPCounterDetail { get; set; }
        public virtual DbSet<VIPCounterLabel> VIPCounterLabel { get; set; }
        public virtual DbSet<VipCounterLabelGoods> VipCounterLabelGoods { get; set; }
        public virtual DbSet<VIPCounterLabelRelation> VIPCounterLabelRelation { get; set; }
        public virtual DbSet<VirtualInventory> VirtualInventory { get; set; }
        public virtual DbSet<YangCaiOrderLog> YangCaiOrderLog { get; set; }
        public virtual DbSet<LogisticsSupported> LogisticsSupported { get; set; }
        public virtual DbSet<Sys_Config> Sys_Config { get; set; }
        public virtual DbSet<V_DeadLock_Process> V_DeadLock_Process { get; set; }
        public virtual DbSet<View_Customer> View_Customer { get; set; }
        public virtual DbSet<View_CustomerCounterDetail> View_CustomerCounterDetail { get; set; }
        public virtual DbSet<View_CustomerLog> View_CustomerLog { get; set; }
        public virtual DbSet<View_CustomerPreReceiveMoney> View_CustomerPreReceiveMoney { get; set; }
        public virtual DbSet<View_DeliverAchievement> View_DeliverAchievement { get; set; }
        public virtual DbSet<View_DeliveryLineCustomer> View_DeliveryLineCustomer { get; set; }
        public virtual DbSet<View_DeliveryLineMember> View_DeliveryLineMember { get; set; }
        public virtual DbSet<View_DetailTransfer> View_DetailTransfer { get; set; }
        public virtual DbSet<View_DistributionCustomerInvoice> View_DistributionCustomerInvoice { get; set; }
        public virtual DbSet<View_DistributionCustomerInvoiceDetail> View_DistributionCustomerInvoiceDetail { get; set; }
        public virtual DbSet<View_DistributionCustomerReceiveMoney> View_DistributionCustomerReceiveMoney { get; set; }
        public virtual DbSet<View_DistributionCustomerReceiveMoneyDetail> View_DistributionCustomerReceiveMoneyDetail { get; set; }
        public virtual DbSet<View_DistributionInvoice> View_DistributionInvoice { get; set; }
        public virtual DbSet<View_DistributionInvoiceDetail> View_DistributionInvoiceDetail { get; set; }
        public virtual DbSet<View_DistributionPay> View_DistributionPay { get; set; }
        public virtual DbSet<View_DistributionPayDetail> View_DistributionPayDetail { get; set; }
        public virtual DbSet<View_DistributionReceiveInvoice> View_DistributionReceiveInvoice { get; set; }
        public virtual DbSet<View_DistributionReceiveInvoiceDetail> View_DistributionReceiveInvoiceDetail { get; set; }
        public virtual DbSet<View_DistributionReceiveMoney> View_DistributionReceiveMoney { get; set; }
        public virtual DbSet<View_DistributionReceiveMoneyDetail> View_DistributionReceiveMoneyDetail { get; set; }
        public virtual DbSet<View_DOStatement> View_DOStatement { get; set; }
        public virtual DbSet<View_DPStatement> View_DPStatement { get; set; }
        public virtual DbSet<View_FinanceRecord> View_FinanceRecord { get; set; }
        public virtual DbSet<View_Goods> View_Goods { get; set; }
        public virtual DbSet<View_Goods_DefaultInfo> View_Goods_DefaultInfo { get; set; }
        public virtual DbSet<View_GoodsModelValue> View_GoodsModelValue { get; set; }
        public virtual DbSet<View_GoodsPackage> View_GoodsPackage { get; set; }
        public virtual DbSet<View_GoodsParamValue> View_GoodsParamValue { get; set; }
        public virtual DbSet<View_GoodsPhoto> View_GoodsPhoto { get; set; }
        public virtual DbSet<View_GoodsTypeParam> View_GoodsTypeParam { get; set; }
        public virtual DbSet<View_GroupOrderStatement> View_GroupOrderStatement { get; set; }
        public virtual DbSet<View_GroupPay> View_GroupPay { get; set; }
        public virtual DbSet<View_IBeiJingGoodsMap> View_IBeiJingGoodsMap { get; set; }
        public virtual DbSet<View_ICategory> View_ICategory { get; set; }
        public virtual DbSet<View_IGoods> View_IGoods { get; set; }
        public virtual DbSet<View_Inventory> View_Inventory { get; set; }
        public virtual DbSet<View_InventoryApply> View_InventoryApply { get; set; }
        public virtual DbSet<View_InventoryLog> View_InventoryLog { get; set; }
        public virtual DbSet<View_InventoryModifyAC> View_InventoryModifyAC { get; set; }
        public virtual DbSet<View_Invoice> View_Invoice { get; set; }
        public virtual DbSet<View_InvoiceAudit> View_InvoiceAudit { get; set; }
        public virtual DbSet<View_InvoiceLog> View_InvoiceLog { get; set; }
        public virtual DbSet<View_InvoiceRequire> View_InvoiceRequire { get; set; }
        public virtual DbSet<View_InvoiceRequireDetail> View_InvoiceRequireDetail { get; set; }
        public virtual DbSet<View_IOrderContract> View_IOrderContract { get; set; }
        public virtual DbSet<View_IProjectPlat> View_IProjectPlat { get; set; }
        public virtual DbSet<View_LogisticsCompany> View_LogisticsCompany { get; set; }
        public virtual DbSet<View_Member> View_Member { get; set; }
        public virtual DbSet<View_Member_Orders> View_Member_Orders { get; set; }
        public virtual DbSet<View_MemberAddress> View_MemberAddress { get; set; }
        public virtual DbSet<View_MemberCart> View_MemberCart { get; set; }
        public virtual DbSet<View_MemberDeliveryLine> View_MemberDeliveryLine { get; set; }
        public virtual DbSet<View_ModifyAC> View_ModifyAC { get; set; }
        public virtual DbSet<View_NeedToPurchaseDetail> View_NeedToPurchaseDetail { get; set; }
        public virtual DbSet<View_News> View_News { get; set; }
        public virtual DbSet<View_OrderAfterSale> View_OrderAfterSale { get; set; }
        public virtual DbSet<View_OrderDeliveryBox> View_OrderDeliveryBox { get; set; }
        public virtual DbSet<View_OrderDetail> View_OrderDetail { get; set; }
        public virtual DbSet<View_OrderDetail_Goods> View_OrderDetail_Goods { get; set; }
        public virtual DbSet<View_OrderDistribution> View_OrderDistribution { get; set; }
        public virtual DbSet<View_OrderDistributionDetail> View_OrderDistributionDetail { get; set; }
        public virtual DbSet<View_OrderGoodsComments> View_OrderGoodsComments { get; set; }
        public virtual DbSet<View_OrderModify> View_OrderModify { get; set; }
        public virtual DbSet<View_OrderModifyAC> View_OrderModifyAC { get; set; }
        public virtual DbSet<View_OrderPicking> View_OrderPicking { get; set; }
        public virtual DbSet<View_OrderReceiveMoney> View_OrderReceiveMoney { get; set; }
        public virtual DbSet<View_OrderReceiveMoneyDetail> View_OrderReceiveMoneyDetail { get; set; }
        public virtual DbSet<View_Orders> View_Orders { get; set; }
        public virtual DbSet<View_OrderStatement> View_OrderStatement { get; set; }
        public virtual DbSet<View_OrdersYangCaiLog> View_OrdersYangCaiLog { get; set; }
        public virtual DbSet<View_ORMAudit> View_ORMAudit { get; set; }
        public virtual DbSet<View_PickOrderDetail> View_PickOrderDetail { get; set; }
        public virtual DbSet<View_PickPurchaseDetail> View_PickPurchaseDetail { get; set; }
        public virtual DbSet<View_Product_Info> View_Product_Info { get; set; }
        public virtual DbSet<View_Purchase> View_Purchase { get; set; }
        public virtual DbSet<View_PurchaseDetail> View_PurchaseDetail { get; set; }
        public virtual DbSet<View_PurchaseLog> View_PurchaseLog { get; set; }
        public virtual DbSet<View_PurchaseModify> View_PurchaseModify { get; set; }
        public virtual DbSet<View_PurchasePay> View_PurchasePay { get; set; }
        public virtual DbSet<View_PurchasePayAudit> View_PurchasePayAudit { get; set; }
        public virtual DbSet<View_PurchasePayDetail> View_PurchasePayDetail { get; set; }
        public virtual DbSet<View_PurchaseQuoteDetail> View_PurchaseQuoteDetail { get; set; }
        public virtual DbSet<View_PurchaseStatement> View_PurchaseStatement { get; set; }
        public virtual DbSet<View_PurchaseStatementDetail> View_PurchaseStatementDetail { get; set; }
        public virtual DbSet<View_PurchaseStatementGoodsDetail> View_PurchaseStatementGoodsDetail { get; set; }
        public virtual DbSet<View_QuotationOrder> View_QuotationOrder { get; set; }
        public virtual DbSet<View_SourceGoods> View_SourceGoods { get; set; }
        public virtual DbSet<View_SupplierDetail> View_SupplierDetail { get; set; }
        public virtual DbSet<View_SupplierInvoice> View_SupplierInvoice { get; set; }
        public virtual DbSet<View_SupplierInvoiceDetails> View_SupplierInvoiceDetails { get; set; }
        public virtual DbSet<View_SupplierOrder> View_SupplierOrder { get; set; }
        public virtual DbSet<View_SupplierPrepayment> View_SupplierPrepayment { get; set; }
        public virtual DbSet<View_SupplierReceiveInvoice> View_SupplierReceiveInvoice { get; set; }
        public virtual DbSet<View_SupplierSettleAccounts> View_SupplierSettleAccounts { get; set; }
        public virtual DbSet<View_Sys_Branch_CSS> View_Sys_Branch_CSS { get; set; }
        public virtual DbSet<View_Sys_BranchGroup> View_Sys_BranchGroup { get; set; }
        public virtual DbSet<View_Sys_Distribution> View_Sys_Distribution { get; set; }
        public virtual DbSet<View_Sys_Permission> View_Sys_Permission { get; set; }
        public virtual DbSet<View_Sys_RolePermission> View_Sys_RolePermission { get; set; }
        public virtual DbSet<View_Sys_Users> View_Sys_Users { get; set; }
        public virtual DbSet<View_TaxCategory> View_TaxCategory { get; set; }
        public virtual DbSet<View_Transfer> View_Transfer { get; set; }
        public virtual DbSet<View_TransferDeliveryBox> View_TransferDeliveryBox { get; set; }
        public virtual DbSet<View_TransferDetail> View_TransferDetail { get; set; }
        public virtual DbSet<View_TransferPicking> View_TransferPicking { get; set; }
        public virtual DbSet<View_TransferReceiveMoney> View_TransferReceiveMoney { get; set; }
        public virtual DbSet<View_TransferStatement> View_TransferStatement { get; set; }
        public virtual DbSet<View_User_Permission> View_User_Permission { get; set; }
        public virtual DbSet<View_User_Role> View_User_Role { get; set; }
        public virtual DbSet<View_VIPApply> View_VIPApply { get; set; }
        public virtual DbSet<View_VIPApplyDetail> View_VIPApplyDetail { get; set; }
        public virtual DbSet<View_VIPCounterCustomer> View_VIPCounterCustomer { get; set; }
        public virtual DbSet<View_VIPCounterDetail> View_VIPCounterDetail { get; set; }
        public virtual DbSet<View_VirtualInventory> View_VirtualInventory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttachedFil>()
                .Property(e => e.FileUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .Property(e => e.EnglishName)
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .Property(e => e.Company)
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .Property(e => e.ProductPlace)
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .Property(e => e.WebSite)
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .Property(e => e.LogoUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .Property(e => e.PY)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessChanceInfo>()
                .Property(e => e.BusinessChangeName)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessChanceInfo>()
                .Property(e => e.Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<BusinessChanceInfo>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessFollowRecord>()
                .Property(e => e.BusinessChangeName)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessFollowRecord>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessFollowRecord>()
                .Property(e => e.Picture)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessFollowRecord>()
                .Property(e => e.FileUrl)
                .IsUnicode(false);

            modelBuilder.Entity<CatagoryParams>()
                .Property(e => e.ITypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<CatagoryParams>()
                .Property(e => e.ParamsName)
                .IsUnicode(false);

            modelBuilder.Entity<Contract>()
                .Property(e => e.ContractNo)
                .IsUnicode(false);

            modelBuilder.Entity<Contract>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Contract>()
                .Property(e => e.FileUrl)
                .IsUnicode(false);

            modelBuilder.Entity<CrawlerRequest>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<CrawlerRequest>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<CrawlerRequest>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<CrawlerRequest>()
                .Property(e => e.CreateByName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.EmployeesNum)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Website)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.RegisterMethod)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.OrderMemo)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.StoreMemo)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.StatementMemo)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PayMethod)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.InvoiceName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.InvoiceTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.InvoiceAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.InvoicePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.InvoiceBank)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.InvoiceBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.InvoiceContent)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.InvoiceMemo)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PY)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.InvoiceCategory)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.EmailForInvoice)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Tpn)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.TpName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerBalanceLog>()
                .Property(e => e.Change)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CustomerBalanceLog>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CustomerInvoiceInfo>()
                .Property(e => e.InvoiceTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerInvoiceInfo>()
                .Property(e => e.InvoiceAddress)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerInvoiceInfo>()
                .Property(e => e.InvoicePhone)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerInvoiceInfo>()
                .Property(e => e.InvoiceBank)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerInvoiceInfo>()
                .Property(e => e.InvoiceAccount)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerInvoiceInfo>()
                .Property(e => e.InvoiceMemo)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerInvoiceInfo>()
                .Property(e => e.MemberName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerLog>()
                .Property(e => e.Customer)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerLog>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerPreReceiveMoney>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerPreReceiveMoney>()
                .Property(e => e.InitialBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CustomerPreReceiveMoney>()
                .Property(e => e.PreReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CustomerPreReceiveMoney>()
                .Property(e => e.ReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CustomerPreReceiveMoney>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CustomerPreReceiveMoney>()
                .Property(e => e.OperatorName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerPreReceiveMoney>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerPreReceiveMoney>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerPreReceiveMoney>()
                .Property(e => e.ReceiveAccount)
                .IsUnicode(false);

            modelBuilder.Entity<DefaultStore>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<DefaultStore>()
                .Property(e => e.Place)
                .IsUnicode(false);

            modelBuilder.Entity<DefaultStore>()
                .Property(e => e.OrderType)
                .IsUnicode(false);

            modelBuilder.Entity<DellOrderGoodsPo>()
                .Property(e => e.PO)
                .IsUnicode(false);

            modelBuilder.Entity<DellOrderGoodsPo>()
                .Property(e => e.GoodsPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Dept>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Dept>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Dept>()
                .Property(e => e.PCode)
                .IsUnicode(false);

            modelBuilder.Entity<Dept>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DeptTemp>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<DeptTemp>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<DeptTemp>()
                .Property(e => e.PCode)
                .IsUnicode(false);

            modelBuilder.Entity<DeptTemp>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.BuyerName)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.BuyerTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.BuyerBank)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.BuyerBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.BuyerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.BuyerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.SaleName)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.SaleTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.SaleBank)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.SaleBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.SalePhone)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.SaleAddress)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoice>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerInvoiceDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionCustomerInvoiceDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionCustomerInvoiceDetail>()
                .Property(e => e.ChargeOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionCustomerInvoiceDetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionCustomerInvoiceDetail>()
                .Property(e => e.TaxCode)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerReceiveMoney>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerReceiveMoney>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionCustomerReceiveMoney>()
                .Property(e => e.ReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionCustomerReceiveMoney>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerReceiveMoneyDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionCustomerReceiveMoneyDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionCustomerReceiveMoneyDetail>()
                .Property(e => e.ChargeOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionCustomerReceiveMoneyDetail>()
                .Property(e => e.GoodsName)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCustomerReceiveMoneyDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.BuyerName)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.BuyerTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.BuyerBank)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.BuyerBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.BuyerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.BuyerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.SaleName)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.SaleTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.SaleBank)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.SaleBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.SalePhone)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.SaleAddress)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoice>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionInvoiceDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionInvoiceDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionInvoiceDetail>()
                .Property(e => e.ChargeOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionInvoiceDetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionInvoiceDetail>()
                .Property(e => e.TaxCode)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionOrderState>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionOrderState>()
                .Property(e => e.ReceiveChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionOrderState>()
                .Property(e => e.InvoiceChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionPay>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionPay>()
                .Property(e => e.PayMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionPay>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionPayDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionPayDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionPayDetail>()
                .Property(e => e.ChargeOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionReceiveInvoice>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionReceiveInvoice>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionReceiveInvoice>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionReceiveInvoice>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionReceiveInvoice>()
                .Property(e => e.BuyerName)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionReceiveInvoice>()
                .Property(e => e.BuyerTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionReceiveInvoice>()
                .Property(e => e.BuyerBank)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionReceiveInvoice>()
                .Property(e => e.BuyerBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionReceiveInvoice>()
                .Property(e => e.BuyerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionReceiveInvoice>()
                .Property(e => e.BuyerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionReceiveInvoice>()
                .Property(e => e.SaleName)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionReceiveInvoice>()
                .Property(e => e.SaleTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionReceiveInvoice>()
                .Property(e => e.SaleBank)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionReceiveInvoice>()
                .Property(e => e.SaleBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionReceiveInvoice>()
                .Property(e => e.SalePhone)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionReceiveInvoice>()
                .Property(e => e.SaleAddress)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionReceiveInvoice>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionReceiveInvoiceDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionReceiveInvoiceDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionReceiveInvoiceDetail>()
                .Property(e => e.ChargeOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionReceiveInvoiceDetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionReceiveInvoiceDetail>()
                .Property(e => e.TaxCode)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionReceiveMoney>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionReceiveMoney>()
                .Property(e => e.ReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionReceiveMoney>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionReceiveMoneyDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionReceiveMoneyDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DistributionReceiveMoneyDetail>()
                .Property(e => e.ChargeOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DOStatement>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DOStatement>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DOStatement>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<DOStatement>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<DOStatement>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<DOStatement>()
                .Property(e => e.InvoiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<DOStatement>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DOStatement>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DOStatement>()
                .Property(e => e.InvoiceChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DOStatement>()
                .Property(e => e.SumGoodsAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DOStatement>()
                .Property(e => e.ApplyReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DOStatement>()
                .Property(e => e.ApplyInvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DPStatement>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DPStatement>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DPStatement>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<DPStatement>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DPStatement>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<DPStatement>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DPStatement>()
                .Property(e => e.InvoiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<DPStatement>()
                .Property(e => e.PaidApplyMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DPStatement>()
                .Property(e => e.InvoiceApplyMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DPStatement>()
                .Property(e => e.InvoiceChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EmailInvoiceSetting>()
                .Property(e => e.PlatIdentity)
                .IsUnicode(false);

            modelBuilder.Entity<EmailInvoiceSetting>()
                .Property(e => e.SaleName)
                .IsUnicode(false);

            modelBuilder.Entity<EmailInvoiceSetting>()
                .Property(e => e.SaleBank)
                .IsUnicode(false);

            modelBuilder.Entity<EmailInvoiceSetting>()
                .Property(e => e.SaleBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<EmailInvoiceSetting>()
                .Property(e => e.SaleTaxNum)
                .IsUnicode(false);

            modelBuilder.Entity<EmailInvoiceSetting>()
                .Property(e => e.SalePhone)
                .IsUnicode(false);

            modelBuilder.Entity<EmailInvoiceSetting>()
                .Property(e => e.SaleAddress)
                .IsUnicode(false);

            modelBuilder.Entity<EmailInvoiceSetting>()
                .Property(e => e.PlatAPI)
                .IsUnicode(false);

            modelBuilder.Entity<EmailInvoiceSetting>()
                .Property(e => e.AppKey)
                .IsUnicode(false);

            modelBuilder.Entity<EmailInvoiceSetting>()
                .Property(e => e.AppSecret)
                .IsUnicode(false);

            modelBuilder.Entity<EmailInvoiceSetting>()
                .Property(e => e.Token)
                .IsUnicode(false);

            modelBuilder.Entity<EmailSetting>()
                .Property(e => e.SmtpServer)
                .IsUnicode(false);

            modelBuilder.Entity<EmailSetting>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<EmailSetting>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.DeviceNum)
                .IsUnicode(false);

            modelBuilder.Entity<EquipmentLog>()
                .Property(e => e.DeviceNum)
                .IsUnicode(false);

            modelBuilder.Entity<EquipmentLog>()
                .Property(e => e.RelationId)
                .IsUnicode(false);

            modelBuilder.Entity<FinanceAudit>()
                .Property(e => e.FinanceData)
                .IsUnicode(false);

            modelBuilder.Entity<FinanceRecord>()
                .Property(e => e.InitBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FinanceRecord>()
                .Property(e => e.OperateAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FinanceRecord>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FinanceRecord>()
                .Property(e => e.SubjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<FinanceRecord>()
                .Property(e => e.Tpn)
                .IsUnicode(false);

            modelBuilder.Entity<FinanceSubject>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<FinanceSubject>()
                .Property(e => e.Pcode)
                .IsUnicode(false);

            modelBuilder.Entity<Franchisee>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Franchisee>()
                .Property(e => e.CompanyProvince)
                .IsUnicode(false);

            modelBuilder.Entity<Franchisee>()
                .Property(e => e.CompanyCity)
                .IsUnicode(false);

            modelBuilder.Entity<Franchisee>()
                .Property(e => e.CompanyArea)
                .IsUnicode(false);

            modelBuilder.Entity<Franchisee>()
                .Property(e => e.CompanyAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Franchisee>()
                .Property(e => e.ContractWay)
                .IsUnicode(false);

            modelBuilder.Entity<Franchisee>()
                .Property(e => e.LocationProvince)
                .IsUnicode(false);

            modelBuilder.Entity<Franchisee>()
                .Property(e => e.LocationCity)
                .IsUnicode(false);

            modelBuilder.Entity<Franchisee>()
                .Property(e => e.LocationArea)
                .IsUnicode(false);

            modelBuilder.Entity<Franchisee>()
                .Property(e => e.LocationAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Franchisee>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Franchisee>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<Franchisee>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Franchisee>()
                .Property(e => e.QQ)
                .IsUnicode(false);

            modelBuilder.Entity<Gift>()
                .Property(e => e.GiftName)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.Guid)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.SN)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.PY)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.InPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Goods>()
                .Property(e => e.PackingList)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.Service)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.HomeImage)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.CombinationType)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.Feature)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.InnerId)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.SalesAnalysis)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.PriceExtend)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Goods>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.Tpn)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.Tags)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsCaptcha>()
                .Property(e => e.Captcha)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsComment>()
                .Property(e => e.Label)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsComment>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsExtensions>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsModel>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsModelValue>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsPackage>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsPackage>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsPackage>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsPackage>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GoodsPackage>()
                .Property(e => e.PriceExtend)
                .HasPrecision(10, 2);

            modelBuilder.Entity<GoodsPackage>()
                .Property(e => e.DonvvSpuCode)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsPackage>()
                .Property(e => e.DonvvSkuCode)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsPackageLog>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsPackageLog>()
                .Property(e => e.OldName)
                .IsFixedLength();

            modelBuilder.Entity<GoodsPackageLog>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsPackageLog>()
                .Property(e => e.OldBarCode)
                .IsFixedLength();

            modelBuilder.Entity<GoodsPackageLog>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsParamValue>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsParamValue>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsParamValue>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsPhoto>()
                .Property(e => e.PhotoUrl)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsPhoto>()
                .Property(e => e.Photo250Url)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsPhoto>()
                .Property(e => e.Photo100Url)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsPriceLog>()
                .Property(e => e.OldPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GoodsPriceLog>()
                .Property(e => e.NewPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GoodsPriceLog>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsType>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsType>()
                .Property(e => e.PCode)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsType>()
                .Property(e => e.PriceArea)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsType>()
                .Property(e => e.DefaultUnit)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsType>()
                .Property(e => e.DefaultSource)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsType>()
                .Property(e => e.PY)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsTypeParam>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsTypeParamGroup>()
                .Property(e => e.ParamSource)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsTypeParamGroup>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsTypeParamOption>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsTypeUpdate>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<GoodsTypeUpdate>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<GroupOrderStatement>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GroupOrderStatement>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GroupOrderStatement>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<GroupOrderStatement>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<GroupOrderStatement>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GroupPay>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GroupPay>()
                .Property(e => e.PayMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GroupPay>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<GroupPay>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<I_Analysis>()
                .Property(e => e.AppKey)
                .IsUnicode(false);

            modelBuilder.Entity<I_Analysis>()
                .Property(e => e.AppSecret)
                .IsUnicode(false);

            modelBuilder.Entity<I_Analysis>()
                .Property(e => e.Token)
                .IsUnicode(false);

            modelBuilder.Entity<I_BeiJingGoodsMap>()
                .Property(e => e.I_BeiJingProductId)
                .IsUnicode(false);

            modelBuilder.Entity<I_BeiJingProductParam>()
                .Property(e => e.I_ParamValue)
                .IsUnicode(false);

            modelBuilder.Entity<I_Category>()
                .Property(e => e.Discount)
                .HasPrecision(8, 4);

            modelBuilder.Entity<I_Category>()
                .Property(e => e.Discount2)
                .HasPrecision(8, 4);

            modelBuilder.Entity<I_Category>()
                .Property(e => e.Discount3)
                .HasPrecision(8, 4);

            modelBuilder.Entity<I_Category>()
                .Property(e => e.Discount4)
                .HasPrecision(8, 4);

            modelBuilder.Entity<I_ChengDuActivityGoods>()
                .Property(e => e.VastPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<I_ChengDuCategoryExt>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<I_ChengDuCategoryExt>()
                .Property(e => e.Summoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<I_ChengDuCategoryParam>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<I_ChengDuCategoryParam>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<I_ChengDuCategoryParam>()
                .Property(e => e.Vals)
                .IsUnicode(false);

            modelBuilder.Entity<I_EfficientGoods>()
                .Property(e => e.GoodsName)
                .IsUnicode(false);

            modelBuilder.Entity<I_EfficientGoods>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<I_EfficientGoods>()
                .Property(e => e.EfficientGoodsCardNum)
                .IsUnicode(false);

            modelBuilder.Entity<I_EfficientGoods>()
                .Property(e => e.EfficientGoodsImagePath)
                .IsUnicode(false);

            modelBuilder.Entity<I_EfficientGoods>()
                .Property(e => e.EfficientGoodsCardOrgan)
                .IsUnicode(false);

            modelBuilder.Entity<I_EfficientGoods>()
                .Property(e => e.AddBy)
                .IsUnicode(false);

            modelBuilder.Entity<I_EGoods>()
                .Property(e => e.CertNo)
                .IsUnicode(false);

            modelBuilder.Entity<I_EGoods>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<I_Goods>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<I_Goods>()
                .Property(e => e.MarketPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<I_GoodsExtention>()
                .Property(e => e.AttrGroup)
                .IsUnicode(false);

            modelBuilder.Entity<I_GoodsLog>()
                .Property(e => e.GoodsName)
                .IsUnicode(false);

            modelBuilder.Entity<I_GoodsLog>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<I_GoodsLog>()
                .Property(e => e.MarketPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<I_GoodsLog>()
                .Property(e => e.Operate)
                .IsUnicode(false);

            modelBuilder.Entity<I_GoodsLog>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<I_GoodsLog>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<I_GoodsMap>()
                .Property(e => e.ProductId)
                .IsUnicode(false);

            modelBuilder.Entity<I_GoodsMap>()
                .Property(e => e.ProductUrl)
                .IsUnicode(false);

            modelBuilder.Entity<I_GoodsMap>()
                .Property(e => e.ProductUrlEC)
                .IsUnicode(false);

            modelBuilder.Entity<I_GoodsPart>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<I_Message>()
                .Property(e => e.Result)
                .IsUnicode(false);

            modelBuilder.Entity<I_Message>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<I_OrderDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<I_OrderDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<I_OrderExtension>()
                .Property(e => e.AttrVal)
                .IsUnicode(false);

            modelBuilder.Entity<I_Orders>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<I_Product>()
                .Property(e => e.AppKey)
                .IsUnicode(false);

            modelBuilder.Entity<I_Product>()
                .Property(e => e.AppSecret)
                .IsUnicode(false);

            modelBuilder.Entity<I_Product>()
                .Property(e => e.Token)
                .IsUnicode(false);

            modelBuilder.Entity<I_ProductsForZGLY>()
                .Property(e => e.ISku)
                .IsUnicode(false);

            modelBuilder.Entity<I_ProductsMapForZGLY>()
                .Property(e => e.IProductSku)
                .IsUnicode(false);

            modelBuilder.Entity<I_Project>()
                .Property(e => e.client_id)
                .IsUnicode(false);

            modelBuilder.Entity<I_Project>()
                .Property(e => e.PrivateKey)
                .IsUnicode(false);

            modelBuilder.Entity<IContract>()
                .Property(e => e.BankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<IContract>()
                .Property(e => e.Signature)
                .IsUnicode(false);

            modelBuilder.Entity<IContract>()
                .Property(e => e.Sign)
                .IsUnicode(false);

            modelBuilder.Entity<IContract>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<IContractMY>()
                .Property(e => e.fileByte)
                .IsUnicode(false);

            modelBuilder.Entity<IContractMY>()
                .Property(e => e.fileByted)
                .IsUnicode(false);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.StoreZone)
                .IsUnicode(false);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.AC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.StoreZoneMemo)
                .IsUnicode(false);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.AFC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<InventoryApply>()
                .Property(e => e.StoreZone)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryApply>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryLog>()
                .Property(e => e.Operate)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryLog>()
                .Property(e => e.AC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InventoryLog>()
                .Property(e => e.OldStoreZone)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryLog>()
                .Property(e => e.StoreZone)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryLog>()
                .Property(e => e.AFC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InventoryModifyAC>()
                .Property(e => e.StoreZone)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryModifyAC>()
                .Property(e => e.OldAC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<InventoryModifyAC>()
                .Property(e => e.NewAC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<InventoryModifyAC>()
                .Property(e => e.StoreZoneMemo)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.OrderNo)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.PlatInvoiceRequestNo)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.PdfUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.InvoiceDetailUrl)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceLog>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceLog>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceLog>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceLog>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceLog>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceLog>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceLog>()
                .Property(e => e.OrderNo)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceLog>()
                .Property(e => e.PlatInvoiceRequestNo)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceLog>()
                .Property(e => e.PdfUrl)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceLog>()
                .Property(e => e.InvoiceDetailUrl)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceLog>()
                .Property(e => e.CancelPdfUrl)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceLog>()
                .Property(e => e.CancelDetailUrl)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceLog>()
                .Property(e => e.CancelOrderNo)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceLog>()
                .Property(e => e.CancelPlatInvoiceRequestNo)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceLog>()
                .Property(e => e.StatementIds)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.InvoiceName)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.InvoiceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.InvoiceMemo)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.InvoiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.DistributionType)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.BuyerTaxNum)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.BuyerBank)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.BuyerBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.BuyerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.SaleName)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.SaleTaxNum)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.SaleBank)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.SaleBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.SalePhone)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.SaleAddress)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequire>()
                .Property(e => e.BuyerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequireDetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceRequireDetail>()
                .Property(e => e.TaxCode)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceRequireDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<IOrderContract>()
                .Property(e => e.ContractNum)
                .IsUnicode(false);

            modelBuilder.Entity<IOrderContract>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<IOrderContract>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<LoginedIdentity>()
                .Property(e => e.BuyerCookie)
                .IsUnicode(false);

            modelBuilder.Entity<LoginedIdentity>()
                .Property(e => e.SessionId)
                .IsUnicode(false);

            modelBuilder.Entity<LoginedIdentity>()
                .Property(e => e.PostUrl)
                .IsUnicode(false);

            modelBuilder.Entity<LoginedIdentity>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<LoginedIdentity>()
                .Property(e => e.UserEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Logistics>()
                .Property(e => e.LogisticName)
                .IsUnicode(false);

            modelBuilder.Entity<Logistics>()
                .Property(e => e.LogisticNo)
                .IsUnicode(false);

            modelBuilder.Entity<LogisticsCompany>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<LogisticsCompany>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<LogisticsDetail>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<LogisticsDetail>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<LogisticsInfomation>()
                .Property(e => e.TrackingNumber)
                .IsUnicode(false);

            modelBuilder.Entity<LogisticsInfomation>()
                .Property(e => e.FromUser)
                .IsUnicode(false);

            modelBuilder.Entity<LogisticsInfomation>()
                .Property(e => e.FromTelphone)
                .IsUnicode(false);

            modelBuilder.Entity<LogisticsInfomation>()
                .Property(e => e.FromAddress)
                .IsUnicode(false);

            modelBuilder.Entity<LogisticsInfomation>()
                .Property(e => e.ToUser)
                .IsUnicode(false);

            modelBuilder.Entity<LogisticsInfomation>()
                .Property(e => e.ToTelphone)
                .IsUnicode(false);

            modelBuilder.Entity<LogisticsInfomation>()
                .Property(e => e.ToAddress)
                .IsUnicode(false);

            modelBuilder.Entity<LogisticsInfomation>()
                .Property(e => e.ImgUrl)
                .IsUnicode(false);

            modelBuilder.Entity<LogisticsSubscribeLog>()
                .Property(e => e.TrackingNumber)
                .IsUnicode(false);

            modelBuilder.Entity<MajorParamsDetail>()
                .Property(e => e.ParamsName)
                .IsUnicode(false);

            modelBuilder.Entity<MajorParamsDetail>()
                .Property(e => e.ParamsValue)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.IM)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.RegisterMethod)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Member>()
                .Property(e => e.HeadPortraitUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Tpn)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.TpName)
                .IsUnicode(false);

            modelBuilder.Entity<MemberApplyDept>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<MemberApplyDept>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<MemberApplyDept>()
                .Property(e => e.PCode)
                .IsUnicode(false);

            modelBuilder.Entity<MemberAuth>()
                .Property(e => e.AccessToken)
                .IsUnicode(false);

            modelBuilder.Entity<MemberAuth>()
                .Property(e => e.RereshToken)
                .IsUnicode(false);

            modelBuilder.Entity<MemberAuth>()
                .Property(e => e.StrustNo)
                .IsUnicode(false);

            modelBuilder.Entity<MemberCart>()
                .Property(e => e.DisplayUnit)
                .IsUnicode(false);

            modelBuilder.Entity<MemberInvoiceInfo>()
                .Property(e => e.MemberName)
                .IsUnicode(false);

            modelBuilder.Entity<MemberInvoiceInfo>()
                .Property(e => e.InvoiceCategory)
                .IsUnicode(false);

            modelBuilder.Entity<MemberInvoiceInfo>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<MemberInvoiceInfo>()
                .Property(e => e.InvoiceContent)
                .IsUnicode(false);

            modelBuilder.Entity<MemberInvoiceInfo>()
                .Property(e => e.InvoiceName)
                .IsUnicode(false);

            modelBuilder.Entity<MemberInvoiceInfo>()
                .Property(e => e.InvoiceTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<MemberInvoiceInfo>()
                .Property(e => e.InvoiceAddress)
                .IsUnicode(false);

            modelBuilder.Entity<MemberInvoiceInfo>()
                .Property(e => e.InvoicePhone)
                .IsUnicode(false);

            modelBuilder.Entity<MemberInvoiceInfo>()
                .Property(e => e.InvoiceBank)
                .IsUnicode(false);

            modelBuilder.Entity<MemberInvoiceInfo>()
                .Property(e => e.InvoiceBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<MemberInvoiceInfo>()
                .Property(e => e.InvoiceMemo)
                .IsUnicode(false);

            modelBuilder.Entity<MemberInvoiceInfo>()
                .Property(e => e.EmailForInvoice)
                .IsUnicode(false);

            modelBuilder.Entity<MemberInvoiceInfo>()
                .Property(e => e.InvoiceReceivePhone)
                .IsUnicode(false);

            modelBuilder.Entity<MemberLog>()
                .Property(e => e.MemberName)
                .IsUnicode(false);

            modelBuilder.Entity<MemberLog>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<MemberOrderDept>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<MemberOrderDept>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<MemberOrderDept>()
                .Property(e => e.PCode)
                .IsUnicode(false);

            modelBuilder.Entity<MemberPoint>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<MemberPoint>()
                .Property(e => e.Income)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MemberPoint>()
                .Property(e => e.Spend)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MemberPoint>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MemberPoint>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTemp>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTemp>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTemp>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTemp>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTemp>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTemp>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTemp>()
                .Property(e => e.IM)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTemp>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTemp>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTemp>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTemp>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTemp>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTemp>()
                .Property(e => e.RegisterMethod)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTemp>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<MemberTemp>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ModifyAC>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<ModifyAC>()
                .Property(e => e.OldInPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ModifyAC>()
                .Property(e => e.OldAC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ModifyAC>()
                .Property(e => e.NewInPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ModifyAC>()
                .Property(e => e.NewAC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NeedToPurchase>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<NeedToPurchaseDetail>()
                .Property(e => e.GoodsMemo)
                .IsUnicode(false);

            modelBuilder.Entity<NeedToPurchaseDetail>()
                .Property(e => e.PurchaseType)
                .IsUnicode(false);

            modelBuilder.Entity<NeedToPurchaseDetail>()
                .Property(e => e.PurchaseMemo)
                .IsUnicode(false);

            modelBuilder.Entity<NeedToPurchaseDetail>()
                .Property(e => e.CreditCard)
                .IsUnicode(false);

            modelBuilder.Entity<NeedToPurchaseDetail>()
                .Property(e => e.InPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<News>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<NewsType>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<Notify_Msg>()
                .Property(e => e.TempletValue)
                .IsUnicode(false);

            modelBuilder.Entity<Notify_Msg>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Notify_Templet>()
                .Property(e => e.Templet)
                .IsUnicode(false);

            modelBuilder.Entity<Notify_Templet>()
                .Property(e => e.DisplayTemplet)
                .IsUnicode(false);

            modelBuilder.Entity<Open_Plat>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Open_Plat>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Open_Project>()
                .Property(e => e.BaseApi)
                .IsUnicode(false);

            modelBuilder.Entity<Open_Project>()
                .Property(e => e.AppKey)
                .IsUnicode(false);

            modelBuilder.Entity<Open_Project>()
                .Property(e => e.AppSecret)
                .IsUnicode(false);

            modelBuilder.Entity<Open_Project>()
                .Property(e => e.AccessToken)
                .IsUnicode(false);

            modelBuilder.Entity<Open_Setting>()
                .Property(e => e.PlatName)
                .IsUnicode(false);

            modelBuilder.Entity<Open_SyncData>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<Open_SyncData>()
                .Property(e => e.ExtendName)
                .IsUnicode(false);

            modelBuilder.Entity<Open_SyncData>()
                .Property(e => e.Extend)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSale>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSale>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSale>()
                .Property(e => e.ApplyType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSale>()
                .Property(e => e.ApplyReason)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSale>()
                .Property(e => e.ReturnWay)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSale>()
                .Property(e => e.PickupAddress)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSale>()
                .Property(e => e.ReceiveAddress)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSale>()
                .Property(e => e.ApplyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSale>()
                .Property(e => e.ContactWay)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSale>()
                .Property(e => e.DisplayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSale>()
                .Property(e => e.InnerStatus)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSale>()
                .Property(e => e.OperateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSale>()
                .Property(e => e.OperateType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSaleFlow>()
                .Property(e => e.OperateType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSaleFlow>()
                .Property(e => e.OperateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSaleFlow>()
                .Property(e => e.DisplayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSaleFlow>()
                .Property(e => e.InnerStatus)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAfterSalePhoto>()
                .Property(e => e.PhotoUrl)
                .IsUnicode(false);

            modelBuilder.Entity<OrderArchive>()
                .Property(e => e.PhotoUrl)
                .IsUnicode(false);

            modelBuilder.Entity<OrderBox>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<OrderBox>()
                .Property(e => e.StoreZone)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDelivery>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDelivery>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDelivery>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDelivery>()
                .Property(e => e.Latitude)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDelivery>()
                .Property(e => e.Longitude)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDeliveryBox>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDeliveryBox>()
                .Property(e => e.Latitude)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDeliveryBox>()
                .Property(e => e.Longitude)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.AC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Point)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.PurchaseMemo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.DisplayUnit)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.DisplayPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.GrossProfitPercent)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.TaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.NoTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.GrossProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.NoTaxPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.DisplayNoTaxPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.AFC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.DisplayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDistribution>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDistribution>()
                .Property(e => e.PayChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDistribution>()
                .Property(e => e.InvoiceChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDistributionDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDistributionDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderInvoiceInfo>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<OrderInvoiceInfo>()
                .Property(e => e.TaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderInvoiceInfo>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<OrderInvoiceInfo>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<OrderInvoiceInfo>()
                .Property(e => e.Bank)
                .IsUnicode(false);

            modelBuilder.Entity<OrderInvoiceInfo>()
                .Property(e => e.BankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<OrderInvoiceInfo>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderInvoiceInfo>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<OrderInvoiceInfo>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<OrderModify>()
                .Property(e => e.OldPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderModify>()
                .Property(e => e.NewPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderModify>()
                .Property(e => e.PurchaseType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderModify>()
                .Property(e => e.DisplayUnit)
                .IsUnicode(false);

            modelBuilder.Entity<OrderModify>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderModify>()
                .Property(e => e.OldTaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderModify>()
                .Property(e => e.NewTaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderModifyAC>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderModifyAC>()
                .Property(e => e.GrossProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderModifyAC>()
                .Property(e => e.NewGrossProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderModifyAC>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderModifyAC>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderModifyAC>()
                .Property(e => e.OldAC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderModifyAC>()
                .Property(e => e.NewAC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderModifyAC>()
                .Property(e => e.OldGrossProfitPercent)
                .IsUnicode(false);

            modelBuilder.Entity<OrderModifyAC>()
                .Property(e => e.NewGrossProfitPercent)
                .IsUnicode(false);

            modelBuilder.Entity<OrderPickingLog>()
                .Property(e => e.StoreZone)
                .IsFixedLength();

            modelBuilder.Entity<OrderReceiveMoney>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderReceiveMoney>()
                .Property(e => e.ReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderReceiveMoney>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderReceiveMoney>()
                .Property(e => e.ReceiveAccount)
                .IsUnicode(false);

            modelBuilder.Entity<OrderReceiveMoneyDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderReceiveMoneyDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderReceiveMoneyDetail>()
                .Property(e => e.ChargeOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderReceiveMoneyDetail>()
                .Property(e => e.GoodsName)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.Guid)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.OrderType)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .Property(e => e.GrossProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .Property(e => e.Point)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .Property(e => e.Customer)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.InvoiceName)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.ServiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.PurchaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.StoreStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.DeliveryStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.I_OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.I_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.ChargeOff)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Orders>()
                .Property(e => e.DeliveryType)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.InvoiceCategory)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.EmailForInvoice)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.ConfirmStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.ThirdPartyId)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.usercode)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .Property(e => e.PayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .Property(e => e.OrderAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .Property(e => e.TaxMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .Property(e => e.NoTaxMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .Property(e => e.GrossProfitPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderStatement>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderStatement>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderStatement>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<OrderStatement>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderStatement>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderStatement>()
                .Property(e => e.InvoiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<OrderStatement>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderStatement>()
                .Property(e => e.NeedToInvoice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderStatement>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderStatement>()
                .Property(e => e.SumGoodsAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderStatementLog>()
                .Property(e => e.OperateType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderStatementLog>()
                .Property(e => e.OperateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.BName)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.Unique)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.PageUnique)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.Host)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.Origin)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.Refer)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.ContentType)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.Browser)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.DeviceType)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.UserAgent)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.UrlMd5)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.Body)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.Scene)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.Ip)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.Lon)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.Lat)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.Before)
                .IsUnicode(false);

            modelBuilder.Entity<PageView>()
                .Property(e => e.Platform)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.BName)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.Unique)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.PageUnique)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.Host)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.Origin)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.Refer)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.ContentType)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.Browser)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.DeviceType)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.UserAgent)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.UrlMd5)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.Body)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.Scene)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.Ip)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.Lon)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.Lat)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.Before)
                .IsUnicode(false);

            modelBuilder.Entity<PageView_copy1>()
                .Property(e => e.Platform)
                .IsUnicode(false);

            modelBuilder.Entity<ParamGather>()
                .Property(e => e.ParamsName)
                .IsUnicode(false);

            modelBuilder.Entity<PayLog>()
                .Property(e => e.Amount)
                .IsUnicode(false);

            modelBuilder.Entity<PreGoodsPhoto>()
                .Property(e => e.GoodsId)
                .IsUnicode(false);

            modelBuilder.Entity<PreGoodsPhoto>()
                .Property(e => e.PhotoUrl)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.InvoiceName)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.InvoiceRemark)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.InvoiceEmail)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.InvoiceMobile)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.BuyerTaxNum)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.BuyerBank)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.BuyerBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.BuyerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.SaleName)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.SaleTaxNum)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.SaleBank)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.SaleBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.SalePhone)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.SaleAddress)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.DistributionType)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.InitialAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.PreInvoiceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.InvoiceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<PreInvoice>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PrintTempletDic>()
                .Property(e => e.Tag)
                .IsUnicode(false);

            modelBuilder.Entity<PrintTempletDic>()
                .Property(e => e.Vuale)
                .IsUnicode(false);

            modelBuilder.Entity<PrintTempletDic>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<PrintTempletDic>()
                .Property(e => e.Pcode)
                .IsUnicode(false);

            modelBuilder.Entity<Product_GoodsType>()
                .Property(e => e.DonvvTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<Product_Info>()
                .Property(e => e.Params)
                .IsUnicode(false);

            modelBuilder.Entity<Product_Info>()
                .Property(e => e.SourceUrl)
                .IsUnicode(false);

            modelBuilder.Entity<ProGoodsType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ProGoodsType>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<ProGoodsType>()
                .Property(e => e.PCode)
                .IsUnicode(false);

            modelBuilder.Entity<ProGoodsType>()
                .Property(e => e.PriceArea)
                .IsUnicode(false);

            modelBuilder.Entity<ProGoodsType>()
                .Property(e => e.DefaultUnit)
                .IsUnicode(false);

            modelBuilder.Entity<ProGoodsType>()
                .Property(e => e.DefaultSource)
                .IsUnicode(false);

            modelBuilder.Entity<ProGoodsType>()
                .Property(e => e.PY)
                .IsUnicode(false);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.PurchaseType)
                .IsUnicode(false);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.SupplierStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.TaxMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.NoTaxMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.ThirdPartyId)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseDetail>()
                .Property(e => e.BillsPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseDetail>()
                .Property(e => e.InPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseDetail>()
                .Property(e => e.PurchaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseDetail>()
                .Property(e => e.DetailMemo)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseDetail>()
                .Property(e => e.DonvvBrandId)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseDetail>()
                .Property(e => e.DonvvBrandName)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseDetail>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseDetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseDetail>()
                .Property(e => e.TaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseDetail>()
                .Property(e => e.NoTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseDetail>()
                .Property(e => e.NoTaxInPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseLog>()
                .Property(e => e.PurchaseType)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseLog>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseLog>()
                .Property(e => e.PurchaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseLog>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseModify>()
                .Property(e => e.OldPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseModify>()
                .Property(e => e.NewPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseModify>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseModify>()
                .Property(e => e.OldTaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseModify>()
                .Property(e => e.NewTaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseModify>()
                .Property(e => e.OldNoTaxPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseModify>()
                .Property(e => e.NewNoTaxPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchasePay>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchasePay>()
                .Property(e => e.PayMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchasePay>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<PurchasePay>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<PurchasePay>()
                .Property(e => e.PayAccount)
                .IsUnicode(false);

            modelBuilder.Entity<PurchasePayDetail>()
                .Property(e => e.InPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchasePayDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchasePayDetail>()
                .Property(e => e.ChargeOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchasePayLog>()
                .Property(e => e.OperateType)
                .IsUnicode(false);

            modelBuilder.Entity<PurchasePayLog>()
                .Property(e => e.OperateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseQuote>()
                .Property(e => e.DonvvBrandId)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseQuote>()
                .Property(e => e.DonvvBrandName)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseQuote>()
                .Property(e => e.DonvvSupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseQuote>()
                .Property(e => e.DonvvSupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseQuote>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseQuoteDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseQuoteDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseQuoteDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseStatement>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseStatement>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseStatement>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseStatement>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseStatement>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseStatementLog>()
                .Property(e => e.OperateType)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseStatementLog>()
                .Property(e => e.OperateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<SaleReportFakeData>()
                .Property(e => e.OrderAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SaleReportFakeData>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SaleReportFakeData>()
                .Property(e => e.GrossProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesPlan>()
                .Property(e => e.Customer)
                .IsUnicode(false);

            modelBuilder.Entity<SalesPlan>()
                .Property(e => e.SalesName)
                .IsUnicode(false);

            modelBuilder.Entity<SalesPlan>()
                .Property(e => e.PlanMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesPlan>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<SalesPlan>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceOrder>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ServiceOrderDelivery>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceOrderDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceOrderDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ServiceOrderDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SourceGoods>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<SourceGoods>()
                .Property(e => e.SourceSku)
                .IsUnicode(false);

            modelBuilder.Entity<SourceGoods>()
                .Property(e => e.SourceMainSku)
                .IsUnicode(false);

            modelBuilder.Entity<SourceGoods>()
                .Property(e => e.SpecVals)
                .IsUnicode(false);

            modelBuilder.Entity<SourceGoods>()
                .Property(e => e.SourceCategory)
                .IsUnicode(false);

            modelBuilder.Entity<SourceGoods>()
                .Property(e => e.SourceBrand)
                .IsUnicode(false);

            modelBuilder.Entity<SourceGoods>()
                .Property(e => e.SourcePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Store>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Place)
                .IsUnicode(false);

            modelBuilder.Entity<StoreZone>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<StoreZone>()
                .Property(e => e.PCode)
                .IsUnicode(false);

            modelBuilder.Entity<StoreZone>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<StoreZone>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Attitude)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.TelPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.QQ)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.MainBrand)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Major)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.PY)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.SupplierTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.BankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.AddUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.DonvvSupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<SupplierInvoice>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<SupplierInvoice>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<SupplierInvoice>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<SupplierInvoice>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierInvoice>()
                .Property(e => e.InvoiceCompany)
                .IsUnicode(false);

            modelBuilder.Entity<SupplierInvoiceContacts>()
                .Property(e => e.FileUrl)
                .IsUnicode(false);

            modelBuilder.Entity<SupplierInvoiceContacts>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<SupplierInvoiceDetails>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<SupplierInvoiceDetails>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<SupplierInvoiceDetails>()
                .Property(e => e.InPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierInvoiceDetails>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierInvoiceDetails>()
                .Property(e => e.ToInvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierPrepayment>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<SupplierPrepayment>()
                .Property(e => e.InitialBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierPrepayment>()
                .Property(e => e.Prepayment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierPrepayment>()
                .Property(e => e.Payment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierPrepayment>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierPrepayment>()
                .Property(e => e.OperatorName)
                .IsUnicode(false);

            modelBuilder.Entity<SupplierPrepayment>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<SupplierPrepayment>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<SupplierPrepayment>()
                .Property(e => e.PayAccount)
                .IsUnicode(false);

            modelBuilder.Entity<SupplierSettleAccounts>()
                .Property(e => e.PurchaseAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierSettleAccounts>()
                .Property(e => e.PurchasePayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierSettleAccounts>()
                .Property(e => e.InvoiceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierSettleAccounts>()
                .Property(e => e.LastTimeBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierSettleAccounts>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Sys_Agent>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Agent>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Agent>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Agent>()
                .Property(e => e.Bank)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Agent>()
                .Property(e => e.AcountNo)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Agent>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Agent>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Agent_Users>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Agent_Users>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Agent_Users>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Agent_Users>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Approve>()
                .Property(e => e.KeyId)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Approve>()
                .Property(e => e.ApproveKey)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Approve>()
                .Property(e => e.ApproveAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Approve>()
                .Property(e => e.ApproveCode)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Authorize>()
                .Property(e => e.Money)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Sys_Authorize>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Branch>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Branch>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Branch>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Branch>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Branch>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Branch>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Branch>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Branch>()
                .Property(e => e.Introduction)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Branch>()
                .Property(e => e.Domain)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Branch>()
                .Property(e => e.DonvvDomain)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Branch>()
                .Property(e => e.Domain2)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Branch>()
                .Property(e => e.CityAlias)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Branch>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchActivity>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchActivityContent>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchActivityGift>()
                .Property(e => e.GoodsName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchActivityGift>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchActivityGift>()
                .Property(e => e.SalePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Sys_BranchActivityRange>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchActivityRule>()
                .Property(e => e.RangeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Sys_BranchActivityRule>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Sys_BranchAds>()
                .Property(e => e.Image1)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchAds>()
                .Property(e => e.Href1)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.AreaName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.LeftLayout)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.Image1)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.Image2)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.Image3)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.Href1)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.Href2)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.Href3)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.Image4)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.Image5)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.Image6)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.Image7)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.Image8)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.Href4)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.Href5)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.Href6)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.Href7)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.Href8)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchArea>()
                .Property(e => e.BackGroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchAreaDetail>()
                .Property(e => e.Alt)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchAreaDetail>()
                .Property(e => e.Href)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchAreaDetail>()
                .Property(e => e.ImgUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchAreas>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchAreas>()
                .Property(e => e.Header_BackGroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchAreas>()
                .Property(e => e.Header_FontColor)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchAreas>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchAreas>()
                .Property(e => e.Border_color)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchAuth>()
                .Property(e => e.AppKey)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchAuth>()
                .Property(e => e.AppSecret)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchAuth>()
                .Property(e => e.Token)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchBankInfo>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchBankInfo>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Sys_BranchBankInfo>()
                .Property(e => e.TelephoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchBankInfo>()
                .Property(e => e.TaxNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchEmailSetting>()
                .Property(e => e.SMTPServer)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchEmailSetting>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchEmailSetting>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchEmailSetting>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchERPSetting>()
                .Property(e => e.ERPName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchERPSetting>()
                .Property(e => e.IconUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchFloor>()
                .Property(e => e.LeftLayout)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchFloor>()
                .Property(e => e.Image1)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchFloor>()
                .Property(e => e.Href1)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchFloor>()
                .Property(e => e.Image2)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchFloor>()
                .Property(e => e.Href2)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchFloor>()
                .Property(e => e.Image3)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchFloor>()
                .Property(e => e.Href3)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchFloor>()
                .Property(e => e.BackGroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchFloorDisplayType>()
                .Property(e => e.DisplayTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchFloorDisplayType>()
                .Property(e => e.GoodsName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchHelpContent>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchHelpGroup>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchHotWords>()
                .Property(e => e.HotWords)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchHotWords>()
                .Property(e => e.Href)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchPay>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchPay>()
                .Property(e => e.AppId)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchPay>()
                .Property(e => e.PartnerId)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchPay>()
                .Property(e => e.Secret)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchPay>()
                .Property(e => e.AppSecret)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchPay>()
                .Property(e => e.Public_key)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchPay>()
                .Property(e => e.Sslcert_path)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchPay>()
                .Property(e => e.CertFileUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchPay>()
                .Property(e => e.BizType)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchPayment>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchPayment>()
                .Property(e => e.ImgUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchPayment>()
                .Property(e => e.ApiPath)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchPayment>()
                .Property(e => e.RedirectUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchPayment>()
                .Property(e => e.ReturnUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchPayment>()
                .Property(e => e.NotifyUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchServicePromiseDetail>()
                .Property(e => e.Href)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchServicePromiseDetail>()
                .Property(e => e.ImgUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchSetting>()
                .Property(e => e.BranchIdOfHideMoney)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchSetting>()
                .Property(e => e.OrderDefaultTaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Sys_BranchSetting>()
                .Property(e => e.PurchaseDefaultTaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Sys_BranchSiteFooter>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchSiteSetting>()
                .Property(e => e.SiteName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchSiteSetting>()
                .Property(e => e.LogoUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchSiteSetting>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchSiteSetting>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchSiteSetting>()
                .Property(e => e.CompanyAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchSiteSetting>()
                .Property(e => e.ICP_No)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchSiteSetting>()
                .Property(e => e.CompanyTelphone)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchSiteSetting>()
                .Property(e => e.QQ)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchSiteSetting>()
                .Property(e => e.IconUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchSiteSetting>()
                .Property(e => e.ContactImage)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchSiteSetting>()
                .Property(e => e.HtmlValidate)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchSiteSetting>()
                .Property(e => e.Qrcode)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchSiteSetting>()
                .Property(e => e.SubTelphone)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchTopMenu>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_BranchTopMenu>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_CanvassAgreement>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Car>()
                .Property(e => e.Plate)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Car>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_CarLog>()
                .Property(e => e.OilMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Sys_CarLog>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_City>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_City>()
                .Property(e => e.PCode)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_City>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dept>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dept>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dept>()
                .Property(e => e.PCode)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dept>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.EnglishName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.CreateName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.UpdateUser)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_DictionaryType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_DictionaryType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_DictionaryType>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_DictionaryType>()
                .Property(e => e.UpdateUser)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_DictionaryType>()
                .HasMany(e => e.Sys_Dictionary)
                .WithRequired(e => e.Sys_DictionaryType)
                .HasForeignKey(e => e.TypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_DistributionGroup>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_ErrorLog>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_ErrorLog>()
                .Property(e => e.RelationId)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_ErrorLog>()
                .Property(e => e.ErrorMessage)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Group>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_GroupBranch>()
                .Property(e => e.JoinType)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_GroupLoginSetting>()
                .Property(e => e.body_bg_color)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_GroupLoginSetting>()
                .Property(e => e.wrapper_bg_color)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_GroupLoginSetting>()
                .Property(e => e.wrapper_bg_img)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_GroupLoginSetting>()
                .Property(e => e.header_logo_img)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_GroupLoginSetting>()
                .Property(e => e.login_bg_img)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_GroupLoginSetting>()
                .Property(e => e.footer_bg_color)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_GroupLoginSetting>()
                .Property(e => e.footer_color)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_GroupLoginSetting>()
                .Property(e => e.header_bg_color)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_GroupLoginSetting>()
                .Property(e => e.header_bg_img)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_GroupLoginSetting>()
                .Property(e => e.login_box_bg_color)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MapiServer>()
                .Property(e => e.ServerName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MapiServer>()
                .Property(e => e.ServerUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MapiServer>()
                .Property(e => e.AppKey)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MapiServer>()
                .Property(e => e.AppSecret)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MapiServer>()
                .Property(e => e.Token)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Permission>()
                .Property(e => e.ClientType)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Permission>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Permission>()
                .Property(e => e.Menu)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Permission>()
                .Property(e => e.Controller)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Permission>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Permission>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Permission>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_PermissionGroup>()
                .Property(e => e.ClientType)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_PermissionGroup>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Price>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_PrintSetting>()
                .Property(e => e.Order_Header)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_PrintSetting>()
                .Property(e => e.Order_LogoUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_PrintSetting>()
                .Property(e => e.Order_Instruction)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_PrintTemplate>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_PrintTemplate>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_PrintTemplate>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_PrintValidate>()
                .Property(e => e.Token)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Renew>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Renew>()
                .Property(e => e.Money)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Sys_Role>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Role>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Role>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_SiteCSS>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_SiteCSS>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_SiteCSS>()
                .Property(e => e.CssFileName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_SiteCSS>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Sms>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Sms>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_UrlLog>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_UrlLog>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_UrlLog>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_UserLog>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_UserLog>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Users>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Users>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Users>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Users>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Users>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Users>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Users>()
                .Property(e => e.IDCard)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Users>()
                .Property(e => e.token)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Users>()
                .Property(e => e.DingId)
                .IsUnicode(false);

            modelBuilder.Entity<SystemManager>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<SystemManager>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<SystemManager>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<TaxCategory>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TaxCategory>()
                .Property(e => e.TaxCode)
                .IsUnicode(false);

            modelBuilder.Entity<ThirdPartyGoodsMatch>()
                .Property(e => e.ThirdPartyGoodsId)
                .IsUnicode(false);

            modelBuilder.Entity<ThirdPartyLogin>()
                .Property(e => e.UUId)
                .IsUnicode(false);

            modelBuilder.Entity<ThirdPartyOrder>()
                .Property(e => e.ThirdPartyOrderId)
                .IsUnicode(false);

            modelBuilder.Entity<ThirdPartyOrder>()
                .Property(e => e.ReceiverMobile)
                .IsUnicode(false);

            modelBuilder.Entity<ThirdPartyOrder>()
                .Property(e => e.ReceiverZip)
                .IsUnicode(false);

            modelBuilder.Entity<ThirdPartyOrder>()
                .Property(e => e.CreatorMobile)
                .IsUnicode(false);

            modelBuilder.Entity<ThirdPartyOrderDetail>()
                .Property(e => e.ThirdPartyOrderId)
                .IsUnicode(false);

            modelBuilder.Entity<ThirdPartyOrderDetail>()
                .Property(e => e.SkuId)
                .IsUnicode(false);

            modelBuilder.Entity<ThirdPartyOrderDetail>()
                .Property(e => e.Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ThirdPartyOrderDetail>()
                .Property(e => e.SN)
                .IsUnicode(false);

            modelBuilder.Entity<ThirdPartyOrderDetail>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<ThirdPartyOrderDetail>()
                .Property(e => e.PrimaryImage)
                .IsUnicode(false);

            modelBuilder.Entity<Transfer>()
                .Property(e => e.OutStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Transfer>()
                .Property(e => e.InStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Transfer>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<Transfer>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TransferArchive>()
                .Property(e => e.PhotoUrl)
                .IsUnicode(false);

            modelBuilder.Entity<TransferBox>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<TransferBox>()
                .Property(e => e.StoreZone)
                .IsUnicode(false);

            modelBuilder.Entity<TransferDelivery>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<TransferDelivery>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<TransferDeliveryBox>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<TransferDeliveryBox>()
                .Property(e => e.Latitude)
                .IsUnicode(false);

            modelBuilder.Entity<TransferDeliveryBox>()
                .Property(e => e.Longitude)
                .IsUnicode(false);

            modelBuilder.Entity<TransferDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TransferDetail>()
                .Property(e => e.ReceivedStatus)
                .IsUnicode(false);

            modelBuilder.Entity<TransferPickingLog>()
                .Property(e => e.StoreZone)
                .IsFixedLength();

            modelBuilder.Entity<TransferReceiveMoney>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TransferReceiveMoney>()
                .Property(e => e.ReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TransferReceiveMoney>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<TransferReceiveMoney>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<TransferStatement>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TransferStatement>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TransferStatement>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<TransferStatement>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<TransferStatement>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<VIPApply>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<VIPApply>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApply>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApply>()
                .Property(e => e.InvoiceName)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApply>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApply>()
                .Property(e => e.InvoiceContent)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApply>()
                .Property(e => e.InvoiceCategory)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApply>()
                .Property(e => e.EmailForInvoice)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApply>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<VIPApplyDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<VIPApplyDetail>()
                .Property(e => e.DisplayUnit)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApplyDetail>()
                .Property(e => e.DisplayPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<VIPApplyInvoiceInfo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApplyInvoiceInfo>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApplyInvoiceInfo>()
                .Property(e => e.TaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApplyInvoiceInfo>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApplyInvoiceInfo>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApplyInvoiceInfo>()
                .Property(e => e.Bank)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApplyInvoiceInfo>()
                .Property(e => e.BankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApplyInvoiceInfo>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApplyInvoiceInfo>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApplyInvoiceInfo>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<VIPApplyModify>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<VIPCounter>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VIPCounter>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<VIPCounterDetail>()
                .Property(e => e.VIPPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<YangCaiOrderLog>()
                .Property(e => e.UserCode)
                .IsUnicode(false);

            modelBuilder.Entity<YangCaiOrderLog>()
                .Property(e => e.ReceiptAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<LogisticsSupported>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<LogisticsSupported>()
                .Property(e => e.CountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Config>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Config>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<V_DeadLock_Process>()
                .Property(e => e.waittype)
                .IsFixedLength();

            modelBuilder.Entity<V_DeadLock_Process>()
                .Property(e => e.lastwaittype)
                .IsFixedLength();

            modelBuilder.Entity<V_DeadLock_Process>()
                .Property(e => e.waitresource)
                .IsFixedLength();

            modelBuilder.Entity<V_DeadLock_Process>()
                .Property(e => e.status)
                .IsFixedLength();

            modelBuilder.Entity<V_DeadLock_Process>()
                .Property(e => e.sid)
                .IsFixedLength();

            modelBuilder.Entity<V_DeadLock_Process>()
                .Property(e => e.hostname)
                .IsFixedLength();

            modelBuilder.Entity<V_DeadLock_Process>()
                .Property(e => e.program_name)
                .IsFixedLength();

            modelBuilder.Entity<V_DeadLock_Process>()
                .Property(e => e.hostprocess)
                .IsFixedLength();

            modelBuilder.Entity<V_DeadLock_Process>()
                .Property(e => e.cmd)
                .IsFixedLength();

            modelBuilder.Entity<V_DeadLock_Process>()
                .Property(e => e.nt_domain)
                .IsFixedLength();

            modelBuilder.Entity<V_DeadLock_Process>()
                .Property(e => e.nt_username)
                .IsFixedLength();

            modelBuilder.Entity<V_DeadLock_Process>()
                .Property(e => e.net_address)
                .IsFixedLength();

            modelBuilder.Entity<V_DeadLock_Process>()
                .Property(e => e.net_library)
                .IsFixedLength();

            modelBuilder.Entity<V_DeadLock_Process>()
                .Property(e => e.loginame)
                .IsFixedLength();

            modelBuilder.Entity<V_DeadLock_Process>()
                .Property(e => e.context_info)
                .IsFixedLength();

            modelBuilder.Entity<V_DeadLock_Process>()
                .Property(e => e.sql_handle)
                .IsFixedLength();

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.EmployeesNum)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.Website)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.RegisterMethod)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.ServiceName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.OrderMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.StoreMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.StatementMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.PayMethod)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.InvoiceName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.InvoiceTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.InvoiceAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.InvoicePhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.InvoiceBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.InvoiceBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.InvoiceContent)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.InvoiceMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.PY)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.SalesName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.MemberRealName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Customer>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<View_CustomerCounterDetail>()
                .Property(e => e.VIPPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_CustomerCounterDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_CustomerCounterDetail>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_CustomerLog>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<View_CustomerLog>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<View_CustomerLog>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_CustomerLog>()
                .Property(e => e.MemberName)
                .IsUnicode(false);

            modelBuilder.Entity<View_CustomerLog>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_CustomerLog>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_CustomerLog>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_CustomerPreReceiveMoney>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_CustomerPreReceiveMoney>()
                .Property(e => e.InitialBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_CustomerPreReceiveMoney>()
                .Property(e => e.PreReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_CustomerPreReceiveMoney>()
                .Property(e => e.ReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_CustomerPreReceiveMoney>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_CustomerPreReceiveMoney>()
                .Property(e => e.OperatorName)
                .IsUnicode(false);

            modelBuilder.Entity<View_CustomerPreReceiveMoney>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_CustomerPreReceiveMoney>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_CustomerPreReceiveMoney>()
                .Property(e => e.ReceiveAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_DeliverAchievement>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_DeliverAchievement>()
                .Property(e => e.PickUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_DeliveryLineCustomer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_DeliveryLineCustomer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<View_DeliveryLineCustomer>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_DetailTransfer>()
                .Property(e => e.OutStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_DetailTransfer>()
                .Property(e => e.InStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_DetailTransfer>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DetailTransfer>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DetailTransfer>()
                .Property(e => e.OutBranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DetailTransfer>()
                .Property(e => e.InBranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DetailTransfer>()
                .Property(e => e.OutStoreName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DetailTransfer>()
                .Property(e => e.InStoreName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DetailTransfer>()
                .Property(e => e.OutStoreUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DetailTransfer>()
                .Property(e => e.InStoreUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DetailTransfer>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DetailTransfer>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DetailTransfer>()
                .Property(e => e.ReceivedStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_DetailTransfer>()
                .Property(e => e.DisPlayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DetailTransfer>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.BuyerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.BuyerTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.BuyerBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.BuyerBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.BuyerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.BuyerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.SaleName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.SaleTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.SaleBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.SaleBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.SalePhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.SaleAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoice>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.ChargeOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.TaxCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.BuyerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.BuyerTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.BuyerBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.BuyerBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.BuyerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.BuyerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.SaleName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.SaleTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.SaleBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.SaleBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.SalePhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.SaleAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerInvoiceDetail>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerReceiveMoney>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerReceiveMoney>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionCustomerReceiveMoney>()
                .Property(e => e.ReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionCustomerReceiveMoney>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerReceiveMoney>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerReceiveMoneyDetail>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerReceiveMoneyDetail>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionCustomerReceiveMoneyDetail>()
                .Property(e => e.ReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionCustomerReceiveMoneyDetail>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerReceiveMoneyDetail>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerReceiveMoneyDetail>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerReceiveMoneyDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionCustomerReceiveMoneyDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionCustomerReceiveMoneyDetail>()
                .Property(e => e.ChargeOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionCustomerReceiveMoneyDetail>()
                .Property(e => e.GoodsName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionCustomerReceiveMoneyDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.BuyerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.BuyerTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.BuyerBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.BuyerBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.BuyerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.BuyerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.SaleName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.SaleTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.SaleBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.SaleBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.SalePhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.SaleAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.PBranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoice>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.ChargeOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.TaxCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.BuyerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.BuyerTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.BuyerBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.BuyerBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.BuyerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.BuyerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.SaleName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.SaleTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.SaleBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.SaleBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.SalePhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.SaleAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.PBranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionInvoiceDetail>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionPay>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionPay>()
                .Property(e => e.PayMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionPay>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionPay>()
                .Property(e => e.ChildBranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionPay>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionPayDetail>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionPayDetail>()
                .Property(e => e.PayMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionPayDetail>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionPayDetail>()
                .Property(e => e.ChildBranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionPayDetail>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionPayDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionPayDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionPayDetail>()
                .Property(e => e.ChargeOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionPayDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionPayDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.BuyerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.BuyerTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.BuyerBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.BuyerBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.BuyerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.BuyerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.SaleName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.SaleTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.SaleBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.SaleBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.SalePhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.SaleAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.ChildBranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoice>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.ChargeOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.TaxCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.BuyerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.BuyerTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.BuyerBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.BuyerBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.BuyerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.BuyerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.SaleName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.SaleTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.SaleBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.SaleBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.SalePhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.SaleAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.ChildBranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveInvoiceDetail>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveMoney>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionReceiveMoney>()
                .Property(e => e.ReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionReceiveMoney>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveMoney>()
                .Property(e => e.PBranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveMoney>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveMoneyDetail>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionReceiveMoneyDetail>()
                .Property(e => e.ReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionReceiveMoneyDetail>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveMoneyDetail>()
                .Property(e => e.PBranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveMoneyDetail>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveMoneyDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionReceiveMoneyDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionReceiveMoneyDetail>()
                .Property(e => e.ChargeOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DistributionReceiveMoneyDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DistributionReceiveMoneyDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_DOStatement>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DOStatement>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DOStatement>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_DOStatement>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DOStatement>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_DOStatement>()
                .Property(e => e.InvoiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_DOStatement>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DOStatement>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DOStatement>()
                .Property(e => e.InvoiceChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DOStatement>()
                .Property(e => e.SumGoodsAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DOStatement>()
                .Property(e => e.ApplyReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DOStatement>()
                .Property(e => e.ApplyInvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DOStatement>()
                .Property(e => e.Customer)
                .IsUnicode(false);

            modelBuilder.Entity<View_DOStatement>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<View_DPStatement>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DPStatement>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DPStatement>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DPStatement>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DPStatement>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DPStatement>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_DPStatement>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DPStatement>()
                .Property(e => e.InvoiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_DPStatement>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_DPStatement>()
                .Property(e => e.UpdateByName)
                .IsUnicode(false);

            modelBuilder.Entity<View_DPStatement>()
                .Property(e => e.PaidApplyMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DPStatement>()
                .Property(e => e.InvoiceApplyMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_DPStatement>()
                .Property(e => e.InvoiceChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_FinanceRecord>()
                .Property(e => e.InitBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_FinanceRecord>()
                .Property(e => e.OperateAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_FinanceRecord>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_FinanceRecord>()
                .Property(e => e.SubjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_FinanceRecord>()
                .Property(e => e.Tpn)
                .IsUnicode(false);

            modelBuilder.Entity<View_FinanceRecord>()
                .Property(e => e.SalesName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.Guid)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.SN)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.PY)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.FranchiseeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.InPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.PackingList)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.Service)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.HomeImage)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.CombinationType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.PCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.Feature)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.InnerId)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.BrandName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.Tpn)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.Tags)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods>()
                .Property(e => e.SalesAnalysis)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods_DefaultInfo>()
                .Property(e => e.Guid)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods_DefaultInfo>()
                .Property(e => e.SN)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods_DefaultInfo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods_DefaultInfo>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods_DefaultInfo>()
                .Property(e => e.PY)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods_DefaultInfo>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods_DefaultInfo>()
                .Property(e => e.PackingList)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods_DefaultInfo>()
                .Property(e => e.Service)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods_DefaultInfo>()
                .Property(e => e.HomeImage)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods_DefaultInfo>()
                .Property(e => e.CombinationType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods_DefaultInfo>()
                .Property(e => e.Feature)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods_DefaultInfo>()
                .Property(e => e.InnerId)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods_DefaultInfo>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods_DefaultInfo>()
                .Property(e => e.SalesAnalysis)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods_DefaultInfo>()
                .Property(e => e.PurchaseUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Goods_DefaultInfo>()
                .Property(e => e.AddUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsModelValue>()
                .Property(e => e.ModelName)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsModelValue>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsModelValue>()
                .Property(e => e.SN)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsModelValue>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsModelValue>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsModelValue>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsPackage>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsPackage>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsPackage>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsPackage>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_GoodsPackage>()
                .Property(e => e.CombinationType)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsPackage>()
                .Property(e => e.DonvvSpuCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsPackage>()
                .Property(e => e.DonvvSkuCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsParamValue>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsParamValue>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsParamValue>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsPhoto>()
                .Property(e => e.PhotoUrl)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsPhoto>()
                .Property(e => e.Photo250Url)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsPhoto>()
                .Property(e => e.Photo100Url)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsTypeParam>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<View_GoodsTypeParam>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_GroupOrderStatement>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_GroupOrderStatement>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_GroupOrderStatement>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_GroupOrderStatement>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_GroupOrderStatement>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_GroupOrderStatement>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_GroupPay>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_GroupPay>()
                .Property(e => e.PayMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_GroupPay>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_GroupPay>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_GroupPay>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_GroupPay>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_ICategory>()
                .Property(e => e.Discount)
                .HasPrecision(8, 4);

            modelBuilder.Entity<View_ICategory>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<View_ICategory>()
                .Property(e => e.PCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_ICategory>()
                .Property(e => e.Discount2)
                .HasPrecision(8, 4);

            modelBuilder.Entity<View_ICategory>()
                .Property(e => e.Discount3)
                .HasPrecision(8, 4);

            modelBuilder.Entity<View_ICategory>()
                .Property(e => e.Discount4)
                .HasPrecision(8, 4);

            modelBuilder.Entity<View_IGoods>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_IGoods>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_IGoods>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<View_IGoods>()
                .Property(e => e.PCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_IGoods>()
                .Property(e => e.HomeImage)
                .IsUnicode(false);

            modelBuilder.Entity<View_IGoods>()
                .Property(e => e.BrandName)
                .IsUnicode(false);

            modelBuilder.Entity<View_IGoods>()
                .Property(e => e.GoodsTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_IGoods>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<View_IGoods>()
                .Property(e => e.MarketPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_IGoods>()
                .Property(e => e.OperateUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_Inventory>()
                .Property(e => e.StoreZone)
                .IsUnicode(false);

            modelBuilder.Entity<View_Inventory>()
                .Property(e => e.AC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_Inventory>()
                .Property(e => e.AFC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_Inventory>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_Inventory>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Inventory>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_Inventory>()
                .Property(e => e.StoreZoneMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryApply>()
                .Property(e => e.StoreZone)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryApply>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryApply>()
                .Property(e => e.AuditName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryApply>()
                .Property(e => e.CreateName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryApply>()
                .Property(e => e.GoodsName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryApply>()
                .Property(e => e.StoreName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryApply>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryLog>()
                .Property(e => e.Operate)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryLog>()
                .Property(e => e.AC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InventoryLog>()
                .Property(e => e.AFC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InventoryLog>()
                .Property(e => e.OldStoreZone)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryLog>()
                .Property(e => e.StoreZone)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryLog>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryLog>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryLog>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryModifyAC>()
                .Property(e => e.StoreZone)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryModifyAC>()
                .Property(e => e.OldAC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_InventoryModifyAC>()
                .Property(e => e.NewAC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_InventoryModifyAC>()
                .Property(e => e.StoreZoneMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryModifyAC>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryModifyAC>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryModifyAC>()
                .Property(e => e.StoreName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.CustomerType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.InvoiceName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.InvoiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.DistributionType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.AllInvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.StatementUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.InvoiceUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.InvoiceRequireUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.SalesName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.ServiceName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.PdfUrl)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.InvoiceDetailUrl)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.PlatInvoiceRequestNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.SalesCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Invoice>()
                .Property(e => e.BuyerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.InvoiceName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.InvoiceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.InvoiceMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.InvoiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.DistributionType)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.NeedToInvoice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.StatementName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.SalesName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.BuyerTaxNum)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.BuyerBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.BuyerBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.BuyerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.SaleName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.SaleTaxNum)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.SaleBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.SaleBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.SalePhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.SaleAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceAudit>()
                .Property(e => e.realInvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.InvoiceName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.InvoiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.DistributionType)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.AllInvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.StatementUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.InvoiceCreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.InvoiceDeleteUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.InvoiceRequireUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.SalesName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.ServiceName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.OrderNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.PlatInvoiceRequestNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.PdfUrl)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.InvoiceDetailUrl)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.CancelPdfUrl)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.CancelDetailUrl)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.CancelOrderNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.CancelPlatInvoiceRequestNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.StatementIds)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceLog>()
                .Property(e => e.SumAC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.InvoiceName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.InvoiceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.InvoiceMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.InvoiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.DistributionType)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.NeedToInvoice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.SumGoodsAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.StatementName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.SalesName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.BuyerTaxNum)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.BuyerBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.BuyerBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.BuyerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.SaleName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.SaleTaxNum)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.SaleBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.SaleBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.SalePhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.SaleAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequire>()
                .Property(e => e.BuyerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.InvoiceName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.InvoiceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.InvoiceMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.InvoiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.DistributionType)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.BuyerTaxNum)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.BuyerBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.BuyerBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.BuyerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.SaleName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.SaleTaxNum)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.SaleBank)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.SaleBankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.SalePhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.SaleAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.GoodsName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InvoiceRequireDetail>()
                .Property(e => e.TaxCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_IOrderContract>()
                .Property(e => e.ContractNum)
                .IsUnicode(false);

            modelBuilder.Entity<View_IOrderContract>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<View_IOrderContract>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<View_IOrderContract>()
                .Property(e => e.BankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_IOrderContract>()
                .Property(e => e.Sign)
                .IsUnicode(false);

            modelBuilder.Entity<View_IOrderContract>()
                .Property(e => e.Signature)
                .IsUnicode(false);

            modelBuilder.Entity<View_IOrderContract>()
                .Property(e => e.CFax)
                .IsUnicode(false);

            modelBuilder.Entity<View_IProjectPlat>()
                .Property(e => e.PrivateKey)
                .IsUnicode(false);

            modelBuilder.Entity<View_IProjectPlat>()
                .Property(e => e.client_id)
                .IsUnicode(false);

            modelBuilder.Entity<View_LogisticsCompany>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_LogisticsCompany>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_LogisticsCompany>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<View_LogisticsCompany>()
                .Property(e => e.CountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.IM)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.RegisterMethod)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member>()
                .Property(e => e.PCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.Guid)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.OrderType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.OrderAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.GrossProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.Point)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.Customer)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.InvoiceName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.ServiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.PurchaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.StoreStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.DeliveryStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.DeliveryType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.I_OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.I_Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.MemberName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<View_Member_Orders>()
                .Property(e => e.PCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_MemberCart>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_MemberCart>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_MemberCart>()
                .Property(e => e.HomeImage)
                .IsUnicode(false);

            modelBuilder.Entity<View_MemberCart>()
                .Property(e => e.DisplayUnit)
                .IsUnicode(false);

            modelBuilder.Entity<View_MemberDeliveryLine>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<View_MemberDeliveryLine>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<View_MemberDeliveryLine>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_ModifyAC>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_ModifyAC>()
                .Property(e => e.OldInPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ModifyAC>()
                .Property(e => e.OldAC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ModifyAC>()
                .Property(e => e.NewInPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ModifyAC>()
                .Property(e => e.NewAC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ModifyAC>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_ModifyAC>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_NeedToPurchaseDetail>()
                .Property(e => e.PurchaseType)
                .IsUnicode(false);

            modelBuilder.Entity<View_NeedToPurchaseDetail>()
                .Property(e => e.PurchaseMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_NeedToPurchaseDetail>()
                .Property(e => e.CreditCard)
                .IsUnicode(false);

            modelBuilder.Entity<View_NeedToPurchaseDetail>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<View_NeedToPurchaseDetail>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_NeedToPurchaseDetail>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_NeedToPurchaseDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_NeedToPurchaseDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_NeedToPurchaseDetail>()
                .Property(e => e.PurchaseUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_NeedToPurchaseDetail>()
                .Property(e => e.GoodsMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_NeedToPurchaseDetail>()
                .Property(e => e.StoreName)
                .IsUnicode(false);

            modelBuilder.Entity<View_News>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<View_News>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderAfterSale>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderAfterSale>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderAfterSale>()
                .Property(e => e.ApplyType)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderAfterSale>()
                .Property(e => e.ApplyReason)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderAfterSale>()
                .Property(e => e.ReturnWay)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderAfterSale>()
                .Property(e => e.PickupAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderAfterSale>()
                .Property(e => e.ReceiveAddress)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderAfterSale>()
                .Property(e => e.ApplyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderAfterSale>()
                .Property(e => e.ContactWay)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderAfterSale>()
                .Property(e => e.DisplayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderAfterSale>()
                .Property(e => e.InnerStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderAfterSale>()
                .Property(e => e.OperateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderAfterSale>()
                .Property(e => e.OperateType)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderAfterSale>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderAfterSale>()
                .Property(e => e.HomeImage)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDeliveryBox>()
                .Property(e => e.OrderBoxStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDeliveryBox>()
                .Property(e => e.OrderDeliveryStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.AC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.Point)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.PurchaseMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.HomeImage)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.ServiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.PurchaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.StoreStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.DeliveryStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.SN)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.Customer)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.CustomerShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.OrderAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.I_OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.OrderType)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.SalesName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.DisplayUnit)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.DisplayPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.GrossProfitPercent)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.AFC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.GrossProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.TaxMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.NoTaxMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.OrderGrossProfitPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.TaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.NoTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.DetailGrossProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.NoTaxPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.DisplayNoTaxPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.Tpn)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail>()
                .Property(e => e.DisplayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail_Goods>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail_Goods>()
                .Property(e => e.AC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail_Goods>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail_Goods>()
                .Property(e => e.Point)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail_Goods>()
                .Property(e => e.PurchaseMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail_Goods>()
                .Property(e => e.DisplayUnit)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail_Goods>()
                .Property(e => e.DisplayPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDetail_Goods>()
                .Property(e => e.GrossProfitPercent)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail_Goods>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail_Goods>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail_Goods>()
                .Property(e => e.InPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_OrderDetail_Goods>()
                .Property(e => e.SN)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDetail_Goods>()
                .Property(e => e.GrossProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.Guid)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.OrderType)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.GrossProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.Point)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.Customer)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.InvoiceName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.ServiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.PurchaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.StoreStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.DeliveryStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.I_OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.I_Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.ChargeOff)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.DeliveryType)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.InvoiceCategory)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.EmailForInvoice)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.ConfirmStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.ThirdPartyId)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.usercode)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.PayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.OrderAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.TaxMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.NoTaxMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDistribution>()
                .Property(e => e.GrossProfitPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDistributionDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDistributionDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDistributionDetail>()
                .Property(e => e.OrgPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDistributionDetail>()
                .Property(e => e.OrgAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDistributionDetail>()
                .Property(e => e.DisplayUnit)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistributionDetail>()
                .Property(e => e.DisplayPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDistributionDetail>()
                .Property(e => e.GrossProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderDistributionDetail>()
                .Property(e => e.GrossProfitPercent)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistributionDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderDistributionDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderGoodsComments>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderGoodsComments>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderGoodsComments>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderGoodsComments>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderGoodsComments>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderGoodsComments>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderGoodsComments>()
                .Property(e => e.ServiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderGoodsComments>()
                .Property(e => e.DeliveryStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderGoodsComments>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderModify>()
                .Property(e => e.OldPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderModify>()
                .Property(e => e.NewPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderModify>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderModify>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderModify>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderModify>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderModify>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderModify>()
                .Property(e => e.DisplayUnit)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderModify>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderModify>()
                .Property(e => e.OldTaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderModify>()
                .Property(e => e.NewTaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderModifyAC>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderModifyAC>()
                .Property(e => e.GrossProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderModifyAC>()
                .Property(e => e.NewGrossProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderModifyAC>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderModifyAC>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderModifyAC>()
                .Property(e => e.OldAC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_OrderModifyAC>()
                .Property(e => e.NewAC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_OrderModifyAC>()
                .Property(e => e.OldGrossProfitPercent)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderModifyAC>()
                .Property(e => e.NewGrossProfitPercent)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderModifyAC>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderModifyAC>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.OrderType)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.OrderAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.GrossProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.Point)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.Customer)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.StoreStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.ServiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.PurchaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.DeliveryStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.Guid)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.SalesName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderPicking>()
                .Property(e => e.ThirdPartyId)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderReceiveMoney>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderReceiveMoney>()
                .Property(e => e.ReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderReceiveMoney>()
                .Property(e => e.DiscountMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderReceiveMoney>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderReceiveMoney>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderReceiveMoney>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderReceiveMoney>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderReceiveMoney>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderReceiveMoney>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderReceiveMoney>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderReceiveMoney>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderReceiveMoney>()
                .Property(e => e.CustomerSalesman)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderReceiveMoneyDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderReceiveMoneyDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderReceiveMoneyDetail>()
                .Property(e => e.ChargeOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderReceiveMoneyDetail>()
                .Property(e => e.GoodsName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderReceiveMoneyDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderReceiveMoneyDetail>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderReceiveMoneyDetail>()
                .Property(e => e.ReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderReceiveMoneyDetail>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderReceiveMoneyDetail>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderReceiveMoneyDetail>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.Guid)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.OrderType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.OrderAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.GrossProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.Point)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.Customer)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.InvoiceName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.ServiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.PurchaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.StoreStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.DeliveryStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.I_Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.SalesName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.ServiceName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.ChargeOff)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.I_OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.SalesName_Now)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.SalesDeptName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.ConfirmStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.ThirdPartyId)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.CustomerShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.TaxMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.NoTaxMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.GrossProfitPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.ArchiveUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.CustomerType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.SumAC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Orders>()
                .Property(e => e.DisPlayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.InvoiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.NeedToInvoice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.InvoiceMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.InvoiceContent)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrderStatement>()
                .Property(e => e.SumGoodsAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.Guid)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.OrderType)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.GrossProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.Point)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.Customer)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.InvoiceName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.InvoiceContent)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.ServiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.PurchaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.StoreStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.DeliveryStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.I_OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.I_Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.DeliveryType)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.InvoiceCategory)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.EmailForInvoice)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.ConfirmStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.ThirdPartyId)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.usercode)
                .IsUnicode(false);

            modelBuilder.Entity<View_OrdersYangCaiLog>()
                .Property(e => e.ReceiptAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<View_ORMAudit>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_ORMAudit>()
                .Property(e => e.ReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_ORMAudit>()
                .Property(e => e.DiscountMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_ORMAudit>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_ORMAudit>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_ORMAudit>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_ORMAudit>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_ORMAudit>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_ORMAudit>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_ORMAudit>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_ORMAudit>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_ORMAudit>()
                .Property(e => e.ApproveUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_PickOrderDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PickOrderDetail>()
                .Property(e => e.AC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PickOrderDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PickOrderDetail>()
                .Property(e => e.Point)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PickOrderDetail>()
                .Property(e => e.PurchaseMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_PickOrderDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PickOrderDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_PickOrderDetail>()
                .Property(e => e.StoreZone)
                .IsUnicode(false);

            modelBuilder.Entity<View_PickOrderDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_PickOrderDetail>()
                .Property(e => e.StoreZoneMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_PickPurchaseDetail>()
                .Property(e => e.InPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PickPurchaseDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PickPurchaseDetail>()
                .Property(e => e.PurchaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_PickPurchaseDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PickPurchaseDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_PickPurchaseDetail>()
                .Property(e => e.StoreZone)
                .IsUnicode(false);

            modelBuilder.Entity<View_PickPurchaseDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_PickPurchaseDetail>()
                .Property(e => e.StoreZoneMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_PickPurchaseDetail>()
                .Property(e => e.DetailMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Product_Info>()
                .Property(e => e.Params)
                .IsUnicode(false);

            modelBuilder.Entity<View_Product_Info>()
                .Property(e => e.SourceUrl)
                .IsUnicode(false);

            modelBuilder.Entity<View_Product_Info>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Product_Info>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Product_Info>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Product_Info>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.PurchaseType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.SupplierStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.SupplierTaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.BankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.TelPhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.ReceiptName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.AddUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.StoreName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.TaxMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.NoTaxMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Purchase>()
                .Property(e => e.ThirdPartyId)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.BillsPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.InPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.PurchaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.SupplierStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.PurchaseType)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.SupplierShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.TelPhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.DetailMemo)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.PurchaseName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.DonvvBrandName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.SN)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.DonvvBrandId)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.AddUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.TaxMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.NoTaxMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.TaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.NoTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseDetail>()
                .Property(e => e.NoTaxInPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseLog>()
                .Property(e => e.PurchaseType)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseLog>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseLog>()
                .Property(e => e.PurchaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseLog>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseLog>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseModify>()
                .Property(e => e.OldPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseModify>()
                .Property(e => e.NewPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseModify>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseModify>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseModify>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseModify>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseModify>()
                .Property(e => e.OldTaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseModify>()
                .Property(e => e.NewTaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseModify>()
                .Property(e => e.OldNoTaxPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseModify>()
                .Property(e => e.NewNoTaxPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchasePay>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchasePay>()
                .Property(e => e.PayMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchasePay>()
                .Property(e => e.DiscountMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchasePay>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePay>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePay>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchasePay>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchasePay>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePay>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePay>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePay>()
                .Property(e => e.TelPhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePay>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePay>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePay>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePay>()
                .Property(e => e.ApplyName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePayAudit>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchasePayAudit>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePayAudit>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchasePayAudit>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchasePayAudit>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePayAudit>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePayAudit>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePayAudit>()
                .Property(e => e.TelPhone)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePayAudit>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePayAudit>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePayAudit>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePayAudit>()
                .Property(e => e.ApproveUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePayAudit>()
                .Property(e => e.FinanceData)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePayDetail>()
                .Property(e => e.InPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchasePayDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchasePayDetail>()
                .Property(e => e.ChargeOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchasePayDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePayDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePayDetail>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchasePayDetail>()
                .Property(e => e.PayMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchasePayDetail>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePayDetail>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePayDetail>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePayDetail>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchasePayDetail>()
                .Property(e => e.PurchaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseQuoteDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseQuoteDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseQuoteDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseQuoteDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatement>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseStatement>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseStatement>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatement>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatement>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatement>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatement>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatement>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatement>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatement>()
                .Property(e => e.Expr1)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatement>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseStatementDetail>()
                .Property(e => e.PurchaseType)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatementDetail>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseStatementDetail>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatementDetail>()
                .Property(e => e.SupplierStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatementDetail>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatementDetail>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatementDetail>()
                .Property(e => e.TaxMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseStatementDetail>()
                .Property(e => e.NoTaxMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseStatementGoodsDetail>()
                .Property(e => e.InPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseStatementGoodsDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseStatementGoodsDetail>()
                .Property(e => e.PurchaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatementGoodsDetail>()
                .Property(e => e.PurchaseType)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatementGoodsDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatementGoodsDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatementGoodsDetail>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_PurchaseStatementGoodsDetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseStatementGoodsDetail>()
                .Property(e => e.NoTaxInPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseStatementGoodsDetail>()
                .Property(e => e.TaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_PurchaseStatementGoodsDetail>()
                .Property(e => e.NoTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.Guid)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.OrderType)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.GrossProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.Point)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.Customer)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.ServiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.PurchaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.StoreStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.DeliveryStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.I_OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.I_Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.DeliveryType)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.InvoiceCategory)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.EmailForInvoice)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.ConfirmStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_QuotationOrder>()
                .Property(e => e.SalesName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SourceGoods>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<View_SourceGoods>()
                .Property(e => e.SourceSku)
                .IsUnicode(false);

            modelBuilder.Entity<View_SourceGoods>()
                .Property(e => e.SourceMainSku)
                .IsUnicode(false);

            modelBuilder.Entity<View_SourceGoods>()
                .Property(e => e.SpecVals)
                .IsUnicode(false);

            modelBuilder.Entity<View_SourceGoods>()
                .Property(e => e.SourceCategory)
                .IsUnicode(false);

            modelBuilder.Entity<View_SourceGoods>()
                .Property(e => e.SourceBrand)
                .IsUnicode(false);

            modelBuilder.Entity<View_SourceGoods>()
                .Property(e => e.SourcePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SourceGoods>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SourceGoods>()
                .Property(e => e.SN)
                .IsUnicode(false);

            modelBuilder.Entity<View_SourceGoods>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SourceGoods>()
                .Property(e => e.BrandName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SourceGoods>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_SourceGoods>()
                .Property(e => e.CombinationType)
                .IsUnicode(false);

            modelBuilder.Entity<View_SourceGoods>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierDetail>()
                .Property(e => e.BillsPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierDetail>()
                .Property(e => e.InPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierDetail>()
                .Property(e => e.PurchaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierInvoice>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierInvoice>()
                .Property(e => e.SysUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierInvoice>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierInvoice>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierInvoice>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierInvoice>()
                .Property(e => e.InvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierInvoiceDetails>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierInvoiceDetails>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierInvoiceDetails>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierInvoiceDetails>()
                .Property(e => e.InPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierInvoiceDetails>()
                .Property(e => e.ToInvoiceMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierInvoiceDetails>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierInvoiceDetails>()
                .Property(e => e.PurchaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierInvoiceDetails>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierInvoiceDetails>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierInvoiceDetails>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierInvoiceDetails>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierOrder>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierOrder>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierOrder>()
                .Property(e => e.PurchaseType)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierOrder>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierOrder>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierOrder>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierOrder>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierOrder>()
                .Property(e => e.SupplierStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierOrder>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierOrder>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierOrder>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierPrepayment>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierPrepayment>()
                .Property(e => e.InitialBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierPrepayment>()
                .Property(e => e.Prepayment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierPrepayment>()
                .Property(e => e.Payment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierPrepayment>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierPrepayment>()
                .Property(e => e.OperatorName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierPrepayment>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierPrepayment>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierPrepayment>()
                .Property(e => e.PayAccount)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierReceiveInvoice>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierReceiveInvoice>()
                .Property(e => e.LastTimeSABalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierReceiveInvoice>()
                .Property(e => e.PurchaseAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierReceiveInvoice>()
                .Property(e => e.PurchasePayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierReceiveInvoice>()
                .Property(e => e.InvoiceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierSettleAccounts>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierSettleAccounts>()
                .Property(e => e.SysUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SupplierSettleAccounts>()
                .Property(e => e.PurchaseAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierSettleAccounts>()
                .Property(e => e.PurchasePayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierSettleAccounts>()
                .Property(e => e.InvoiceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierSettleAccounts>()
                .Property(e => e.LastTimeBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_SupplierSettleAccounts>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Sys_Branch_CSS>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Branch_CSS>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Branch_CSS>()
                .Property(e => e.CssFileName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Branch_CSS>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_BranchGroup>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_BranchGroup>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_BranchGroup>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_BranchGroup>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_BranchGroup>()
                .Property(e => e.CityAlias)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_BranchGroup>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_BranchGroup>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_BranchGroup>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_BranchGroup>()
                .Property(e => e.Introduction)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_BranchGroup>()
                .Property(e => e.Domain)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_BranchGroup>()
                .Property(e => e.Domain2)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_BranchGroup>()
                .Property(e => e.DonvvDomain)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_BranchGroup>()
                .Property(e => e.JoinType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_BranchGroup>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_BranchGroup>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Distribution>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Distribution>()
                .Property(e => e.TopBranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Distribution>()
                .Property(e => e.PBranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Distribution>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Distribution>()
                .Property(e => e.BranchShortName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Distribution>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Distribution>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Distribution>()
                .Property(e => e.CityAlias)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Distribution>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Distribution>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Distribution>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Distribution>()
                .Property(e => e.Introduction)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Distribution>()
                .Property(e => e.Domain)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Distribution>()
                .Property(e => e.Domain2)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Distribution>()
                .Property(e => e.DonvvDomain)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Distribution>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Permission>()
                .Property(e => e.ClientType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Permission>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Permission>()
                .Property(e => e.Menu)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Permission>()
                .Property(e => e.Controller)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Permission>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Permission>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Permission>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Permission>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_RolePermission>()
                .Property(e => e.ClientType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_RolePermission>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_RolePermission>()
                .Property(e => e.Controller)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_RolePermission>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_RolePermission>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_RolePermission>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_RolePermission>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_RolePermission>()
                .Property(e => e.Menu)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Users>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Users>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Users>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Users>()
                .Property(e => e.Telphone)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Users>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Users>()
                .Property(e => e.IDCard)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Users>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Users>()
                .Property(e => e.token)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Users>()
                .Property(e => e.DingId)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Users>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Sys_Users>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TaxCategory>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_TaxCategory>()
                .Property(e => e.TaxCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_TaxCategory>()
                .Property(e => e.AddUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TaxCategory>()
                .Property(e => e.UpdateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TaxCategory>()
                .Property(e => e.GoodsTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transfer>()
                .Property(e => e.OutStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transfer>()
                .Property(e => e.InStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transfer>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transfer>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Transfer>()
                .Property(e => e.OutBranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transfer>()
                .Property(e => e.InBranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transfer>()
                .Property(e => e.OutStoreName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transfer>()
                .Property(e => e.InStoreName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transfer>()
                .Property(e => e.OutStoreUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transfer>()
                .Property(e => e.InStoreUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transfer>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferDeliveryBox>()
                .Property(e => e.TransferBoxStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferDeliveryBox>()
                .Property(e => e.TransferDeliveryStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferDetail>()
                .Property(e => e.OutStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferDetail>()
                .Property(e => e.InStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferDetail>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferDetail>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_TransferDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_TransferDetail>()
                .Property(e => e.ReceivedStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferPicking>()
                .Property(e => e.OutStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferPicking>()
                .Property(e => e.InStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferPicking>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferPicking>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_TransferPicking>()
                .Property(e => e.OutBranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferPicking>()
                .Property(e => e.InBranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferPicking>()
                .Property(e => e.OutStoreName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferPicking>()
                .Property(e => e.InStoreName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferPicking>()
                .Property(e => e.InStoreUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferPicking>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferPicking>()
                .Property(e => e.PickingUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferReceiveMoney>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_TransferReceiveMoney>()
                .Property(e => e.ReceiveMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_TransferReceiveMoney>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferReceiveMoney>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferReceiveMoney>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_TransferReceiveMoney>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferReceiveMoney>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_TransferReceiveMoney>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferReceiveMoney>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferStatement>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_TransferStatement>()
                .Property(e => e.PaidMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_TransferStatement>()
                .Property(e => e.PayStatus)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferStatement>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferStatement>()
                .Property(e => e.ChargeOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_TransferStatement>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TransferStatement>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_User_Permission>()
                .Property(e => e.ClientType)
                .IsUnicode(false);

            modelBuilder.Entity<View_User_Permission>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_User_Permission>()
                .Property(e => e.Menu)
                .IsUnicode(false);

            modelBuilder.Entity<View_User_Permission>()
                .Property(e => e.Controller)
                .IsUnicode(false);

            modelBuilder.Entity<View_User_Permission>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<View_User_Permission>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<View_User_Permission>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<View_User_Permission>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<View_User_Role>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<View_User_Role>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<View_User_Role>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<View_User_Role>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_User_Role>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<View_User_Role>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApply>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_VIPApply>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApply>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApply>()
                .Property(e => e.InvoiceName)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApply>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApply>()
                .Property(e => e.InvoiceContent)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApply>()
                .Property(e => e.InvoiceCategory)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApply>()
                .Property(e => e.EmailForInvoice)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApply>()
                .Property(e => e.MemberName)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApply>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApplyDetail>()
                .Property(e => e.SumMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_VIPApplyDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApplyDetail>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApplyDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_VIPApplyDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApplyDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApplyDetail>()
                .Property(e => e.HomeImage)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApplyDetail>()
                .Property(e => e.MemberName)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApplyDetail>()
                .Property(e => e.MemberDeptName)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApplyDetail>()
                .Property(e => e.MemberDeptCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApplyDetail>()
                .Property(e => e.MemberDeptPCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApplyDetail>()
                .Property(e => e.DisplayUnit)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPApplyDetail>()
                .Property(e => e.DisplayPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_VIPCounterCustomer>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPCounterCustomer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPCounterDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPCounterDetail>()
                .Property(e => e.VIPPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_VIPCounterDetail>()
                .Property(e => e.GoodsName)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPCounterDetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPCounterDetail>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPCounterDetail>()
                .Property(e => e.PCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPCounterDetail>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPCounterDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_VIPCounterDetail>()
                .Property(e => e.HomeImage)
                .IsUnicode(false);

            modelBuilder.Entity<View_VirtualInventory>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<View_VirtualInventory>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_VirtualInventory>()
                .Property(e => e.UserName)
                .IsUnicode(false);
        }
    }
}
