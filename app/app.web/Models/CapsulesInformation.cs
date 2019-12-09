using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using app.Models;

namespace app.web.Models
{
	public class CapsulesInformation: Entity
	{
		public string Titre { get; set; }
		public string Nature { get; set; }
		public string Commentaire { get; set; }
		public string Secteur { get; set; }
		public string Date { get; set; }
		public string Heure { get; set; }
	}
}


