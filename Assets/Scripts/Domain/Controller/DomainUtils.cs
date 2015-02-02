using UnityEngine;
using System.Collections;

[AddComponentMenu ("Fabiel/WebService/Utilities/DomainUtils")]
public class DomainUtils : MonoBehaviour {


	public static ArrayList parseToArray(JSONObject jsonArray){
		ArrayList arrayList = new ArrayList();
		for(int i = 0; i < jsonArray.list.Count; i++){
			JSONObject j = (JSONObject)jsonArray.list[i];
			if(JSONObject.Type.STRING == j.type){
				arrayList.Add(j.str);
			}
		}
		return arrayList;
	}

}
