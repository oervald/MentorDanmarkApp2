using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class BrickFactory : MonoBehaviour {
	public GameObject brick;
	public GameObject imagePanel;
	ColorClass cc;
	Dictionary<string, GameObject> BricksInUse;
	// Use this for initialization
	void Start () {
		cc = new ColorClass ();
		BricksInUse = new Dictionary<string, GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CreateBrick(string title){
		GameObject object_brick = Instantiate (brick) as GameObject;
		object_brick.GetComponentInChildren<Text>().text = title;

		object_brick.GetComponentInChildren<Image> ().color = ColorSync (title);
		BricksInUse.Add(title, object_brick);
		object_brick.transform.localScale = (new Vector3 (0.45f, 0.45f, 0.45f));
		object_brick.transform.SetParent(imagePanel.transform,true);



	}

	public void DestroyBrick(string title){
		List<string> keys = new List<string> (BricksInUse.Keys);
		foreach (string s in keys) {
			if(s == title){
				GameObject gm =BricksInUse[s];


				BricksInUse.Remove(s);
				Destroy(gm);
			
			}
		}
	}

	public Color32 ColorSync(string title){
		Color32 ret = new Color32();
		switch (title) {
		case "An" :
			ret = cc.Analytisk;
			break;
		case "Ho" :
			ret = cc.Holistisk;
			break;
		case "Vi" :
			ret = cc.Visuel;
			break;
		case "Au" :
			ret = cc.Auditiv;
			break;
		case "Ta" :
			ret = cc.Taktil;
			break;
		case "Ki" :
			ret = cc.Kinaestaetisk;
			break;
		 default:
			print ("No titles maches colors");
			break;
		}
		return ret;
	}
}
