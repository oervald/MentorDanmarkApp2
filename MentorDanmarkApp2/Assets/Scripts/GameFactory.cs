using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameFactory : MonoBehaviour {
	public GameObject prefab;
	public GameObject indskolingPanel;
	public GameObject mellemtrinPanel;
	public GameObject udskolingPanel;

	List<Game> listIndskoling;
	List<Game> listMellemstrin;
	List<Game> listUdskoling;

	// Use this for initialization
	void Awake () {
		listIndskoling = new List<Game> ();
		listMellemstrin = new List<Game> ();
		listUdskoling = new List<Game> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SortGames(List<Game> games){

		foreach (Game g in games) {
			if(!listIndskoling.Contains(g) && !listMellemstrin.Contains(g) && !listUdskoling.Contains(g)){ 
			foreach(string s in g.Levels){
				switch(s){
				case "Indskoling":
					listIndskoling.Add(g);
					break;
				case "Mellemtrin":
					listMellemstrin.Add(g);
					break;
				case "Udskoling":
					listUdskoling.Add(g);
					break;

				default: print ("no level detected");
					break;
				}
			}
			}
		}
		InstantiateGames ();
	}

	public void InstantiateGames(){
		instantiateInPanel (listIndskoling, indskolingPanel);
		instantiateInPanel (listMellemstrin, mellemtrinPanel);
		instantiateInPanel (listUdskoling, udskolingPanel);
	}

	public void instantiateInPanel(List<Game> list, GameObject go){

		foreach (Game g in list) {

			GameObject newGameObject = Instantiate (prefab) as GameObject;
			newGameObject.GetComponentInChildren<Text>().text = g.AppHeadline;
			if(g.LearningStyles != null){
			newGameObject.transform.tag = g.LearningStyles[0];
			}
			newGameObject.transform.SetParent(go.transform,false);

		}

	}
}
