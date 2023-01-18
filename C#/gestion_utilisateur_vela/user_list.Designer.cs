
namespace gestion_utilisateur_vela
{
    partial class user_list
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
            this.ListView = new System.Windows.Forms.ListView();
            this.usr_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usr_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usr_firstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usr_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usr_password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usr_idRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usr_IdUserParrainer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.AutoArrange = false;
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usr_ID,
            this.usr_name,
            this.usr_firstname,
            this.usr_email,
            this.usr_password,
            this.usr_idRole,
            this.usr_IdUserParrainer});
            this.ListView.FullRowSelect = true;
            this.ListView.HideSelection = false;
            this.ListView.LabelEdit = true;
            this.ListView.Location = new System.Drawing.Point(64, 97);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(623, 399);
            this.ListView.TabIndex = 0;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // usr_ID
            // 
            this.usr_ID.Text = "ID";
            this.usr_ID.Width = 36;
            // 
            // usr_name
            // 
            this.usr_name.Text = "Name";
            this.usr_name.Width = 87;
            // 
            // usr_firstname
            // 
            this.usr_firstname.Text = "first name";
            this.usr_firstname.Width = 180;
            // 
            // usr_email
            // 
            this.usr_email.Text = "mail";
            this.usr_email.Width = 102;
            // 
            // usr_password
            // 
            this.usr_password.Text = "password";
            this.usr_password.Width = 66;
            // 
            // usr_idRole
            // 
            this.usr_idRole.Text = "ID Role";
            this.usr_idRole.Width = 59;
            // 
            // usr_IdUserParrainer
            // 
            this.usr_IdUserParrainer.Text = "ID sponsor";
            this.usr_IdUserParrainer.Width = 67;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(251, 35);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(150, 31);
            this.Title.TabIndex = 1;
            this.Title.Text = "Utilisateurs";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(731, 124);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(100, 47);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.DarkRed;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_remove.Location = new System.Drawing.Point(731, 198);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(147, 70);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // user_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 573);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ListView);
            this.Name = "user_list";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ColumnHeader usr_name;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ColumnHeader usr_ID;
        private System.Windows.Forms.ColumnHeader usr_firstname;
        private System.Windows.Forms.ColumnHeader usr_email;
        private System.Windows.Forms.ColumnHeader usr_password;
        private System.Windows.Forms.ColumnHeader usr_idRole;
        private System.Windows.Forms.ColumnHeader usr_IdUserParrainer;
    }
}