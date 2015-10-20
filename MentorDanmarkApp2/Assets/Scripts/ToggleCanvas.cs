using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ToggleCanvas : MonoBehaviour {
	public Canvas main;
	public Canvas settings;
	public Toggle toggle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClickToggle(){
		if (toggle.isOn) {
			settings.transform.SetAsLastSibling();
		
		}
		if (toggle.isOn == false) {
			main.transform.SetAsLastSibling();
		}
	}
}
