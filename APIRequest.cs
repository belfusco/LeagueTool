using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LToolsGUI {
    class APIRequest {
		//static for holding apiKey to be implemented in form design input box
		private static String apiKey;
		//holds a working summonerName to be updated when input box is changed
		private String summonerName;

		//construct an empty Request shell when form boots
		public APIRequest() {
			summonerName = "";
		}

		public String GetName() {
			return summonerName;
		}

		//update the APIRequest's SummonerName when the textbox is changed
		public void UpdateName(String name) {
			summonerName = name;
		}

		//returns a formatted String (?) of the Summoner Info using current request's SummonerName and the apiKey
		public String ProcessSummCheck() {
			return "TEST OUTPUT SUMMCHECK";
		}

		public String ProcessRankedCheck() {
			return "";
		}

		public String ProcessMasteryCheck(int numChamps) {
			return "";
		}


	}
}
