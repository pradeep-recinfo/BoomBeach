using Assets.Scripts.UIControllersAndData;

namespace UIControllersAndData.Store
{
	
	public class BaseStoreItemData 
	{
		public string Description;
		public CurrencyType Currency;
		public int Price;
		public int TimeToBuild;
		public int XpAward;
		public int HP;
		public int UpRatio; //how much can you upgrade in relation to HQ - half, equal, double

		public string IdOfBigIcon;
		public string IdOfSmallIcon;
		public string IdOfIconOnBuyButton;
		public string IdOfBlackBigIcon;

		public int MaxCountOfThisItem;
	}
}