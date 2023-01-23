
namespace WindowsFormsApp2
{
    partial class Form3
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
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lalage = new System.Windows.Forms.Label();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblStream = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblrollno = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.txtStream = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(104, 249);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 49;
            // 
            // lalage
            // 
            this.lalage.AutoSize = true;
            this.lalage.Location = new System.Drawing.Point(17, 251);
            this.lalage.Name = "lalage";
            this.lalage.Size = new System.Drawing.Size(26, 13);
            this.lalage.TabIndex = 48;
            this.lalage.Text = "Age";
            // 
            // GridView1
            // 
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Location = new System.Drawing.Point(254, 124);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.Size(515, 261);
            this.GridView1.TabIndex = 47;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(17, 214);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(62, 13);
            this.lblPercentage.TabIndex = 46;
            this.lblPercentage.Text = "Percentage";
            // 
            // lblStream
            // 
            this.lblStream.AutoSize = true;
            this.lblStream.Location = new System.Drawing.Point(17, 167);
            this.lblStream.Name = "lblStream";
            this.lblStream.Size = new System.Drawing.Size(40, 13);
            this.lblStream.TabIndex = 45;
            this.lblStream.Text = "Stream";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 13);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "Student Name";
            // 
            // lblrollno
            // 
            this.lblrollno.AutoSize = true;
            this.lblrollno.Location = new System.Drawing.Point(13, 79);
            this.lblrollno.Name = "lblrollno";
            this.lblrollno.Size = new System.Drawing.Size(82, 13);
            this.lblrollno.TabIndex = 43;
            this.lblrollno.Text = "Student Roll No";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 42;
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(104, 214);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtPercentage.TabIndex = 41;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(104, 79);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 39;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(428, 405);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(156, 33);
            this.btnShowAll.TabIndex = 38;
            this.btnShowAll.Text = "ShowAll";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(239, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(342, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(158, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 33);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(104, 290);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 20);
            this.txtGender.TabIndex = 51;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(17, 292);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(42, 13);
            this.lblgender.TabIndex = 50;
            this.lblgender.Text = "Gender";
            // 
            // txtStream
            // 
            this.txtStream.FormattingEnabled = true;
            this.txtStream.Items.AddRange(new object[] {
            "Mech",
            "CSC",
            "E&TC",
            "IT",
            "CIVIL"});
            this.txtStream.Location = new System.Drawing.Point(104, 167);
            this.txtStream.Name = "txtStream";
            this.txtStream.Size = new System.Drawing.Size(100, 21);
            this.txtStream.TabIndex = 52;
            this.txtStream.Text = "Stream";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(88, 392);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 31);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtStream);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lalage);
            this.Controls.Add(this.GridView1);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblStream);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblrollno);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lalage;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblStream;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblrollno;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.ComboBox txtStream;
        private System.Windows.Forms.Button btnClear;
    }
}