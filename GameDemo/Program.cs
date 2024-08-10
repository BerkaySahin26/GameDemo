

using GameDemo.Concrete;
using GameDemo.Entities;

Gamer gamer = new Gamer()
{
    Id = 1,
    Name = "Berkay",
    Surname = "Şahin",
    Tckn = "123415124",
    BirthOfYear = 2000,
};


Game game = new Game()
{
    Id = 1,
    Name = "Batman",
    Description = "Batmanin yeni oyunu",
    Price = 24,
    Provider = "DC",
    RelaseDate = DateTime.Today,
};


Campaign campaign = new Campaign()
{
    Id = 1,
    Name = "Kış indirimleri",
    Description = "Her ürün için geçerlidir.",
    CampaignDiscount = "%34"
};


GamerManager gamerManager = new GamerManager(new CheckRealPersonManager());
gamerManager.Add(gamer);
gamerManager.Update(gamer);
gamerManager.Delete(gamer);

Console.WriteLine("--------------------------------------");

GameManager gameManager = new GameManager();
gameManager.Sell(gamer, game);


Console.WriteLine("---------------------------------------");

CampaignManager campaignManager = new CampaignManager();
campaignManager.Add(game, campaign);
campaignManager.Update(game, campaign);
campaignManager.Delete(game, campaign);