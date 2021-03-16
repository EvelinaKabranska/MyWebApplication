﻿namespace MyWebApplication.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ICategoriesService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs();
    }
}