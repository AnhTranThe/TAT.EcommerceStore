using System.Text.Json.Serialization;

namespace TAT.Ecommerce.Domain.Helpers
{
    public class Enums
    {
        #region User properties
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum EGender
        {

            NotDetect,
            Male,
            Female,
            Other,
        }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum EUserStatus
        {
            Block,
            Active,
            InActive,
        }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum ERoleType
        {
            Admin,
            StoreOwner,
            Shipper,
            Customer
        }
        #endregion
        #region Order properties
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum EOrderStatus
        {
            PendingPayment,
            Created,
            Doing,
            Delivered,
            Completed,
            Cancelled,

        }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum EOrderBy
        {
            HighToLow,
            LowToHigh,
            Latest,
            Oldest,
            Default
        }
        #endregion
        #region UploadFile properties
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum EUploadFileStatus
        {
            Delete,
            Active,
        }
        #endregion
        #region TransactionType
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum ETransactionType
        {
            Order,
            AmountTransfer,
        }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum EWalletType
        {
            Deposit,// tien gui
            Payment, // thanh toan
            Refund, // hoan tra
            Withdrawal, // rut tien
        }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum EPayType
        {
            Wallet,
            Momo,
            VnPay
        }
        #endregion
        #region TagType 
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum ETagType
        {
            Category,
            Product,
            Post

        }
        #endregion

    }
}
