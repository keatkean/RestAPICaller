using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Timer = System.Threading.Timer;

namespace RestAPICaller
{
    public partial class Form1 : Form
    {
        private readonly List<int> _numberList = new();
        private HttpClient httpClient = new HttpClient();
        private const string ApiUrl = "http://localhost:5000/lightup";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSequence_Click(object sender, EventArgs e)
        {
            foreach (var number in _numberList)
            {
                var model = new Model
                {
                    id = number.ToString()
                };

                var content = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8,"application/json"); 
                httpClient.PostAsync(ApiUrl,content);
                Thread.Sleep(10);
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
            
        }
    }
}