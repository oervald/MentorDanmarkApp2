using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TestAddAndDestroy : MonoBehaviour {

	GUIController con;
	Transform [] objects;
	public GameObject obj;
	// Use this for initialization
	void Start () {
		con = GameObject.Find ("ScriptObject").GetComponent<GUIController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onClickDestroyAndAdd(string learningStyle, Toggle toggle){

		objects = obj.GetComponentsInChildren<Transform> ();
		print (objects.Length);
			if (!toggle.isOn) {
			con.loadWithTag(learningStyle);
				
			
			} else {
				foreach (Transform t in objects) {
					if (t.CompareTag (learningStyle)) {
						Destroy (t.gameObject);
					}
				}
			}
	}



}
