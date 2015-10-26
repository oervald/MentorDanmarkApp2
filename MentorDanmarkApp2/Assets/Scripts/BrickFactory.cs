using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class BrickFactory : MonoBehaviour {
	public GameObject brick;
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
	//Creates a new brick and puts it into the BrickPanel, also places the brick in a Dictionary to control the amount of bricks
	public void CreateBrick(string title, string percentage, GameObject panel){
		GameObject object_brick = Instantiate (brick) as GameObject;


		object_brick.GetComponentInChildren<Image> ().color = ColorSync (title);
		BricksInUse.Add(title, object_brick);

		object_brick.transform.SetParent(panel.transform,true);
		object_brick.transform.localScale = (new Vector3 (1, 1, 1));
		Text[] texts = object_brick.GetComponentsInChildren<Text>();
		foreach (Text t in texts) {
			if(t.CompareTag("BrickText")){
				t.text = title;
			}

			if(t.CompareTag("BrickPercentage")){
				t.text = percentage;
			}

		}


		object_brick.GetComponentInChildren<Text> ().fontSize = 24;
	}

	//Removes a brick by title from the Panel and Dictionary
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

	//Returns a color from the ColorClass given a title. If title doesnt exist, prints to the console
	public Color32 ColorSync(string title){
		print (title);
		Color32 ret = new Color32();
		cc = new ColorClass ();
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
