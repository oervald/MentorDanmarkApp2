using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ToggleHighlightScript : MonoBehaviour {

	Toggle [] toggles;

	// Use this for initialization
	void Start () {
		toggles = gameObject.GetComponentsInChildren<Toggle> ();
		onClickHightlight ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClickHightlight(){
		foreach (Toggle t in toggles) {
			if(t.isOn){
				t.GetComponent<Text>().fontStyle = FontStyle.Bold;
				t.GetComponent<Text>().fontSize = 34;


			}
			if(!t.isOn){
				 t.GetComponent<Text>().fontStyle = FontStyle.Normal;
				t.GetComponent<Text>().fontSize = 24;

			}
		}
	}
}
