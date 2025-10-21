using System.ComponentModel;

namespace ApiAIMaker.Forms;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        _txtURL = new System.Windows.Forms.TextBox();
        _cmboxJazyk = new System.Windows.Forms.ComboBox();
        _txtBoxParametry = new System.Windows.Forms.TextBox();
        _lblJazyk = new System.Windows.Forms.Label();
        _lblURL = new System.Windows.Forms.Label();
        _lblParametry = new System.Windows.Forms.Label();
        _btnSend = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // _txtURL
        // 
        _txtURL.Location = new System.Drawing.Point(17, 47);
        _txtURL.Name = "_txtURL";
        _txtURL.Size = new System.Drawing.Size(776, 23);
        _txtURL.TabIndex = 0;
        // 
        // _cmboxJazyk
        // 
        _cmboxJazyk.FormattingEnabled = true;
        _cmboxJazyk.Location = new System.Drawing.Point(17, 111);
        _cmboxJazyk.Name = "_cmboxJazyk";
        _cmboxJazyk.Size = new System.Drawing.Size(269, 23);
        _cmboxJazyk.TabIndex = 1;
        // 
        // _txtBoxParametry
        // 
        _txtBoxParametry.Location = new System.Drawing.Point(17, 170);
        _txtBoxParametry.Multiline = true;
        _txtBoxParametry.Name = "_txtBoxParametry";
        _txtBoxParametry.Size = new System.Drawing.Size(771, 246);
        _txtBoxParametry.TabIndex = 2;
        // 
        // _lblJazyk
        // 
        _lblJazyk.Location = new System.Drawing.Point(17, 85);
        _lblJazyk.Name = "_lblJazyk";
        _lblJazyk.Size = new System.Drawing.Size(148, 23);
        _lblJazyk.TabIndex = 3;
        _lblJazyk.Text = "Jazyk";
        // 
        // _lblURL
        // 
        _lblURL.Location = new System.Drawing.Point(17, 19);
        _lblURL.Name = "_lblURL";
        _lblURL.Size = new System.Drawing.Size(142, 24);
        _lblURL.TabIndex = 4;
        _lblURL.Text = "API DOKUMENTACE URL";
        // 
        // _lblParametry
        // 
        _lblParametry.Location = new System.Drawing.Point(17, 146);
        _lblParametry.Name = "_lblParametry";
        _lblParametry.Size = new System.Drawing.Size(180, 21);
        _lblParametry.TabIndex = 5;
        _lblParametry.Text = "Parametry";
        // 
        // _btnSend
        // 
        _btnSend.Location = new System.Drawing.Point(17, 422);
        _btnSend.Name = "_btnSend";
        _btnSend.Size = new System.Drawing.Size(770, 20);
        _btnSend.TabIndex = 6;
        _btnSend.Text = "Send";
        _btnSend.UseVisualStyleBackColor = true;
        _btnSend.Click += _btnSend_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(_btnSend);
        Controls.Add(_lblParametry);
        Controls.Add(_lblURL);
        Controls.Add(_lblJazyk);
        Controls.Add(_txtBoxParametry);
        Controls.Add(_cmboxJazyk);
        Controls.Add(_txtURL);
        Text = "MainForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button _btnSend;

    private System.Windows.Forms.Label _lblJazyk;
    private System.Windows.Forms.Label _lblURL;
    private System.Windows.Forms.Label _lblParametry;

    private System.Windows.Forms.TextBox _txtURL;
    private System.Windows.Forms.ComboBox _cmboxJazyk;
    private System.Windows.Forms.TextBox _txtBoxParametry;

    #endregion
}