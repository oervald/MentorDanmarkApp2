using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GUIController : MonoBehaviour {
	GamePanelScript gps;
	XMLReader xreader;
	GameFactory gf;
	// Use this for initialization
	void Start () {
		gps = GameObject.Find ("GamePanelHolder").GetComponent<GamePanelScript> ();
		gf = gameObject.GetComponent<GameFactory> ();
		xreader = new XMLReader ();
		LoadAllXML ();


	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void goToGamePanel(string name, Sprite img){
		gps.TweenThis (name, img);
	}

	public void LoadAllXML(){
		List<Game> games = xreader.LoadXML ();
		gf.SortGames (games);

	}
}
