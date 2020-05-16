﻿using MyCms.DomainClasses.Page;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCms.Services.Repositories
{
   public interface IPageRepository
    {
        IEnumerable<Page> GetAllPages();
        Page GetPageById(int pageId);
        void InsertPage(Page page);
        void UpdatePage(Page page);
        void DeletePage(Page page);
        void DeletePage(int pageId);
        void Save();

    }
}
