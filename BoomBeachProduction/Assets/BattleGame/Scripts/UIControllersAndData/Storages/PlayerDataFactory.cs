using Assets.Scripts.UIControllersAndData.Player;
using JetBrains.Annotations;

namespace Assets.Scripts.UIControllersAndData.Storages
{
	public class PlayerDataFactory:SingletonModelFactory<PlayerData> 
	{
		private const string PLAYER_DATA_FILE_NAME = "PlayerData";

		public PlayerDataFactory([NotNull] IPersistentStorage storage) : base(storage)
		{
		}

		protected override string PersistentPath
		{
			get { return PLAYER_DATA_FILE_NAME; }
		}
	}
}
