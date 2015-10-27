using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class TweenPanelScript : MonoBehaviour {
	GUIController GC;
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
		GC.goToGamePanel (name);
	}


}
