namespace FastFix_vista
{
    partial class FastFix_vista
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.Pass = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.sexo = new MaterialSkin.Controls.MaterialComboBox();
            this.Pass2_Crear = new MaterialSkin.Controls.MaterialTextBox2();
            this.Pass_Crear = new MaterialSkin.Controls.MaterialTextBox2();
            this.Gmail_Crear = new MaterialSkin.Controls.MaterialTextBox2();
            this.Apellido2_Crear = new MaterialSkin.Controls.MaterialTextBox2();
            this.Apellido_Crear = new MaterialSkin.Controls.MaterialTextBox2();
            this.Nombre_Crear = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 80);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(549, 749);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(541, 723);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Loging";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox3);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.pictureBox2);
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Controls.Add(this.Gmail);
            this.materialCard1.Controls.Add(this.Pass);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(41, 61);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(458, 600);
            this.materialCard1.TabIndex = 0;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FastFix_vista.Properties.Resources.Screenshot_1;
            this.pictureBox3.Location = new System.Drawing.Point(312, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(185, 365);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(77, 36);
            this.materialButton1.TabIndex = 5;
            this.materialButton1.Text = "Entrar ";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FastFix_vista.Properties.Resources.password_14562503;
            this.pictureBox2.Location = new System.Drawing.Point(350, 298);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FastFix_vista.Properties.Resources.envelope_14562231;
            this.pictureBox1.Location = new System.Drawing.Point(350, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Gmail
            // 
            this.Gmail.AnimateReadOnly = false;
            this.Gmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Gmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Gmail.Depth = 0;
            this.Gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Gmail.HideSelection = true;
            this.Gmail.LeadingIcon = null;
            this.Gmail.Location = new System.Drawing.Point(55, 199);
            this.Gmail.MaxLength = 32767;
            this.Gmail.MouseState = MaterialSkin.MouseState.OUT;
            this.Gmail.Name = "Gmail";
            this.Gmail.PasswordChar = '\0';
            this.Gmail.PrefixSuffixText = null;
            this.Gmail.ReadOnly = false;
            this.Gmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Gmail.SelectedText = "";
            this.Gmail.SelectionLength = 0;
            this.Gmail.SelectionStart = 0;
            this.Gmail.ShortcutsEnabled = true;
            this.Gmail.Size = new System.Drawing.Size(270, 48);
            this.Gmail.TabIndex = 2;
            this.Gmail.TabStop = false;
            this.Gmail.Text = "Gmail";
            this.Gmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Gmail.TrailingIcon = null;
            this.Gmail.UseSystemPasswordChar = false;
            this.Gmail.Click += new System.EventHandler(this.Gmail_Click);
            this.Gmail.Leave += new System.EventHandler(this.Gmail_Leave);
            // 
            // Pass
            // 
            this.Pass.AnimateReadOnly = false;
            this.Pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Pass.Depth = 0;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Pass.HideSelection = true;
            this.Pass.LeadingIcon = null;
            this.Pass.Location = new System.Drawing.Point(55, 298);
            this.Pass.MaxLength = 32767;
            this.Pass.MouseState = MaterialSkin.MouseState.OUT;
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.PrefixSuffixText = null;
            this.Pass.ReadOnly = false;
            this.Pass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Pass.SelectedText = "";
            this.Pass.SelectionLength = 0;
            this.Pass.SelectionStart = 0;
            this.Pass.ShortcutsEnabled = true;
            this.Pass.Size = new System.Drawing.Size(270, 48);
            this.Pass.TabIndex = 1;
            this.Pass.TabStop = false;
            this.Pass.Text = "Pass";
            this.Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pass.TrailingIcon = null;
            this.Pass.UseSystemPasswordChar = false;
            this.Pass.Click += new System.EventHandler(this.Gmail_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialButton2);
            this.tabPage2.Controls.Add(this.sexo);
            this.tabPage2.Controls.Add(this.Pass2_Crear);
            this.tabPage2.Controls.Add(this.Pass_Crear);
            this.tabPage2.Controls.Add(this.Gmail_Crear);
            this.tabPage2.Controls.Add(this.Apellido2_Crear);
            this.tabPage2.Controls.Add(this.Apellido_Crear);
            this.tabPage2.Controls.Add(this.Nombre_Crear);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(541, 723);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create user";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(204, 519);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(132, 36);
            this.materialButton2.TabIndex = 10;
            this.materialButton2.Text = "Crear Usuario";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // sexo
            // 
            this.sexo.AutoResize = false;
            this.sexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sexo.Depth = 0;
            this.sexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sexo.DropDownHeight = 174;
            this.sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexo.DropDownWidth = 121;
            this.sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sexo.FormattingEnabled = true;
            this.sexo.IntegralHeight = false;
            this.sexo.ItemHeight = 43;
            this.sexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer ",
            "Otros"});
            this.sexo.Location = new System.Drawing.Point(135, 304);
            this.sexo.MaxDropDownItems = 4;
            this.sexo.MouseState = MaterialSkin.MouseState.OUT;
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(270, 49);
            this.sexo.StartIndex = 0;
            this.sexo.TabIndex = 9;
            // 
            // Pass2_Crear
            // 
            this.Pass2_Crear.AnimateReadOnly = false;
            this.Pass2_Crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pass2_Crear.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Pass2_Crear.Depth = 0;
            this.Pass2_Crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Pass2_Crear.HideSelection = true;
            this.Pass2_Crear.LeadingIcon = null;
            this.Pass2_Crear.Location = new System.Drawing.Point(135, 449);
            this.Pass2_Crear.MaxLength = 32767;
            this.Pass2_Crear.MouseState = MaterialSkin.MouseState.OUT;
            this.Pass2_Crear.Name = "Pass2_Crear";
            this.Pass2_Crear.PasswordChar = '\0';
            this.Pass2_Crear.PrefixSuffixText = null;
            this.Pass2_Crear.ReadOnly = false;
            this.Pass2_Crear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Pass2_Crear.SelectedText = "";
            this.Pass2_Crear.SelectionLength = 0;
            this.Pass2_Crear.SelectionStart = 0;
            this.Pass2_Crear.ShortcutsEnabled = true;
            this.Pass2_Crear.Size = new System.Drawing.Size(270, 48);
            this.Pass2_Crear.TabIndex = 8;
            this.Pass2_Crear.TabStop = false;
            this.Pass2_Crear.Text = "Confirma la contraseña";
            this.Pass2_Crear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pass2_Crear.TrailingIcon = null;
            this.Pass2_Crear.UseSystemPasswordChar = false;
            this.Pass2_Crear.Click += new System.EventHandler(this.Gmail_Click);
            // 
            // Pass_Crear
            // 
            this.Pass_Crear.AnimateReadOnly = false;
            this.Pass_Crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pass_Crear.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Pass_Crear.Depth = 0;
            this.Pass_Crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Pass_Crear.HideSelection = true;
            this.Pass_Crear.LeadingIcon = null;
            this.Pass_Crear.Location = new System.Drawing.Point(135, 374);
            this.Pass_Crear.MaxLength = 32767;
            this.Pass_Crear.MouseState = MaterialSkin.MouseState.OUT;
            this.Pass_Crear.Name = "Pass_Crear";
            this.Pass_Crear.PasswordChar = '\0';
            this.Pass_Crear.PrefixSuffixText = null;
            this.Pass_Crear.ReadOnly = false;
            this.Pass_Crear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Pass_Crear.SelectedText = "";
            this.Pass_Crear.SelectionLength = 0;
            this.Pass_Crear.SelectionStart = 0;
            this.Pass_Crear.ShortcutsEnabled = true;
            this.Pass_Crear.Size = new System.Drawing.Size(270, 48);
            this.Pass_Crear.TabIndex = 7;
            this.Pass_Crear.TabStop = false;
            this.Pass_Crear.Text = "Crea una contraseña";
            this.Pass_Crear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pass_Crear.TrailingIcon = null;
            this.Pass_Crear.UseSystemPasswordChar = false;
            this.Pass_Crear.Click += new System.EventHandler(this.Gmail_Click);
            // 
            // Gmail_Crear
            // 
            this.Gmail_Crear.AnimateReadOnly = false;
            this.Gmail_Crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Gmail_Crear.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Gmail_Crear.Depth = 0;
            this.Gmail_Crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Gmail_Crear.HideSelection = true;
            this.Gmail_Crear.LeadingIcon = null;
            this.Gmail_Crear.Location = new System.Drawing.Point(135, 236);
            this.Gmail_Crear.MaxLength = 32767;
            this.Gmail_Crear.MouseState = MaterialSkin.MouseState.OUT;
            this.Gmail_Crear.Name = "Gmail_Crear";
            this.Gmail_Crear.PasswordChar = '\0';
            this.Gmail_Crear.PrefixSuffixText = null;
            this.Gmail_Crear.ReadOnly = false;
            this.Gmail_Crear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Gmail_Crear.SelectedText = "";
            this.Gmail_Crear.SelectionLength = 0;
            this.Gmail_Crear.SelectionStart = 0;
            this.Gmail_Crear.ShortcutsEnabled = true;
            this.Gmail_Crear.Size = new System.Drawing.Size(270, 48);
            this.Gmail_Crear.TabIndex = 6;
            this.Gmail_Crear.TabStop = false;
            this.Gmail_Crear.Text = "Correo Electronico";
            this.Gmail_Crear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Gmail_Crear.TrailingIcon = null;
            this.Gmail_Crear.UseSystemPasswordChar = false;
            this.Gmail_Crear.Click += new System.EventHandler(this.Gmail_Click);
            // 
            // Apellido2_Crear
            // 
            this.Apellido2_Crear.AnimateReadOnly = false;
            this.Apellido2_Crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Apellido2_Crear.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Apellido2_Crear.Depth = 0;
            this.Apellido2_Crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Apellido2_Crear.HideSelection = true;
            this.Apellido2_Crear.LeadingIcon = null;
            this.Apellido2_Crear.Location = new System.Drawing.Point(135, 168);
            this.Apellido2_Crear.MaxLength = 32767;
            this.Apellido2_Crear.MouseState = MaterialSkin.MouseState.OUT;
            this.Apellido2_Crear.Name = "Apellido2_Crear";
            this.Apellido2_Crear.PasswordChar = '\0';
            this.Apellido2_Crear.PrefixSuffixText = null;
            this.Apellido2_Crear.ReadOnly = false;
            this.Apellido2_Crear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Apellido2_Crear.SelectedText = "";
            this.Apellido2_Crear.SelectionLength = 0;
            this.Apellido2_Crear.SelectionStart = 0;
            this.Apellido2_Crear.ShortcutsEnabled = true;
            this.Apellido2_Crear.Size = new System.Drawing.Size(270, 48);
            this.Apellido2_Crear.TabIndex = 5;
            this.Apellido2_Crear.TabStop = false;
            this.Apellido2_Crear.Text = "Segundo apellido";
            this.Apellido2_Crear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Apellido2_Crear.TrailingIcon = null;
            this.Apellido2_Crear.UseSystemPasswordChar = false;
            this.Apellido2_Crear.Click += new System.EventHandler(this.Gmail_Click);
            // 
            // Apellido_Crear
            // 
            this.Apellido_Crear.AnimateReadOnly = false;
            this.Apellido_Crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Apellido_Crear.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Apellido_Crear.Depth = 0;
            this.Apellido_Crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Apellido_Crear.HideSelection = true;
            this.Apellido_Crear.LeadingIcon = null;
            this.Apellido_Crear.Location = new System.Drawing.Point(135, 96);
            this.Apellido_Crear.MaxLength = 32767;
            this.Apellido_Crear.MouseState = MaterialSkin.MouseState.OUT;
            this.Apellido_Crear.Name = "Apellido_Crear";
            this.Apellido_Crear.PasswordChar = '\0';
            this.Apellido_Crear.PrefixSuffixText = null;
            this.Apellido_Crear.ReadOnly = false;
            this.Apellido_Crear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Apellido_Crear.SelectedText = "";
            this.Apellido_Crear.SelectionLength = 0;
            this.Apellido_Crear.SelectionStart = 0;
            this.Apellido_Crear.ShortcutsEnabled = true;
            this.Apellido_Crear.Size = new System.Drawing.Size(270, 48);
            this.Apellido_Crear.TabIndex = 4;
            this.Apellido_Crear.TabStop = false;
            this.Apellido_Crear.Text = "Prime apellido ";
            this.Apellido_Crear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Apellido_Crear.TrailingIcon = null;
            this.Apellido_Crear.UseSystemPasswordChar = false;
            this.Apellido_Crear.Click += new System.EventHandler(this.Gmail_Click);
            // 
            // Nombre_Crear
            // 
            this.Nombre_Crear.AnimateReadOnly = false;
            this.Nombre_Crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Nombre_Crear.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Nombre_Crear.Depth = 0;
            this.Nombre_Crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Nombre_Crear.HideSelection = true;
            this.Nombre_Crear.LeadingIcon = null;
            this.Nombre_Crear.Location = new System.Drawing.Point(135, 33);
            this.Nombre_Crear.MaxLength = 32767;
            this.Nombre_Crear.MouseState = MaterialSkin.MouseState.OUT;
            this.Nombre_Crear.Name = "Nombre_Crear";
            this.Nombre_Crear.PasswordChar = '\0';
            this.Nombre_Crear.PrefixSuffixText = null;
            this.Nombre_Crear.ReadOnly = false;
            this.Nombre_Crear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Nombre_Crear.SelectedText = "";
            this.Nombre_Crear.SelectionLength = 0;
            this.Nombre_Crear.SelectionStart = 0;
            this.Nombre_Crear.ShortcutsEnabled = true;
            this.Nombre_Crear.Size = new System.Drawing.Size(270, 48);
            this.Nombre_Crear.TabIndex = 3;
            this.Nombre_Crear.TabStop = false;
            this.Nombre_Crear.Text = "Nombre";
            this.Nombre_Crear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nombre_Crear.TrailingIcon = null;
            this.Nombre_Crear.UseSystemPasswordChar = false;
            this.Nombre_Crear.Click += new System.EventHandler(this.Gmail_Click);
            // 
            // FastFix_vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 832);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_56;
            this.MaximizeBox = false;
            this.Name = "FastFix_vista";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Fix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 Pass;
        private MaterialSkin.Controls.MaterialTextBox2 Gmail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialTextBox2 Pass2_Crear;
        private MaterialSkin.Controls.MaterialTextBox2 Pass_Crear;
        private MaterialSkin.Controls.MaterialTextBox2 Gmail_Crear;
        private MaterialSkin.Controls.MaterialTextBox2 Apellido2_Crear;
        private MaterialSkin.Controls.MaterialTextBox2 Apellido_Crear;
        private MaterialSkin.Controls.MaterialTextBox2 Nombre_Crear;
        private MaterialSkin.Controls.MaterialComboBox sexo;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}

