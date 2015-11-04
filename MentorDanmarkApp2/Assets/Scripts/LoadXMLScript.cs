using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.XmlElemnt;
using System.IO;
using System.Linq;
using System.Xml.Linq.XElement;
using System.Collections.Generic;



public class LoadXMLScript : MonoBehaviour {

	XmlDocument xml;
	XmlElement root;
	// Use this for initialization
	void Start () {
		TextAsset textAsset =(TextAsset) Resources.Load("XMLMentorAPP", typeof (TextAsset));
		xml = new XmlDocument ();
		xml.LoadXml (textAsset.text);
		root = xml.DocumentElement;

		XElement root = XElement.Load ("XMLMentorAPP");
			

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
}
