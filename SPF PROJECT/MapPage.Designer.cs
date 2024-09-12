namespace GMap_Tutorial
{
    partial class MapPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapPage));
            this.panelTop = new System.Windows.Forms.Panel();
            this.locPanel = new System.Windows.Forms.Panel();
            this.splitterMap = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLng = new System.Windows.Forms.TextBox();
            this.btnPointAdd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClearMap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRoute = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalPath = new System.Windows.Forms.Label();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.locLbl = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelInputs.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.panelTop.Controls.Add(this.locPanel);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1556, 12);
            this.panelTop.TabIndex = 0;
            // 
            // locPanel
            // 
            this.locPanel.Location = new System.Drawing.Point(719, 0);
            this.locPanel.Name = "locPanel";
            this.locPanel.Size = new System.Drawing.Size(283, 52);
            this.locPanel.TabIndex = 16;
            // 
            // splitterMap
            // 
            this.splitterMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.splitterMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterMap.Location = new System.Drawing.Point(0, 12);
            this.splitterMap.Margin = new System.Windows.Forms.Padding(4);
            this.splitterMap.Name = "splitterMap";
            this.splitterMap.Size = new System.Drawing.Size(1556, 722);
            this.splitterMap.TabIndex = 2;
            this.splitterMap.TabStop = false;
            // 
            // map
            // 
            this.map.AllowDrop = true;
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.BackColor = System.Drawing.Color.Transparent;
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.Margin = new System.Windows.Forms.Padding(4);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1571, 725);
            this.map.TabIndex = 3;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Latitude";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Longitude";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLat
            // 
            this.txtLat.Font = new System.Drawing.Font("Lucida Fax", 15.75F);
            this.txtLat.Location = new System.Drawing.Point(235, 31);
            this.txtLat.Margin = new System.Windows.Forms.Padding(4);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(544, 38);
            this.txtLat.TabIndex = 6;
            this.txtLat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLat_KeyPress);
            // 
            // txtLng
            // 
            this.txtLng.Font = new System.Drawing.Font("Lucida Fax", 15.75F);
            this.txtLng.Location = new System.Drawing.Point(235, 98);
            this.txtLng.Margin = new System.Windows.Forms.Padding(4);
            this.txtLng.Name = "txtLng";
            this.txtLng.Size = new System.Drawing.Size(544, 38);
            this.txtLng.TabIndex = 7;
            this.txtLng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLng_KeyPress);
            // 
            // btnPointAdd
            // 
            this.btnPointAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPointAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPointAdd.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPointAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPointAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnPointAdd.Image")));
            this.btnPointAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPointAdd.Location = new System.Drawing.Point(145, 166);
            this.btnPointAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnPointAdd.Name = "btnPointAdd";
            this.btnPointAdd.Size = new System.Drawing.Size(296, 59);
            this.btnPointAdd.TabIndex = 8;
            this.btnPointAdd.Text = "Add Location";
            this.btnPointAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPointAdd.UseVisualStyleBackColor = false;
            this.btnPointAdd.Click += new System.EventHandler(this.btnPointAdd_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Gainsboro;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(133, 166);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(402, 59);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Calculate Distance";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClearMap
            // 
            this.btnClearMap.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClearMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearMap.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMap.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnClearMap.Image = ((System.Drawing.Image)(resources.GetObject("btnClearMap.Image")));
            this.btnClearMap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearMap.Location = new System.Drawing.Point(532, 166);
            this.btnClearMap.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearMap.Name = "btnClearMap";
            this.btnClearMap.Size = new System.Drawing.Size(248, 59);
            this.btnClearMap.TabIndex = 10;
            this.btnClearMap.Text = "Clear";
            this.btnClearMap.UseVisualStyleBackColor = false;
            this.btnClearMap.Click += new System.EventHandler(this.btnClearMap_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(32, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Distance => ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelInputs
            // 
            this.panelInputs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(155)))), ((int)(((byte)(141)))));
            this.panelInputs.Controls.Add(this.label1);
            this.panelInputs.Controls.Add(this.txtLat);
            this.panelInputs.Controls.Add(this.label2);
            this.panelInputs.Controls.Add(this.txtLng);
            this.panelInputs.Controls.Add(this.btnPointAdd);
            this.panelInputs.Controls.Add(this.btnClearMap);
            this.panelInputs.Location = new System.Drawing.Point(4, 4);
            this.panelInputs.Margin = new System.Windows.Forms.Padding(4);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(824, 252);
            this.panelInputs.TabIndex = 13;
            this.panelInputs.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInputs_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.49717F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.50283F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelInputs, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 624);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1556, 260);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(155)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.lblRoute);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblTotalPath);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(836, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 252);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.BackColor = System.Drawing.Color.Transparent;
            this.lblRoute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRoute.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoute.Location = new System.Drawing.Point(227, 38);
            this.lblRoute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(25, 34);
            this.lblRoute.TabIndex = 15;
            this.lblRoute.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "Route =>";
            // 
            // lblTotalPath
            // 
            this.lblTotalPath.AutoSize = true;
            this.lblTotalPath.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPath.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPath.Location = new System.Drawing.Point(383, 105);
            this.lblTotalPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPath.Name = "lblTotalPath";
            this.lblTotalPath.Size = new System.Drawing.Size(25, 34);
            this.lblTotalPath.TabIndex = 13;
            this.lblTotalPath.Text = "-";
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 52);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // locLbl
            // 
            this.locLbl.AutoSize = true;
            this.locLbl.BackColor = System.Drawing.Color.Transparent;
            this.locLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locLbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.locLbl.Location = new System.Drawing.Point(668, 12);
            this.locLbl.Name = "locLbl";
            this.locLbl.Size = new System.Drawing.Size(203, 23);
            this.locLbl.TabIndex = 16;
            this.locLbl.Text = "Add location below";
            this.locLbl.Click += new System.EventHandler(this.locLbl_Click);
            // 
            // MapPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.locLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitterMap);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelTop.ResumeLayout(false);
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Splitter splitterMap;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLng;
        private System.Windows.Forms.Button btnPointAdd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClearMap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPath;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel locPanel;
        private System.Windows.Forms.Label locLbl;
    }
}