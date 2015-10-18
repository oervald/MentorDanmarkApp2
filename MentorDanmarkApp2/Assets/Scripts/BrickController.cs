using UnityEngine;
using System.Collections;

public class BrickController : MonoBehaviour {
	BrickFactory bf;
	// Use this for initialization
	void Start () {
		bf = gameObject.GetComponent<BrickFactory> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CreateNewBrick(string title){
		bf.CreateBrick (title);
	}

	public void DeleteBrick( string title){
		bf.DestroyBrick (title);
	}

	public Color32 ColorSync(string title){
		return bf.ColorSync (title);
	}
}
