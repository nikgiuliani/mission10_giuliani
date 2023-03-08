using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission10_giuliani.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Books> Books { get; }
    } 
}