using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Forum.Models;

namespace Forum.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Find()
        {
            var marvel = new MarvelApi();

            var apiResultCharacters = await marvel.GetCharacters();
            var apiResultComics = await marvel.GetComics();
            var apiResultCreators = await marvel.GetCreators();
            var apiResultSeries = await marvel.GetSeries();


            var findVM = new FindVM()
            {
                Characters = apiResultCharacters.Data.Results.AsEnumerable(),
                Comics = apiResultComics.Data.Results.AsEnumerable(),
                Creators = apiResultCreators.Data.Results.AsEnumerable(),
                Series = apiResultSeries.Data.Results.AsEnumerable()
            };

            return View(findVM);
        }

        public async Task<IActionResult> CharacterDetails(int? id, string name)
        {
            MarvelApi marvel = new MarvelApi();
            CharacterDataWrapper apiCharacter =  new CharacterDataWrapper();

            if(id == null && name == null)
            {
                return NotFound();
            }
            
            if(id != null)
            {
                apiCharacter = await marvel.GetCharacterById(id);
            }

            if (name != null)
            {
                apiCharacter = await marvel.GetCharacterByName(name);
            }

            IEnumerable<Character> characterList = apiCharacter.Data.Results;

            return View(characterList);
        }

        public async Task<IActionResult> ComicDetails(int? id, string title)
        {
            MarvelApi marvel = new MarvelApi();
            ComicDataWrapper apiComic = new ComicDataWrapper();

            if(id == null && title == null)
            {
                return NotFound();
            }

            if (id != null)
            {
                apiComic = await marvel.GetComicId(id);
            }

            if(title != null)
            {
                apiComic = await marvel.GetComicByTitle(title);
            }

            IEnumerable<Comic> comicList = apiComic.Data.Results;

            return View(comicList);
        }

        public async Task<IActionResult> CreatorDetails(int? id, string name)
        {
            MarvelApi marvel = new MarvelApi();
            CreatorDataWrapper apiCreator = new CreatorDataWrapper();

            if(id == null && name == null)
            {
                return NotFound();
            }

            if(id != null)
            {
                apiCreator = await marvel.GetCreatorById(id);
            }

            if(name != null)
            {
                apiCreator = await marvel.GetCreatorByName(name);
            }

            IEnumerable<Creator> creatorList = apiCreator.Data.Results;

            return View(creatorList);
        }

        public async Task<IActionResult> SerieDetails(int? id, string title)
        {
            MarvelApi marvel = new MarvelApi();
            SeriesDataWrapper apiSerie = new SeriesDataWrapper();

            if (id == null && title == null)
            {
                return NotFound();
            }

            if (id != null)
            {
                apiSerie = await marvel.GetSerieById(id);
            }

            if (title != null)
            {
                apiSerie = await marvel.GetSerieByTitle(title);
            }

            IEnumerable<Series> seriesList = apiSerie.Data.Results;

            return View(seriesList);
        }

        public IActionResult Redireccionador(string searchValue, string radioValue)
        {
            if(radioValue == "character")
            {
                return RedirectToAction("CharacterDetails", "Home", new { name = searchValue });
            }

            if(radioValue == "comic")
            {
                return RedirectToAction("ComicDetails", "Home", new { title = searchValue });
            }

            if(radioValue == "creator")
            {
                return RedirectToAction("CreatorDetails", "Home", new { name = searchValue });
            }

            if(radioValue == "series")
            {
                return RedirectToAction("SerieDetails", "Home", new { title = searchValue });
            }


            return NotFound();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
