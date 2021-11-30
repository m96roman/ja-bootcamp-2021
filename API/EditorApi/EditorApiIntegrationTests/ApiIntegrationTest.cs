using EditorApi;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EditorApiIntegrationTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task Copy_file()
        {
            var factory = new WebApplicationFactory<Startup>();

            HttpClient client = factory.CreateClient();

            string text = "Hello I am text and I am little!\n\r But a good new is that I grow.\n\rI`m becomming bigger right now!\n\r";

            string stringContent = JsonConvert.SerializeObject(text);

            StringContent content = new StringContent(stringContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PutAsync("/Files/New.txt", content);

            Assert.True(response.IsSuccessStatusCode);
        }


        [TestCase("Test.txt")]
        public async Task GetFileNames(string expected)
        {
            var factory = new WebApplicationFactory<Startup>();
        
            HttpClient client = factory.CreateClient();

            HttpResponseMessage response = await client.GetAsync("/Files");
         
            var res = response.StatusCode;
          
            var result = await response.Content.ReadAsStringAsync();

             var stringContent = JsonConvert.DeserializeObject(result);

            Assert.AreEqual(expected, stringContent);
            Assert.True(response.IsSuccessStatusCode);
        }

      
        [Test]
        public async Task ReplacesCount()
        {
            var factory = new WebApplicationFactory<Startup>();
           
            HttpClient client = factory.CreateClient();

            HttpResponseMessage response = await client.PostAsync("/Files/Test.txt?searchText=NIGHT&replaceText=night", null);
           // HttpResponseMessage response = await client.PostAsync("/Files/Test.txt?searchText=night&replaceText=NIGHT", null);
            string result = await response.Content.ReadAsStringAsync();
        }

        [Test]
        public async Task GetParagraphs()
        {
            var factory = new WebApplicationFactory<Startup>();
           
            HttpClient client = factory.CreateClient();

            HttpResponseMessage response = await client.GetAsync("/Files/Test.txt?searchText=MacDonald");

            string resultedText = await response.Content.ReadAsStringAsync();  
        }

      
        public async Task Full_intergation_test()
        {
            var factory = new WebApplicationFactory<Startup>();

            HttpClient clientCopy = factory.CreateClient();
           
            string text = "Hello I am text and I am little!\n\r But a good new is that I grow.\n\rI`m becomming bigger right now!\n\r";

            string stringContent = JsonConvert.SerializeObject(text);


            StringContent content = new StringContent(stringContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await clientCopy.PutAsync("/Files/New.txt", content);

           
           
            HttpClient clientGetFiles = factory.CreateClient();
            HttpResponseMessage response1 = await clientGetFiles.GetAsync("/Files");



            HttpClient clientReplace = factory.CreateClient();
           // HttpResponseMessage response2 = await clientReplace.PostAsync("/Files/Test.txt?searchText=NIGHT&replaceText=night", null);
            HttpResponseMessage response2 = await clientReplace.PostAsync("/Files/Test.txt?searchText=NIGHT&replaceText=night", null);


            HttpClient clientSearch = factory.CreateClient();
            HttpResponseMessage response3 = await clientSearch.GetAsync("/Files/Test.txt?searchText=MacDonald");

        }
    }
}