using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Model;

namespace RestAPICaller
{
    public partial class Form1 : Form
    {
        private readonly List<int> _numberList = new();
        private readonly HttpClient _httpClient = new();
        private static string? _apiUrl;
        private static int _sleepNumber = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSequence_Click(object sender, EventArgs e)
        {
            foreach (var number in _numberList)
            {
                Fire(number);
            }
            
        }

        // generate a private function to generate number 1 to 1400 and store in a list
        private void GenerateNumberList()
        {
            for (var i = 1; i <= 1400; i++)
            {
                _numberList.Add(i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
            GenerateNumberList();
            webView21.Source = new Uri($"{_apiUrl}admin");
        }

        private void LoadSettings()
        {
            var settings = Program.Configuration.GetSection("Settings").Get<Settings>();
            _apiUrl = settings.Url;
            _sleepNumber = int.Parse(settings.SleepTime);

        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var randomList = _numberList.OrderBy(number => random.Next());
            foreach (var number in randomList)
            {
                Fire(number);
            }
        }

        private void Fire(int number)
        {
            var content = new StringContent(JsonSerializer.Serialize(new Model {id = number.ToString()}), Encoding.UTF8, "application/json");
            var test = _httpClient.PostAsync($"{_apiUrl}lightup", content);
            Thread.Sleep(_sleepNumber);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //var content = new StringContent("", Encoding.UTF8, "application/json");
            //_httpClient.PostAsync($"{_apiUrl}reset", content);
            webView21.Reload();
        }

        private void buttonFireTile_Click(object sender, EventArgs e)
        {
            var tile = int.Parse(textBoxTile.Text.Trim());
            Fire(tile);
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate($"{_apiUrl}admin");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var tile = int.Parse(textBoxTile.Text.Trim());
            webView21.CoreWebView2.Navigate($"{_apiUrl}?id={tile}");
        }

        private void buttonAssignTiles_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate($"{_apiUrl}assigntiles");
        }
    }
}