using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFdoga_FR_12B.models;

namespace WPFdoga_FR_12B.datas
{
    internal class Show
    {

        public List<books> ReadBooks()
        {

            using (var context = new KonyvtardbContext())
            {
                var book = context.Books.ToList();
                return book;
            }
        }

    }
}
