using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GUIController : MonoBehaviour {
	GamePanelScript gps;
	XMLReader xreader;
	GameFactory gf;
	TestAddAndDestroy taad;
	TagFilter tagFilter;
	List<Game> games;
	List<string> gamesActive;
	// Use this for initialization
	void Start () {
		gps = GameObject.Find ("GamePanelHolder").GetComponent<GamePanelScript> ();
		gf = gameObject.GetComponent<GameFactory> ();
		xreader = new XMLReader ();
		taad = gameObject.GetComponent<TestAddAndDestroy> ();
		gamesActive = new List<string> {"Auditiv","Kinæstetisk","Visuel","Taktil"};
		tagFilter = new TagFilter ();
		LoadAllXML ();


	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void goToGamePanel(string name, Sprite img){
		gps.TweenThis (name, img);
	}

	public void LoadAllXML(){
		games = xreader.LoadXML ();
		gf.SortGames (games);

	}

	public void DestroyAndAdd(string learningStyle, Toggle toggle){
		taad.onClickDestroyAndAdd (learningStyle, toggle);
	}

	public void loadWithTag(string tag){
		

		List<Game> temp = tagFilter.filterWithTag(tag, xreader.LoadXML());
		gf.SortGames (temp);

	}

	public void addToGamesActive(string learningStyle){
		if (!gamesActive.Contains (learningStyle)) {
			gamesActive.Add (learningStyle);
		} else {
			gamesActive.Remove(learningStyle);
		}
	}

}
