using UnityEngine;
using System.Collections;

[AddComponentMenu ("Fabiel/WebService/Services/SearchContent")]
public class SearchContent : MonoBehaviour {

	#region PRIVATE_VARIABLES
	private static int idContent;
	private static string results = "";
	private static string errors;
	#endregion
	
	#region PUBLIC_VARIABLES

	#endregion
	
	#region MONOBEHAVIOUR_METHODS
	void Start () {
		
	}
	
	void Update () {
		
	}
	#endregion
	
	#region PUBLIC_METHODS
	public static void GetContentInfo(int idContentWeb, GameObject callbackObj){
		idContent = idContentWeb;
		switch(idContent){
			case 1:
				results = "{" +
						"\"id\":1, " +
						"\"name\": \"mariposa\", " +
						"\"description\": \"mariposa\", " +
						"\"type\": 5, " +
						"\"url-content\": {\"none\"}," +
					"\"url-local-content\":{\"Prefabs/mariposa/butterfly2\"} " +
						"}";
				break;
			case 6:
				results = "{" +
				"\"id\":6, " +
					"\"name\": \"ballenas\", " +
					"\"description\": \"ballenas en el mar\", " +
					"\"type\": 6, " +
					"\"url-content\": {\"http://www.scubadelivery.com/expertos/vida_marina/humback.whale.12.mp3\"}," +
					"\"url-local-content\":{\"Prefabs/ballena/whale\"} " +
						"}";
				break;
			default:
				results = "{errors : no data found}";
					break;
		}
		callbackObj.SendMessage("LoadInfoContent", results, SendMessageOptions.RequireReceiver);
	}
	#endregion
	
	#region PRIVATE METOHODS
	#endregion
}
