using MyCms.DomainClasses.PageGroup;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCms.Services.Repositories
{
  public  interface IPageGroupRepository
    {
        List<PageGroup> GetAllPageGroups();
        PageGroup GetPageGroupById(int groupId);
        void InsertPageGroup(PageGroup pageGroup);
        void UpdatePageGroup(PageGroup pageGroup);
        void DeletePageGroup(PageGroup pageGroup);
        void DeletePageGroup(int groupId);
        bool PageGroupExists(int pageGroupId);
        void Save(); 

    }
}
