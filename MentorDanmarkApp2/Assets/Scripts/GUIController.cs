using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIController : MonoBehaviour {
	GamePanelScript gps;
	// Use this for initialization
	void Start () {
		gps = GameObject.Find ("GamePanelHolder").GetComponent<GamePanelScript> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void goToGamePanel(string name, Sprite img){
		gps.TweenThis (name, img);
	}
}
