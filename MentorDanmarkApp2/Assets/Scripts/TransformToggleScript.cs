using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TransformToggleScript : MonoBehaviour {

	BrickController bc;

	Color circleOn;
	Color circleOff;
	Color barOn;
	Color barOff;
	int toggleOffSet;

	public Image bar;
	public Toggle circle;
	// Use this for initialization
	void Start () {
		GameObject so = GameObject.Find ("ScriptObject");
		bc = so.GetComponent<BrickController> ();

		circleOn = new Color32 (128, 203, 196, 255);
		circleOff = new Color32 (224, 224, 224, 255);
		barOn = new Color32 (0, 105, 92, 255);
		barOff = new Color32 (154, 154, 154, 255);
		toggleOffSet = 23;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClickTransform(string title){
		if(circle.isOn){
			Toggle temp_cicle = circle.GetComponent<Toggle>();
		
			ColorBlock cb = temp_cicle.colors;
			cb.normalColor = circleOn;
			cb.highlightedColor = circleOn;
			temp_cicle.colors = cb;
	
			Vector3 temp = circle.transform.position;
			temp.x +=toggleOffSet;
		 	circle.transform.position = temp;
			bar.color = barOn;

			bc.CreateNewBrick(title);



		} if(circle.isOn == false) {
			Toggle temp_cicle = circle.GetComponent<Toggle>();
		
			ColorBlock cb = temp_cicle.colors;
			cb.normalColor = circleOff;
			cb.highlightedColor = circleOff;
			temp_cicle.colors = cb;

			Vector3 temp = circle.transform.position;
			temp.x -=toggleOffSet;
			circle.transform.position = temp;

			bar.color = barOff;
			bc.DeleteBrick(title);
		}
	}
}
