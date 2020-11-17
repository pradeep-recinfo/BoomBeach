using UIControllersAndData.GameResources;

namespace UIControllersAndData.Models
{
    public interface IProdBuilding
    {
        GameResourceType GetProdType();
        int GetProdPerHour();
    }
}