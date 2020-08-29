using System;
using System.Net;
using System.IO;
using System.Text.Json;
//using JValue;
//using Formatting;


namespace myApp
{
    class Program
    {
		private static string apiKey = "RGAPI-f8db2d2b-b629-486e-a5c4-6c9f01ddeedf";
		
		private static string buildRequest(int choice, string summonerNameUrl)
		{
			string requestString = "";
			switch(choice)
			{
				case 1:
				{
					
					requestString = "https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + summonerNameUrl;
					break;
				}
				case 2:
				{
					/* WebRequest request = WebRequest.Create("https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + summonerNameUrl + "?api_key=" + apiKey);
					WebResponse response = request.GetResponse();
					using (Stream dataStream = response.GetResponseStream())
					{
						StreamReader reader = new StreamReader(dataStream);
						string responseFromServer = reader.ReadToEnd();
						using JsonDocument doc = JsonDocument.Parse(responseFromServer);
						JsonElement root = doc.RootElement;
						string encryptedSummonerId = root.GetProperty("id").GetString(); */
						requestString = "https://na1.api.riotgames.com/lol/league/v4/entries/by-summoner/" + getEncryptedID(summonerNameUrl);
				//	}
					//response.Close();
					break;
				}
				case 3:
				{
					requestString = "https://na1.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-summoner/" + getEncryptedID(summonerNameUrl);
					break;
				}
				case 4:
				{
					requestString = "https://na1.api.riotgames.com/lol/league-exp/v4/entries/RANKED_SOLO_5x5/CHALLENGER/I";
					break;
				}
			}
			return requestString;
		}
		
