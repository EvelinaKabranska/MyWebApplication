namespace MyWebApplication.Data.Models
{
    using MyWebApplication.Data.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }

        public string Extension { get; set; }

        public string RemoteImageUrl { get; set; }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }
    }
}
