﻿//-----------------------------------------------------------------------
// <copyright file="Form1.Designer.cs" company="Thorlabs GmbH">
//     Copyright (c) Thorlabs GmbH. All rights reserved.
// </copyright>
// <auto-generated />
//-----------------------------------------------------------------------
namespace Thorlabs.BP2_CSharpDemo
{
   /// <summary>
   /// Code generated from the Windows Form Designer
   /// </summary>
   public partial class Form1
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
         if (disposing && (this.components != null))
         {
            this.components.Dispose();
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_driverVersion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_serialNumber = new System.Windows.Forms.TextBox();
            this.label_serialNumber = new System.Windows.Forms.Label();
            this.textBox_instrumentName = new System.Windows.Forms.TextBox();
            this.label_instrumentName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_centroidPositionSlit1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_peakIntensitySlit1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_peakPositionSlit1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chart25um = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart5um = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reconstructionPicture = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_powerSaturation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_drumSpeed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_centroidPositionSlit2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_peakIntensitySlit2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_peakPositionSlit2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart25um)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5um)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reconstructionPicture)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_driverVersion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_serialNumber);
            this.groupBox1.Controls.Add(this.label_serialNumber);
            this.groupBox1.Controls.Add(this.textBox_instrumentName);
            this.groupBox1.Controls.Add(this.label_instrumentName);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(282, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BP2 Information";
            // 
            // textBox_driverVersion
            // 
            this.textBox_driverVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_driverVersion.Location = new System.Drawing.Point(148, 109);
            this.textBox_driverVersion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_driverVersion.Name = "textBox_driverVersion";
            this.textBox_driverVersion.ReadOnly = true;
            this.textBox_driverVersion.Size = new System.Drawing.Size(122, 26);
            this.textBox_driverVersion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Driver Version";
            // 
            // textBox_serialNumber
            // 
            this.textBox_serialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_serialNumber.Location = new System.Drawing.Point(148, 69);
            this.textBox_serialNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_serialNumber.Name = "textBox_serialNumber";
            this.textBox_serialNumber.ReadOnly = true;
            this.textBox_serialNumber.Size = new System.Drawing.Size(122, 26);
            this.textBox_serialNumber.TabIndex = 3;
            // 
            // label_serialNumber
            // 
            this.label_serialNumber.AutoSize = true;
            this.label_serialNumber.Location = new System.Drawing.Point(9, 74);
            this.label_serialNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_serialNumber.Name = "label_serialNumber";
            this.label_serialNumber.Size = new System.Drawing.Size(109, 20);
            this.label_serialNumber.TabIndex = 2;
            this.label_serialNumber.Text = "Serial Number";
            // 
            // textBox_instrumentName
            // 
            this.textBox_instrumentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_instrumentName.Location = new System.Drawing.Point(148, 29);
            this.textBox_instrumentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_instrumentName.Name = "textBox_instrumentName";
            this.textBox_instrumentName.ReadOnly = true;
            this.textBox_instrumentName.Size = new System.Drawing.Size(122, 26);
            this.textBox_instrumentName.TabIndex = 1;
            // 
            // label_instrumentName
            // 
            this.label_instrumentName.AutoSize = true;
            this.label_instrumentName.Location = new System.Drawing.Point(9, 34);
            this.label_instrumentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_instrumentName.Name = "label_instrumentName";
            this.label_instrumentName.Size = new System.Drawing.Size(132, 20);
            this.label_instrumentName.TabIndex = 0;
            this.label_instrumentName.Text = "Instrument Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_centroidPositionSlit1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_peakIntensitySlit1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_peakPositionSlit1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(598, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(297, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculation Result for Slit 1 (25 µm X)";
            // 
            // textBox_centroidPositionSlit1
            // 
            this.textBox_centroidPositionSlit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_centroidPositionSlit1.Location = new System.Drawing.Point(177, 109);
            this.textBox_centroidPositionSlit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_centroidPositionSlit1.Name = "textBox_centroidPositionSlit1";
            this.textBox_centroidPositionSlit1.ReadOnly = true;
            this.textBox_centroidPositionSlit1.Size = new System.Drawing.Size(109, 26);
            this.textBox_centroidPositionSlit1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Centoid Position [µm]";
            // 
            // textBox_peakIntensitySlit1
            // 
            this.textBox_peakIntensitySlit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_peakIntensitySlit1.Location = new System.Drawing.Point(177, 29);
            this.textBox_peakIntensitySlit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_peakIntensitySlit1.Name = "textBox_peakIntensitySlit1";
            this.textBox_peakIntensitySlit1.ReadOnly = true;
            this.textBox_peakIntensitySlit1.Size = new System.Drawing.Size(109, 26);
            this.textBox_peakIntensitySlit1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Peak Intensity [%]";
            // 
            // textBox_peakPositionSlit1
            // 
            this.textBox_peakPositionSlit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_peakPositionSlit1.Location = new System.Drawing.Point(177, 69);
            this.textBox_peakPositionSlit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_peakPositionSlit1.Name = "textBox_peakPositionSlit1";
            this.textBox_peakPositionSlit1.ReadOnly = true;
            this.textBox_peakPositionSlit1.Size = new System.Drawing.Size(109, 26);
            this.textBox_peakPositionSlit1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peak Position [µm]";
            // 
            // chart25um
            // 
            this.chart25um.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.LabelStyle.Format = "F0";
            chartArea1.AxisX.Maximum = 4500D;
            chartArea1.AxisX.Minimum = -4500D;
            chartArea1.AxisX.Title = "Position [µm]";
            chartArea1.AxisX2.LabelStyle.Format = "F0";
            chartArea1.AxisY.Title = "Intensity [digits]";
            chartArea1.Name = "ChartArea1";
            this.chart25um.ChartAreas.Add(chartArea1);
            this.chart25um.Location = new System.Drawing.Point(18, 178);
            this.chart25um.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart25um.Name = "chart25um";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.LegendText = "X";
            series1.LegendToolTip = "Samples of the 25µm slit in x direction";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Name = "Series2";
            this.chart25um.Series.Add(series1);
            this.chart25um.Series.Add(series2);
            this.chart25um.Size = new System.Drawing.Size(400, 357);
            this.chart25um.TabIndex = 2;
            this.chart25um.Text = "chart1";
            // 
            // chart5um
            // 
            this.chart5um.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.LabelStyle.Format = "F0";
            chartArea2.AxisX.Maximum = 4500D;
            chartArea2.AxisX.Minimum = -4500D;
            chartArea2.AxisX.Title = "Position [µm]";
            chartArea2.AxisY.LabelStyle.Format = "F0";
            chartArea2.AxisY.Title = "Intensity [digits]";
            chartArea2.Name = "ChartArea1";
            this.chart5um.ChartAreas.Add(chartArea2);
            this.chart5um.Location = new System.Drawing.Point(426, 178);
            this.chart5um.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart5um.Name = "chart5um";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Name = "Series2";
            this.chart5um.Series.Add(series3);
            this.chart5um.Series.Add(series4);
            this.chart5um.Size = new System.Drawing.Size(400, 357);
            this.chart5um.TabIndex = 5;
            this.chart5um.Text = "chart2";
            // 
            // reconstructionPicture
            // 
            this.reconstructionPicture.Location = new System.Drawing.Point(844, 178);
            this.reconstructionPicture.Name = "reconstructionPicture";
            this.reconstructionPicture.Size = new System.Drawing.Size(357, 357);
            this.reconstructionPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reconstructionPicture.TabIndex = 0;
            this.reconstructionPicture.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_powerSaturation);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_drumSpeed);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(310, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(279, 152);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Measurements";
            // 
            // textBox_powerSaturation
            // 
            this.textBox_powerSaturation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_powerSaturation.Location = new System.Drawing.Point(177, 69);
            this.textBox_powerSaturation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_powerSaturation.Name = "textBox_powerSaturation";
            this.textBox_powerSaturation.ReadOnly = true;
            this.textBox_powerSaturation.Size = new System.Drawing.Size(91, 26);
            this.textBox_powerSaturation.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Power Saturation [%]";
            // 
            // textBox_drumSpeed
            // 
            this.textBox_drumSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_drumSpeed.Location = new System.Drawing.Point(177, 29);
            this.textBox_drumSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_drumSpeed.Name = "textBox_drumSpeed";
            this.textBox_drumSpeed.ReadOnly = true;
            this.textBox_drumSpeed.Size = new System.Drawing.Size(91, 26);
            this.textBox_drumSpeed.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Drum Speed [Hz]";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_centroidPositionSlit2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBox_peakIntensitySlit2);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.textBox_peakPositionSlit2);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(904, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(297, 152);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calculation Result for Slit 2 (25µm Y)";
            // 
            // textBox_centroidPositionSlit2
            // 
            this.textBox_centroidPositionSlit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_centroidPositionSlit2.Location = new System.Drawing.Point(177, 109);
            this.textBox_centroidPositionSlit2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_centroidPositionSlit2.Name = "textBox_centroidPositionSlit2";
            this.textBox_centroidPositionSlit2.ReadOnly = true;
            this.textBox_centroidPositionSlit2.Size = new System.Drawing.Size(109, 26);
            this.textBox_centroidPositionSlit2.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 114);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Centoid Position [µm]";
            // 
            // textBox_peakIntensitySlit2
            // 
            this.textBox_peakIntensitySlit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_peakIntensitySlit2.Location = new System.Drawing.Point(177, 29);
            this.textBox_peakIntensitySlit2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_peakIntensitySlit2.Name = "textBox_peakIntensitySlit2";
            this.textBox_peakIntensitySlit2.ReadOnly = true;
            this.textBox_peakIntensitySlit2.Size = new System.Drawing.Size(109, 26);
            this.textBox_peakIntensitySlit2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Peak Intensity [%]";
            // 
            // textBox_peakPositionSlit2
            // 
            this.textBox_peakPositionSlit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_peakPositionSlit2.Location = new System.Drawing.Point(177, 69);
            this.textBox_peakPositionSlit2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_peakPositionSlit2.Name = "textBox_peakPositionSlit2";
            this.textBox_peakPositionSlit2.ReadOnly = true;
            this.textBox_peakPositionSlit2.Size = new System.Drawing.Size(109, 26);
            this.textBox_peakPositionSlit2.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 74);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Peak Position [µm]";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1361, 32);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 572);
            this.Controls.Add(this.reconstructionPicture);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chart5um);
            this.Controls.Add(this.chart25um);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart25um)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5um)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reconstructionPicture)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox textBox_instrumentName;
      private System.Windows.Forms.Label label_instrumentName;
      private System.Windows.Forms.TextBox textBox_serialNumber;
      private System.Windows.Forms.Label label_serialNumber;
      private System.Windows.Forms.TextBox textBox_driverVersion;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.TextBox textBox_peakIntensitySlit1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox textBox_peakPositionSlit1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox textBox_centroidPositionSlit1;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.DataVisualization.Charting.Chart chart25um;
      private System.Windows.Forms.DataVisualization.Charting.Chart chart5um;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.TextBox textBox_powerSaturation;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.TextBox textBox_drumSpeed;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.GroupBox groupBox4;
      private System.Windows.Forms.TextBox textBox_centroidPositionSlit2;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.TextBox textBox_peakIntensitySlit2;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.TextBox textBox_peakPositionSlit2;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.PictureBox reconstructionPicture;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
