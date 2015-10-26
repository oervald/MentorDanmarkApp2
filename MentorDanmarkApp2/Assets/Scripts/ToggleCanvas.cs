using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ToggleCanvas : MonoBehaviour {
	public GameObject panel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClickToggle(){
		panel.transform.SetAsFirstSibling ();
	}
}
