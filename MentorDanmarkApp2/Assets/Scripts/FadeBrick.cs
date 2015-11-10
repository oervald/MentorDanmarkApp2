using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeBrick : MonoBehaviour {
	public Image brick;
	public Toggle toggle;
	public string nameOfLearningStyle;
	GUIController con;
	// Use this for initialization
	void Start () {
	
		GameObject go = GameObject.Find ("ScriptObject");
		con = go.GetComponent<GUIController> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClickFade(){
	if (toggle.isOn) {
			Color32 faded = brick.color;
			faded.a = 35;
			brick.color = faded;

		}
		if(toggle.isOn == false){
			Color32 clear = brick.color;
			clear.a = 255;
			brick.color = clear;
		}

	}
}
