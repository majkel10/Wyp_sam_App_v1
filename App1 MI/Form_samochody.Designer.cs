namespace App1_MI
{
    partial class Form_samochody
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
            this.button_menu = new MaterialSkin.Controls.MaterialFlatButton();
            this.button_dodaj_samochod = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_marka = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_typ = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_rok_produkcji = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_kolor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_pojemnosc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_przebieg = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wyp_sam_lok_v1DataSet = new App1_MI.Wyp_sam_lok_v1DataSet();
            this.sAMOCHODYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAMOCHODYTableAdapter = new App1_MI.Wyp_sam_lok_v1DataSetTableAdapters.SAMOCHODYTableAdapter();
            this.iDsamochoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokprodukcjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pojemnoscsilnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.przebiegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_exit = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyp_sam_lok_v1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMOCHODYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_menu
            // 
            this.button_menu.AutoSize = true;
            this.button_menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_menu.Depth = 0;
            this.button_menu.Location = new System.Drawing.Point(567, 146);
            this.button_menu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_menu.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_menu.Name = "button_menu";
            this.button_menu.Primary = false;
            this.button_menu.Size = new System.Drawing.Size(50, 36);
            this.button_menu.TabIndex = 10;
            this.button_menu.Text = "MENU";
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // button_dodaj_samochod
            // 
            this.button_dodaj_samochod.AutoSize = true;
            this.button_dodaj_samochod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_dodaj_samochod.Depth = 0;
            this.button_dodaj_samochod.Location = new System.Drawing.Point(526, 93);
            this.button_dodaj_samochod.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_dodaj_samochod.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_dodaj_samochod.Name = "button_dodaj_samochod";
            this.button_dodaj_samochod.Primary = false;
            this.button_dodaj_samochod.Size = new System.Drawing.Size(136, 36);
            this.button_dodaj_samochod.TabIndex = 11;
            this.button_dodaj_samochod.Text = "Dodaj samochód";
            this.button_dodaj_samochod.UseVisualStyleBackColor = true;
            this.button_dodaj_samochod.Click += new System.EventHandler(this.button_dodaj_samochod_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(102, 93);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(51, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Marka";
            // 
            // textBox_marka
            // 
            this.textBox_marka.Depth = 0;
            this.textBox_marka.Hint = "";
            this.textBox_marka.Location = new System.Drawing.Point(159, 89);
            this.textBox_marka.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox_marka.Name = "textBox_marka";
            this.textBox_marka.PasswordChar = '\0';
            this.textBox_marka.SelectedText = "";
            this.textBox_marka.SelectionLength = 0;
            this.textBox_marka.SelectionStart = 0;
            this.textBox_marka.Size = new System.Drawing.Size(235, 23);
            this.textBox_marka.TabIndex = 13;
            this.textBox_marka.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(102, 130);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(33, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Typ";
            // 
            // textBox_typ
            // 
            this.textBox_typ.Depth = 0;
            this.textBox_typ.Hint = "";
            this.textBox_typ.Location = new System.Drawing.Point(159, 126);
            this.textBox_typ.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox_typ.Name = "textBox_typ";
            this.textBox_typ.PasswordChar = '\0';
            this.textBox_typ.SelectedText = "";
            this.textBox_typ.SelectionLength = 0;
            this.textBox_typ.SelectionStart = 0;
            this.textBox_typ.Size = new System.Drawing.Size(235, 23);
            this.textBox_typ.TabIndex = 13;
            this.textBox_typ.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(52, 163);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(101, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Rok produkcji";
            // 
            // textBox_rok_produkcji
            // 
            this.textBox_rok_produkcji.Depth = 0;
            this.textBox_rok_produkcji.Hint = "";
            this.textBox_rok_produkcji.Location = new System.Drawing.Point(159, 159);
            this.textBox_rok_produkcji.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox_rok_produkcji.Name = "textBox_rok_produkcji";
            this.textBox_rok_produkcji.PasswordChar = '\0';
            this.textBox_rok_produkcji.SelectedText = "";
            this.textBox_rok_produkcji.SelectionLength = 0;
            this.textBox_rok_produkcji.SelectionStart = 0;
            this.textBox_rok_produkcji.Size = new System.Drawing.Size(235, 23);
            this.textBox_rok_produkcji.TabIndex = 13;
            this.textBox_rok_produkcji.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(108, 201);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(45, 19);
            this.materialLabel4.TabIndex = 12;
            this.materialLabel4.Text = "Kolor";
            // 
            // textBox_kolor
            // 
            this.textBox_kolor.Depth = 0;
            this.textBox_kolor.Hint = "";
            this.textBox_kolor.Location = new System.Drawing.Point(159, 197);
            this.textBox_kolor.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox_kolor.Name = "textBox_kolor";
            this.textBox_kolor.PasswordChar = '\0';
            this.textBox_kolor.SelectedText = "";
            this.textBox_kolor.SelectionLength = 0;
            this.textBox_kolor.SelectionStart = 0;
            this.textBox_kolor.Size = new System.Drawing.Size(235, 23);
            this.textBox_kolor.TabIndex = 13;
            this.textBox_kolor.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(20, 238);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(133, 19);
            this.materialLabel5.TabIndex = 12;
            this.materialLabel5.Text = "Pojemność silnika";
            // 
            // textBox_pojemnosc
            // 
            this.textBox_pojemnosc.Depth = 0;
            this.textBox_pojemnosc.Hint = "";
            this.textBox_pojemnosc.Location = new System.Drawing.Point(159, 234);
            this.textBox_pojemnosc.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox_pojemnosc.Name = "textBox_pojemnosc";
            this.textBox_pojemnosc.PasswordChar = '\0';
            this.textBox_pojemnosc.SelectedText = "";
            this.textBox_pojemnosc.SelectionLength = 0;
            this.textBox_pojemnosc.SelectionStart = 0;
            this.textBox_pojemnosc.Size = new System.Drawing.Size(235, 23);
            this.textBox_pojemnosc.TabIndex = 13;
            this.textBox_pojemnosc.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(87, 272);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(66, 19);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Przebieg";
            // 
            // textBox_przebieg
            // 
            this.textBox_przebieg.Depth = 0;
            this.textBox_przebieg.Hint = "";
            this.textBox_przebieg.Location = new System.Drawing.Point(159, 268);
            this.textBox_przebieg.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox_przebieg.Name = "textBox_przebieg";
            this.textBox_przebieg.PasswordChar = '\0';
            this.textBox_przebieg.SelectedText = "";
            this.textBox_przebieg.SelectionLength = 0;
            this.textBox_przebieg.SelectionStart = 0;
            this.textBox_przebieg.Size = new System.Drawing.Size(235, 23);
            this.textBox_przebieg.TabIndex = 13;
            this.textBox_przebieg.UseSystemPasswordChar = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDsamochoduDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.typDataGridViewTextBoxColumn,
            this.rokprodukcjiDataGridViewTextBoxColumn,
            this.kolorDataGridViewTextBoxColumn,
            this.pojemnoscsilnikaDataGridViewTextBoxColumn,
            this.przebiegDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sAMOCHODYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(823, 139);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // wyp_sam_lok_v1DataSet
            // 
            this.wyp_sam_lok_v1DataSet.DataSetName = "Wyp_sam_lok_v1DataSet";
            this.wyp_sam_lok_v1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sAMOCHODYBindingSource
            // 
            this.sAMOCHODYBindingSource.DataMember = "SAMOCHODY";
            this.sAMOCHODYBindingSource.DataSource = this.wyp_sam_lok_v1DataSet;
            // 
            // sAMOCHODYTableAdapter
            // 
            this.sAMOCHODYTableAdapter.ClearBeforeFill = true;
            // 
            // iDsamochoduDataGridViewTextBoxColumn
            // 
            this.iDsamochoduDataGridViewTextBoxColumn.DataPropertyName = "IDsamochodu";
            this.iDsamochoduDataGridViewTextBoxColumn.HeaderText = "IDsamochodu";
            this.iDsamochoduDataGridViewTextBoxColumn.Name = "iDsamochoduDataGridViewTextBoxColumn";
            this.iDsamochoduDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDsamochoduDataGridViewTextBoxColumn.Width = 50;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.Width = 150;
            // 
            // typDataGridViewTextBoxColumn
            // 
            this.typDataGridViewTextBoxColumn.DataPropertyName = "Typ";
            this.typDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            // 
            // rokprodukcjiDataGridViewTextBoxColumn
            // 
            this.rokprodukcjiDataGridViewTextBoxColumn.DataPropertyName = "Rok_produkcji";
            this.rokprodukcjiDataGridViewTextBoxColumn.HeaderText = "Rok_produkcji";
            this.rokprodukcjiDataGridViewTextBoxColumn.Name = "rokprodukcjiDataGridViewTextBoxColumn";
            // 
            // kolorDataGridViewTextBoxColumn
            // 
            this.kolorDataGridViewTextBoxColumn.DataPropertyName = "Kolor";
            this.kolorDataGridViewTextBoxColumn.HeaderText = "Kolor";
            this.kolorDataGridViewTextBoxColumn.Name = "kolorDataGridViewTextBoxColumn";
            this.kolorDataGridViewTextBoxColumn.Width = 150;
            // 
            // pojemnoscsilnikaDataGridViewTextBoxColumn
            // 
            this.pojemnoscsilnikaDataGridViewTextBoxColumn.DataPropertyName = "Pojemnosc_silnika";
            this.pojemnoscsilnikaDataGridViewTextBoxColumn.HeaderText = "Pojemnosc_silnika";
            this.pojemnoscsilnikaDataGridViewTextBoxColumn.Name = "pojemnoscsilnikaDataGridViewTextBoxColumn";
            this.pojemnoscsilnikaDataGridViewTextBoxColumn.Width = 50;
            // 
            // przebiegDataGridViewTextBoxColumn
            // 
            this.przebiegDataGridViewTextBoxColumn.DataPropertyName = "Przebieg";
            this.przebiegDataGridViewTextBoxColumn.HeaderText = "Przebieg";
            this.przebiegDataGridViewTextBoxColumn.Name = "przebiegDataGridViewTextBoxColumn";
            this.przebiegDataGridViewTextBoxColumn.Width = 150;
            // 
            // button_exit
            // 
            this.button_exit.AutoSize = true;
            this.button_exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_exit.BackColor = System.Drawing.SystemColors.Control;
            this.button_exit.Depth = 0;
            this.button_exit.Location = new System.Drawing.Point(576, 201);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_exit.Name = "button_exit";
            this.button_exit.Primary = false;
            this.button_exit.Size = new System.Drawing.Size(41, 36);
            this.button_exit.TabIndex = 15;
            this.button_exit.Text = "EXIT";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form_samochody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 538);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_przebieg);
            this.Controls.Add(this.textBox_pojemnosc);
            this.Controls.Add(this.textBox_kolor);
            this.Controls.Add(this.textBox_rok_produkcji);
            this.Controls.Add(this.textBox_typ);
            this.Controls.Add(this.textBox_marka);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.button_dodaj_samochod);
            this.Controls.Add(this.button_menu);
            this.Name = "Form_samochody";
            this.Text = "Okno samochodow";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyp_sam_lok_v1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMOCHODYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton button_menu;
        private MaterialSkin.Controls.MaterialFlatButton button_dodaj_samochod;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox_marka;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox_typ;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox_rok_produkcji;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox_kolor;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox_pojemnosc;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox_przebieg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Wyp_sam_lok_v1DataSet wyp_sam_lok_v1DataSet;
        private System.Windows.Forms.BindingSource sAMOCHODYBindingSource;
        private Wyp_sam_lok_v1DataSetTableAdapters.SAMOCHODYTableAdapter sAMOCHODYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDsamochoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokprodukcjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pojemnoscsilnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn przebiegDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialFlatButton button_exit;
    }
}

