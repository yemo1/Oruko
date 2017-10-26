using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrukoNG.Entities;
using OrukoNG.Models;
using OrukoData;


namespace OrukoNG.Repositories
{
    public class Name:IName
    {
        private OrukoContext _context;

        public Name(OrukoContext Context)
        {
            this._context = Context;
        }

        public IEnumerable<Tune> GetTunes()
        {
            return _context.Tunes.ToList();
        }

        public IEnumerable<ETune> GetETunes()
        {
            return _context.ETunes.ToList();
        }
        public string GetByXter(string xter)
        {
            var db = _context.Tunes.Where(x => x.Names.StartsWith(xter)).FirstOrDefault();
            if (db == null)
                return string.Empty;
            return db.Names;
        }

        public string GetByEXter(string xter)
        {
            var db = _context.ETunes.Where(x => x.Rbt_Name.StartsWith(xter)).FirstOrDefault();
            if (db == null)
                return string.Empty;
            return db.Rbt_Name;
        }

        public string GetByName(string name)
        {
            var db = _context.Tunes.Where(x => x.Names.Contains(name)).FirstOrDefault();
            if (db == null)
                return string.Empty;
            return db.Names;
        }

        public string GetByEName(string name)
        {
            var db = _context.ETunes.Where(x => x.Rbt_Name.Contains(name)).FirstOrDefault();
            if (db == null)
                return string.Empty;
            return db.Rbt_Name;
        }
    }
}