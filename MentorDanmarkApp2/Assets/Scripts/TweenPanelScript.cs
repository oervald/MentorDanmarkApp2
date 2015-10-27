using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class TweenPanelScript : MonoBehaviour {
	GUIController GC;
	Sprite img;
	// Use this for initialization
	void Start () {
		GC = GameObject.Find ("ScriptObject").GetComponent<GUIController> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClickGameStartGame(){
		Text t = gameObject.GetComponentInChildren<Text> ();
		string name = t.text;
		Image[] imgs = gameObject.GetComponentsInChildren<Image> ();
		foreach (Image i in imgs) {
			if(i.CompareTag("GamePrefabImage")){
				img = i.sprite;
			}
		}
		GC.goToGamePanel (name, img);
	}


}
