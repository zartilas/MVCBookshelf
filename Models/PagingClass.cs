using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBookshelf.Models
{
    public class PagingClass
    {
        /// <summary>
        /// Gets or sets Customers.
        /// </summary>
        public List<titles> Customers { get; set; }

        /// <summary>
        /// Gets or sets CurrentPageIndex.
        /// </summary>
        public int CurrentPageIndex { get; set; }

        /// <summary>
        /// Gets or sets PageCount.
        /// </summary>
        public int PageCount { get; set; }
    }
}
