using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GigaSharpForms
{
    public partial class AboutFrm : Form
    {
        #region Params

        private static Assembly CurrentAssembly = Assembly.GetEntryAssembly();
        private AssemblyName NameProject = CurrentAssembly.GetName();
        private bool IsDragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        #endregion

        public AboutFrm()
        {
            InitializeComponent();
        }
        private void AboutFrm_Load(object sender, EventArgs e)
        {
            lableProject.Text += NameProject.Name;
            labelVerison.Text += NameProject.Version;
        }

        #region Methods

        [Description("Навигация панели")]

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

        private void BtnMouseEnter(object sender, EventArgs e)
        {
            exitBtn.IconColor = Color.White;
        }

        private void BtnMouseLeave(object sender, EventArgs e)
        {
            exitBtn.IconColor = Color.FromArgb(196, 196, 196);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            StartFrm.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        #endregion

    }
}
