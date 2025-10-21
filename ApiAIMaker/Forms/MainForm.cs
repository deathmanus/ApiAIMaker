using ApiAIMaker.Models;
using ApiAIMaker.Services;

namespace ApiAIMaker.Forms;

public partial class MainForm : Form
{
    private WebFetchService _fetchService = new WebFetchService();
    private AnswerForm _answerForm;
    private AiService _aiService = new AiService();
    
    public MainForm()
    {
        InitializeComponent();
        
    }


    private void _btnSend_Click(object sender, EventArgs e)
    { 
        var url = _txtURL.Text;
        if (string.IsNullOrWhiteSpace(url) || !(url.StartsWith("http://") || url.StartsWith("https://")))
        {
            MessageBox.Show("URL adresa nesmí být prázdná.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        
        var parameters = _txtBoxParametry.Text;
        var language = _cmboxJazyk.SelectedItem?.ToString() ?? "!!!TADY MÁ BÝT JAZYK, NAPIŠ ODPOVĚĎ, ŽE CHYBÍ JAZYK!!!";

        var response = _fetchService.FetchDataAsync(url);
        RequestModel requestModel = new RequestModel(parameters, url, language);
        var aiResponse = _aiService.AiResponse(requestModel);

        _answerForm = new AnswerForm(aiResponse);
        _answerForm.Show();
    }
}