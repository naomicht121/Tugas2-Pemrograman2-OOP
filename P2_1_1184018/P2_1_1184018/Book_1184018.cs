using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1184018
{
    public class Book_1184018 : Product_1184018
    {
        protected string pageCount;

        public Book_1184018(string type, string title, string pagecount)  
            : base(type, title)      
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }
            set
            {
                pageCount = value;
            }
        }

    }
}
