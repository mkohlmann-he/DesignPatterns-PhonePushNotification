﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_PhonePush
{
    public class Subscription_Sports : Abstract_Subscription
    {
        public Subscription_Sports(Abstract_Subscription subscription, Abstract_NewsFeed NewsFeedObject) : base(subscription, NewsFeedObject)
        {
            this.NewsFeedName = "Sports";
        }
    }
}
