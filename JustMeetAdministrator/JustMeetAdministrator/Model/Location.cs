namespace JustMeetAdministrator.Model
{
    public class Location
    {
        public int idLocation { get; set; }
        public double longitud { get; set; }
        public double latitud { get; set; }
        public int idUser { get; set; }

        public Location(int idLocation, double longitud, double latitud, int idUser)
        {
            this.idLocation = idLocation;
            this.longitud = longitud;
            this.latitud = latitud;
            this.idUser = idUser;
        }

        public Location()
        {
        }
    }
}
