using System.Net;

namespace RestAPICaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSequence_Click(object sender, EventArgs e)
        {
          
        }

        // generate a private function to generate number 1 to 1400 and store in a list
        private List<int> GenerateNumberList()
        {
            var numberList = new List<int>();
            for (var i = 1; i <= 1400; i++)
            {
                numberList.Add(i);
            }
            return numberList;
        }
    }
}