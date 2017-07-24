﻿using System.Collections.Generic;

namespace TShirtAppTest
{
    public class DiscountProvider
    {
        private static Dictionary<string, IDiscount> _discount = new Dictionary<string, IDiscount>();

        public DiscountProvider()
        {
            _discount = new Dictionary<string, IDiscount>()
            {
                { "None", new StudentDiscount()},
                { "Student", new StudentDiscount()},
                { "Member", new MemberDiscount()},
                { "StudentMember", new StudentMemberDiscount()}
            };
        }

        public IDiscount Discount(string key)
        {
            return _discount[key];
        }
    }
}
