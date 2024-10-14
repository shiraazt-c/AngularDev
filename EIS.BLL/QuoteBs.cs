using EIS.BOL;
using EIS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIS.BLL
{
    public class QuoteBs
    {
        private QuoteDb objDb;

        public QuoteBs()
        {
            objDb = new QuoteDb();
        }
        public IEnumerable<Quote> GetALL()
        {
            return objDb.GetALL().ToList();
        }
        public Quote GetByID(int Id)
        {
            return objDb.GetByID(Id);
        }
        public void Insert(Quote quote)
        {
            quote.Info=  string.IsNullOrEmpty(quote.Info) ? "TemporaryUnavailable" : quote.Info;
            objDb.Insert(quote);
        }
        public void Delete(int Id)
        {
            objDb.Delete(Id);
        }
        public void Update(Quote quote)
        {
            objDb.Update(quote);
        }
    }
}