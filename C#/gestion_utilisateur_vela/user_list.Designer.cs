
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
            this.Title = new System.Windows.Forms.Label();
            this.usr_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usr_role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usr_name,
            this.usr_role});
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(64, 97);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(612, 399);
            this.ListView.TabIndex = 0;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
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
            // usr_name
            // 
            this.usr_name.Text = "User";
            // 
            // usr_role
            // 
            this.usr_role.Text = "Role";
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
            this.btn_remove.Location = new System.Drawing.Point(731, 198);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(100, 47);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.ColumnHeader usr_role;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_remove;
    }
}