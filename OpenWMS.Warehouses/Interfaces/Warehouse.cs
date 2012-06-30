using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenWMS.Warehouses.Interfaces
{
    public interface IWarehouse
    {
        IWarehouse SetId(string newId);
        IWarehouse SetName(string newName);        
    }
}
