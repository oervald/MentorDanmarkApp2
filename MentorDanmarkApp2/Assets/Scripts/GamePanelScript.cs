﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class GamePanelScript : MonoBehaviour {
	public GameObject gamePanel;
	Button backButton;
	// Use this for initialization
	void Start () {
		backButton = gameObject.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void TweenThis(string name, Sprite img){
		Text [] t = gamePanel.GetComponentsInChildren<Text> ();
		foreach (Text x in t) {
			if(x.CompareTag("GamePanelHeadline")){
				x.text = name;
			}
		}

		Image [] i = gameObject.GetComponentsInChildren<Image> ();
		foreach (Image x in i) {
			if(x.CompareTag("GamePanelImage")){
				x.sprite = img;
			}
		}


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

	public void goBack(){
		GameObject panel = GameObject.Find ("BackGround");
		panel.transform.SetAsLastSibling ();

	}
}
