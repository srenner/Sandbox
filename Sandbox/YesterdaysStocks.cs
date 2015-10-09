using System;
using System.Linq;

namespace Sandbox
{
    /*
        The indices are the time in minutes past trade opening time, which was 9:30am local time.
        The values are the price in dollars of Apple stock at that time.

        For example, if the stock cost $500 at 10:30am, stock_prices_yesterday[60] = 500.

        Write an efficient function that takes stock_prices_yesterday and returns the best profit I could have made 
        from 1 purchase and 1 sale of 1 Apple stock yesterday.

        No "shorting",you must buy before you sell. You may not buy and sell in the same time step 
        (at least 1 minute must pass). 
    */ 
    public class YesterdaysStocks
    {
        private int _minValue;
        private int _maxValue;
        private int _dayLength;
        private int[] _stockPricesYesterday;

        public YesterdaysStocks(int minValue = 400, int maxValue = 500, int dayLength = 400)
        {
            _minValue = minValue;
            _maxValue = maxValue;
            _dayLength = dayLength;
        }

        public void Run()
        {
            BuildStockPrices();
        }

        private void BuildStockPrices()
        {
            if (_stockPricesYesterday == null)
            {
                _stockPricesYesterday = new int[_dayLength];
                for (int i = 0; i < _stockPricesYesterday.Length; i++)
                {
                    Random random = new Random();
                    _stockPricesYesterday[i] = random.Next(_minValue, _maxValue);
                }
            }
        }

        private int Analyze()
        {
            int lowest = _maxValue;
            int lowestPosition = 0;
            int highest = _minValue;
            int highestPosition = 0;
            int maxProfit = 0;
            for (int i = 0; i < _stockPricesYesterday.Length; i++)
            {
                if (_stockPricesYesterday[i] < lowest)
                {
                    lowest = _stockPricesYesterday[i];
                    lowestPosition = i;
                }
                else if (_stockPricesYesterday[i] > highest)
                {
                    highest = _stockPricesYesterday[i];
                    highestPosition = i;
                }
            }
            reteurn maxProfit;
        }
    }
}

