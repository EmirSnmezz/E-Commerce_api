

namespace Core.Utilities.Messages.Constants
{
    public static class Messages
    {
        #region Messages Of Product

            #region Product Messages For Successful Processes

                public const string ProductAddedSuccessfully = "Ürün Başarıyla Eklendi.";
                public const string ProductUpdatedSuccessfully = "Ürün Başarıyla Güncellendi.";
                public const string ProductDeletedSuccessfully = "Ürün Başarıyla Silindi";
                public const string ProductsListedSuccessfully = "Ürünler Başarıyla Listelendi";


        #region ValidationMessages
        public const string ProductNameMustBeNotNull = "Ürün adı bilgisi boş geçilemez";
        public const string CategoryNameMustBeNotNullOnTheProductDefinition = "Ürün tanımlama esnasında Kategori bilgisi boş geçilemez.";
        public const string UnitsInStockNotBeNullOnTheProductDefinition = "Ürün Tanımlama Esnasında Stok Adedi bilgisi Boş Geçilemez.";
        public const string UnitPriceNotBeNullOnTheProductDefinition = "Ürün tanımlama esnasında birim fiyat bilgisi boş geçilemez.";

        #endregion

        #endregion

        #region Product Messages For Failed Process
        public const string ProductAddedError = "Ürün Eklenirken Hata!";
                public const string ProducUpdatedError = "Ürün Güncellenirken Hata!";
                public const string ProductDeletedError = "Ürün Silinirken Hata!";
                public const string ProductsListedError = "Ürünler Listelenirken Hata!";
        #endregion

        #endregion


        #region Messages Of Category

        #region Category Messages For Successful Process

            public const string CategoryAddedSuccessfully = "Kategori Başarıyla Eklendi.";
            public const string CategoryUpdatedSuccessfully = "Kategori Başarıyla Güncellendi.";
            public const string CategoryDeletedSuccessfully = "Kategori Başarıyla Silindi";
            public const string CatagoriesListedSuccessfully = "Kategoriler Başarıyla Listelendi";
      
        #endregion

        #region Category Messages For Failed Process

            public const string CategoryAddedError = "Kategori Eklenirken Hata!";
            public const string CategoryUpdatedError = "Kategori Güncellenirken Hata!";
            public const string CategoryDeletedError = "Kategori Silinirken Hata!";
            public const string CategoriesListedError = "Kategoriler Listelenirken Hata!";

        #endregion

        #endregion


        #region Messages Of Customer

        #region Customer Messages For Successful Process

            public const string CustomerAddedSuccessfully = "Müşteri Başarıyla Eklendi.";
            public const string CustomerUpdatedSuccessfully = "Müşteri Başarıyla Güncellendi.";
            public const string CustomerDeletedSuccessfully = "Müşteri Başarıyla Silindi";
            public const string CustomersListedSuccessfully = "Müşteriler Başarıyla Listelendi.";

        #endregion

        #region Customer Messages For Failed Process

            public const string CustomerAddError = "Müşteri Eklenirken Hata!";
            public const string CustomerUpdateError = "Müşteri Güncellenirken Hata!";
            public const string CustomerDeleteError = "Müşteri Silinirken Hata!";
            public const string CustomersListedError = "Müşteriler Listelenirken Hata!";

        #endregion

        #endregion


        #region Global Messages

            public const string MaintenanceTimeError = "Sistem Saat 22.00 İtibariyle Bakıma Alındığı İçin Hizmet Verememektedir. Lütfen Bir Kaç Saat Sonra Tekrar Deneyiniz.";

        #endregion

    }
}