		private static string getEncryptedID(string summonerNameUrl)
		{
			WebRequest request = WebRequest.Create("https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + summonerNameUrl + "?api_key=" + apiKey);
			WebResponse response = request.GetResponse();
			Stream dataStream = response.GetResponseStream();
			StreamReader reader = new StreamReader(dataStream);
			string responseFromServer = reader.ReadToEnd();
			using JsonDocument doc = JsonDocument.Parse(responseFromServer);
			
			
			response.Close();
			dataStream.Close();
			return doc.RootElement.GetProperty("id").GetString();
			
		}
		
		private static string getChampionDataList()//broken
		{
			WebRequest request = WebRequest.Create("https://ddragon.leagueoflegends.com/cdn/10.16.1/data/en_US/champion.json");
			WebResponse response = request.GetResponse();
			Stream dataStream = response.GetResponseStream();
			StreamReader reader = new StreamReader(dataStream);
			string dataString = reader.ReadToEnd();
			response.Close();
			dataStream.Close();
			return dataString;
			
		}
		
		private static void printResults(int choice, JsonElement root, string summoner)
		{
			switch(choice)
			{
				case 1:
				{
				//	Console.WriteLine("root: " + root);
					Console.WriteLine("Summoner name: " + root.GetProperty("name"));
					Console.WriteLine("Profile Icon ID: " + root.GetProperty("profileIconId"));
					Console.WriteLine("Encrypted Summoner ID: " + root.GetProperty("id"));
					Console.WriteLine("Summoner Level: " + root.GetProperty("summonerLevel"));
					break;
				}
				case 2:
				{
					if(root.GetArrayLength() == 0)
					{
						Console.WriteLine("No ranked data to display");
						break;
					}
					Console.WriteLine("Ranked information for " + summoner);
					for(int i = 0; i < root.GetArrayLength(); i++)
					{
						Console.WriteLine("League Type: " + root[i].GetProperty("queueType"));
						Console.WriteLine("Tier: " + root[i].GetProperty("tier"));
						Console.WriteLine("Rank: " + root[i].GetProperty("rank"));
						Console.WriteLine("Winrate: " + (100 * Math.Round(root[i].GetProperty("wins").GetDouble() /
										 (root[i].GetProperty("wins").GetDouble() + root[i].GetProperty("losses").GetDouble()), 4)) + "%");
					}
					break;
				}
				case 3:
				{	
					if(root.GetArrayLength() == 0)
					{
						Console.WriteLine("No mastery data to display");
						break;
					}	
					Console.WriteLine("Amount of champions to display?: ");
					int n = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Top " + n + " champion mastery for "  + summoner);
					
					
					
					
					//request ddragon info to translate championId to champion name
	

					string strChampionDataList = getChampionDataList();
					using JsonDocument doc = JsonDocument.Parse(strChampionDataList);
					JsonElement element = doc.RootElement;
					JsonElement championDataList = element.GetProperty("data");
					//Console.WriteLine(championDataList);
					for(int i = 0; i < n; i++)
					{
						if(i >= root.GetArrayLength())//tying to display more champions than available (n > total champions)
							break;
						foreach(JsonProperty champion in championDataList.EnumerateObject())
						{
							JsonElement championData = champion.Value;
							if(championData.GetProperty("key").ToString() == root[i].GetProperty("championId").ToString())
							{
								Console.WriteLine((i+1) + ". " + championData.GetProperty("name") + " - Mastery Level " + root[i].GetProperty("championLevel")
												 + " with " + root[i].GetProperty("championPoints") + " points");
								break;
							}
						}
						
					}

					break;
				}
				case 4:
				{
					for(int i = 0; i < root.GetArrayLength(); i++)
					{
						string formatNum = ((i+1) + ".").PadRight(5);
						Console.WriteLine(formatNum + root[i].GetProperty("summonerName"));
					}
					break;
				}
			}
			
		}
		
		private static string[] summonerNameInput()
		{
			string[] summonerInfo = new string[2];
			Console.Write("Enter the summoner name:  ");
			string summoner = Console.ReadLine();
			//in case of spaces, "URLify" the name for use in the URL later
			string urlSummoner = "";
			foreach (char ch in summoner)
			{
				if(ch == ' ')
					urlSummoner += "%20";
				else
					urlSummoner += ch;
			}				
			Console.WriteLine("Summoner name URLified: " + urlSummoner);
			summonerInfo[0] = summoner;
			summonerInfo[1] = urlSummoner;
			return summonerInfo;
		}
		
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
			//Console.WriteLine("The current time is " + DateTime.Now);
			
			//expires every 24 hours
			bool done = false;
			while(!done)
			{
				Console.WriteLine("Enter the request type:");
				Console.WriteLine("1:Summoner lookup by name");
				Console.WriteLine("2:Summoner league lookup");
				Console.WriteLine("3:Champion mastery lookup");
				Console.WriteLine("4:View Challenger League");
				//Console.WriteLine("0:Quit");
				try
				{
					int choice = Convert.ToInt32(Console.ReadLine());
					string summoner = "";
					string urlSummoner = "";
					if(choice <= 3)
					{
						string[] summonerInfo = summonerNameInput();
						urlSummoner = summonerInfo[1];
						summoner = summonerInfo[0];
					}
					
					
					
					//create a webrequest using the WebRequest class
					WebRequest request = WebRequest.Create(buildRequest(choice,urlSummoner) + "?api_key=" + apiKey);
					//get the response using the WebResponse class
					WebResponse response = request.GetResponse();
				
				
				
					Console.WriteLine(((HttpWebResponse)response).StatusDescription);
					
					//the using block will automatically close the dataStream
					using (Stream dataStream = response.GetResponseStream())
					{
						// Open the stream using a StreamReader for easy access.
						StreamReader reader = new StreamReader(dataStream);
						// Read the content.
						string responseFromServer = reader.ReadToEnd();
						using JsonDocument doc = JsonDocument.Parse(responseFromServer);
						JsonElement root = doc.RootElement;
						printResults(choice, root, summoner);
					//	Console.WriteLine("root: " + root);
					//	Console.WriteLine("Summoner name: " + root.GetProperty("name"));
					//	Console.WriteLine("Profile Icon ID: " + root.GetProperty("profileIconId"));
					   // Console.WriteLine(responseFromServer);
					}
					Console.WriteLine("Continue?(Y/N)");
					string confirm = Console.ReadLine();
					if(confirm[0] != 'y' && confirm[0] != 'Y')
						done = true;
					response.Close();	
				}
				
				
				
				
				catch(Exception e)
				{
					Console.WriteLine(e.ToString());
					
				}

			}
			
        }
    }
}
