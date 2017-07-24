using System.Collections.Generic;

namespace TShirtApp
{
    public class TshirtPriceProvider
    {
        private static Dictionary<string, ITshirtPrice> _tShirtPrice = new Dictionary<string, ITshirtPrice>();

        public TshirtPriceProvider()
        {
            _tShirtPrice = new Dictionary<string, ITshirtPrice>()
            {
                { "1", new TshirtOneDayPrice()},
                { "2", new TshirtTwoDayPrice()},
                { "3", new TshirtThreeDayPriITshirtPricece()}
            };
        }

        public ITshirtPrice TshirtPrice(string key)
        {
            return _tShirtPrice[key];
        }
    }
}
