﻿using Autofac;
using HashtagAggregatorTwitter.Contracts;
using HashtagAggregatorTwitter.Service.Infrastructure.Queues;
using HashtagAggregatorTwitter.Service.Infrastructure.Twitter;

namespace HashtagAggregatorTwitter.Service.Configuration.Modules
{
    public class TwitterModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TwitterAuth>().As<ITwitterAuth>();
            builder.RegisterType<TwitterQueue>().As<ITwitterQueue>();
        }
    }
}
