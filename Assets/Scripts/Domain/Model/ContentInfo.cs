using UnityEngine;
using System.Collections;

[AddComponentMenu ("Fabiel/WebService/Model/ContentInfo")]
public class ContentInfo {

	private int id;
	private string name;
	private string description;
	private int type;
	private ArrayList urlContent;
	private ArrayList urlLocalContent;

	public int Id {
		get {
			return this.id;
		}
		set {
			id = value;
		}
	}

	public string Name {
		get {
			return this.name;
		}
		set {
			name = value;
		}
	}

	public string Description {
		get {
			return this.description;
		}
		set {
			description = value;
		}
	}

	public int Type {
		get {
			return this.type;
		}
		set {
			type = value;
		}
	}

	public ArrayList UrlContent {
		get {
			return this.urlContent;
		}
		set {
			urlContent = value;
		}
	}

	public ArrayList UrlLocalContent {
		get {
			return this.urlLocalContent;
		}
		set {
			urlLocalContent = value;
		}
	}

}
