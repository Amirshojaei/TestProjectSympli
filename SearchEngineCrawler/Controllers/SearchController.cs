using Microsoft.AspNetCore.Mvc;
using SearchEngineCrawlerServices.Contract;
using SearchEngineCrawlerWebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace SearchEngineCrawlerWebApi.Controllers
{
    [ApiController]
    [Route("{controller}/{action}")]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService searchService;
        private readonly List<ISearchEngine> searchEngineList;

        public SearchController(ISearchService searchService)
        {
            this.searchService = searchService;
            this.searchEngineList = searchService.getSearchEngineList();
        }

        [HttpGet]
        public string[] LoadSearchEngines()
        {
            return searchEngineList.Select(x => x.Name).ToArray();
        }

        [HttpGet]
        public SearchResultViewModel Search(string Keyword, string Url, string searchEngineName)
        {
            var selectedSearchEngine = searchEngineList.FirstOrDefault(x => x.Name == searchEngineName);
            if (selectedSearchEngine != null)
            {
                var serviceResult = searchService.SearchAsync(selectedSearchEngine, Keyword, Url).Result;
                return new SearchResultViewModel(serviceResult.Success, serviceResult.Result, serviceResult.ErrorMessages);
            }

            return new SearchResultViewModel(false, null, new string[] { "Search engine name is not valid." });
        }

    }
}

