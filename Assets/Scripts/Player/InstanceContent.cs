using UnityEngine;
using System.Collections;

[AddComponentMenu ("Fabiel/Content Manager/Instance Content")]
public class InstanceContent : MonoBehaviour {

	/*
	 * 1:image, 2:model, 3:music, 4:video, 5:model with animation, 6:model with music
	 */
	public string typeData;
	public Transform model;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/**
	 * create content info to rendere in RA 
	 */
	public void InstanceObjects(ContentInfo contentInfo){
		Debug.Log("Instantiate element " + contentInfo.Name + contentInfo.Type);
		switch(contentInfo.Type){
			case 1:
				break;
			case 2:
				break;
			case 3:
				break;
			case 4:
				break;
			case 5:
				IntantiateModel(contentInfo);
				break;
			case 6:
				IntantiateModelMusic(contentInfo);
				break;        
		}
	}

	public void DestroyModel(){
		if(model != null){
			Destroy(model.gameObject);
		}
	}

	private void IntantiateModel(ContentInfo contentInfo){
		Debug.Log("Local Resource " + contentInfo.UrlLocalContent[0]);
		model = (Transform)Instantiate(Resources.LoadAssetAtPath<Transform>((string)contentInfo.UrlLocalContent[0]), transform.position, Quaternion.identity);
		model.transform.parent = gameObject.transform;
	}

	private void IntantiateModelMusic(ContentInfo contentInfo){
		Debug.Log("Local Resource " + contentInfo.UrlLocalContent[0]);
		model = (Transform)Instantiate(Resources.LoadAssetAtPath<Transform>((string)contentInfo.UrlLocalContent[0]), transform.position, Quaternion.identity);
		model.transform.parent = gameObject.transform;
	}
}
