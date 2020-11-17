using System.Collections.Generic;
using UIControllersAndData.Models;

namespace UIControllersAndData.Store.Categories.Buildings
{
    [System.Serializable]
    public class BuildingCategoryLevels: INamed, IId
    {
        public string name;
        public int id;
        public List<BuildingsCategory> levels;

        public string GetName()
        {
            return name;
        }

        public int GetId()
        {
            return id;
        }
    }
}
