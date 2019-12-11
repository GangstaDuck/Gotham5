using app.persistence;
using app.web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestStack.BDDfy;
using Xunit;

namespace app.unitTests
{
    [Story(
            Title = "Je veux pouvoir voir les infos d'une nouvelle",
            AsA = "User général",
            IWant = "Je veux les infos d'une news,",
            SoThat = "Afin de pouvoir prendre connaissance d'une news")]

    public class NewsTestsAcceptation
    {
        public domain.News news = new domain.News();
        public MockNewsRepository mockRepo;
        public NewsController controller;
        public IActionResult result;

         [Fact]
        public void visualiser_les_infos_d_une_news()
        {
            this.Given(x => une_news())
                .When(x => l_user_demande_de_voir_la_liste_des_news())
                .Then(x => les_infos_d_une_news())
                .BDDfy();
        }

        private void une_news()
        {
            news.Title = "Les framboises sont de retours!";
            news.Text = "Les fermes Onésimes Pouliot produisent les meilleurs fraises, framboises et bleuets de l'île d'Orléan.";
            news.Link = "https://onesimepouliot.com/";
            news.Status = "Non publié";
        }

        private async Task l_user_demande_de_voir_la_liste_des_news()
        {
            // Arrange
            mockRepo = new MockNewsRepository();
            controller = new NewsController(mockRepo);

            // Act
            result = await controller.Index();
        }

        private async void les_infos_d_une_news()
        {
            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
