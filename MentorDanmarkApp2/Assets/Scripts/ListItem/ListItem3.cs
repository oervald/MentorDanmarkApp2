using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class ListItem3 : MonoBehaviour {
	[Header("ListItem")]

	// Child vars
	public Image headlineIcon;
	public Text headlineText;
	public Text foldoutText;
	public GameObject content;
	
	// Fold vars
	public float foldoutSpeed = 0.3f; 	// fold time.
	public bool foldout = true;
	
	// Layout vars
	public float headlineHeight = 100; 	// not used. Should be 0 now.
	public float height;				// Current height.
	public float curHeight; 			// not used anymore.
	public float padding = 40; 			// bottom padding added to ResetHeight calculations.
	
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
		
		Fold ();
		ResetHeight ();
	}
	
	
	public void SetHeadline(string s){
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
				if(le.transform.parent == content.transform){
					height += LayoutUtility.GetPreferredHeight(le.GetComponent<RectTransform>());
				}
			}
		}

		height += padding;
		
	}
	// fold content in or out.
	public void Fold (){
		//print ("Preferred Height: " + LayoutUtility.GetPreferredHeight(GetComponent<RectTransform>()));
		foldout = !foldout;
		ResetHeight ();

		if (foldout) {
			foldoutText.GetComponentInChildren<Text> ().text = "-";
			content.GetComponent<LayoutElement>().DOPreferredSize(Vector2.up*height + Vector2.left, foldoutSpeed, false).OnComplete(FinishFold);
		} 
		else {
			content.GetComponent<LayoutElement>().preferredHeight = height; // sets height, so it doesnt tween from -1 to 0, but from max to 0.
			foldoutText.GetComponentInChildren<Text> ().text = "+";
			content.GetComponent<LayoutElement>().DOPreferredSize(Vector2.up*headlineHeight + Vector2.left, foldoutSpeed, false); // headlineHeight should be 0.
		}

	}

	// Set the layout height to -1 so it autoexpands, when child sizes changes - like child ListItems.
	public void FinishFold(){
		content.GetComponent<LayoutElement> ().preferredHeight = -1;
	}
	
	
	
}


