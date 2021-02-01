
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textY = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.saisir = new System.Windows.Forms.Button();
            this.grdVisite = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVisite)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(12, 230);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(549, 222);
            this.grd.TabIndex = 1;
            this.grd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.textX);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textY);
            this.panel1.Controls.Add(this.textNom);
            this.panel1.Controls.Add(this.textId);
            this.panel1.Controls.Add(this.saisir);
            this.panel1.Location = new System.Drawing.Point(316, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 156);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(82, 115);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(100, 20);
            this.textX.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position X                                               Y";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textY
            // 
            this.textY.Location = new System.Drawing.Point(230, 115);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(100, 20);
            this.textY.TabIndex = 1;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(82, 64);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(100, 20);
            this.textNom.TabIndex = 1;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(82, 14);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 1;
            this.textId.TextChanged += new System.EventHandler(this.textId_TextChanged);
            // 
            // saisir
            // 
            this.saisir.Location = new System.Drawing.Point(394, 113);
            this.saisir.Name = "saisir";
            this.saisir.Size = new System.Drawing.Size(75, 23);
            this.saisir.TabIndex = 0;
            this.saisir.Text = "Saisir";
            this.saisir.UseVisualStyleBackColor = true;
            this.saisir.Click += new System.EventHandler(this.button2_Click);
            // 
            // grdVisite
            // 
            this.grdVisite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVisite.Location = new System.Drawing.Point(629, 230);
            this.grdVisite.Name = "grdVisite";
            this.grdVisite.Size = new System.Drawing.Size(486, 222);
            this.grdVisite.TabIndex = 1;
            this.grdVisite.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdVisite);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVisite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saisir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdVisite;
    }
}

