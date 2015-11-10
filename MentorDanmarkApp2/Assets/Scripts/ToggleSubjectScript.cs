using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ToggleSubjectScript : MonoBehaviour {
	public string nameOfSubject;
	// Use this for initialization
	void Start () {
		OnToggle ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnToggle(){
		Toggle[] toggle = gameObject.GetComponentsInChildren<Toggle> ();
		foreach (Toggle t in toggle) {
			if (t.isOn) {
				t.GetComponent<Text> ().fontSize = 34;
				t.GetComponent<Text> ().fontStyle = FontStyle.Bold;
			}
			if (!t.isOn) {
				t.GetComponent<Text> ().fontSize = 24;
				t.GetComponent<Text> ().fontStyle = FontStyle.Normal;
			}
		}

	}
}
