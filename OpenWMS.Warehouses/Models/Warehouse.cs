using OpenWMS.Warehouses.Interfaces;

namespace OpenWMS.Warehouses.Models
{
    public class Warehouse : IWarehouse
    {
        public static IWarehouse New()
        {
            return new Warehouse();
        }

        public IWarehouse SetId(string newId)
        {
            throw new System.NotImplementedException();
        }

        public IWarehouse SetName(string newName)
        {
            throw new System.NotImplementedException();
        }
    }
}
