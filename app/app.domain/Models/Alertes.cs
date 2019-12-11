using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using app.Models;

namespace app.domain.Models
{
	public class Alertes : Entity
	{
		public string Titre { get; set; }
		public string Secteur { get; set; }
		public string Risques { get; set; }
		public string Ressources { get; set; }
		public string Conseils { get; set; }
		public string DateHeure { get; set; }
		public string Status { get; set; }
	}
}


