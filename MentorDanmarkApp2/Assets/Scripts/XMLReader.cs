using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class XMLReader
{

	public XMLReader ()
	{
	}

	public List<Game> LoadXML(){
		List<Game> games = new List<Game> ();

		TextAsset text = (TextAsset)Resources.Load ("XMLMentorAPP", typeof(TextAsset));
		XmlDocument doc = new XmlDocument ();
		doc.LoadXml(text.text);

		foreach (XmlElement node in doc.SelectNodes("gamelibrary/game")) {
			Game tempGame = new Game();
			tempGame.Headline = node.SelectSingleNode("headline").InnerText;
			tempGame.AppHeadline = node.SelectSingleNode("appHeadline").InnerText;
			tempGame.Subjects =  convertFromXmlNodeList(node.SelectNodes("./subjects/subject"));
			tempGame.Levels = convertFromXmlNodeList( node.SelectNodes("./levels/level"));
			tempGame.Tools = convertFromXmlNodeList( node.SelectNodes("./tools/tool"));
			tempGame.Text =  node.SelectSingleNode("text").InnerText;
			
			games.Add(tempGame);
		}
		
		return games;	
	}
	
	public List<string> convertFromXmlNodeList(XmlNodeList xml){
		
		List<string> list = new List<string> ();
		
		for (int i=0; i<xml.Count; i++) {
			
			list.Add( xml[i].InnerText);
		}
		
		return list;
	}

	}


