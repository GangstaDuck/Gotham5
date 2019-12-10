using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.persistence;
using app.domain.Models;

namespace app.persistence
{
	public class MockCapsulesInformationRepository : IRepository<CapsulesInformation>
	{
		private readonly List<CapsulesInformation> _capsulesInformation;

		public MockCapsulesInformationRepository()
		{
			_capsulesInformation = new List<CapsulesInformation>()
			{
				new CapsulesInformation(){ Titre = "Folie contagieusse", Lien = "https://www.youtube.com/watch?v=RJIDLGuqfmc", Status = "published", Texte = "lorem ipsum"},
				new CapsulesInformation(){ Titre = "Feu", Lien = "https://www.youtube.com/watch?v=BDpS28vIpsA&t=78s", Status = "pending", Texte = "lorem ipsum"},
				new CapsulesInformation(){ Titre = "Zombie", Lien = "https://www.youtube.com/watch?v=iSiouayIEAI", Status = "archived", Texte = "lorem ipsum"},
			};

	}

		public Task Add(CapsulesInformation entity)
		{
			throw new NotImplementedException();
		}

		public Task Delete(CapsulesInformation entity)
		{
			throw new NotImplementedException();
		}

		public Task<IQueryable<CapsulesInformation>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<CapsulesInformation> GetById(int? id)
		{
			throw new NotImplementedException();
		}

		public Task Update(CapsulesInformation entity)
		{
			throw new NotImplementedException();
		}
	}
}
