using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TicketMaster.Model;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace TicketMaster
{
    internal class Program
    {
        private static readonly HttpClient Client = new HttpClient();

        private static async Task Main()
        {
            var result = await ProcessRepositories();

            if (result.Page.TryGetValue("totalPages", out var pages))
            {
                Console.WriteLine($"Founded {pages} count pages by this theme...\n");
                Show_articles_info(result);
            }
            else
                Console.WriteLine("Not exist");

            Console.ReadKey();
        }

        private static void Show_articles_info(CurrentJsonModel model)
        {
            foreach (var news in model.Embedded["attractions"])
            {
                var article = new StringBuilder();
                article.AppendLine($"{news.Name} (id#[{news.Id}])");
                article.AppendLine($"\t {news.Url}");

                Console.WriteLine(article);
            }
        }

        private static async Task<CurrentJsonModel> ProcessRepositories()
        {
            Client.DefaultRequestHeaders.Accept.Clear();
            var streamTask = Client.GetStreamAsync(Settings.ApiRequestString);
            try
            {
                return await JsonSerializer.DeserializeAsync<CurrentJsonModel>(await streamTask);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Some error has been caught | e {e.Message}");
                return new CurrentJsonModel();
            }
        }
    }
}