using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Graph;

namespace ConsoleGraphTest
{
    public class ToDoHelper
    {
        private GraphServiceClient _graphClient;
        public ToDoHelper(GraphServiceClient graphClient)
        {
            if (null == graphClient) throw new ArgumentNullException(nameof(graphClient));
            _graphClient = graphClient;
        }

        public async void GetTaskList()
        {
            //var queryResult = await _graphClient.Search.Query(sro).Request().PostAsync();
            //if (queryResult.Count == 0) throw new ApplicationException($"Unable to find a tasklist with the keyword {queryKeyword}");

            //return queryResult;
        }
    }
}