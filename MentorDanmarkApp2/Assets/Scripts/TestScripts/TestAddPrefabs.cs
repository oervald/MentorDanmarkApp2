using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TestAddPrefabs : MonoBehaviour {
	public GameObject prefab;
	public GameObject panel;
	public int count;
	// Use this for initialization
	void Start () {
		for (int i=0; i<count; i++) {
			GameObject newGameObject = Instantiate (prefab) as GameObject;
			newGameObject.transform.SetParent(panel.transform,false);
		}
	}

}
