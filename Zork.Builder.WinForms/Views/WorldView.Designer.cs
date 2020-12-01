namespace Zork.Builder.WinForms
{
    partial class WorldView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label startingLocationLabel;
            System.Windows.Forms.Label roomsLabel;
            System.Windows.Forms.Label roomNameLabel;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectedRoomGroupBox = new System.Windows.Forms.GroupBox();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            startingLocationLabel = new System.Windows.Forms.Label();
            roomsLabel = new System.Windows.Forms.Label();
            roomNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.selectedRoomGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startingLocationLabel
            // 
            startingLocationLabel.AutoSize = true;
            startingLocationLabel.Location = new System.Drawing.Point(3, 10);
            startingLocationLabel.Name = "startingLocationLabel";
            startingLocationLabel.Size = new System.Drawing.Size(90, 13);
            startingLocationLabel.TabIndex = 0;
            startingLocationLabel.Text = "&Starting Location:";
            // 
            // roomsLabel
            // 
            roomsLabel.AutoSize = true;
            roomsLabel.Location = new System.Drawing.Point(3, 49);
            roomsLabel.Name = "roomsLabel";
            roomsLabel.Size = new System.Drawing.Size(43, 13);
            roomsLabel.TabIndex = 2;
            roomsLabel.Text = "&Rooms:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "Game.World.StartingLocation", true));
            this.nameTextBox.Location = new System.Drawing.Point(6, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(156, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // roomsListBox
            // 
            this.roomsListBox.DisplayMember = "Name";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(6, 66);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(156, 212);
            this.roomsListBox.TabIndex = 3;
            this.roomsListBox.ValueMember = "Description";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 285);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(87, 285);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.WinForms.GameViewModel);
            // 
            // selectedRoomGroupBox
            // 
            this.selectedRoomGroupBox.Controls.Add(this.roomNameTextBox);
            this.selectedRoomGroupBox.Controls.Add(roomNameLabel);
            this.selectedRoomGroupBox.Location = new System.Drawing.Point(169, 66);
            this.selectedRoomGroupBox.Name = "selectedRoomGroupBox";
            this.selectedRoomGroupBox.Size = new System.Drawing.Size(413, 212);
            this.selectedRoomGroupBox.TabIndex = 6;
            this.selectedRoomGroupBox.TabStop = false;
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.Location = new System.Drawing.Point(6, 16);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new System.Drawing.Size(38, 13);
            roomNameLabel.TabIndex = 3;
            roomNameLabel.Text = "&Name:";
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "Game.World.StartingLocation", true));
            this.roomNameTextBox.Location = new System.Drawing.Point(9, 32);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.roomNameTextBox.TabIndex = 7;
            // 
            // WorldView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectedRoomGroupBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.roomsListBox);
            this.Controls.Add(roomsLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(startingLocationLabel);
            this.Name = "WorldView";
            this.Size = new System.Drawing.Size(617, 336);
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.selectedRoomGroupBox.ResumeLayout(false);
            this.selectedRoomGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox selectedRoomGroupBox;
        private System.Windows.Forms.TextBox roomNameTextBox;
    }
}
