namespace TShirtAppTest
{
    public class TshirtPrice : ITshirtPrice
    {
        private readonly decimal _tShirtDesignCost;
        private readonly TshirtOneDayPrice _tshirtOneDayPrice;
        private readonly TshirtTwoDayPrice _tshirtTwoDayPrice;
        private readonly TshirtThreeDayPrice _tshirtThreeDayPrice;

        public TshirtPrice(decimal designCost)
        {
            _tShirtDesignCost = designCost;
            _tshirtOneDayPrice = new TshirtOneDayPrice(this);
            _tshirtTwoDayPrice = new TshirtTwoDayPrice(this);
            _tshirtThreeDayPrice = new TshirtThreeDayPrice(this);
        }

        public decimal CalculateOneDayPrice()
        {
            return _tshirtOneDayPrice.CalculatePrice(100);
        }

        public decimal CalculateTwoDayPrice()
        {
            return _tshirtTwoDayPrice.CalculateTwoDayPrice();
        }

        public decimal CalculateThreeDayPrice()
        {
            return _tshirtThreeDayPrice.CalculateThreeDayPrice();
        }

    }
}
