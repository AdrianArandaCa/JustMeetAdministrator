﻿using System.Net.WebSockets;

namespace JustMeetAdministrator.Model
{
    public class User
    {
        public int idUser { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int? birthday { get; set; }
        public string genre { get; set; }
        public string photo { get; set; }
        public string description { get; set; }
        public bool premium { get; set; }
        public int? idSetting { get; set; }
        public bool? isConnected { get; set; }
        public Setting idSettingNavigation { get; set; }
        public Location Locations { get; set; }
    }

}
