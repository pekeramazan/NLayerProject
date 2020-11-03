﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NLayerProject.Core.Repositories;

namespace NLayerProject.Core.UnitOfWorks
{
    public interface UnitOfWorks
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }

        Task CommitAsync();
        void Commit();
    }
}
