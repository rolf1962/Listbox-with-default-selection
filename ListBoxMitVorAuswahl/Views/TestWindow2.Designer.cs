
namespace WindowsFormsApp1.Views
{
    partial class TestWindow2
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.beteiligteListBox = new System.Windows.Forms.ListBox();
            this.beteiligteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainWindowViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nurTatVerdaechtigeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.beteiligteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // beteiligteListBox
            // 
            this.beteiligteListBox.DataSource = this.beteiligteBindingSource;
            this.beteiligteListBox.FormattingEnabled = true;
            this.beteiligteListBox.Location = new System.Drawing.Point(12, 40);
            this.beteiligteListBox.Name = "beteiligteListBox";
            this.beteiligteListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.beteiligteListBox.Size = new System.Drawing.Size(320, 95);
            this.beteiligteListBox.TabIndex = 0;
            // 
            // beteiligteBindingSource
            // 
            this.beteiligteBindingSource.DataMember = "Beteiligte";
            this.beteiligteBindingSource.DataSource = this.mainWindowViewModelBindingSource;
            // 
            // mainWindowViewModelBindingSource
            // 
            this.mainWindowViewModelBindingSource.DataSource = typeof(WindowsFormsApp1.ViewModels.TestWindowViewModel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beteiligte";
            // 
            // nurTatVerdaechtigeCheckBox
            // 
            this.nurTatVerdaechtigeCheckBox.AutoSize = true;
            this.nurTatVerdaechtigeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mainWindowViewModelBindingSource, "NurTatVerdaechtige", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nurTatVerdaechtigeCheckBox.Location = new System.Drawing.Point(89, 20);
            this.nurTatVerdaechtigeCheckBox.Name = "nurTatVerdaechtigeCheckBox";
            this.nurTatVerdaechtigeCheckBox.Size = new System.Drawing.Size(116, 17);
            this.nurTatVerdaechtigeCheckBox.TabIndex = 2;
            this.nurTatVerdaechtigeCheckBox.Text = "nur Tatverdächtige";
            this.nurTatVerdaechtigeCheckBox.UseVisualStyleBackColor = true;
            // 
            // TestWindow2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 169);
            this.Controls.Add(this.nurTatVerdaechtigeCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.beteiligteListBox);
            this.Name = "TestWindow2";
            this.Text = "LBmVA - Testfenster 2";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beteiligteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox beteiligteListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox nurTatVerdaechtigeCheckBox;
        private System.Windows.Forms.BindingSource mainWindowViewModelBindingSource;
        private System.Windows.Forms.BindingSource beteiligteBindingSource;
    }
}

