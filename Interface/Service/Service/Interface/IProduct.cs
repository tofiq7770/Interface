using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface IProduct
    {
        Product[] GetAll();
        Product[] GetCountOfProduct();
        Product[] SortName(string name);
        Product[] SortByDateTime();
    }
}
