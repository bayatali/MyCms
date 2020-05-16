using Microsoft.EntityFrameworkCore;
using MyCms.DataLayer;
using MyCms.DomainClasses.Page;
using MyCms.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCms.Services.Services
{
    public class PageRepository : IPageRepository
    {

        private MyCmsDbContext _db;

        public PageRepository(MyCmsDbContext db)
        {
            this._db = db;
        }
        public IEnumerable<Page> GetAllPages()
        {
            return _db.Pages.ToList();
        }


        public Page GetPageById(int pageId)
        {
           return _db.Pages.Find(pageId);
        }

      
        public void InsertPage(Page page)
        {
             _db.Pages.Add(page);
        }

        public void UpdatePage(Page page)
        {
            _db.Entry(page).State = EntityState.Modified;
        }
        public void DeletePage(Page page)
        {
            _db.Entry(page).State = EntityState.Deleted;
        }

        public void DeletePage(int pageId)
        {
            var page = GetPageById(pageId);
            DeletePage(page);
            
        }
        public void Save()
        {
            _db.SaveChanges();
        }

       
    }
}
