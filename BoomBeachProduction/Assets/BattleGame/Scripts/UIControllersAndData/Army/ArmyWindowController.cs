using System.Collections.Generic;
using UIControllersAndData.Units;
using UnityEngine;

namespace Army
{
    public class ArmyWindowController:MonoBehaviour
    {

        [SerializeField] private List<ArmyItem> _listOfUnItems;
        
        public void Initialize()
        {
                foreach (ExistedUnit existedUnit in Stats.Instance.ExistingUnits)
                {
                    _listOfUnItems[existedUnit.id].Initialize(existedUnit.count);
                }
        }
    }
}
