using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFdoga_FR_12B.models;

namespace WPFdoga_FR_12B.datas
{
    internal class Add
    {

        KonyvtarResults konyvtarResults = new KonyvtarResults();

        public KonyvtarResults AddBooks(books konyv)
        {

            if (konyv == null)
            {

                konyvtarResults.Message = "A könyv adatai hiányoznak.";
                konyvtarResults.Result = null;
                return konyvtarResults;

            }

            if (string.IsNullOrWhiteSpace(konyv.title))
            {

                konyvtarResults.Message = "A könyv címe kötelező.";
                konyvtarResults.Result = null;
                return konyvtarResults;

            }

            using (var context = new KonyvtardbContext())
            {

                var book = new books
                {

                    title = konyv.title?.Trim(),
                    author = konyv.author?.Trim(),
                    year = konyv.year,
                    price = konyv.price

                };

                context.Books.Add(book);

                try
                {

                    context.SaveChanges();
                    konyvtarResults.Message = "Sikeres könyv felvétel";
                    konyvtarResults.Result = book;

                }
                catch (Exception ex)
                {

                    konyvtarResults.Message = "Hiba a mentés során: " + ex.Message;
                    konyvtarResults.Result = null;

                }

                return konyvtarResults;
            }

        }

    }
}
