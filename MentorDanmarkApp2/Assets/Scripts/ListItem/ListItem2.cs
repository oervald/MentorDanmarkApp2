using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class ListItem2 : MonoBehaviour
{
	[Header("ListItem")]
	// Object
	//public JSONObject item;
	
	// Child vars
	public Image headlineIcon;
	public Text headlineText;
	public Text foldoutText;
	public GameObject content;
	
	// Fold vars
	public float foldoutSpeed = 10;
	public bool foldout = true;
	
	// Layout vars
	public float headlineHeight = 100;
	public float height;
	public float curHeight;
	public float padding = 40;
	
	// Other vars
	float actualHeight;
	RectTransform rt;
	
	
	// Use this for initialization
	public virtual void Start ()
	{
		rt = (RectTransform)gameObject.transform;

		//print(content.GetComponent<LayoutElement> ().preferredHeight);

		//transform.Find ("Headline").GetComponent<LayoutElement> ().preferredHeight = headlineHeight;
		//transform.Find ("Headline").GetComponent<LayoutElement> ().minHeight = headlineHeight;
		
		if(foldoutText == null){
			foldoutText = transform.Find("Headline/Icon").GetComponent<Text>();
		}
		
		height = content.GetComponent<LayoutElement> ().preferredHeight;
		if (!foldout) {
			content.GetComponent<LayoutElement> ().preferredHeight = headlineHeight;
			
			foldoutText.text = "+";
		} 
		else {
			foldoutText.text = "-";
		}
		curHeight = content.GetComponent<LayoutElement> ().preferredHeight;
		height = LayoutUtility.GetPreferredHeight (content.GetComponent<RectTransform> ());
		
		
		ResetHeight ();
	}
	
	
	public void SetHeadline(string s){
		//string headline = System.DateTime.TryParse (item ["Date"].ToString ()) + " - " + item ["TimeBegin"].ToString () + "-" + item ["TimeEnd"].ToString ();

		headlineText.text = s;


	}
	
	// Update is called once per frame
	public virtual void Update ()
	{
	}
	
	// Calculates the total height of the ListItem by checking every child LayoutElement's preferredHeight.
	public void ResetHeight ()
	{
		
		height = LayoutUtility.GetPreferredHeight (content.GetComponent<RectTransform> ());
		
		height = 0;
		foreach (LayoutElement le in content.GetComponentsInChildren<LayoutElement>()) {
			if(le != content.GetComponent<LayoutElement>() && le.gameObject.activeInHierarchy){
				if(le.transform.parent.GetComponent<LayoutElement>() != null && le.transform.parent.GetComponent<LayoutElement>().preferredHeight > 0){
					
				}
				if(le.transform.parent == content.transform)
					height += LayoutUtility.GetPreferredHeight(le.GetComponent<RectTransform>());
				
				if(transform.GetSiblingIndex() == 3){
					//print ("name = " + le.name + " " + LayoutUtility.GetPreferredHeight(le.GetComponent<RectTransform>()));
					//print (transform.GetSiblingIndex() + " new height: " + height);
				}
			}
		}
		height += padding;
		
		//print ("Total height is?: " + height);
		
		
		//GetComponent<LayoutElement> ().preferredHeight = height;
		//		print ("Changed internal height to: " + height);
	}
	
	// Should update this to include a change in the headline +/-
	public void Fold (){
		foldout = !foldout;
		ResetHeight ();
		if (foldout) {
			foldoutText.GetComponentInChildren<Text> ().text = "-";
			content.GetComponent<LayoutElement>().DOPreferredSize(Vector2.up*height + Vector2.left, foldoutSpeed, false).OnComplete(FinishFold);
		} 
		else {
			content.GetComponent<LayoutElement>().preferredHeight = height;
			foldoutText.GetComponentInChildren<Text> ().text = "+";
			content.GetComponent<LayoutElement>().DOPreferredSize(Vector2.up*headlineHeight + Vector2.left, foldoutSpeed, false);
		}


	}

	public void ChangeHeight(){
		//ResetHeight ();
		//content.GetComponent<LayoutElement>().DOPreferredSize(Vector2.up*height + Vector2.left, 0f, false);
		//Fold ();
	}

	public void FinishFold(){
		//GetComponent<LayoutElement> ().preferredHeight = content.GetComponent<LayoutElement>().preferredHeight;
		content.GetComponent<LayoutElement> ().preferredHeight = -1;
	}
	
	
}


