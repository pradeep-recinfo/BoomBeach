using Assets.Scripts.UIControllersAndData.Store;
using UIControllersAndData.GameResources;

namespace UIControllersAndData.Models
{
    public interface IStoreBuilding
    {
        int GetStoreCap();
        StoreType GetStoreType();
        GameResourceType GetStoreResource();
    }
}