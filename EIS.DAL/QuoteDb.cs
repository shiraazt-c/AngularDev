using EIS.BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIS.DAL
{
    public class QuoteDb
    {
        private EISDBContext db;

        public QuoteDb()
        {
            db = new EISDBContext();
        }
        public IEnumerable<Quote> GetALL()
        {
            return db.Quotes.ToList();
        }
        public Quote GetByID(int Id)
        {
            return db.Quotes.Find(Id);
        }
        public void Insert(Quote quote)
        {
            db.Quotes.Add(quote);
            Save();
        }
        public void Delete(int Id)
        {
            Quote quote = db.Quotes.Find(Id);
            db.Quotes.Remove(quote);
            Save();
        }
        public void Update(Quote quote)
        {
            db.Entry(quote).State = EntityState.Modified;
            db.Configuration.ValidateOnSaveEnabled = false;
            Save();
            db.Configuration.ValidateOnSaveEnabled = true;
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
