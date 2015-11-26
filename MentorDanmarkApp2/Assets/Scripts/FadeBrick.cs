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
	
		con = GameObject.Find ("ScriptObject").GetComponent<GUIController>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClickFade(){
	if (toggle.isOn) {
			Color32 faded = brick.color;
			faded.a = 35;
			brick.color = faded;
			//con.addToGamesActive(nameOfLearningStyle);
			con.DestroyAndAdd(nameOfLearningStyle,toggle);

		}
		if(toggle.isOn == false){
			Color32 clear = brick.color;
			clear.a = 255;
			brick.color = clear;
		//	con.addToGamesActive(nameOfLearningStyle);
			con.DestroyAndAdd(nameOfLearningStyle,toggle);
		}

	}
}
