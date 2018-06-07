﻿namespace WorkshopManager
{
    partial class MainView
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
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem(new string[] {
            "Naciągnąc linkę ręcznego"}, -1, System.Drawing.SystemColors.ControlDarkDark, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("Nie działa wycieraczka");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("Piszczenie paska w silniku");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem(new string[] {
            "Spore wgniecenia na drzwiach LP"}, -1, System.Drawing.SystemColors.ControlDarkDark, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("Ściąganie kierownicy podczas jazdy");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Olej 5W40 ELF"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Olej 5W40 LIQUI MOLY"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "Pasek pompy wody FEBI"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "Pasek pompy wody MAXGEAR"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "Pompa wody DELPHI"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "Pompa wody FEBI"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem(new string[] {
            "Uszczelka pokrywy zaworów RINZ"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, null);
            this.listViewCars = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPartsTypeEngine = new System.Windows.Forms.Button();
            this.btnPartsTypeSuspension = new System.Windows.Forms.Button();
            this.btnPartsTypeBrakes = new System.Windows.Forms.Button();
            this.btnPartsTypeChassis = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAddNewCar = new System.Windows.Forms.Button();
            this.groupBoxCarProperties = new System.Windows.Forms.GroupBox();
            this.comboBoxCarBrand = new System.Windows.Forms.ComboBox();
            this.tbCarModel = new System.Windows.Forms.TextBox();
            this.numericUpDownCarYear = new System.Windows.Forms.NumericUpDown();
            this.tbCarEngine = new System.Windows.Forms.TextBox();
            this.btnCarRemoveProblem = new System.Windows.Forms.Button();
            this.btnCarAddNewProblem = new System.Windows.Forms.Button();
            this.lCarProblemsHeader = new System.Windows.Forms.Label();
            this.listViewCarProblems = new System.Windows.Forms.ListView();
            this.lcarYearDesc = new System.Windows.Forms.Label();
            this.lcarEngineDesc = new System.Windows.Forms.Label();
            this.lcarModelDesc = new System.Windows.Forms.Label();
            this.lcarBrandDesc = new System.Windows.Forms.Label();
            this.btnSwitchCarListMode = new System.Windows.Forms.Button();
            this.btnCarApplyChanges = new System.Windows.Forms.Button();
            this.groupBoxPartProperties = new System.Windows.Forms.GroupBox();
            this.lPartCarEngine = new System.Windows.Forms.Label();
            this.lPartCarModel = new System.Windows.Forms.Label();
            this.lPartCarBrand = new System.Windows.Forms.Label();
            this.lPartArea = new System.Windows.Forms.Label();
            this.lPartCarEngineDesc = new System.Windows.Forms.Label();
            this.lPartCarModelDesc = new System.Windows.Forms.Label();
            this.lPartCarBrandDesc = new System.Windows.Forms.Label();
            this.lPartAreaDesc = new System.Windows.Forms.Label();
            this.lPartBrandDesc = new System.Windows.Forms.Label();
            this.btnPartOrder = new System.Windows.Forms.Button();
            this.lPartsDesc = new System.Windows.Forms.Label();
            this.listViewParts = new System.Windows.Forms.ListView();
            this.lPartBrand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxCarProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarYear)).BeginInit();
            this.groupBoxPartProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewCars
            // 
            this.listViewCars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCars.Location = new System.Drawing.Point(3, 32);
            this.listViewCars.Name = "listViewCars";
            this.listViewCars.Size = new System.Drawing.Size(500, 250);
            this.listViewCars.TabIndex = 0;
            this.listViewCars.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "lCarListHeader";
            // 
            // btnPartsTypeEngine
            // 
            this.btnPartsTypeEngine.Location = new System.Drawing.Point(3, 23);
            this.btnPartsTypeEngine.Name = "btnPartsTypeEngine";
            this.btnPartsTypeEngine.Size = new System.Drawing.Size(80, 80);
            this.btnPartsTypeEngine.TabIndex = 2;
            this.btnPartsTypeEngine.Text = "Silnik";
            this.btnPartsTypeEngine.UseVisualStyleBackColor = true;
            // 
            // btnPartsTypeSuspension
            // 
            this.btnPartsTypeSuspension.Location = new System.Drawing.Point(89, 23);
            this.btnPartsTypeSuspension.Name = "btnPartsTypeSuspension";
            this.btnPartsTypeSuspension.Size = new System.Drawing.Size(80, 80);
            this.btnPartsTypeSuspension.TabIndex = 3;
            this.btnPartsTypeSuspension.Text = "Zawieszenie";
            this.btnPartsTypeSuspension.UseVisualStyleBackColor = true;
            // 
            // btnPartsTypeBrakes
            // 
            this.btnPartsTypeBrakes.Location = new System.Drawing.Point(175, 23);
            this.btnPartsTypeBrakes.Name = "btnPartsTypeBrakes";
            this.btnPartsTypeBrakes.Size = new System.Drawing.Size(80, 80);
            this.btnPartsTypeBrakes.TabIndex = 4;
            this.btnPartsTypeBrakes.Text = "Hamulce";
            this.btnPartsTypeBrakes.UseVisualStyleBackColor = true;
            // 
            // btnPartsTypeChassis
            // 
            this.btnPartsTypeChassis.Location = new System.Drawing.Point(261, 23);
            this.btnPartsTypeChassis.Name = "btnPartsTypeChassis";
            this.btnPartsTypeChassis.Size = new System.Drawing.Size(80, 80);
            this.btnPartsTypeChassis.TabIndex = 5;
            this.btnPartsTypeChassis.Text = "Karoseria";
            this.btnPartsTypeChassis.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAddNewCar);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxCarProperties);
            this.splitContainer1.Panel1.Controls.Add(this.btnSwitchCarListMode);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnCarApplyChanges);
            this.splitContainer1.Panel1.Controls.Add(this.listViewCars);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxPartProperties);
            this.splitContainer1.Panel2.Controls.Add(this.btnPartOrder);
            this.splitContainer1.Panel2.Controls.Add(this.lPartsDesc);
            this.splitContainer1.Panel2.Controls.Add(this.listViewParts);
            this.splitContainer1.Panel2.Controls.Add(this.btnPartsTypeEngine);
            this.splitContainer1.Panel2.Controls.Add(this.btnPartsTypeChassis);
            this.splitContainer1.Panel2.Controls.Add(this.btnPartsTypeSuspension);
            this.splitContainer1.Panel2.Controls.Add(this.btnPartsTypeBrakes);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 658);
            this.splitContainer1.SplitterDistance = 508;
            this.splitContainer1.TabIndex = 6;
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.Location = new System.Drawing.Point(223, 3);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(137, 23);
            this.btnAddNewCar.TabIndex = 4;
            this.btnAddNewCar.Text = "Dodaj nowy";
            this.btnAddNewCar.UseVisualStyleBackColor = true;
            // 
            // groupBoxCarProperties
            // 
            this.groupBoxCarProperties.Controls.Add(this.comboBoxCarBrand);
            this.groupBoxCarProperties.Controls.Add(this.tbCarModel);
            this.groupBoxCarProperties.Controls.Add(this.numericUpDownCarYear);
            this.groupBoxCarProperties.Controls.Add(this.tbCarEngine);
            this.groupBoxCarProperties.Controls.Add(this.btnCarRemoveProblem);
            this.groupBoxCarProperties.Controls.Add(this.btnCarAddNewProblem);
            this.groupBoxCarProperties.Controls.Add(this.lCarProblemsHeader);
            this.groupBoxCarProperties.Controls.Add(this.listViewCarProblems);
            this.groupBoxCarProperties.Controls.Add(this.lcarYearDesc);
            this.groupBoxCarProperties.Controls.Add(this.lcarEngineDesc);
            this.groupBoxCarProperties.Controls.Add(this.lcarModelDesc);
            this.groupBoxCarProperties.Controls.Add(this.lcarBrandDesc);
            this.groupBoxCarProperties.Location = new System.Drawing.Point(3, 288);
            this.groupBoxCarProperties.Name = "groupBoxCarProperties";
            this.groupBoxCarProperties.Size = new System.Drawing.Size(500, 336);
            this.groupBoxCarProperties.TabIndex = 3;
            this.groupBoxCarProperties.TabStop = false;
            this.groupBoxCarProperties.Text = "Właścidowści samochodu";
            // 
            // comboBoxCarBrand
            // 
            this.comboBoxCarBrand.FormattingEnabled = true;
            this.comboBoxCarBrand.Location = new System.Drawing.Point(107, 19);
            this.comboBoxCarBrand.Name = "comboBoxCarBrand";
            this.comboBoxCarBrand.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCarBrand.TabIndex = 12;
            // 
            // tbCarModel
            // 
            this.tbCarModel.Location = new System.Drawing.Point(107, 46);
            this.tbCarModel.Name = "tbCarModel";
            this.tbCarModel.Size = new System.Drawing.Size(100, 20);
            this.tbCarModel.TabIndex = 11;
            // 
            // numericUpDownCarYear
            // 
            this.numericUpDownCarYear.Location = new System.Drawing.Point(107, 95);
            this.numericUpDownCarYear.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.numericUpDownCarYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownCarYear.Name = "numericUpDownCarYear";
            this.numericUpDownCarYear.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownCarYear.TabIndex = 10;
            this.numericUpDownCarYear.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // tbCarEngine
            // 
            this.tbCarEngine.Location = new System.Drawing.Point(107, 70);
            this.tbCarEngine.Name = "tbCarEngine";
            this.tbCarEngine.Size = new System.Drawing.Size(100, 20);
            this.tbCarEngine.TabIndex = 9;
            // 
            // btnCarRemoveProblem
            // 
            this.btnCarRemoveProblem.Location = new System.Drawing.Point(198, 121);
            this.btnCarRemoveProblem.Name = "btnCarRemoveProblem";
            this.btnCarRemoveProblem.Size = new System.Drawing.Size(114, 23);
            this.btnCarRemoveProblem.TabIndex = 7;
            this.btnCarRemoveProblem.Text = "Usuń zaznaczony";
            this.btnCarRemoveProblem.UseVisualStyleBackColor = true;
            // 
            // btnCarAddNewProblem
            // 
            this.btnCarAddNewProblem.Location = new System.Drawing.Point(91, 121);
            this.btnCarAddNewProblem.Name = "btnCarAddNewProblem";
            this.btnCarAddNewProblem.Size = new System.Drawing.Size(75, 23);
            this.btnCarAddNewProblem.TabIndex = 6;
            this.btnCarAddNewProblem.Text = "Dodaj nowy";
            this.btnCarAddNewProblem.UseVisualStyleBackColor = true;
            // 
            // lCarProblemsHeader
            // 
            this.lCarProblemsHeader.AutoSize = true;
            this.lCarProblemsHeader.Location = new System.Drawing.Point(9, 126);
            this.lCarProblemsHeader.Name = "lCarProblemsHeader";
            this.lCarProblemsHeader.Size = new System.Drawing.Size(50, 13);
            this.lCarProblemsHeader.TabIndex = 5;
            this.lCarProblemsHeader.Text = "Problemy";
            // 
            // listViewCarProblems
            // 
            this.listViewCarProblems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCarProblems.CheckBoxes = true;
            this.listViewCarProblems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem20.Checked = true;
            listViewItem20.StateImageIndex = 1;
            listViewItem21.StateImageIndex = 0;
            listViewItem22.StateImageIndex = 0;
            listViewItem23.Checked = true;
            listViewItem23.StateImageIndex = 1;
            listViewItem24.StateImageIndex = 0;
            this.listViewCarProblems.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24});
            this.listViewCarProblems.Location = new System.Drawing.Point(9, 145);
            this.listViewCarProblems.MultiSelect = false;
            this.listViewCarProblems.Name = "listViewCarProblems";
            this.listViewCarProblems.ShowGroups = false;
            this.listViewCarProblems.Size = new System.Drawing.Size(491, 186);
            this.listViewCarProblems.TabIndex = 4;
            this.listViewCarProblems.UseCompatibleStateImageBehavior = false;
            this.listViewCarProblems.View = System.Windows.Forms.View.List;
            // 
            // lcarYearDesc
            // 
            this.lcarYearDesc.AutoSize = true;
            this.lcarYearDesc.Location = new System.Drawing.Point(6, 98);
            this.lcarYearDesc.Name = "lcarYearDesc";
            this.lcarYearDesc.Size = new System.Drawing.Size(46, 13);
            this.lcarYearDesc.TabIndex = 3;
            this.lcarYearDesc.Text = "Rocznik";
            // 
            // lcarEngineDesc
            // 
            this.lcarEngineDesc.AutoSize = true;
            this.lcarEngineDesc.Location = new System.Drawing.Point(6, 73);
            this.lcarEngineDesc.Name = "lcarEngineDesc";
            this.lcarEngineDesc.Size = new System.Drawing.Size(95, 13);
            this.lcarEngineDesc.TabIndex = 2;
            this.lcarEngineDesc.Text = "Oznaczenie silnika";
            // 
            // lcarModelDesc
            // 
            this.lcarModelDesc.AutoSize = true;
            this.lcarModelDesc.Location = new System.Drawing.Point(6, 49);
            this.lcarModelDesc.Name = "lcarModelDesc";
            this.lcarModelDesc.Size = new System.Drawing.Size(36, 13);
            this.lcarModelDesc.TabIndex = 1;
            this.lcarModelDesc.Text = "Model";
            // 
            // lcarBrandDesc
            // 
            this.lcarBrandDesc.AutoSize = true;
            this.lcarBrandDesc.Location = new System.Drawing.Point(6, 26);
            this.lcarBrandDesc.Name = "lcarBrandDesc";
            this.lcarBrandDesc.Size = new System.Drawing.Size(37, 13);
            this.lcarBrandDesc.TabIndex = 0;
            this.lcarBrandDesc.Text = "Marka";
            // 
            // btnSwitchCarListMode
            // 
            this.btnSwitchCarListMode.Location = new System.Drawing.Point(366, 3);
            this.btnSwitchCarListMode.Name = "btnSwitchCarListMode";
            this.btnSwitchCarListMode.Size = new System.Drawing.Size(137, 23);
            this.btnSwitchCarListMode.TabIndex = 2;
            this.btnSwitchCarListMode.Text = "Przełącz na archiwum";
            this.btnSwitchCarListMode.UseVisualStyleBackColor = true;
            // 
            // btnCarApplyChanges
            // 
            this.btnCarApplyChanges.Location = new System.Drawing.Point(418, 625);
            this.btnCarApplyChanges.Name = "btnCarApplyChanges";
            this.btnCarApplyChanges.Size = new System.Drawing.Size(75, 23);
            this.btnCarApplyChanges.TabIndex = 8;
            this.btnCarApplyChanges.Text = "Zapisz";
            this.btnCarApplyChanges.UseVisualStyleBackColor = true;
            // 
            // groupBoxPartProperties
            // 
            this.groupBoxPartProperties.Controls.Add(this.lPartBrand);
            this.groupBoxPartProperties.Controls.Add(this.lPartCarEngine);
            this.groupBoxPartProperties.Controls.Add(this.lPartCarModel);
            this.groupBoxPartProperties.Controls.Add(this.lPartCarBrand);
            this.groupBoxPartProperties.Controls.Add(this.lPartArea);
            this.groupBoxPartProperties.Controls.Add(this.lPartCarEngineDesc);
            this.groupBoxPartProperties.Controls.Add(this.lPartCarModelDesc);
            this.groupBoxPartProperties.Controls.Add(this.lPartCarBrandDesc);
            this.groupBoxPartProperties.Controls.Add(this.lPartAreaDesc);
            this.groupBoxPartProperties.Controls.Add(this.lPartBrandDesc);
            this.groupBoxPartProperties.Location = new System.Drawing.Point(6, 467);
            this.groupBoxPartProperties.Name = "groupBoxPartProperties";
            this.groupBoxPartProperties.Size = new System.Drawing.Size(544, 152);
            this.groupBoxPartProperties.TabIndex = 11;
            this.groupBoxPartProperties.TabStop = false;
            this.groupBoxPartProperties.Text = "Właściwości części";
            // 
            // lPartCarEngine
            // 
            this.lPartCarEngine.AutoSize = true;
            this.lPartCarEngine.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lPartCarEngine.Location = new System.Drawing.Point(138, 127);
            this.lPartCarEngine.Name = "lPartCarEngine";
            this.lPartCarEngine.Size = new System.Drawing.Size(82, 13);
            this.lPartCarEngine.TabIndex = 17;
            this.lPartCarEngine.Text = "Pasuje do marki";
            // 
            // lPartCarModel
            // 
            this.lPartCarModel.AutoSize = true;
            this.lPartCarModel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lPartCarModel.Location = new System.Drawing.Point(138, 99);
            this.lPartCarModel.Name = "lPartCarModel";
            this.lPartCarModel.Size = new System.Drawing.Size(82, 13);
            this.lPartCarModel.TabIndex = 16;
            this.lPartCarModel.Text = "Pasuje do marki";
            // 
            // lPartCarBrand
            // 
            this.lPartCarBrand.AutoSize = true;
            this.lPartCarBrand.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lPartCarBrand.Location = new System.Drawing.Point(138, 72);
            this.lPartCarBrand.Name = "lPartCarBrand";
            this.lPartCarBrand.Size = new System.Drawing.Size(82, 13);
            this.lPartCarBrand.TabIndex = 15;
            this.lPartCarBrand.Text = "Pasuje do marki";
            // 
            // lPartArea
            // 
            this.lPartArea.AutoSize = true;
            this.lPartArea.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lPartArea.Location = new System.Drawing.Point(137, 47);
            this.lPartArea.Name = "lPartArea";
            this.lPartArea.Size = new System.Drawing.Size(82, 13);
            this.lPartArea.TabIndex = 14;
            this.lPartArea.Text = "Pasuje do marki";
            // 
            // lPartCarEngineDesc
            // 
            this.lPartCarEngineDesc.AutoSize = true;
            this.lPartCarEngineDesc.Location = new System.Drawing.Point(6, 127);
            this.lPartCarEngineDesc.Name = "lPartCarEngineDesc";
            this.lPartCarEngineDesc.Size = new System.Drawing.Size(86, 13);
            this.lPartCarEngineDesc.TabIndex = 13;
            this.lPartCarEngineDesc.Text = "Pasuje do silnika";
            // 
            // lPartCarModelDesc
            // 
            this.lPartCarModelDesc.AutoSize = true;
            this.lPartCarModelDesc.Location = new System.Drawing.Point(6, 99);
            this.lPartCarModelDesc.Name = "lPartCarModelDesc";
            this.lPartCarModelDesc.Size = new System.Drawing.Size(91, 13);
            this.lPartCarModelDesc.TabIndex = 12;
            this.lPartCarModelDesc.Text = "Pasuje do modelu";
            // 
            // lPartCarBrandDesc
            // 
            this.lPartCarBrandDesc.AutoSize = true;
            this.lPartCarBrandDesc.Location = new System.Drawing.Point(6, 72);
            this.lPartCarBrandDesc.Name = "lPartCarBrandDesc";
            this.lPartCarBrandDesc.Size = new System.Drawing.Size(82, 13);
            this.lPartCarBrandDesc.TabIndex = 11;
            this.lPartCarBrandDesc.Text = "Pasuje do marki";
            // 
            // lPartAreaDesc
            // 
            this.lPartAreaDesc.AutoSize = true;
            this.lPartAreaDesc.Location = new System.Drawing.Point(6, 45);
            this.lPartAreaDesc.Name = "lPartAreaDesc";
            this.lPartAreaDesc.Size = new System.Drawing.Size(107, 13);
            this.lPartAreaDesc.TabIndex = 10;
            this.lPartAreaDesc.Text = "Segment samochodu";
            // 
            // lPartBrandDesc
            // 
            this.lPartBrandDesc.AutoSize = true;
            this.lPartBrandDesc.Location = new System.Drawing.Point(6, 19);
            this.lPartBrandDesc.Name = "lPartBrandDesc";
            this.lPartBrandDesc.Size = new System.Drawing.Size(37, 13);
            this.lPartBrandDesc.TabIndex = 9;
            this.lPartBrandDesc.Text = "Marka";
            // 
            // btnPartOrder
            // 
            this.btnPartOrder.Location = new System.Drawing.Point(405, 625);
            this.btnPartOrder.Name = "btnPartOrder";
            this.btnPartOrder.Size = new System.Drawing.Size(137, 23);
            this.btnPartOrder.TabIndex = 5;
            this.btnPartOrder.Text = "Zamów część";
            this.btnPartOrder.UseVisualStyleBackColor = true;
            // 
            // lPartsDesc
            // 
            this.lPartsDesc.AutoSize = true;
            this.lPartsDesc.Location = new System.Drawing.Point(3, 7);
            this.lPartsDesc.Name = "lPartsDesc";
            this.lPartsDesc.Size = new System.Drawing.Size(212, 13);
            this.lPartsDesc.TabIndex = 10;
            this.lPartsDesc.Text = "Części pasujące do wybranego samochodu";
            // 
            // listViewParts
            // 
            this.listViewParts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewParts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem13.StateImageIndex = 0;
            listViewItem14.Checked = true;
            listViewItem14.StateImageIndex = 1;
            listViewItem15.StateImageIndex = 0;
            listViewItem16.Checked = true;
            listViewItem16.StateImageIndex = 1;
            listViewItem19.StateImageIndex = 0;
            this.listViewParts.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19});
            this.listViewParts.Location = new System.Drawing.Point(3, 111);
            this.listViewParts.MultiSelect = false;
            this.listViewParts.Name = "listViewParts";
            this.listViewParts.ShowGroups = false;
            this.listViewParts.Size = new System.Drawing.Size(547, 350);
            this.listViewParts.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewParts.TabIndex = 9;
            this.listViewParts.UseCompatibleStateImageBehavior = false;
            this.listViewParts.View = System.Windows.Forms.View.List;
            // 
            // lPartBrand
            // 
            this.lPartBrand.AutoSize = true;
            this.lPartBrand.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lPartBrand.Location = new System.Drawing.Point(138, 24);
            this.lPartBrand.Name = "lPartBrand";
            this.lPartBrand.Size = new System.Drawing.Size(82, 13);
            this.lPartBrand.TabIndex = 18;
            this.lPartBrand.Text = "Pasuje do marki";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainView";
            this.Text = "WorkshopManager";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxCarProperties.ResumeLayout(false);
            this.groupBoxCarProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarYear)).EndInit();
            this.groupBoxPartProperties.ResumeLayout(false);
            this.groupBoxPartProperties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPartsTypeEngine;
        private System.Windows.Forms.Button btnPartsTypeSuspension;
        private System.Windows.Forms.Button btnPartsTypeBrakes;
        private System.Windows.Forms.Button btnPartsTypeChassis;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxCarProperties;
        private System.Windows.Forms.Label lCarProblemsHeader;
        private System.Windows.Forms.ListView listViewCarProblems;
        private System.Windows.Forms.Label lcarYearDesc;
        private System.Windows.Forms.Label lcarEngineDesc;
        private System.Windows.Forms.Label lcarModelDesc;
        private System.Windows.Forms.Label lcarBrandDesc;
        private System.Windows.Forms.Button btnSwitchCarListMode;
        private System.Windows.Forms.Button btnAddNewCar;
        private System.Windows.Forms.Button btnCarApplyChanges;
        private System.Windows.Forms.Button btnCarRemoveProblem;
        private System.Windows.Forms.Button btnCarAddNewProblem;
        private System.Windows.Forms.GroupBox groupBoxPartProperties;
        private System.Windows.Forms.Label lPartCarEngineDesc;
        private System.Windows.Forms.Label lPartCarModelDesc;
        private System.Windows.Forms.Label lPartCarBrandDesc;
        private System.Windows.Forms.Label lPartAreaDesc;
        private System.Windows.Forms.Label lPartBrandDesc;
        private System.Windows.Forms.Button btnPartOrder;
        private System.Windows.Forms.Label lPartsDesc;
        private System.Windows.Forms.ListView listViewParts;
        private System.Windows.Forms.ComboBox comboBoxCarBrand;
        private System.Windows.Forms.TextBox tbCarModel;
        private System.Windows.Forms.NumericUpDown numericUpDownCarYear;
        private System.Windows.Forms.TextBox tbCarEngine;
        private System.Windows.Forms.Label lPartCarEngine;
        private System.Windows.Forms.Label lPartCarModel;
        private System.Windows.Forms.Label lPartCarBrand;
        private System.Windows.Forms.Label lPartArea;
        private System.Windows.Forms.Label lPartBrand;
    }
}
