using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.persistence;
using app.domain.Models;

namespace app.persistence
{
	public class MockListeSignalementRepository : IRepository<ListeSignalement>
	{
		private readonly List<ListeSignalement> _listeSignalement;

		public MockListeSignalementRepository()
		{
			_listeSignalement = new List<ListeSignalement>()
			{
				new ListeSignalement(){Titre = "Feu", Nature = "soleil", Commentaire = "chaud", Secteur = "Ici", Date = "aujourd'hui", Heure = "maintenant"},
				new ListeSignalement(){Titre = "blizzard", Nature = "foird", Commentaire = "asd", Secteur = "asd", Date = "asd", Heure = "asd"},
			};

	}

		public Task Add(ListeSignalement entity)
		{
			throw new NotImplementedException();
		}

		public Task Delete(ListeSignalement entity)
		{
			throw new NotImplementedException();
		}

		public Task<IQueryable<ListeSignalement>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<ListeSignalement> GetById(int? id)
		{
			throw new NotImplementedException();
		}

		public Task Update(ListeSignalement entity)
		{
			throw new NotImplementedException();
		}
	}
}
