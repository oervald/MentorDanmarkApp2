using UnityEngine;
using System;

	public class ColorClass
	{

	Color32 analytisk;
	Color32 holistisk;
	Color32 visuel;
	Color32 auditiv;
	Color32 taktil;
	Color32 kinaestaetisk;


		public ColorClass ()
		{
		this.analytisk = new Color32 (244, 67, 54, 255);
		this.holistisk = new Color32 (233, 30, 99, 255);
		this.visuel = new Color32 (156, 39, 176, 255);
		this.auditiv = new Color32 (103, 58, 183, 255);
		this.taktil = new Color32 (61, 81, 181, 255);
		this.kinaestaetisk = new Color32 (33, 150, 243, 255);
		}

	 public Color32 Analytisk {
			get {
				return this.analytisk;
			}
		}

		public Color32 Holistisk {
			get {
				return this.holistisk;
			}
		}

		public Color32 Visuel {
			get {
				return this.visuel;
			}
		}

		public Color32 Auditiv {
			get {
				return this.auditiv;
			}
		}

		public Color32 Taktil {
			get {
				return this.taktil;
			}
		}

		public Color32 Kinaestaetisk {
			get {
				return this.kinaestaetisk;
			}
		}


	}


