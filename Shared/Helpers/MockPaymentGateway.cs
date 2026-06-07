using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Smart_Food_Delivery.Shared.Helpers
{
    public class MockPaymentGateway
    {
        //simulated user balance(in real app,fectch from DB/session)
        public static decimal UpiBalance{get;set;}=5000m;
        public static decimal CardBalance{get;set;}=10000m;
        //simulate payment processing
        public static bool ProcessUpiPayment(decimal Amount)
        {
            if(Amount<0) return false;
            if (UpiBalance >= Amount)
            {
                UpiBalance-=Amount;
                return true;
            }
            return false;//insufficent balance
        }

        public static bool ProcessCardPayment(decimal amount)
        {
            if(amount<0) return false;
            if (CardBalance >= amount)
            {
                CardBalance-=amount;
                return true;
            }
            return false;
        }

        //cash always succeed(asuming customer gives exact cash)
        public static bool ProcessCashPayment(decimal amount)
        {
            return amount>0;
        }

    }
}