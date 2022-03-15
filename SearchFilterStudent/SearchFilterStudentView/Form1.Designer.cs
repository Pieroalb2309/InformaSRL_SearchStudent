
namespace SearchFilterStudentView
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.StudentListDataGridView = new System.Windows.Forms.DataGridView();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(316, 33);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(215, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Search Students";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(136, 252);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(36, 16);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Input";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(577, 247);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(122, 30);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(199, 250);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(317, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // StudentListDataGridView
            // 
            this.StudentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentListDataGridView.Location = new System.Drawing.Point(49, 306);
            this.StudentListDataGridView.Name = "StudentListDataGridView";
            this.StudentListDataGridView.Size = new System.Drawing.Size(705, 344);
            this.StudentListDataGridView.TabIndex = 4;
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.Location = new System.Drawing.Point(45, 79);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(561, 100);
            this.labelSubtitle.TabIndex = 5;
            this.labelSubtitle.Text = "Can search:\r\nby name\r\nby surname\r\nby school\'s name\r\nby date of birth in MM/DD/YYY" +
    "Y format and comparison symbols(optional) like:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "\"<MM/DD/YYYY \" or \">MM/DD/YYYY\" or \"<=MM/DD/YYYY\" or  \"\'>=MM/DD/YYYY \"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.StudentListDataGridView);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StudentListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView StudentListDataGridView;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label label1;
    }
}

