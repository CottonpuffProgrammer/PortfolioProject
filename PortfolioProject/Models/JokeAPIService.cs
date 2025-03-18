namespace PortfolioProject.Models
{
    /// <summary>
    /// This method uses the JokeAPI to receive a randomly selected 
    /// programming joke from the API to be displayed on a webpage.
    /// </summary>
    public class JokeAPIService
    {
        private readonly HttpClient _httpClient;

        public JokeAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetJokeAsync()
        {
            var url = "https://jokeapi.dev/joke/Programming?format=txt&type=single&blacklistFlags=nsfw,religious,political,racist,sexist,explicit&lang=en";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jokeResponse = await response.Content.ReadAsStringAsync();
                return jokeResponse;
            }
            else
            {
                return "Unable to fetch a joke.";
            }
        }
    }
}
