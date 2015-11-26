using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TestSetHightZero : MonoBehaviour {
	public GameObject gameOBJECT;
	public Toggle toggle;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClickSetHightZero(){
		if (toggle.isOn == false) {
			Transform[] objects = gameOBJECT.GetComponentsInChildren<Transform>();
			foreach(Transform temp in objects){

				if(temp.CompareTag("Auditiv")){
					temp.GetComponent<LayoutElement>().preferredHeight = 100;
					temp.GetComponent<LayoutElement>().minHeight= 100;
					print ("preffered hight should be 100");
				}
			}

		}
		if (toggle.isOn == true) {
			Transform[] objects = gameOBJECT.GetComponentsInChildren<Transform>();
			foreach(Transform temp in objects){
				
				if(temp.CompareTag("Auditiv")){
					temp.GetComponent<LayoutElement>().preferredHeight= 0;
					temp.GetComponent<LayoutElement>().minHeight=0;
					print("preffered hight should be 0");
				}
			}
		}
	}
}
