namespace OpenWMS.Warehouses.Interfaces
{
    public interface IWarehouse
    {
        IWarehouse SetId(string newId);
        IWarehouse SetName(string newName);        
    }
}
