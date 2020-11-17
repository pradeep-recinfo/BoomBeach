namespace Assets.Scripts.UIControllersAndData.Player
{
    public interface IPlayer
    {

        PlayerData GetPlayer();

        void Save();

        PlayerEvent PlayerEvt { get; }
    }
}
