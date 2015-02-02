using UnityEngine;
using System.Collections;

[AddComponentMenu ("Fabiel/WebService/Services/ContentGenerator")]
public class ContentGenerator : MonoBehaviour {

	#region PUBLIC_VARIABLES
	public InstanceContent instanceContent;
	#endregion

	#region PRIVATE_VARIABLES

	#endregion

	#region MONOBEHAVIOUR_METHODS
	// Use this for initialization
	void Start () {
		if(instanceContent == null){
			instanceContent = (InstanceContent) FindObjectOfType(typeof (InstanceContent));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	#endregion

	#region PUBLIC_METHODS
	public void LoadDataContent(int idContentWeb){
		instanceContent.DestroyModel();
		SearchContent.GetContentInfo(idContentWeb, gameObject);
	}

	public void LoadInfoContent(string encodedString){
		//parse json incoming
		Debug.Log("EncodedString " + encodedString);
		JSONObject jsonInfo = new JSONObject(encodedString);
		Debug.Log("DataInfo " + jsonInfo.GetField("type").n);
		ParceContentData(jsonInfo);
  }

	//access data (and print it)
	private void ParceContentData(JSONObject jsonInfo){
		ContentInfo contentInfo = new ContentInfo();
		contentInfo.Id = (int)jsonInfo.GetField("id").n;
		contentInfo.Name = jsonInfo.GetField("name").str;
		contentInfo.Description = jsonInfo.GetField("description").str;
		contentInfo.Type = (int)jsonInfo.GetField("type").n;
		contentInfo.UrlContent = DomainUtils.parseToArray(jsonInfo.GetField("url-content"));
		contentInfo.UrlLocalContent = DomainUtils.parseToArray(jsonInfo.GetField("url-local-content"));
		instanceContent.InstanceObjects(contentInfo);
	}
	#endregion

	#region PRIVATE METOHODS

	#endregion
}
