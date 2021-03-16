namespace MyWebApplication.Services.Data
{
    using MyWebApplication.Services.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IGetCountsService
    {
        CountsDto GetCounts();
    }
}
