﻿using Leagueoflegends.Data.Setting.Clients;

namespace Leagueoflegends.Data.Setting
{
	public class SettingModel
	{ 
		public ClientNormalModel ClientNormal { get; set; }
		public ClientAlarmModel ClientAlarm { get; set; }
		public ClientChatModel ClientChat { get; set; }
		public ClientSoundModel ClientSound { get; set; }

		public SettingModel()
		{
			ClientNormal = new ClientNormalModel();
			ClientAlarm = new ClientAlarmModel();
			ClientChat = new ClientChatModel();
			ClientSound = new ClientSoundModel();
		}
	}
}
