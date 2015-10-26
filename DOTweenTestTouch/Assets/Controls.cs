using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;

public class Controls : MonoBehaviour {

	public GameObject imgPrefab;
	public GameObject panel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void tweenThis(){
	
		imgPrefab = Instantiate (imgPrefab) as GameObject;
		imgPrefab.transform.SetParent (panel.transform, false);

		imgPrefab.transform.DOScale (14f, 2f);


	}
}
