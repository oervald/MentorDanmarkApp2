using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TransformToggleScript : MonoBehaviour {

	BrickController bc;
	public Toggle circle;
	public Sprite toggleOn;
	public Sprite toggleOff;

	string percentage;
	
	// Use this for initialization
	void Start () {
		percentage = "";
		GameObject so = GameObject.Find ("SettingsCanvasScriptObject");
		bc = so.GetComponent<BrickController> ();
		Text[] texts = gameObject.GetComponentsInChildren<Text> ();
		foreach (Text t in texts) {
			if(t.CompareTag("PanelPercentage")){
				percentage = t.text;
				percentage = percentage.Replace("("," ");
				percentage = percentage.Replace(")"," ");
				percentage = percentage.Trim();
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClickTransform(string title){
		if(circle.isOn){

			circle.gameObject.GetComponent<Image>().sprite = toggleOn;
			bc.CreateNewBrick(title,percentage);

		} if(circle.isOn == false) {
			circle.gameObject.GetComponent<Image>().sprite = toggleOff;
			bc.DeleteBrick(title);
		}
	}
}
