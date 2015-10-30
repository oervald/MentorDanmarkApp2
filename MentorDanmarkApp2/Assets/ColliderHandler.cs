using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColliderHandler : MonoBehaviour {
	public Text headline;
	bool mellemIsDown = false;
	bool udskolIsDown = false;
	void OnTriggerEnter2D(Collider2D other ) {

		switch (other.gameObject.name) {
		case "MellemTrinBreak":
			if(!mellemIsDown){
			headline.text = "Mellemtrin";
				mellemIsDown = true;}
			else{headline.text = "Indskoling";
			     mellemIsDown = false;
			}
			break;
		case "UdskolingBreak":
			if(!udskolIsDown){
			headline.text = "Udskoling";
			udskolIsDown = true;
			}else{
				headline.text = "Mellemtrin";
				udskolIsDown = false;
			}
			break;

		}
		print (other.gameObject.name);
	}
}
