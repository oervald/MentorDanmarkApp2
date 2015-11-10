using System;
using System.Collections.Generic;

	public class Game
	{
	string headline;
	string appHeadline;
	List<string> levels;
	List<string> subjects;
	List<string> tools;
	string text;

	public Game (string headline, string appHeadline, List<string> levels, List<string> subjects, List<string> tools, string text)
		{
			this.headline = headline;
			this.appHeadline = appHeadline;
			this.levels = levels;
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

	public override string ToString ()
		{
			return string.Format ("[Game: headline={0}, appHeadline={1}, levels={2}, subjects={3}, tools={4}, text={5}]", headline, appHeadline, levels, subjects, tools, text);
		}
		

	}



