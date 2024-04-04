
namespace GigaSharpForms
{
    partial class AboutFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.exitBtn = new FontAwesome.Sharp.IconButton();
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lableProject = new System.Windows.Forms.Label();
            this.labelVerison = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.guna2GradientPanel1.Controls.Add(this.iconButton2);
            this.guna2GradientPanel1.Controls.Add(this.exitBtn);
            this.guna2GradientPanel1.CustomizableEdges = customizableEdges1;
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(344, 34);
            this.guna2GradientPanel1.TabIndex = 1;
            this.guna2GradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2GradientPanel1_MouseDown);
            this.guna2GradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2GradientPanel1_MouseMove);
            this.guna2GradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2GradientPanel1_MouseUp);
            // 
            // iconButton2
            // 
            this.iconButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 23;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton2.Location = new System.Drawing.Point(280, 0);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(27, 34);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.exitBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitBtn.IconSize = 23;
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitBtn.Location = new System.Drawing.Point(307, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(37, 34);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // borderlessForm
            // 
            this.borderlessForm.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
            this.borderlessForm.BorderRadius = 20;
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.DockIndicatorColor = System.Drawing.Color.Transparent;
            this.borderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessForm.DragForm = false;
            this.borderlessForm.HasFormShadow = false;
            this.borderlessForm.ResizeForm = false;
            this.borderlessForm.ShadowColor = System.Drawing.Color.Transparent;
            this.borderlessForm.TransparentWhileDrag = true;
            // 
            // lableProject
            // 
            this.lableProject.AllowDrop = true;
            this.lableProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lableProject.AutoSize = true;
            this.lableProject.BackColor = System.Drawing.Color.Transparent;
            this.lableProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lableProject.Font = new System.Drawing.Font("Segoe UI", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lableProject.Location = new System.Drawing.Point(27, 73);
            this.lableProject.Name = "lableProject";
            this.lableProject.Size = new System.Drawing.Size(171, 23);
            this.lableProject.TabIndex = 7;
            this.lableProject.Text = "Название проекта: ";
            // 
            // labelVerison
            // 
            this.labelVerison.AllowDrop = true;
            this.labelVerison.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVerison.AutoSize = true;
            this.labelVerison.BackColor = System.Drawing.Color.Transparent;
            this.labelVerison.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelVerison.Font = new System.Drawing.Font("Segoe UI", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVerison.Location = new System.Drawing.Point(27, 110);
            this.labelVerison.Name = "labelVerison";
            this.labelVerison.Size = new System.Drawing.Size(80, 23);
            this.labelVerison.TabIndex = 8;
            this.labelVerison.Text = "Версия: ";
            // 
            // AboutFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.labelVerison);
            this.Controls.Add(this.lableProject);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutFrm";
            this.Text = "AboutFrm";
            this.Load += new System.EventHandler(this.AboutFrm_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;
        private System.Windows.Forms.Label labelVerison;
        private System.Windows.Forms.Label lableProject;
        private FontAwesome.Sharp.IconButton exitBtn;
    }
}