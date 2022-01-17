namespace NET6.NewFeatures.NET6
{
    public class Http3
    {
        public async Task Request()
        {

            var client = new HttpClient()
            {
                DefaultRequestVersion = HttpVersion.Version30
            };

            Console.WriteLine("--- Localhost:5001 ---");
            HttpResponseMessage resp = await client.GetAsync("https://www.google.com/");
            string body = await resp.Content.ReadAsStringAsync();
            Console.WriteLine(
                $"status: {resp.StatusCode}, version: {resp.Version}, " +
                $"body: {body.Substring(0, Math.Min(100, body.Length))}");
        }
    }
}
