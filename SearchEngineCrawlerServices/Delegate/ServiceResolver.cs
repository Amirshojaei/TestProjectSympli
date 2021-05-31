using SearchEngineCrawlerServices.Contract;
using SearchEngineCrawlerServices.Enumeration;

namespace SearchEngineCrawlerServices.Delegate
{
    public delegate ISearchEngine ServiceResolver(SearchEngineTypes key);
}
