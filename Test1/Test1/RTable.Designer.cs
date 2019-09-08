using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Robinet
{
    partial class RTable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // RTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 387);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RTable";
            this.Text = "Selectie Model";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);


            this.dataGridView1.Columns.Add("KV", "KV");
            this.dataGridView1.Columns.Add("Producator", "Producator");
            this.dataGridView1.Columns.Add("Produs", "Produs");
            this.dataGridView1.Columns.Add("Pret", "Pret");
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Thistle;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            ReadCSV();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;

        private void ReadCSV()
        {
            int count = 0;
            using (var reader = new StreamReader("DataKV.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    string[] values = line.Split(',');

                    if (Int32.Parse(values[0]) >= Form1.kv && count < 5)
                    {
                        dataGridView1.Rows.Add(values);
                        count++;
                    }
                        
                }
            }
        }
    }
}