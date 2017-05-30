using Cards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cards.Controllers
{
    public class CardController : Controller
    {
        public List<Card> PopulateCards()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card { ID = 1, CardName = "Spader", Value = "ess", Color = "black" });
            cards.Add(new Card { ID = 2, CardName = "Spader", Value = "2", Color = "black" });
            cards.Add(new Card { ID = 3, CardName = "Spader", Value = "3", Color = "black" });
            cards.Add(new Card { ID = 4, CardName = "Spader", Value = "4", Color = "black" });
            cards.Add(new Card { ID = 5, CardName = "Spader", Value = "5", Color = "black" });
            cards.Add(new Card { ID = 6, CardName = "Spader", Value = "6", Color = "black" });
            cards.Add(new Card { ID = 7, CardName = "Spader", Value = "7", Color = "black" });
            cards.Add(new Card { ID = 8, CardName = "Spader", Value = "8", Color = "black" });
            cards.Add(new Card { ID = 9, CardName = "Spader", Value = "9", Color = "black" });
            cards.Add(new Card { ID = 10, CardName = "Spader", Value = "10", Color = "black" });
            cards.Add(new Card { ID = 11, CardName = "Spader", Value = "knekt", Color = "black" });
            cards.Add(new Card { ID = 12, CardName = "Spader", Value = "kung", Color = "black" });
            cards.Add(new Card { ID = 13, CardName = "Spader", Value = "dam", Color = "black" });
            cards.Add(new Card { ID = 14, CardName = "Ruter", Value = "ess", Color = "red" });
            cards.Add(new Card { ID = 15, CardName = "Ruter", Value = "2", Color = "red" });
            cards.Add(new Card { ID = 16, CardName = "Ruter", Value = "3", Color = "red" });
            cards.Add(new Card { ID = 17, CardName = "Ruter", Value = "4", Color = "red" });
            cards.Add(new Card { ID = 18, CardName = "Ruter", Value = "5", Color = "red" });
            cards.Add(new Card { ID = 19, CardName = "Ruter", Value = "6", Color = "red" });
            cards.Add(new Card { ID = 20, CardName = "Ruter", Value = "7", Color = "red" });
            cards.Add(new Card { ID = 21, CardName = "Ruter", Value = "8", Color = "red" });
            cards.Add(new Card { ID = 22, CardName = "Ruter", Value = "9", Color = "red" });
            cards.Add(new Card { ID = 23, CardName = "Ruter", Value = "10", Color = "red" });
            cards.Add(new Card { ID = 24, CardName = "Ruter", Value = "knekt", Color = "red" });
            cards.Add(new Card { ID = 25, CardName = "Ruter", Value = "kung", Color = "red" });
            cards.Add(new Card { ID = 26, CardName = "Ruter", Value = "dam", Color = "red" });
            cards.Add(new Card { ID = 27, CardName = "Hjärter", Value = "ess", Color = "red" });
            cards.Add(new Card { ID = 28, CardName = "Hjärter", Value = "2", Color = "red" });
            cards.Add(new Card { ID = 29, CardName = "Hjärter", Value = "3", Color = "red" });
            cards.Add(new Card { ID = 30, CardName = "Hjärter", Value = "4", Color = "red" });
            cards.Add(new Card { ID = 31, CardName = "Hjärter", Value = "5", Color = "red" });
            cards.Add(new Card { ID = 32, CardName = "Hjärter", Value = "6", Color = "red" });
            cards.Add(new Card { ID = 33, CardName = "Hjärter", Value = "7", Color = "red" });
            cards.Add(new Card { ID = 34, CardName = "Hjärter", Value = "8", Color = "red" });
            cards.Add(new Card { ID = 35, CardName = "Hjärter", Value = "9", Color = "red" });
            cards.Add(new Card { ID = 36, CardName = "Hjärter", Value = "10", Color = "red" });
            cards.Add(new Card { ID = 37, CardName = "Hjärter", Value = "knekt", Color = "red" });
            cards.Add(new Card { ID = 38, CardName = "Hjärter", Value = "kung", Color = "red" });
            cards.Add(new Card { ID = 39, CardName = "Hjärter", Value = "dam", Color = "red" });
            cards.Add(new Card { ID = 40, CardName = "Klöver", Value = "ess", Color = "black" });
            cards.Add(new Card { ID = 41, CardName = "Klöver", Value = "2", Color = "black" });
            cards.Add(new Card { ID = 42, CardName = "Klöver", Value = "3", Color = "black" });
            cards.Add(new Card { ID = 43, CardName = "Klöver", Value = "4", Color = "black" });
            cards.Add(new Card { ID = 44, CardName = "Klöver", Value = "5", Color = "black" });
            cards.Add(new Card { ID = 45, CardName = "Klöver", Value = "6", Color = "black" });
            cards.Add(new Card { ID = 46, CardName = "Klöver", Value = "7", Color = "black" });
            cards.Add(new Card { ID = 47, CardName = "Klöver", Value = "8", Color = "black" });
            cards.Add(new Card { ID = 48, CardName = "Klöver", Value = "9", Color = "black" });
            cards.Add(new Card { ID = 49, CardName = "Klöver", Value = "10", Color = "black" });
            cards.Add(new Card { ID = 50, CardName = "Klöver", Value = "knekt", Color = "black" });
            cards.Add(new Card { ID = 51, CardName = "Klöver", Value = "kung", Color = "black" });
            cards.Add(new Card { ID = 52, CardName = "Klöver", Value = "dam", Color = "black" });
            return cards;
        }

        // GET: Card
        public ActionResult Index()
        {
            var cards = PopulateCards();
            Session["Cards"] = cards;
            return View(cards);
        }

        public ActionResult ShowMore()
        {
            var cards = (List<Card>)Session["Cards"];
            Session.Remove("Cards");
            var newCards = PopulateCards();
            cards.AddRange(newCards);
            Session["Cards"] = cards;
            return PartialView("_MyPartialView", cards);
        }

        public ActionResult UppdateCards()
        {
            var cards = (List<Card>)Session["Cards"];
            return PartialView("_MyPartialView", cards);
        }

        public ActionResult ShowFirstCard()
        {
            var cards = (List<Card>)Session["Cards"];
            Session.Remove("Cards");
            var firstCard = cards.First();
            cards.Remove(firstCard);
            Session["Cards"] = cards;
            ViewBag.FirstCard = firstCard;
            return PartialView("_OneCard", cards);      
        }

        public ActionResult GroupCardsByColor()
        {
            var cards = (List<Card>)Session["Cards"];
            //List<Card> cards = PopulateCards();
            var sortedCards = cards.OrderBy(c => c.Color).ToList();
            return PartialView("_MyPartialView", sortedCards);
        }

        public ActionResult GroupCardsByValue()
        {
            var cards = (List<Card>)Session["Cards"];
            //List<Card> cards = PopulateCards();
            var sortedCards = cards.OrderBy(c => c.Value).ToList();
            return PartialView("_MyPartialView", sortedCards);
        }

        public ActionResult RandomCard()
        {           
            var cards = (List<Card>)Session["Cards"];
            Session.Remove("Cards");
            var shuffledcards = cards.OrderBy(a => Guid.NewGuid()).ToList();
            Session["Cards"] = shuffledcards;
            return PartialView("_MyPartialView", shuffledcards);
        }
    }
}