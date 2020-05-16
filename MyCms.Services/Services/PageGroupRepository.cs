using MyCms.DataLayer;
using MyCms.DomainClasses.PageGroup;
using MyCms.Services.Repositories;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace MyCms.Services.Services
{
    public class PageGroupRepository : IPageGroupRepository
    {
        private MyCmsDbContext _db;
        public PageGroupRepository(MyCmsDbContext db)
        {
           _db = db;
        }

     

        public List<PageGroup> GetAllPageGroups()
        {
            return _db.PageGroups.ToList();
        }

        public PageGroup GetPageGroupById(int groupId)
        {
            return _db.PageGroups.Find(groupId);
        }

        public void InsertPageGroup(PageGroup pageGroup)
        {
            _db.PageGroups.Add(pageGroup);
        }

        public void UpdatePageGroup(PageGroup pageGroup)
        {
            _db.Entry(pageGroup).State = EntityState.Modified;
        }

        public void DeletePageGroup(PageGroup pageGroup)
        {
            _db.Entry(pageGroup).State = EntityState.Deleted;
        }

        public void DeletePageGroup(int groupId)
        {
            var group = GetPageGroupById(groupId);
            DeletePageGroup(group);
        }



        public void Save()
        {
            _db.SaveChanges();
        }

        public bool PageGroupExists(int pageGroupId)
        {
            return _db.PageGroups.Any(p => p.GroupID == pageGroupId);
        }
    }
}
