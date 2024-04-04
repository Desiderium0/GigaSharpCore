using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LikhodedDynamics.Sber.GigaChatSDK;
using LikhodedDynamics.Sber.GigaChatSDK.Models;

namespace GigaSharpForms
{
    public partial class StartFrm : Form
    {
        #region Params

        private static string AuthorizationData = "ZWM3MzY4OGItMmQxYy00Nzg5LWE5OGUtOGU0NjE1OGQ2ODE4OmVjNjM1ZjI0LTJiY2ItNDk3YS04M2ZmLTQ5NmE1M2ViNWFlMg==";
        private static GigaChat Chat = new(AuthorizationData, false, true, false);
        private bool IsDragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private Color DisableColor = Color.FromArgb(94, 148, 255);
        private Color ActivateColor = Color.FromArgb(255, 77, 165);

        #endregion

        public StartFrm()
        {
            InitializeComponent();
        }

        #region Methods

        private void BtnMouseEnter(object sender, EventArgs e)
        {
            exitBtn.IconColor = Color.White;
        }

        private void BtnMouseLeave(object sender, EventArgs e)
        {
            exitBtn.IconColor = Color.FromArgb(196, 196, 196);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            int widthTextBox = guna2TextBox2.Size.Width;
            int heightTextBox = guna2TextBox2.Size.Height;

            if (this.WindowState == FormWindowState.Normal)
            {
                StartFrm.ActiveForm.WindowState = FormWindowState.Maximized;
                guna2TextBox2.Size = new Size((widthTextBox * 2) + (widthTextBox / 3), (heightTextBox * 2) + (heightTextBox / 3));
            }
            else
            {
                StartFrm.ActiveForm.WindowState = FormWindowState.Normal;
                StartFrm.ActiveForm.StartPosition = FormStartPosition.CenterScreen;
                guna2TextBox2.Size = new Size(705, 386);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            StartFrm.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        [Description("Навигация панели")]
        private void guna2GradientPanel1_DoubleClick(object sender, EventArgs e)
        {
            int widthTextBox = guna2TextBox2.Size.Width;
            int heightTextBox = guna2TextBox2.Size.Height;

            if (this.WindowState == FormWindowState.Normal)
            {
                StartFrm.ActiveForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                StartFrm.ActiveForm.WindowState = FormWindowState.Normal;
                StartFrm.ActiveForm.StartPosition = FormStartPosition.CenterScreen;
                guna2TextBox2.Size = new Size(705, 386);
            }
        }

        private void guna2GradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            IsDragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void guna2GradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragging = false;
        }

        private void guna2GradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDragging)
            {
                Point point = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(point));
            }
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            AboutFrm aboutFrm = new AboutFrm();
            if (!Application.OpenForms.OfType<AboutFrm>().Any())
            {
                aboutFrm.Show();
            }            
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.panelColor1.BackColor = ActivateColor;
            this.panelColor2.BackColor = DisableColor;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.panelColor2.BackColor = ActivateColor;
            this.panelColor1.BackColor = DisableColor;
        }

        private async void iconButton5_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(guna2TextBox1.Text))
            {
                guna2TextBox2.Text += guna2TextBox1.Text;
                guna2TextBox1.Text = string.Empty;
                await CreateContent(guna2TextBox1.Text);
            }
        }


        async Task CreateContent(string content)
        {
            await Chat.CreateTokenAsync();
            Response response = await Chat.CompletionsAsync(content);
            guna2TextBox2.Text += "\n" + response.choices.LastOrDefault().message.content + "\n";
        }

        private void BtnClickExit(object sender, EventArgs e) => Application.Exit();

        #endregion

    }
}
