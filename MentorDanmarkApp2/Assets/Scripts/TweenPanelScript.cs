using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class TweenPanelScript : MonoBehaviour {
	public GameObject gamePanel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void TweenThis(){
	//Uses saves the original Vector3 position from the panel
		Vector3 origin = gamePanel.transform.position;
		gamePanel.transform.SetAsLastSibling ();
		//Gets Vector3 Input as Coordinates
		Vector3 inputCoordinates = Input.mousePosition;
		inputCoordinates.x = origin.x;

		//Moves the panel to the inputcoordinates and scales is while moving it towards its old position, thus making the effekt
		gamePanel.transform.DOMove (inputCoordinates,0);
		gamePanel.transform.DOScale (new Vector3(0,0,0), 0.3f).From();
		gamePanel.transform.DOMove(origin,0.3f);
	}
}
