using UIControllersAndData.GameResources;

namespace Assets.Scripts.UIControllersAndData.GameResources
{
	
	public class ResourceData 
	{
		public GameResourceType Type { get; set; }
		public int CurrentValue { get; set; }
		public int MaxValue { get; set; }
	}
}