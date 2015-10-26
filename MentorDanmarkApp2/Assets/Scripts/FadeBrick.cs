using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeBrick : MonoBehaviour {
	public Image brick;
	public Toggle toggle;
	// Use this for initialization
	void Start () {
	
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
