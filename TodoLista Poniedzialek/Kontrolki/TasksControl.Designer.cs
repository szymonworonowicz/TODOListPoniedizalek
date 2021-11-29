namespace TodoLista_Poniedzialek.Kontrolki
{
    partial class TasksControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWyloguj = new System.Windows.Forms.Button();
            this.lblZalogowny = new System.Windows.Forms.Label();
            this.lblZalogowanyWartosc = new System.Windows.Forms.Label();
            this.lblKreski = new System.Windows.Forms.Label();
            this.lvZadania = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIsReady = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblTodoTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWyloguj
            // 
            this.btnWyloguj.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnWyloguj.FlatAppearance.BorderSize = 0;
            this.btnWyloguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWyloguj.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWyloguj.Location = new System.Drawing.Point(424, 11);
            this.btnWyloguj.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnWyloguj.Name = "btnWyloguj";
            this.btnWyloguj.Size = new System.Drawing.Size(68, 56);
            this.btnWyloguj.TabIndex = 1;
            this.btnWyloguj.Text = "🏃";
            this.btnWyloguj.UseVisualStyleBackColor = false;
            // 
            // lblZalogowny
            // 
            this.lblZalogowny.AutoSize = true;
            this.lblZalogowny.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZalogowny.Location = new System.Drawing.Point(133, 28);
            this.lblZalogowny.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblZalogowny.Name = "lblZalogowny";
            this.lblZalogowny.Size = new System.Drawing.Size(137, 24);
            this.lblZalogowny.TabIndex = 2;
            this.lblZalogowny.Text = "Zalogowany jako:";
            // 
            // lblZalogowanyWartosc
            // 
            this.lblZalogowanyWartosc.AutoSize = true;
            this.lblZalogowanyWartosc.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZalogowanyWartosc.Location = new System.Drawing.Point(266, 27);
            this.lblZalogowanyWartosc.Name = "lblZalogowanyWartosc";
            this.lblZalogowanyWartosc.Size = new System.Drawing.Size(83, 27);
            this.lblZalogowanyWartosc.TabIndex = 3;
            this.lblZalogowanyWartosc.Text = "Anonim";
            // 
            // lblKreski
            // 
            this.lblKreski.AutoSize = true;
            this.lblKreski.Font = new System.Drawing.Font("Monotype Corsiva", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKreski.Location = new System.Drawing.Point(3, 68);
            this.lblKreski.Name = "lblKreski";
            this.lblKreski.Size = new System.Drawing.Size(495, 11);
            this.lblKreski.TabIndex = 5;
            this.lblKreski.Text = "_________________________________________________________________________________" +
       "_________________";
            // 
            // lvZadania
            // 
            this.lvZadania.BackColor = System.Drawing.SystemColors.Info;
            this.lvZadania.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colTitle,
            this.colIsReady});
            this.lvZadania.FullRowSelect = true;
            this.lvZadania.GridLines = true;
            this.lvZadania.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvZadania.HideSelection = false;
            this.lvZadania.Location = new System.Drawing.Point(5, 87);
            this.lvZadania.MultiSelect = false;
            this.lvZadania.Name = "lvZadania";
            this.lvZadania.ShowGroups = false;
            this.lvZadania.Size = new System.Drawing.Size(413, 548);
            this.lvZadania.TabIndex = 6;
            this.lvZadania.UseCompatibleStateImageBehavior = false;
            this.lvZadania.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 50;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            this.colTitle.Width = 274;
            // 
            // colIsReady
            // 
            this.colIsReady.Text = "Zrobione";
            this.colIsReady.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colIsReady.Width = 85;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Maiandra GD", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(424, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 210);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "➕";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(424, 529);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 106);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "🗑";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Turquoise;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(424, 303);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(68, 220);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "🖉";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // lblTodoTitle
            // 
            this.lblTodoTitle.AutoSize = true;
            this.lblTodoTitle.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodoTitle.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblTodoTitle.Location = new System.Drawing.Point(3, 11);
            this.lblTodoTitle.Name = "lblTodoTitle";
            this.lblTodoTitle.Size = new System.Drawing.Size(122, 49);
            this.lblTodoTitle.TabIndex = 11;
            this.lblTodoTitle.Text = "TODO";
            // 
            // TasksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Controls.Add(this.lblTodoTitle);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvZadania);
            this.Controls.Add(this.lblKreski);
            this.Controls.Add(this.lblZalogowanyWartosc);
            this.Controls.Add(this.lblZalogowny);
            this.Controls.Add(this.btnWyloguj);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TasksControl";
            this.Size = new System.Drawing.Size(500, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnWyloguj;
        private System.Windows.Forms.Label lblZalogowny;
        private System.Windows.Forms.Label lblZalogowanyWartosc;
        private System.Windows.Forms.Label lblKreski;
        private System.Windows.Forms.ListView lvZadania;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colIsReady;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblTodoTitle;
    }
}
