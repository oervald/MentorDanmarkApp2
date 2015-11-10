using UnityEngine;
using System.Collections;

public class XMLQueryCreator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CreateQuery(string[] learningStyles, string subject){
		string query = "game[(.classes/class='"+subject+"')";

		for (int i=0; i<learningStyles.Length; i++) {
		
			string queryChild = "and(./learningstyle/='" + learningStyles [i] + "')";
			query += queryChild;
		
			i++;
		}
	}
}
