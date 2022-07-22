using System.Text;
using System.Text.Json;

namespace RestAPICaller
{
    public partial class Form1 : Form
    {
        private readonly List<int> _numberList = new();
        private readonly HttpClient _httpClient = new();
        private const string ApiUrl = "http://localhost:5000/";
        private const int SleepNumber = 10;
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
            GenerateNumberList();
            webView21.Source = new Uri($"{ApiUrl}admin");
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
            _httpClient.PostAsync($"{ApiUrl}lightup", content);
            Thread.Sleep(SleepNumber);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            var content = new StringContent("", Encoding.UTF8, "application/json");
            _httpClient.PostAsync($"{ApiUrl}reset", content);
            webView21.Reload();
        }
    }
}