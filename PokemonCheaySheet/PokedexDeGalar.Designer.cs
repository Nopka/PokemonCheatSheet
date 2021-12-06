namespace PokemonCheaySheet
{
    partial class PokedexDeGalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokedexDeGalar));
            this.NumPoke_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomPoke_Textbox = new System.Windows.Forms.TextBox();
            this.TypePoke_Textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ImagePoke_Picturebox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TalentPoke_Richtextbox = new System.Windows.Forms.RichTextBox();
            this.LocalisationPoke_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NationalDex_Textbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PokedexGridView = new System.Windows.Forms.DataGridView();
            this.pokedexGalarTableAdapter = new PokemonCheatSheet.PokedexDeGalarDataSetREADY01TableAdapters.PokedexGalarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePoke_Picturebox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PokedexGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NumPoke_Textbox
            // 
            this.NumPoke_Textbox.Location = new System.Drawing.Point(124, 49);
            this.NumPoke_Textbox.Name = "NumPoke_Textbox";
            this.NumPoke_Textbox.ReadOnly = true;
            this.NumPoke_Textbox.Size = new System.Drawing.Size(105, 20);
            this.NumPoke_Textbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numéro du pokemon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom du pokemon :";
            // 
            // NomPoke_Textbox
            // 
            this.NomPoke_Textbox.Location = new System.Drawing.Point(124, 75);
            this.NomPoke_Textbox.Name = "NomPoke_Textbox";
            this.NomPoke_Textbox.ReadOnly = true;
            this.NomPoke_Textbox.Size = new System.Drawing.Size(105, 20);
            this.NomPoke_Textbox.TabIndex = 4;
            // 
            // TypePoke_Textbox
            // 
            this.TypePoke_Textbox.Location = new System.Drawing.Point(124, 101);
            this.TypePoke_Textbox.Name = "TypePoke_Textbox";
            this.TypePoke_Textbox.ReadOnly = true;
            this.TypePoke_Textbox.Size = new System.Drawing.Size(105, 20);
            this.TypePoke_Textbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type du pokemon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apparence du pokemon :";
            // 
            // ImagePoke_Picturebox
            // 
            this.ImagePoke_Picturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImagePoke_Picturebox.BackgroundImage")));
            this.ImagePoke_Picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagePoke_Picturebox.Location = new System.Drawing.Point(486, 19);
            this.ImagePoke_Picturebox.Name = "ImagePoke_Picturebox";
            this.ImagePoke_Picturebox.Size = new System.Drawing.Size(172, 150);
            this.ImagePoke_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImagePoke_Picturebox.TabIndex = 8;
            this.ImagePoke_Picturebox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Talents du pokemon :";
            // 
            // TalentPoke_Richtextbox
            // 
            this.TalentPoke_Richtextbox.BackColor = System.Drawing.SystemColors.Control;
            this.TalentPoke_Richtextbox.Location = new System.Drawing.Point(124, 224);
            this.TalentPoke_Richtextbox.Name = "TalentPoke_Richtextbox";
            this.TalentPoke_Richtextbox.ReadOnly = true;
            this.TalentPoke_Richtextbox.Size = new System.Drawing.Size(220, 54);
            this.TalentPoke_Richtextbox.TabIndex = 10;
            this.TalentPoke_Richtextbox.Text = "";
            // 
            // LocalisationPoke_RichTextBox
            // 
            this.LocalisationPoke_RichTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.LocalisationPoke_RichTextBox.Location = new System.Drawing.Point(152, 300);
            this.LocalisationPoke_RichTextBox.Name = "LocalisationPoke_RichTextBox";
            this.LocalisationPoke_RichTextBox.ReadOnly = true;
            this.LocalisationPoke_RichTextBox.Size = new System.Drawing.Size(485, 116);
            this.LocalisationPoke_RichTextBox.TabIndex = 11;
            this.LocalisationPoke_RichTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Localisation du pokemon :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Num du pokedex national :";
            // 
            // NationalDex_Textbox
            // 
            this.NationalDex_Textbox.Location = new System.Drawing.Point(146, 127);
            this.NationalDex_Textbox.Name = "NationalDex_Textbox";
            this.NationalDex_Textbox.ReadOnly = true;
            this.NationalDex_Textbox.Size = new System.Drawing.Size(105, 20);
            this.NationalDex_Textbox.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.NationalDex_Textbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LocalisationPoke_RichTextBox);
            this.groupBox1.Controls.Add(this.TalentPoke_Richtextbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ImagePoke_Picturebox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TypePoke_Textbox);
            this.groupBox1.Controls.Add(this.NomPoke_Textbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NumPoke_Textbox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(460, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 523);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations Complémentaires";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Réinitialiser Pokedex";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(406, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 75);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PokedexGridView
            // 
            this.PokedexGridView.AllowUserToAddRows = false;
            this.PokedexGridView.AllowUserToDeleteRows = false;
            this.PokedexGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.PokedexGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.PokedexGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PokedexGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PokedexGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.PokedexGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PokedexGridView.Location = new System.Drawing.Point(0, 0);
            this.PokedexGridView.Name = "PokedexGridView";
            this.PokedexGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.PokedexGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PokedexGridView.Size = new System.Drawing.Size(460, 523);
            this.PokedexGridView.TabIndex = 0;
            this.PokedexGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PokedexGridView_CellClick);
            this.PokedexGridView.SelectionChanged += new System.EventHandler(this.PokedexGridView_SelectionChanged);
            // 
            // pokedexGalarTableAdapter
            // 
            this.pokedexGalarTableAdapter.ClearBeforeFill = true;
            // 
            // PokedexDeGalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1130, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PokedexGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PokedexDeGalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokedexDeGalar";
            this.Load += new System.EventHandler(this.PokedexDeGalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePoke_Picturebox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PokedexGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView PokedexGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumPoke_Textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ImagePoke_Picturebox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TypePoke_Textbox;
        private System.Windows.Forms.TextBox NomPoke_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox LocalisationPoke_RichTextBox;
        private System.Windows.Forms.RichTextBox TalentPoke_Richtextbox;
        private System.Windows.Forms.Label label5;
        //private PokedexDeGalarDataFINALTableAdapters.PokedexGalarTableAdapter pokedexGalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localisationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox NationalDex_Textbox;
        private System.Windows.Forms.Label label7;
        private PokemonCheatSheet.PokedexDeGalarDataSetREADY01TableAdapters.PokedexGalarTableAdapter pokedexGalarTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}