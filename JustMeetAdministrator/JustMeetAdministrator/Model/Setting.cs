namespace JustMeetAdministrator.Model
{
    public class Setting
    {
        public int idSetting { get; set; }
        public double maxDistance { get; set; }
        public int minAge { get; set; }
        public int maxAge { get; set; }
        public string genre { get; set; }
        public int? idGameType { get; set; }
        public GameType IdGametypeNavigation { get; set; }

        public Setting(int idSetting, double maxDistance, int minAge, int maxAge, string genre, int? idGameType, GameType idGametypeNavigation)
        {
            this.idSetting = idSetting;
            this.maxDistance = maxDistance;
            this.minAge = minAge;
            this.maxAge = maxAge;
            this.genre = genre;
            this.idGameType = idGameType;
            IdGametypeNavigation = idGametypeNavigation;
        }

        public Setting()
        {
        }
    }
}
