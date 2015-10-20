using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TransformToggleScript : MonoBehaviour {

	BrickController bc;
	public Toggle circle;
	public Sprite toggleOn;
	public Sprite toggleOff;
	
	// Use this for initialization
	void Start () {

		GameObject so = GameObject.Find ("SettingsCanvasScriptObject");
		bc = so.GetComponent<BrickController> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClickTransform(string title){
		if(circle.isOn){

			circle.gameObject.GetComponent<Image>().sprite = toggleOn;
			bc.CreateNewBrick(title);

		} if(circle.isOn == false) {
			circle.gameObject.GetComponent<Image>().sprite = toggleOff;
			bc.DeleteBrick(title);
		}
	}
}
