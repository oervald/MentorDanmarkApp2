using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BrickController : MonoBehaviour {
	public BrickFactory bf;
	// Use this for initialization
	void Start () {

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
		print (title);
		print (bf.imagePanel.name);
		return bf.ColorSync (title);
	}
}
