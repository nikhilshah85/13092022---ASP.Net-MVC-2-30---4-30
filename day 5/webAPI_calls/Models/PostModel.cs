namespace webAPI_calls.Models
{
    public class PostModel
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public string body { get; set; }


        List<PostModel> dataFromAPI = new List<PostModel>();

        public List<PostModel> CallPostAPI()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new HttpClient();

            //every browser makes api call in default format, like XML, JSON,Binary, text etc....

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //try to make a call and test if the call is a success, then only start to read the data else throw an exception

            var call = client.GetAsync(url);

            if (call.Result.IsSuccessStatusCode)
            {
                var data = call.Result.Content.ReadAsAsync<List<PostModel>>();
                data.Wait(); //please wait till we start reading the data
                dataFromAPI = data.Result;
                return dataFromAPI;

            }
            else
            {
                throw new Exception("Cannot contact server, please check with Admin");
            }


        }
    }
}
