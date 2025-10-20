namespace ApiAIMaker.Forms;

public partial class AnswerForm : Form
{
    public AnswerForm(string answerText)
    {
        InitializeComponent();
        
        richTextBox1.Text = answerText;
    }
}