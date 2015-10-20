using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PageSetup : MonoBehaviour {
	BrickController bc;
	List<GameObject> PanelBricks;
	public GameObject panel;
	public Canvas main;
	// Use this for initialization
	void Start () {
		bc = GameObject.Find ("SettingsCanvasScriptObject").GetComponent<BrickController> ();

		Image [] transforms = panel.GetComponentsInChildren<Image> ();

	

		foreach (Image img in transforms) {
		if(img.CompareTag( "PanelBrickImage")){
				img.color = bc.ColorSync(img.GetComponentInChildren<Text>().text);
		}
		}
		main.transform.SetAsLastSibling ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
