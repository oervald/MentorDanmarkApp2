using System;
using System.Collections.Generic;

	public class TagFilter
	{
		public TagFilter ()
		{
		}

	public List<Game> filterWithTag(string tag, List<Game> games){
		List<Game> returns = new List<Game> ();

		foreach (Game g in games) {
			if(g.LearningStyles.Contains(tag)){
				returns.Add(g);
			}
		}
		return returns;
	}
	}


