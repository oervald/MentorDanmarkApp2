using System;
using System.Collections.Generic;

	public class Game
	{
	string headline;
	string appHeadline;
	List<string> levels;
	List<string> learningStyles;
	List<string> subjects;
	List<string> tools;
	string text;

	public Game (string headline, string appHeadline, List<string> levels, List<string> learningStyles, List<string> subjects, List<string> tools, string text)
		{
			this.headline = headline;
			this.appHeadline = appHeadline;
			this.levels = levels;
			this.learningStyles = learningStyles;
			this.subjects = subjects;
			this.tools = tools;
			this.text = text;
		}
	public Game (){
	}
		
	public string Headline {
			get {
				return this.headline;
			}
			set {
				headline = value;
			}
		}

		public string AppHeadline {
			get {
				return this.appHeadline;
			}
			set {
				appHeadline = value;
			}
		}

		public List<string> Levels {
			get {
				return this.levels;
			}
			set {
				levels = value;
			}
		}

		public List<string> Subjects {
			get {
				return this.subjects;
			}
			set {
				subjects = value;
			}
		}

		public List<string> Tools {
			get {
				return this.tools;
			}
			set {
				tools = value;
			}
		}

		public string Text {
			get {
				return this.text;
			}
			set {
				text = value;
			}
		}

		public List<string> LearningStyles {
			get {
				return this.learningStyles;
			}
			set {
				learningStyles = value;
			}
		}


		public override string ToString ()
		{
			return string.Format ("[Game: headline={0}, appHeadline={1}, levels={2}, learningStyles={3}, subjects={4}, tools={5}, text={6}]", headline, appHeadline, levels, learningStyles, subjects, tools, text);
		}


	public override bool Equals(object obj)
	{
		if (obj == null) return false;
		Game objAsGame = obj as Game;
		if (objAsGame == null) return false;
		else return Equals(objAsGame);
	}

	public bool Equals (Game otherGame)
		{
			if (otherGame == null) return false;
			return (otherGame.Headline.Equals (this.Headline) && otherGame.Text.Equals (this.Text));

		}
		

	}



