using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AggregatorApi.Models
{
    public class Product
    {
        private  List<ProductFee>? _fees;
        private  List<ProductErc>? _ercs;
        private  List<ProductRate>? _rates;
        private  List<ProductFeature>? _features;

        #region Public Properties

        /// <summary>
        /// Gets or sets the alias account code.
        /// </summary>
        /// <value>
        /// The alias account code.
        /// </value>
        public string? AliasAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string? Type  { get; set; }      


        /// <summary>
        /// Gets or sets the mortgage term.
        /// </summary>
        /// <value>
        /// The mortgage term.
        /// </value>
        public string? MortgageTerm { get; set; } = null!;

        /// <summary>
        /// Gets or sets the initial rate.
        /// </summary>
        /// <value>
        /// The initial rate.
        /// </value>
        public decimal InitialRate { get; set; }

        /// <summary>
        /// Gets or sets the subsequent rate.
        /// </summary>
        /// <value>
        /// The subsequent rate.
        /// </value>
        public decimal SubsequentRate { get; set; }

        /// <summary>
        /// Gets or sets the fee.
        /// </summary>
        /// <value>
        /// The fee.
        /// </value>
        public decimal Fee { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public string? FundCode { get; set; }

        /// <summary>
        /// Gets or sets the repayment amount.
        /// </summary>
        /// <value>
        /// The repayment amount.
        /// </value>
        public decimal RepaymentAmount { get; set; }

        /// <summary>
        /// Gets or sets the interest only amount.
        /// </summary>
        /// <value>
        /// The interest only amount.
        /// </value>
        public decimal InterestOnlyAmount { get; set; }

        /// <summary>
        /// Gets or sets the total term months.
        /// </summary>
        /// <value>
        /// The total term months.
        /// </value>
        public int TotalTermMonths { get; set; }

        /// <summary>
        /// Gets or sets the product cost.
        /// </summary>
        /// <value>
        /// The product cost.
        /// </value>
        //public ProductCostOverYears ProductCost { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [no product fees].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [no product fees]; otherwise, <c>false</c>.
        /// </value>
        public bool NoProductFees { get; set; }

        /// <summary>
        /// Gets or sets the monthly payment.
        /// </summary>
        /// <value>
        /// The monthly payment.
        /// </value>
        public decimal MonthlyPayment { get; set; }

        /// <summary>
        /// Gets or sets the APR.
        /// </summary>
        /// <value>
        /// The APR.
        /// </value>
        public decimal Apr { get; set; }

        /// <summary>
        /// Gets or sets the total amount payable during erc period.
        /// </summary>
        /// <value>
        /// The total amount payable during erc period.
        /// </value>
        public decimal TotalAmountPayableDuringErcPeriod { get; set; }

        /// <summary>
        /// Gets or sets the total amount payable.
        /// </summary>
        /// <value>
        /// The total amount payable.
        /// </value>
        public decimal TotalAmountPayable { get; set; }

        /// <summary>
        /// Gets or sets the product id.
        /// </summary>
        /// <value>
        /// The product id.
        /// </value>
        
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? ProductId { get; set; }

        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the product description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the product AccountTypeCode
        /// </summary>
        /// <value>
        /// The product AccountTypeCode.
        /// </value>
        public string? AccountTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the product fees.
        /// </summary>
        /// <value>
        /// The product fees.
        /// </value>
        public List<ProductFee>? Fees
        {
            get { return _fees;}
            set { _fees = value; }
        }

        /// <summary>
        /// Gets the ercs.
        /// </summary>
        public List<ProductErc>? Ercs
        {
            get { return _ercs; }
            set { _ercs = value; }
        }

        /// <summary>
        /// Gets the rates.
        /// </summary>
        public List<ProductRate>? Rates
        {
            get { return _rates; }
            set { _rates = value; }
        }

        /// <summary>
        /// Gets the features.
        /// </summary>
        public List<ProductFeature>? Features
        {
            get { return _features; }
            set { _features = value; }
        }

        /// <summary>
        /// Gets or sets the product features.
        /// </summary>
        /// <value>
        /// The product features.
        /// </value>
        //public ProductFeaturesSummary ProductFeatures { get; set; }

        #endregion

       
    }
    public class ProductRate
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string? Type { get; set; }

        /// <summary>
        /// Gets or sets the rate.
        /// </summary>
        /// <value>
        /// The rate.
        /// </value>
        public decimal Rate { get; set; }

        /// <summary>
        /// Gets or sets the term.
        /// </summary>
        /// <value>
        /// The term.
        /// </value>
        public string? Term { get; set; }

        /// <summary>
        /// Gets or sets the cap.
        /// </summary>
        /// <value>
        /// The cap.
        /// </value>
        public decimal? Cap { get; set; }

        /// <summary>
        /// Gets or sets the collar.
        /// </summary>
        /// <value>
        /// The collar.
        /// </value>
        public decimal? Collar { get; set; }
    }
    public class ProductFeature
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the long description.
        /// </summary>
        /// <value>
        /// The long description.
        /// </value>
        public string? LongDescription { get; set; }

        #endregion

    }
    public class ProductFee
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string? Type { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Enumeration for Product Fee Type Ids
        /// </summary>
        /// <value>
        /// Product Fee Type Id
        /// </value>
        public enum ProductFeeTypeIds
        {
            Redemption = 4,
            Repayment = 8,
            Solicitor = 12
        }

        #endregion
    }
    public class ProductErc
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the percentage of basis.
        /// </summary>
        /// <value>
        /// The basis.
        /// </value>
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Gets or sets the amount of basis.
        /// </summary>
        /// <value>
        /// The basis.
        /// </value>
        public decimal Amount { get; set; }

        #endregion
    }

    public enum ProductFeaturesFilter
    {
        None = 0,
        FixedRate = 1,
        Tracker = 2,
        Variable = 4,
        NoEarlyRepaymentCharges = 8,
        NoExtendedTieIn = 16,
        FreeLegalFees = 32,
        FreeValuationFees = 64,
        FeesFree = 128,
        PaymentHolidays = 256,
        BorrowbackMoney = 512,
        CashLumpsumAtOutsetOfLoan = 1024,
        OneYear = 2048,
        TwoYear = 4096,
        ThreeYear = 8192,
        FourYear = 16384,
        FiveYear = 32768,
        OverFiveYear = 65536,
        Overpayment = 131072,
        TrackerOrVariable = 262144
    }

}
