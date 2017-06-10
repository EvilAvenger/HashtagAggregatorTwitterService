﻿using System.Collections.Generic;
using Hangfire;
using Hangfire.Storage;
using HashtagAggregatorTwitter.Contracts.Interface;

namespace HahtagAggregatorTwitter.Storage
{
    public class HangfireStorageAccessor : IStorageAccessor
    {
        public List<RecurringJobDto> GetJobsList()
        {
            return JobStorage.Current.GetConnection().GetRecurringJobs();
        }
    }
}
