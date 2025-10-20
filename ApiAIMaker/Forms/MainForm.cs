using ApiAIMaker.Services;

namespace ApiAIMaker.Forms;

public partial class MainForm : Form
{
    private WebFetchService _fetchService = new WebFetchService();
    
    
    public MainForm()
    {
        InitializeComponent();
    }
}