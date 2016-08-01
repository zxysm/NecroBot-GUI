namespace NecroBot_Settings_GUI
{
    partial class LauncherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
            this.l_GpxFile = new System.Windows.Forms.Label();
            this.tb_GpxFile = new System.Windows.Forms.TextBox();
            this.cb_UseGpxPathing = new System.Windows.Forms.CheckBox();
            this.l_MaxTravelDistanceInMeters = new System.Windows.Forms.Label();
            this.l_WalkingSpeedInKilometerPerHour = new System.Windows.Forms.Label();
            this.l_DefaultAltitude = new System.Windows.Forms.Label();
            this.l_DefaultLongitude = new System.Windows.Forms.Label();
            this.l_DefaultLatitude = new System.Windows.Forms.Label();
            this.tb_DefaultLongitude = new System.Windows.Forms.TextBox();
            this.tb_DefaultLatitude = new System.Windows.Forms.TextBox();
            this.SettingsTab = new System.Windows.Forms.TabControl();
            this.tabPage_Loc = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.nUD_MaxTravelDistanceInMeters = new System.Windows.Forms.NumericUpDown();
            this.nUD_DefaultAltitude = new System.Windows.Forms.NumericUpDown();
            this.nUD_WalkingSpeedInKilometerPerHour = new System.Windows.Forms.NumericUpDown();
            this.l_MaxSpawnLocationOffset = new System.Windows.Forms.Label();
            this.nUD_MaxSpawnLocationOffset = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.l_AdressBox = new System.Windows.Forms.TextBox();
            this.b_FindLoc = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.tabPage_Bot = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nUD_DelayBetweenPlayerActions = new System.Windows.Forms.NumericUpDown();
            this.l_DelayBetweenPokemonCatch = new System.Windows.Forms.Label();
            this.nUD_DelayBetweenPokemonCatch = new System.Windows.Forms.NumericUpDown();
            this.l_DelayBetweenPlayerActions = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cb_UseEggIncubators = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cb_UseIncenseConstantly = new System.Windows.Forms.CheckBox();
            this.cb_UseLuckyEggConstantly = new System.Windows.Forms.CheckBox();
            this.nUD_WebSocketPort = new System.Windows.Forms.NumericUpDown();
            this.cb_DisableHumanWalking = new System.Windows.Forms.CheckBox();
            this.cb_StartupWelcomeDelay = new System.Windows.Forms.CheckBox();
            this.nUD_AmountOfPokemonToDisplayOnStart = new System.Windows.Forms.NumericUpDown();
            this.l_WebSocketPort = new System.Windows.Forms.Label();
            this.l_AmountOfPokemonToDisplayOnStart = new System.Windows.Forms.Label();
            this.cb_AutoUpdate = new System.Windows.Forms.CheckBox();
            this.cb_DumpPokemonStats = new System.Windows.Forms.CheckBox();
            this.cb_TransferConfigAndAuthOnUpdate = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.nUD_RecycleInventoryAtUsagePercentag = new System.Windows.Forms.NumericUpDown();
            this.l_RecycleInventoryAtUsagePercentag = new System.Windows.Forms.Label();
            this.cb_VerboseRecycling = new System.Windows.Forms.CheckBox();
            this.cb_ShowPokeballCountsBeforeRecycle = new System.Windows.Forms.CheckBox();
            this.nUD_TotalAmountOfRevivesToKeep = new System.Windows.Forms.NumericUpDown();
            this.nUD_TotalAmountOfPotionsToKeep = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.l_TotalAmountOfRevivesToKeep = new System.Windows.Forms.Label();
            this.nUD_TotalAmountOfPokebalsToKeep = new System.Windows.Forms.NumericUpDown();
            this.l_TotalAmountOfPotionsToKeep = new System.Windows.Forms.Label();
            this.l_TotalAmountOfPokebalsToKeep = new System.Windows.Forms.Label();
            this.tp_Pokemon = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.nUD_FavoriteMinIvPercentage = new System.Windows.Forms.NumericUpDown();
            this.cb_AutoFavoritePokemon = new System.Windows.Forms.CheckBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.l_UpgradePokemonCpMinimum = new System.Windows.Forms.Label();
            this.l_UpgradePokemonIvMinimum = new System.Windows.Forms.Label();
            this.nUD_UpgradePokemonIvMinimum = new System.Windows.Forms.NumericUpDown();
            this.nUD_UpgradePokemonCpMinimum = new System.Windows.Forms.NumericUpDown();
            this.l_AmountOfTimesToUpgradeLoop = new System.Windows.Forms.Label();
            this.l_GetMinStarDustForLevelUp = new System.Windows.Forms.Label();
            this.nUD_GetMinStarDustForLevelUp = new System.Windows.Forms.NumericUpDown();
            this.nUD_AmountOfTimesToUpgradeLoop = new System.Windows.Forms.NumericUpDown();
            this.cb_LevelUpByCPorIv = new System.Windows.Forms.CheckBox();
            this.cb_AutomaticallyLevelUpPokemon = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_RenamePokemon = new System.Windows.Forms.CheckBox();
            this.cb_RenameOnlyAboveIv = new System.Windows.Forms.CheckBox();
            this.l_RenameTemplate = new System.Windows.Forms.Label();
            this.tb_RenameTemplate = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nUD_KeepMinIvPercentage = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.nUD_KeepMinDuplicatePokemon = new System.Windows.Forms.NumericUpDown();
            this.nUD_KeepMinCp = new System.Windows.Forms.NumericUpDown();
            this.cb_PrioritizeIvOverCp = new System.Windows.Forms.CheckBox();
            this.l_KeepMinIvPercentage = new System.Windows.Forms.Label();
            this.cb_KeepPokemonsThatCanEvolve = new System.Windows.Forms.CheckBox();
            this.l_KeepMinDuplicatePokemon = new System.Windows.Forms.Label();
            this.l_KeepMinCp = new System.Windows.Forms.Label();
            this.cb_TransferDuplicatePokemon = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.l_EvolveKeptPokemonsAtStorageUsagePercentage = new System.Windows.Forms.Label();
            this.nUD_EvolveKeptPokemonsAtStorageUsagePercentage = new System.Windows.Forms.NumericUpDown();
            this.nUD_UseLuckyEggsMinPokemonAmount = new System.Windows.Forms.NumericUpDown();
            this.nUD_EvolveAboveIvValue = new System.Windows.Forms.NumericUpDown();
            this.cb_UseLuckyEggsWhileEvolving = new System.Windows.Forms.CheckBox();
            this.cb_EvolveAllPokemonWithEnoughCandy = new System.Windows.Forms.CheckBox();
            this.cb_EvolveAllPokemonAboveIv = new System.Windows.Forms.CheckBox();
            this.tP_CatchSnipe = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.l_SnipingScanOffset = new System.Windows.Forms.Label();
            this.tb_SnipingScanOffset = new System.Windows.Forms.TextBox();
            this.nUD_MinPokeballsWhileSnipe = new System.Windows.Forms.NumericUpDown();
            this.l_MinPokeballsWhileSnipe = new System.Windows.Forms.Label();
            this.cb_UseSnipeOnlineLocationServer = new System.Windows.Forms.CheckBox();
            this.nUD_MinDelayBetweenSnipes = new System.Windows.Forms.NumericUpDown();
            this.nUD_MinPokeballsToSnipe = new System.Windows.Forms.NumericUpDown();
            this.nUD_SnipeLocationServerPort = new System.Windows.Forms.NumericUpDown();
            this.l_SnipeLocationServerPort = new System.Windows.Forms.Label();
            this.l_MinDelayBetweenSnipes = new System.Windows.Forms.Label();
            this.l_SnipeLocationServer = new System.Windows.Forms.Label();
            this.cb_SnipeIgnoreUnknownIv = new System.Windows.Forms.CheckBox();
            this.tb_SnipeLocationServer = new System.Windows.Forms.TextBox();
            this.cb_UseTransferIvForSnipe = new System.Windows.Forms.CheckBox();
            this.cb_UseSnipeLocationServer = new System.Windows.Forms.CheckBox();
            this.cb_SnipeAtPokestops = new System.Windows.Forms.CheckBox();
            this.l_MinPokeballsToSnipe = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.nUD_UseMasterBallBelowCatchProbability = new System.Windows.Forms.NumericUpDown();
            this.l_UseMasterBallBelowCatchProbability = new System.Windows.Forms.Label();
            this.nUD_UseUltraBallBelowCatchProbability = new System.Windows.Forms.NumericUpDown();
            this.l_UseUltraBallBelowCatchProbability = new System.Windows.Forms.Label();
            this.nUD_UseGreatBallBelowCatchProbability = new System.Windows.Forms.NumericUpDown();
            this.l_UseGreatBallBelowCatchProbability = new System.Windows.Forms.Label();
            this.nUD_UseMasterBallAboveCp = new System.Windows.Forms.NumericUpDown();
            this.l_UseMasterBallAboveCp = new System.Windows.Forms.Label();
            this.nUD_UseUltraBallAboveIv = new System.Windows.Forms.NumericUpDown();
            this.l_UseUltraBallAboveIv = new System.Windows.Forms.Label();
            this.nUD_UseUltraBallAboveCp = new System.Windows.Forms.NumericUpDown();
            this.l_UseUltraBallAboveCp = new System.Windows.Forms.Label();
            this.nUD_UseGreatBallAboveIv = new System.Windows.Forms.NumericUpDown();
            this.l_UseGreatBallAboveIv = new System.Windows.Forms.Label();
            this.nUD_UseGreatBallAboveCp = new System.Windows.Forms.NumericUpDown();
            this.l_UseGreatBallAboveCp = new System.Windows.Forms.Label();
            this.nUD_MaxPokeballsPerPokemon = new System.Windows.Forms.NumericUpDown();
            this.l_MaxPokeballsPerPokemon = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cb_UsePokemonToNotCatchFilter = new System.Windows.Forms.CheckBox();
            this.tp_About = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_TranslationLanguageCode = new System.Windows.Forms.ComboBox();
            this.username = new System.Windows.Forms.TextBox();
            this.b_StartNecroBot = new System.Windows.Forms.Button();
            this.l_TranslationLanguageCode = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.radioPTC = new System.Windows.Forms.RadioButton();
            this.password = new System.Windows.Forms.TextBox();
            this.radioGoogle = new System.Windows.Forms.RadioButton();
            this.SettingsTab.SuspendLayout();
            this.tabPage_Loc.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MaxTravelDistanceInMeters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_DefaultAltitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_WalkingSpeedInKilometerPerHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MaxSpawnLocationOffset)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.tabPage_Bot.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_DelayBetweenPlayerActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_DelayBetweenPokemonCatch)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_WebSocketPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_AmountOfPokemonToDisplayOnStart)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_RecycleInventoryAtUsagePercentag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TotalAmountOfRevivesToKeep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TotalAmountOfPotionsToKeep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TotalAmountOfPokebalsToKeep)).BeginInit();
            this.tp_Pokemon.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_FavoriteMinIvPercentage)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UpgradePokemonIvMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UpgradePokemonCpMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_GetMinStarDustForLevelUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_AmountOfTimesToUpgradeLoop)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_KeepMinIvPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_KeepMinDuplicatePokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_KeepMinCp)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_EvolveKeptPokemonsAtStorageUsagePercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseLuckyEggsMinPokemonAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_EvolveAboveIvValue)).BeginInit();
            this.tP_CatchSnipe.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MinPokeballsWhileSnipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MinDelayBetweenSnipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MinPokeballsToSnipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_SnipeLocationServerPort)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseMasterBallBelowCatchProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseUltraBallBelowCatchProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseGreatBallBelowCatchProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseMasterBallAboveCp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseUltraBallAboveIv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseUltraBallAboveCp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseGreatBallAboveIv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseGreatBallAboveCp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MaxPokeballsPerPokemon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_GpxFile
            // 
            this.l_GpxFile.AutoSize = true;
            this.l_GpxFile.BackColor = System.Drawing.Color.Transparent;
            this.l_GpxFile.Location = new System.Drawing.Point(286, 70);
            this.l_GpxFile.Name = "l_GpxFile";
            this.l_GpxFile.Size = new System.Drawing.Size(77, 13);
            this.l_GpxFile.TabIndex = 12;
            this.l_GpxFile.Text = "GPX Filename:";
            // 
            // tb_GpxFile
            // 
            this.tb_GpxFile.Location = new System.Drawing.Point(386, 67);
            this.tb_GpxFile.Name = "tb_GpxFile";
            this.tb_GpxFile.Size = new System.Drawing.Size(100, 20);
            this.tb_GpxFile.TabIndex = 11;
            this.tb_GpxFile.Text = "GPXPath.GPX";
            this.tb_GpxFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_UseGpxPathing
            // 
            this.cb_UseGpxPathing.AutoSize = true;
            this.cb_UseGpxPathing.BackColor = System.Drawing.Color.Transparent;
            this.cb_UseGpxPathing.Location = new System.Drawing.Point(286, 47);
            this.cb_UseGpxPathing.Name = "cb_UseGpxPathing";
            this.cb_UseGpxPathing.Size = new System.Drawing.Size(101, 17);
            this.cb_UseGpxPathing.TabIndex = 10;
            this.cb_UseGpxPathing.Text = "Use GPX-Path?";
            this.cb_UseGpxPathing.UseVisualStyleBackColor = false;
            // 
            // l_MaxTravelDistanceInMeters
            // 
            this.l_MaxTravelDistanceInMeters.AutoSize = true;
            this.l_MaxTravelDistanceInMeters.BackColor = System.Drawing.Color.Transparent;
            this.l_MaxTravelDistanceInMeters.Location = new System.Drawing.Point(283, 23);
            this.l_MaxTravelDistanceInMeters.Name = "l_MaxTravelDistanceInMeters";
            this.l_MaxTravelDistanceInMeters.Size = new System.Drawing.Size(100, 13);
            this.l_MaxTravelDistanceInMeters.TabIndex = 9;
            this.l_MaxTravelDistanceInMeters.Text = "Travel distance (m):";
            // 
            // l_WalkingSpeedInKilometerPerHour
            // 
            this.l_WalkingSpeedInKilometerPerHour.AutoSize = true;
            this.l_WalkingSpeedInKilometerPerHour.BackColor = System.Drawing.Color.Transparent;
            this.l_WalkingSpeedInKilometerPerHour.Location = new System.Drawing.Point(7, 55);
            this.l_WalkingSpeedInKilometerPerHour.Name = "l_WalkingSpeedInKilometerPerHour";
            this.l_WalkingSpeedInKilometerPerHour.Size = new System.Drawing.Size(75, 13);
            this.l_WalkingSpeedInKilometerPerHour.TabIndex = 6;
            this.l_WalkingSpeedInKilometerPerHour.Text = "Speed (km/h):";
            // 
            // l_DefaultAltitude
            // 
            this.l_DefaultAltitude.AutoSize = true;
            this.l_DefaultAltitude.BackColor = System.Drawing.Color.Transparent;
            this.l_DefaultAltitude.Location = new System.Drawing.Point(7, 29);
            this.l_DefaultAltitude.Name = "l_DefaultAltitude";
            this.l_DefaultAltitude.Size = new System.Drawing.Size(62, 13);
            this.l_DefaultAltitude.TabIndex = 1;
            this.l_DefaultAltitude.Text = "Altitude (m):";
            // 
            // l_DefaultLongitude
            // 
            this.l_DefaultLongitude.AutoSize = true;
            this.l_DefaultLongitude.BackColor = System.Drawing.Color.Transparent;
            this.l_DefaultLongitude.Location = new System.Drawing.Point(7, 388);
            this.l_DefaultLongitude.Name = "l_DefaultLongitude";
            this.l_DefaultLongitude.Size = new System.Drawing.Size(57, 13);
            this.l_DefaultLongitude.TabIndex = 4;
            this.l_DefaultLongitude.Text = "Longitude:";
            // 
            // l_DefaultLatitude
            // 
            this.l_DefaultLatitude.AutoSize = true;
            this.l_DefaultLatitude.BackColor = System.Drawing.Color.Transparent;
            this.l_DefaultLatitude.Location = new System.Drawing.Point(283, 388);
            this.l_DefaultLatitude.Name = "l_DefaultLatitude";
            this.l_DefaultLatitude.Size = new System.Drawing.Size(48, 13);
            this.l_DefaultLatitude.TabIndex = 3;
            this.l_DefaultLatitude.Text = "Latitude:";
            // 
            // tb_DefaultLongitude
            // 
            this.tb_DefaultLongitude.Location = new System.Drawing.Point(70, 385);
            this.tb_DefaultLongitude.Name = "tb_DefaultLongitude";
            this.tb_DefaultLongitude.Size = new System.Drawing.Size(161, 20);
            this.tb_DefaultLongitude.TabIndex = 2;
            this.tb_DefaultLongitude.Text = "0";
            this.tb_DefaultLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_DefaultLatitude
            // 
            this.tb_DefaultLatitude.Location = new System.Drawing.Point(347, 385);
            this.tb_DefaultLatitude.Name = "tb_DefaultLatitude";
            this.tb_DefaultLatitude.Size = new System.Drawing.Size(161, 20);
            this.tb_DefaultLatitude.TabIndex = 1;
            this.tb_DefaultLatitude.Text = "0";
            this.tb_DefaultLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.tabPage_Loc);
            this.SettingsTab.Controls.Add(this.tabPage_Bot);
            this.SettingsTab.Controls.Add(this.tp_Pokemon);
            this.SettingsTab.Controls.Add(this.tP_CatchSnipe);
            this.SettingsTab.Controls.Add(this.tp_About);
            this.SettingsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsTab.Location = new System.Drawing.Point(0, 0);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.SelectedIndex = 0;
            this.SettingsTab.Size = new System.Drawing.Size(542, 571);
            this.SettingsTab.TabIndex = 1;
            // 
            // tabPage_Loc
            // 
            this.tabPage_Loc.Controls.Add(this.groupBox10);
            this.tabPage_Loc.Controls.Add(this.groupBox2);
            this.tabPage_Loc.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Loc.Name = "tabPage_Loc";
            this.tabPage_Loc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Loc.Size = new System.Drawing.Size(534, 545);
            this.tabPage_Loc.TabIndex = 3;
            this.tabPage_Loc.Text = "Location Settings";
            this.tabPage_Loc.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.Transparent;
            this.groupBox10.Controls.Add(this.nUD_MaxTravelDistanceInMeters);
            this.groupBox10.Controls.Add(this.nUD_DefaultAltitude);
            this.groupBox10.Controls.Add(this.nUD_WalkingSpeedInKilometerPerHour);
            this.groupBox10.Controls.Add(this.l_GpxFile);
            this.groupBox10.Controls.Add(this.l_DefaultAltitude);
            this.groupBox10.Controls.Add(this.tb_GpxFile);
            this.groupBox10.Controls.Add(this.l_WalkingSpeedInKilometerPerHour);
            this.groupBox10.Controls.Add(this.cb_UseGpxPathing);
            this.groupBox10.Controls.Add(this.l_MaxTravelDistanceInMeters);
            this.groupBox10.Controls.Add(this.l_MaxSpawnLocationOffset);
            this.groupBox10.Controls.Add(this.nUD_MaxSpawnLocationOffset);
            this.groupBox10.Location = new System.Drawing.Point(6, 424);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(520, 113);
            this.groupBox10.TabIndex = 31;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Advanced Location Settings";
            // 
            // nUD_MaxTravelDistanceInMeters
            // 
            this.nUD_MaxTravelDistanceInMeters.Location = new System.Drawing.Point(386, 20);
            this.nUD_MaxTravelDistanceInMeters.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUD_MaxTravelDistanceInMeters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_MaxTravelDistanceInMeters.Name = "nUD_MaxTravelDistanceInMeters";
            this.nUD_MaxTravelDistanceInMeters.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_MaxTravelDistanceInMeters.Size = new System.Drawing.Size(100, 20);
            this.nUD_MaxTravelDistanceInMeters.TabIndex = 15;
            this.nUD_MaxTravelDistanceInMeters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_MaxTravelDistanceInMeters.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nUD_DefaultAltitude
            // 
            this.nUD_DefaultAltitude.Location = new System.Drawing.Point(153, 27);
            this.nUD_DefaultAltitude.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUD_DefaultAltitude.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_DefaultAltitude.Name = "nUD_DefaultAltitude";
            this.nUD_DefaultAltitude.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_DefaultAltitude.Size = new System.Drawing.Size(100, 20);
            this.nUD_DefaultAltitude.TabIndex = 14;
            this.nUD_DefaultAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_DefaultAltitude.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nUD_WalkingSpeedInKilometerPerHour
            // 
            this.nUD_WalkingSpeedInKilometerPerHour.Location = new System.Drawing.Point(153, 53);
            this.nUD_WalkingSpeedInKilometerPerHour.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUD_WalkingSpeedInKilometerPerHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_WalkingSpeedInKilometerPerHour.Name = "nUD_WalkingSpeedInKilometerPerHour";
            this.nUD_WalkingSpeedInKilometerPerHour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_WalkingSpeedInKilometerPerHour.Size = new System.Drawing.Size(100, 20);
            this.nUD_WalkingSpeedInKilometerPerHour.TabIndex = 13;
            this.nUD_WalkingSpeedInKilometerPerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_WalkingSpeedInKilometerPerHour.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // l_MaxSpawnLocationOffset
            // 
            this.l_MaxSpawnLocationOffset.AutoSize = true;
            this.l_MaxSpawnLocationOffset.Location = new System.Drawing.Point(7, 81);
            this.l_MaxSpawnLocationOffset.Name = "l_MaxSpawnLocationOffset";
            this.l_MaxSpawnLocationOffset.Size = new System.Drawing.Size(136, 13);
            this.l_MaxSpawnLocationOffset.TabIndex = 34;
            this.l_MaxSpawnLocationOffset.Text = "Max. spawn location offset:";
            // 
            // nUD_MaxSpawnLocationOffset
            // 
            this.nUD_MaxSpawnLocationOffset.Location = new System.Drawing.Point(153, 79);
            this.nUD_MaxSpawnLocationOffset.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nUD_MaxSpawnLocationOffset.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_MaxSpawnLocationOffset.Name = "nUD_MaxSpawnLocationOffset";
            this.nUD_MaxSpawnLocationOffset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_MaxSpawnLocationOffset.Size = new System.Drawing.Size(100, 20);
            this.nUD_MaxSpawnLocationOffset.TabIndex = 35;
            this.nUD_MaxSpawnLocationOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_MaxSpawnLocationOffset.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackBar);
            this.groupBox2.Controls.Add(this.l_AdressBox);
            this.groupBox2.Controls.Add(this.b_FindLoc);
            this.groupBox2.Controls.Add(this.l_DefaultLongitude);
            this.groupBox2.Controls.Add(this.tb_DefaultLongitude);
            this.groupBox2.Controls.Add(this.tb_DefaultLatitude);
            this.groupBox2.Controls.Add(this.l_DefaultLatitude);
            this.groupBox2.Controls.Add(this.gMapControl1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 412);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Start Location Settings";
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.White;
            this.trackBar.Location = new System.Drawing.Point(463, 47);
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.Size = new System.Drawing.Size(45, 81);
            this.trackBar.TabIndex = 27;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // l_AdressBox
            // 
            this.l_AdressBox.Location = new System.Drawing.Point(10, 19);
            this.l_AdressBox.Name = "l_AdressBox";
            this.l_AdressBox.Size = new System.Drawing.Size(386, 20);
            this.l_AdressBox.TabIndex = 29;
            // 
            // b_FindLoc
            // 
            this.b_FindLoc.Location = new System.Drawing.Point(402, 15);
            this.b_FindLoc.Name = "b_FindLoc";
            this.b_FindLoc.Size = new System.Drawing.Size(106, 26);
            this.b_FindLoc.TabIndex = 28;
            this.b_FindLoc.Text = "Find Location";
            this.b_FindLoc.UseVisualStyleBackColor = true;
            this.b_FindLoc.Click += new System.EventHandler(this.FindAdressButton_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.BackColor = System.Drawing.Color.White;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(10, 47);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(498, 332);
            this.gMapControl1.TabIndex = 26;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_DoubleClick);
            // 
            // tabPage_Bot
            // 
            this.tabPage_Bot.Controls.Add(this.groupBox1);
            this.tabPage_Bot.Controls.Add(this.groupBox7);
            this.tabPage_Bot.Controls.Add(this.groupBox9);
            this.tabPage_Bot.Controls.Add(this.groupBox8);
            this.tabPage_Bot.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Bot.Name = "tabPage_Bot";
            this.tabPage_Bot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Bot.Size = new System.Drawing.Size(534, 545);
            this.tabPage_Bot.TabIndex = 0;
            this.tabPage_Bot.Text = "Bot Settings";
            this.tabPage_Bot.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nUD_DelayBetweenPlayerActions);
            this.groupBox1.Controls.Add(this.l_DelayBetweenPokemonCatch);
            this.groupBox1.Controls.Add(this.nUD_DelayBetweenPokemonCatch);
            this.groupBox1.Controls.Add(this.l_DelayBetweenPlayerActions);
            this.groupBox1.Location = new System.Drawing.Point(6, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 78);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delay:";
            // 
            // nUD_DelayBetweenPlayerActions
            // 
            this.nUD_DelayBetweenPlayerActions.Location = new System.Drawing.Point(149, 48);
            this.nUD_DelayBetweenPlayerActions.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nUD_DelayBetweenPlayerActions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_DelayBetweenPlayerActions.Name = "nUD_DelayBetweenPlayerActions";
            this.nUD_DelayBetweenPlayerActions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_DelayBetweenPlayerActions.Size = new System.Drawing.Size(76, 20);
            this.nUD_DelayBetweenPlayerActions.TabIndex = 22;
            this.nUD_DelayBetweenPlayerActions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_DelayBetweenPlayerActions.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // l_DelayBetweenPokemonCatch
            // 
            this.l_DelayBetweenPokemonCatch.AutoSize = true;
            this.l_DelayBetweenPokemonCatch.Location = new System.Drawing.Point(31, 24);
            this.l_DelayBetweenPokemonCatch.Name = "l_DelayBetweenPokemonCatch";
            this.l_DelayBetweenPokemonCatch.Size = new System.Drawing.Size(107, 13);
            this.l_DelayBetweenPokemonCatch.TabIndex = 5;
            this.l_DelayBetweenPokemonCatch.Text = "Pokemon catch (ms):";
            // 
            // nUD_DelayBetweenPokemonCatch
            // 
            this.nUD_DelayBetweenPokemonCatch.Location = new System.Drawing.Point(149, 22);
            this.nUD_DelayBetweenPokemonCatch.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nUD_DelayBetweenPokemonCatch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_DelayBetweenPokemonCatch.Name = "nUD_DelayBetweenPokemonCatch";
            this.nUD_DelayBetweenPokemonCatch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_DelayBetweenPokemonCatch.Size = new System.Drawing.Size(76, 20);
            this.nUD_DelayBetweenPokemonCatch.TabIndex = 21;
            this.nUD_DelayBetweenPokemonCatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_DelayBetweenPokemonCatch.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // l_DelayBetweenPlayerActions
            // 
            this.l_DelayBetweenPlayerActions.AutoSize = true;
            this.l_DelayBetweenPlayerActions.Location = new System.Drawing.Point(31, 50);
            this.l_DelayBetweenPlayerActions.Name = "l_DelayBetweenPlayerActions";
            this.l_DelayBetweenPlayerActions.Size = new System.Drawing.Size(98, 13);
            this.l_DelayBetweenPlayerActions.TabIndex = 7;
            this.l_DelayBetweenPlayerActions.Text = "Player actions (ms):";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cb_UseEggIncubators);
            this.groupBox7.Location = new System.Drawing.Point(271, 368);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(255, 78);
            this.groupBox7.TabIndex = 24;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Pokemon Egg Settings";
            // 
            // cb_UseEggIncubators
            // 
            this.cb_UseEggIncubators.AutoSize = true;
            this.cb_UseEggIncubators.Location = new System.Drawing.Point(66, 36);
            this.cb_UseEggIncubators.Name = "cb_UseEggIncubators";
            this.cb_UseEggIncubators.Size = new System.Drawing.Size(124, 17);
            this.cb_UseEggIncubators.TabIndex = 22;
            this.cb_UseEggIncubators.Text = "Use egg incubators?";
            this.cb_UseEggIncubators.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cb_UseIncenseConstantly);
            this.groupBox9.Controls.Add(this.cb_UseLuckyEggConstantly);
            this.groupBox9.Controls.Add(this.nUD_WebSocketPort);
            this.groupBox9.Controls.Add(this.cb_DisableHumanWalking);
            this.groupBox9.Controls.Add(this.cb_StartupWelcomeDelay);
            this.groupBox9.Controls.Add(this.nUD_AmountOfPokemonToDisplayOnStart);
            this.groupBox9.Controls.Add(this.l_WebSocketPort);
            this.groupBox9.Controls.Add(this.l_AmountOfPokemonToDisplayOnStart);
            this.groupBox9.Controls.Add(this.cb_AutoUpdate);
            this.groupBox9.Controls.Add(this.cb_DumpPokemonStats);
            this.groupBox9.Controls.Add(this.cb_TransferConfigAndAuthOnUpdate);
            this.groupBox9.Location = new System.Drawing.Point(6, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(520, 199);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Bot Settings:";
            // 
            // cb_UseIncenseConstantly
            // 
            this.cb_UseIncenseConstantly.AutoSize = true;
            this.cb_UseIncenseConstantly.Location = new System.Drawing.Point(194, 139);
            this.cb_UseIncenseConstantly.Name = "cb_UseIncenseConstantly";
            this.cb_UseIncenseConstantly.Size = new System.Drawing.Size(142, 17);
            this.cb_UseIncenseConstantly.TabIndex = 49;
            this.cb_UseIncenseConstantly.Text = "Use incense constantly?";
            this.cb_UseIncenseConstantly.UseVisualStyleBackColor = true;
            // 
            // cb_UseLuckyEggConstantly
            // 
            this.cb_UseLuckyEggConstantly.AutoSize = true;
            this.cb_UseLuckyEggConstantly.Location = new System.Drawing.Point(9, 139);
            this.cb_UseLuckyEggConstantly.Name = "cb_UseLuckyEggConstantly";
            this.cb_UseLuckyEggConstantly.Size = new System.Drawing.Size(151, 17);
            this.cb_UseLuckyEggConstantly.TabIndex = 48;
            this.cb_UseLuckyEggConstantly.Text = "Use lucky egg constantly?";
            this.cb_UseLuckyEggConstantly.UseVisualStyleBackColor = true;
            // 
            // nUD_WebSocketPort
            // 
            this.nUD_WebSocketPort.Location = new System.Drawing.Point(101, 169);
            this.nUD_WebSocketPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nUD_WebSocketPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_WebSocketPort.Name = "nUD_WebSocketPort";
            this.nUD_WebSocketPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_WebSocketPort.Size = new System.Drawing.Size(81, 20);
            this.nUD_WebSocketPort.TabIndex = 47;
            this.nUD_WebSocketPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_WebSocketPort.Value = new decimal(new int[] {
            14251,
            0,
            0,
            0});
            // 
            // cb_DisableHumanWalking
            // 
            this.cb_DisableHumanWalking.AutoSize = true;
            this.cb_DisableHumanWalking.Location = new System.Drawing.Point(9, 116);
            this.cb_DisableHumanWalking.Name = "cb_DisableHumanWalking";
            this.cb_DisableHumanWalking.Size = new System.Drawing.Size(141, 17);
            this.cb_DisableHumanWalking.TabIndex = 20;
            this.cb_DisableHumanWalking.Text = "Disable human walking?";
            this.cb_DisableHumanWalking.UseVisualStyleBackColor = true;
            // 
            // cb_StartupWelcomeDelay
            // 
            this.cb_StartupWelcomeDelay.AutoSize = true;
            this.cb_StartupWelcomeDelay.Location = new System.Drawing.Point(9, 44);
            this.cb_StartupWelcomeDelay.Name = "cb_StartupWelcomeDelay";
            this.cb_StartupWelcomeDelay.Size = new System.Drawing.Size(327, 17);
            this.cb_StartupWelcomeDelay.TabIndex = 19;
            this.cb_StartupWelcomeDelay.Text = "Enable startup welcome delay (Force to press ENTER on start)?";
            this.cb_StartupWelcomeDelay.UseVisualStyleBackColor = true;
            // 
            // nUD_AmountOfPokemonToDisplayOnStart
            // 
            this.nUD_AmountOfPokemonToDisplayOnStart.Location = new System.Drawing.Point(236, 89);
            this.nUD_AmountOfPokemonToDisplayOnStart.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nUD_AmountOfPokemonToDisplayOnStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_AmountOfPokemonToDisplayOnStart.Name = "nUD_AmountOfPokemonToDisplayOnStart";
            this.nUD_AmountOfPokemonToDisplayOnStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_AmountOfPokemonToDisplayOnStart.Size = new System.Drawing.Size(100, 20);
            this.nUD_AmountOfPokemonToDisplayOnStart.TabIndex = 15;
            this.nUD_AmountOfPokemonToDisplayOnStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_AmountOfPokemonToDisplayOnStart.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // l_WebSocketPort
            // 
            this.l_WebSocketPort.AutoSize = true;
            this.l_WebSocketPort.Location = new System.Drawing.Point(6, 171);
            this.l_WebSocketPort.Name = "l_WebSocketPort";
            this.l_WebSocketPort.Size = new System.Drawing.Size(89, 13);
            this.l_WebSocketPort.TabIndex = 18;
            this.l_WebSocketPort.Text = "WebSocket Port:";
            // 
            // l_AmountOfPokemonToDisplayOnStart
            // 
            this.l_AmountOfPokemonToDisplayOnStart.AutoSize = true;
            this.l_AmountOfPokemonToDisplayOnStart.Location = new System.Drawing.Point(8, 91);
            this.l_AmountOfPokemonToDisplayOnStart.Name = "l_AmountOfPokemonToDisplayOnStart";
            this.l_AmountOfPokemonToDisplayOnStart.Size = new System.Drawing.Size(191, 13);
            this.l_AmountOfPokemonToDisplayOnStart.TabIndex = 1;
            this.l_AmountOfPokemonToDisplayOnStart.Text = "Amount of Pokemon to display on start:";
            // 
            // cb_AutoUpdate
            // 
            this.cb_AutoUpdate.AutoSize = true;
            this.cb_AutoUpdate.Location = new System.Drawing.Point(9, 19);
            this.cb_AutoUpdate.Name = "cb_AutoUpdate";
            this.cb_AutoUpdate.Size = new System.Drawing.Size(92, 17);
            this.cb_AutoUpdate.TabIndex = 13;
            this.cb_AutoUpdate.Text = "Auto Update?";
            this.cb_AutoUpdate.UseVisualStyleBackColor = true;
            // 
            // cb_DumpPokemonStats
            // 
            this.cb_DumpPokemonStats.AutoSize = true;
            this.cb_DumpPokemonStats.Location = new System.Drawing.Point(9, 67);
            this.cb_DumpPokemonStats.Name = "cb_DumpPokemonStats";
            this.cb_DumpPokemonStats.Size = new System.Drawing.Size(199, 17);
            this.cb_DumpPokemonStats.TabIndex = 14;
            this.cb_DumpPokemonStats.Text = "Dump Pokemon stats to file on start?";
            this.cb_DumpPokemonStats.UseVisualStyleBackColor = true;
            // 
            // cb_TransferConfigAndAuthOnUpdate
            // 
            this.cb_TransferConfigAndAuthOnUpdate.AutoSize = true;
            this.cb_TransferConfigAndAuthOnUpdate.Location = new System.Drawing.Point(158, 19);
            this.cb_TransferConfigAndAuthOnUpdate.Name = "cb_TransferConfigAndAuthOnUpdate";
            this.cb_TransferConfigAndAuthOnUpdate.Size = new System.Drawing.Size(178, 17);
            this.cb_TransferConfigAndAuthOnUpdate.TabIndex = 10;
            this.cb_TransferConfigAndAuthOnUpdate.Text = "Transfer config on auto update?";
            this.cb_TransferConfigAndAuthOnUpdate.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.nUD_RecycleInventoryAtUsagePercentag);
            this.groupBox8.Controls.Add(this.l_RecycleInventoryAtUsagePercentag);
            this.groupBox8.Controls.Add(this.cb_VerboseRecycling);
            this.groupBox8.Controls.Add(this.cb_ShowPokeballCountsBeforeRecycle);
            this.groupBox8.Controls.Add(this.nUD_TotalAmountOfRevivesToKeep);
            this.groupBox8.Controls.Add(this.nUD_TotalAmountOfPotionsToKeep);
            this.groupBox8.Controls.Add(this.button1);
            this.groupBox8.Controls.Add(this.l_TotalAmountOfRevivesToKeep);
            this.groupBox8.Controls.Add(this.nUD_TotalAmountOfPokebalsToKeep);
            this.groupBox8.Controls.Add(this.l_TotalAmountOfPotionsToKeep);
            this.groupBox8.Controls.Add(this.l_TotalAmountOfPokebalsToKeep);
            this.groupBox8.Location = new System.Drawing.Point(6, 211);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(520, 151);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Recycle Filter:";
            // 
            // nUD_RecycleInventoryAtUsagePercentag
            // 
            this.nUD_RecycleInventoryAtUsagePercentag.Location = new System.Drawing.Point(78, 107);
            this.nUD_RecycleInventoryAtUsagePercentag.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_RecycleInventoryAtUsagePercentag.Name = "nUD_RecycleInventoryAtUsagePercentag";
            this.nUD_RecycleInventoryAtUsagePercentag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_RecycleInventoryAtUsagePercentag.Size = new System.Drawing.Size(100, 20);
            this.nUD_RecycleInventoryAtUsagePercentag.TabIndex = 31;
            this.nUD_RecycleInventoryAtUsagePercentag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_RecycleInventoryAtUsagePercentag.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // l_RecycleInventoryAtUsagePercentag
            // 
            this.l_RecycleInventoryAtUsagePercentag.AutoSize = true;
            this.l_RecycleInventoryAtUsagePercentag.Location = new System.Drawing.Point(20, 76);
            this.l_RecycleInventoryAtUsagePercentag.Name = "l_RecycleInventoryAtUsagePercentag";
            this.l_RecycleInventoryAtUsagePercentag.Size = new System.Drawing.Size(218, 13);
            this.l_RecycleInventoryAtUsagePercentag.TabIndex = 30;
            this.l_RecycleInventoryAtUsagePercentag.Text = "Recycle Inventory At Usage Percentage (%):";
            // 
            // cb_VerboseRecycling
            // 
            this.cb_VerboseRecycling.AutoSize = true;
            this.cb_VerboseRecycling.Location = new System.Drawing.Point(23, 47);
            this.cb_VerboseRecycling.Name = "cb_VerboseRecycling";
            this.cb_VerboseRecycling.Size = new System.Drawing.Size(151, 17);
            this.cb_VerboseRecycling.TabIndex = 25;
            this.cb_VerboseRecycling.Text = "Show Verbose Recycling?";
            this.cb_VerboseRecycling.UseVisualStyleBackColor = true;
            // 
            // cb_ShowPokeballCountsBeforeRecycle
            // 
            this.cb_ShowPokeballCountsBeforeRecycle.AutoSize = true;
            this.cb_ShowPokeballCountsBeforeRecycle.Location = new System.Drawing.Point(23, 20);
            this.cb_ShowPokeballCountsBeforeRecycle.Name = "cb_ShowPokeballCountsBeforeRecycle";
            this.cb_ShowPokeballCountsBeforeRecycle.Size = new System.Drawing.Size(207, 17);
            this.cb_ShowPokeballCountsBeforeRecycle.TabIndex = 20;
            this.cb_ShowPokeballCountsBeforeRecycle.Text = "Show pokeball counts before recycle?";
            this.cb_ShowPokeballCountsBeforeRecycle.UseVisualStyleBackColor = true;
            // 
            // nUD_TotalAmountOfRevivesToKeep
            // 
            this.nUD_TotalAmountOfRevivesToKeep.Location = new System.Drawing.Point(392, 74);
            this.nUD_TotalAmountOfRevivesToKeep.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUD_TotalAmountOfRevivesToKeep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_TotalAmountOfRevivesToKeep.Name = "nUD_TotalAmountOfRevivesToKeep";
            this.nUD_TotalAmountOfRevivesToKeep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_TotalAmountOfRevivesToKeep.Size = new System.Drawing.Size(100, 20);
            this.nUD_TotalAmountOfRevivesToKeep.TabIndex = 21;
            this.nUD_TotalAmountOfRevivesToKeep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_TotalAmountOfRevivesToKeep.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // nUD_TotalAmountOfPotionsToKeep
            // 
            this.nUD_TotalAmountOfPotionsToKeep.Location = new System.Drawing.Point(392, 46);
            this.nUD_TotalAmountOfPotionsToKeep.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUD_TotalAmountOfPotionsToKeep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_TotalAmountOfPotionsToKeep.Name = "nUD_TotalAmountOfPotionsToKeep";
            this.nUD_TotalAmountOfPotionsToKeep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_TotalAmountOfPotionsToKeep.Size = new System.Drawing.Size(100, 20);
            this.nUD_TotalAmountOfPotionsToKeep.TabIndex = 22;
            this.nUD_TotalAmountOfPotionsToKeep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_TotalAmountOfPotionsToKeep.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(321, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 26);
            this.button1.TabIndex = 29;
            this.button1.Text = "Advanced Recycle Filter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // l_TotalAmountOfRevivesToKeep
            // 
            this.l_TotalAmountOfRevivesToKeep.AutoSize = true;
            this.l_TotalAmountOfRevivesToKeep.Location = new System.Drawing.Point(290, 76);
            this.l_TotalAmountOfRevivesToKeep.Name = "l_TotalAmountOfRevivesToKeep";
            this.l_TotalAmountOfRevivesToKeep.Size = new System.Drawing.Size(72, 13);
            this.l_TotalAmountOfRevivesToKeep.TabIndex = 4;
            this.l_TotalAmountOfRevivesToKeep.Text = "Max Revives:";
            // 
            // nUD_TotalAmountOfPokebalsToKeep
            // 
            this.nUD_TotalAmountOfPokebalsToKeep.Location = new System.Drawing.Point(392, 19);
            this.nUD_TotalAmountOfPokebalsToKeep.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUD_TotalAmountOfPokebalsToKeep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_TotalAmountOfPokebalsToKeep.Name = "nUD_TotalAmountOfPokebalsToKeep";
            this.nUD_TotalAmountOfPokebalsToKeep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_TotalAmountOfPokebalsToKeep.Size = new System.Drawing.Size(100, 20);
            this.nUD_TotalAmountOfPokebalsToKeep.TabIndex = 20;
            this.nUD_TotalAmountOfPokebalsToKeep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_TotalAmountOfPokebalsToKeep.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // l_TotalAmountOfPotionsToKeep
            // 
            this.l_TotalAmountOfPotionsToKeep.AutoSize = true;
            this.l_TotalAmountOfPotionsToKeep.Location = new System.Drawing.Point(290, 48);
            this.l_TotalAmountOfPotionsToKeep.Name = "l_TotalAmountOfPotionsToKeep";
            this.l_TotalAmountOfPotionsToKeep.Size = new System.Drawing.Size(68, 13);
            this.l_TotalAmountOfPotionsToKeep.TabIndex = 3;
            this.l_TotalAmountOfPotionsToKeep.Text = "Max Potions:";
            // 
            // l_TotalAmountOfPokebalsToKeep
            // 
            this.l_TotalAmountOfPokebalsToKeep.AutoSize = true;
            this.l_TotalAmountOfPokebalsToKeep.Location = new System.Drawing.Point(290, 21);
            this.l_TotalAmountOfPokebalsToKeep.Name = "l_TotalAmountOfPokebalsToKeep";
            this.l_TotalAmountOfPokebalsToKeep.Size = new System.Drawing.Size(79, 13);
            this.l_TotalAmountOfPokebalsToKeep.TabIndex = 1;
            this.l_TotalAmountOfPokebalsToKeep.Text = "Max Pokeballs:";
            // 
            // tp_Pokemon
            // 
            this.tp_Pokemon.Controls.Add(this.groupBox13);
            this.tp_Pokemon.Controls.Add(this.groupBox12);
            this.tp_Pokemon.Controls.Add(this.groupBox4);
            this.tp_Pokemon.Controls.Add(this.groupBox5);
            this.tp_Pokemon.Controls.Add(this.groupBox3);
            this.tp_Pokemon.Location = new System.Drawing.Point(4, 22);
            this.tp_Pokemon.Name = "tp_Pokemon";
            this.tp_Pokemon.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Pokemon.Size = new System.Drawing.Size(534, 545);
            this.tp_Pokemon.TabIndex = 1;
            this.tp_Pokemon.Text = "Pokemon Settings";
            this.tp_Pokemon.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.nUD_FavoriteMinIvPercentage);
            this.groupBox13.Controls.Add(this.cb_AutoFavoritePokemon);
            this.groupBox13.Location = new System.Drawing.Point(6, 458);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(520, 53);
            this.groupBox13.TabIndex = 27;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Favorite Pokemon Settings";
            // 
            // nUD_FavoriteMinIvPercentage
            // 
            this.nUD_FavoriteMinIvPercentage.Location = new System.Drawing.Point(305, 23);
            this.nUD_FavoriteMinIvPercentage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_FavoriteMinIvPercentage.Name = "nUD_FavoriteMinIvPercentage";
            this.nUD_FavoriteMinIvPercentage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_FavoriteMinIvPercentage.Size = new System.Drawing.Size(100, 20);
            this.nUD_FavoriteMinIvPercentage.TabIndex = 23;
            this.nUD_FavoriteMinIvPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_FavoriteMinIvPercentage.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            // 
            // cb_AutoFavoritePokemon
            // 
            this.cb_AutoFavoritePokemon.AutoSize = true;
            this.cb_AutoFavoritePokemon.Location = new System.Drawing.Point(103, 24);
            this.cb_AutoFavoritePokemon.Name = "cb_AutoFavoritePokemon";
            this.cb_AutoFavoritePokemon.Size = new System.Drawing.Size(196, 17);
            this.cb_AutoFavoritePokemon.TabIndex = 21;
            this.cb_AutoFavoritePokemon.Text = "Auto favorite Pokemon? Min. IV (%):";
            this.cb_AutoFavoritePokemon.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.l_UpgradePokemonCpMinimum);
            this.groupBox12.Controls.Add(this.l_UpgradePokemonIvMinimum);
            this.groupBox12.Controls.Add(this.nUD_UpgradePokemonIvMinimum);
            this.groupBox12.Controls.Add(this.nUD_UpgradePokemonCpMinimum);
            this.groupBox12.Controls.Add(this.l_AmountOfTimesToUpgradeLoop);
            this.groupBox12.Controls.Add(this.l_GetMinStarDustForLevelUp);
            this.groupBox12.Controls.Add(this.nUD_GetMinStarDustForLevelUp);
            this.groupBox12.Controls.Add(this.nUD_AmountOfTimesToUpgradeLoop);
            this.groupBox12.Controls.Add(this.cb_LevelUpByCPorIv);
            this.groupBox12.Controls.Add(this.cb_AutomaticallyLevelUpPokemon);
            this.groupBox12.Location = new System.Drawing.Point(6, 275);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(520, 101);
            this.groupBox12.TabIndex = 26;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "LevelUp Pokemon Settings";
            // 
            // l_UpgradePokemonCpMinimum
            // 
            this.l_UpgradePokemonCpMinimum.AutoSize = true;
            this.l_UpgradePokemonCpMinimum.Location = new System.Drawing.Point(6, 76);
            this.l_UpgradePokemonCpMinimum.Name = "l_UpgradePokemonCpMinimum";
            this.l_UpgradePokemonCpMinimum.Size = new System.Drawing.Size(135, 13);
            this.l_UpgradePokemonCpMinimum.TabIndex = 32;
            this.l_UpgradePokemonCpMinimum.Text = "Upgrade Pokemon CP min:";
            // 
            // l_UpgradePokemonIvMinimum
            // 
            this.l_UpgradePokemonIvMinimum.AutoSize = true;
            this.l_UpgradePokemonIvMinimum.Location = new System.Drawing.Point(280, 76);
            this.l_UpgradePokemonIvMinimum.Name = "l_UpgradePokemonIvMinimum";
            this.l_UpgradePokemonIvMinimum.Size = new System.Drawing.Size(131, 13);
            this.l_UpgradePokemonIvMinimum.TabIndex = 31;
            this.l_UpgradePokemonIvMinimum.Text = "Upgrade Pokemon IV min:";
            // 
            // nUD_UpgradePokemonIvMinimum
            // 
            this.nUD_UpgradePokemonIvMinimum.Location = new System.Drawing.Point(414, 74);
            this.nUD_UpgradePokemonIvMinimum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_UpgradePokemonIvMinimum.Name = "nUD_UpgradePokemonIvMinimum";
            this.nUD_UpgradePokemonIvMinimum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_UpgradePokemonIvMinimum.Size = new System.Drawing.Size(80, 20);
            this.nUD_UpgradePokemonIvMinimum.TabIndex = 30;
            this.nUD_UpgradePokemonIvMinimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_UpgradePokemonIvMinimum.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            // 
            // nUD_UpgradePokemonCpMinimum
            // 
            this.nUD_UpgradePokemonCpMinimum.Location = new System.Drawing.Point(174, 74);
            this.nUD_UpgradePokemonCpMinimum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUD_UpgradePokemonCpMinimum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_UpgradePokemonCpMinimum.Name = "nUD_UpgradePokemonCpMinimum";
            this.nUD_UpgradePokemonCpMinimum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_UpgradePokemonCpMinimum.Size = new System.Drawing.Size(80, 20);
            this.nUD_UpgradePokemonCpMinimum.TabIndex = 29;
            this.nUD_UpgradePokemonCpMinimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_UpgradePokemonCpMinimum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // l_AmountOfTimesToUpgradeLoop
            // 
            this.l_AmountOfTimesToUpgradeLoop.AutoSize = true;
            this.l_AmountOfTimesToUpgradeLoop.Location = new System.Drawing.Point(6, 50);
            this.l_AmountOfTimesToUpgradeLoop.Name = "l_AmountOfTimesToUpgradeLoop";
            this.l_AmountOfTimesToUpgradeLoop.Size = new System.Drawing.Size(162, 13);
            this.l_AmountOfTimesToUpgradeLoop.TabIndex = 28;
            this.l_AmountOfTimesToUpgradeLoop.Text = "Amount of times to upgrade loop:";
            // 
            // l_GetMinStarDustForLevelUp
            // 
            this.l_GetMinStarDustForLevelUp.AutoSize = true;
            this.l_GetMinStarDustForLevelUp.Location = new System.Drawing.Point(280, 50);
            this.l_GetMinStarDustForLevelUp.Name = "l_GetMinStarDustForLevelUp";
            this.l_GetMinStarDustForLevelUp.Size = new System.Drawing.Size(128, 13);
            this.l_GetMinStarDustForLevelUp.TabIndex = 27;
            this.l_GetMinStarDustForLevelUp.Text = "Min. star dust for level up:";
            // 
            // nUD_GetMinStarDustForLevelUp
            // 
            this.nUD_GetMinStarDustForLevelUp.Location = new System.Drawing.Point(414, 48);
            this.nUD_GetMinStarDustForLevelUp.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUD_GetMinStarDustForLevelUp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_GetMinStarDustForLevelUp.Name = "nUD_GetMinStarDustForLevelUp";
            this.nUD_GetMinStarDustForLevelUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_GetMinStarDustForLevelUp.Size = new System.Drawing.Size(80, 20);
            this.nUD_GetMinStarDustForLevelUp.TabIndex = 26;
            this.nUD_GetMinStarDustForLevelUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_GetMinStarDustForLevelUp.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // nUD_AmountOfTimesToUpgradeLoop
            // 
            this.nUD_AmountOfTimesToUpgradeLoop.Location = new System.Drawing.Point(174, 48);
            this.nUD_AmountOfTimesToUpgradeLoop.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUD_AmountOfTimesToUpgradeLoop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_AmountOfTimesToUpgradeLoop.Name = "nUD_AmountOfTimesToUpgradeLoop";
            this.nUD_AmountOfTimesToUpgradeLoop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_AmountOfTimesToUpgradeLoop.Size = new System.Drawing.Size(80, 20);
            this.nUD_AmountOfTimesToUpgradeLoop.TabIndex = 25;
            this.nUD_AmountOfTimesToUpgradeLoop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_AmountOfTimesToUpgradeLoop.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cb_LevelUpByCPorIv
            // 
            this.cb_LevelUpByCPorIv.AutoSize = true;
            this.cb_LevelUpByCPorIv.Location = new System.Drawing.Point(283, 24);
            this.cb_LevelUpByCPorIv.Name = "cb_LevelUpByCPorIv";
            this.cb_LevelUpByCPorIv.Size = new System.Drawing.Size(185, 17);
            this.cb_LevelUpByCPorIv.TabIndex = 24;
            this.cb_LevelUpByCPorIv.Text = "Prioritize IV Over CP for LevelUp?";
            this.cb_LevelUpByCPorIv.UseVisualStyleBackColor = true;
            // 
            // cb_AutomaticallyLevelUpPokemon
            // 
            this.cb_AutomaticallyLevelUpPokemon.AutoSize = true;
            this.cb_AutomaticallyLevelUpPokemon.Location = new System.Drawing.Point(42, 24);
            this.cb_AutomaticallyLevelUpPokemon.Name = "cb_AutomaticallyLevelUpPokemon";
            this.cb_AutomaticallyLevelUpPokemon.Size = new System.Drawing.Size(185, 17);
            this.cb_AutomaticallyLevelUpPokemon.TabIndex = 23;
            this.cb_AutomaticallyLevelUpPokemon.Text = "Automatically LevelUp Pokemon?";
            this.cb_AutomaticallyLevelUpPokemon.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_RenamePokemon);
            this.groupBox4.Controls.Add(this.cb_RenameOnlyAboveIv);
            this.groupBox4.Controls.Add(this.l_RenameTemplate);
            this.groupBox4.Controls.Add(this.tb_RenameTemplate);
            this.groupBox4.Location = new System.Drawing.Point(6, 382);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 70);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rename Pokemon Settings";
            // 
            // cb_RenamePokemon
            // 
            this.cb_RenamePokemon.AutoSize = true;
            this.cb_RenamePokemon.Location = new System.Drawing.Point(9, 20);
            this.cb_RenamePokemon.Name = "cb_RenamePokemon";
            this.cb_RenamePokemon.Size = new System.Drawing.Size(119, 17);
            this.cb_RenamePokemon.TabIndex = 21;
            this.cb_RenamePokemon.Text = "Rename pokemon?";
            this.cb_RenamePokemon.UseVisualStyleBackColor = true;
            // 
            // cb_RenameOnlyAboveIv
            // 
            this.cb_RenameOnlyAboveIv.AutoSize = true;
            this.cb_RenameOnlyAboveIv.Location = new System.Drawing.Point(9, 43);
            this.cb_RenameOnlyAboveIv.Name = "cb_RenameOnlyAboveIv";
            this.cb_RenameOnlyAboveIv.Size = new System.Drawing.Size(187, 17);
            this.cb_RenameOnlyAboveIv.TabIndex = 20;
            this.cb_RenameOnlyAboveIv.Text = "Rename pokemon only above IV?";
            this.cb_RenameOnlyAboveIv.UseVisualStyleBackColor = true;
            // 
            // l_RenameTemplate
            // 
            this.l_RenameTemplate.AutoSize = true;
            this.l_RenameTemplate.Location = new System.Drawing.Point(270, 30);
            this.l_RenameTemplate.Name = "l_RenameTemplate";
            this.l_RenameTemplate.Size = new System.Drawing.Size(93, 13);
            this.l_RenameTemplate.TabIndex = 19;
            this.l_RenameTemplate.Text = "Rename template:";
            // 
            // tb_RenameTemplate
            // 
            this.tb_RenameTemplate.Location = new System.Drawing.Point(387, 27);
            this.tb_RenameTemplate.Name = "tb_RenameTemplate";
            this.tb_RenameTemplate.Size = new System.Drawing.Size(100, 20);
            this.tb_RenameTemplate.TabIndex = 18;
            this.tb_RenameTemplate.Text = "{1}_{0}";
            this.tb_RenameTemplate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nUD_KeepMinIvPercentage);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.nUD_KeepMinDuplicatePokemon);
            this.groupBox5.Controls.Add(this.nUD_KeepMinCp);
            this.groupBox5.Controls.Add(this.cb_PrioritizeIvOverCp);
            this.groupBox5.Controls.Add(this.l_KeepMinIvPercentage);
            this.groupBox5.Controls.Add(this.cb_KeepPokemonsThatCanEvolve);
            this.groupBox5.Controls.Add(this.l_KeepMinDuplicatePokemon);
            this.groupBox5.Controls.Add(this.l_KeepMinCp);
            this.groupBox5.Controls.Add(this.cb_TransferDuplicatePokemon);
            this.groupBox5.Location = new System.Drawing.Point(6, 139);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(520, 130);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Transfer Pokemon Settings";
            // 
            // nUD_KeepMinIvPercentage
            // 
            this.nUD_KeepMinIvPercentage.Location = new System.Drawing.Point(182, 99);
            this.nUD_KeepMinIvPercentage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_KeepMinIvPercentage.Name = "nUD_KeepMinIvPercentage";
            this.nUD_KeepMinIvPercentage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_KeepMinIvPercentage.Size = new System.Drawing.Size(100, 20);
            this.nUD_KeepMinIvPercentage.TabIndex = 26;
            this.nUD_KeepMinIvPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_KeepMinIvPercentage.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(336, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 26);
            this.button2.TabIndex = 30;
            this.button2.Text = "Advanced Transfer Filter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // nUD_KeepMinDuplicatePokemon
            // 
            this.nUD_KeepMinDuplicatePokemon.Location = new System.Drawing.Point(182, 47);
            this.nUD_KeepMinDuplicatePokemon.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUD_KeepMinDuplicatePokemon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_KeepMinDuplicatePokemon.Name = "nUD_KeepMinDuplicatePokemon";
            this.nUD_KeepMinDuplicatePokemon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_KeepMinDuplicatePokemon.Size = new System.Drawing.Size(100, 20);
            this.nUD_KeepMinDuplicatePokemon.TabIndex = 25;
            this.nUD_KeepMinDuplicatePokemon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_KeepMinDuplicatePokemon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUD_KeepMinCp
            // 
            this.nUD_KeepMinCp.Location = new System.Drawing.Point(182, 73);
            this.nUD_KeepMinCp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUD_KeepMinCp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_KeepMinCp.Name = "nUD_KeepMinCp";
            this.nUD_KeepMinCp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_KeepMinCp.Size = new System.Drawing.Size(100, 20);
            this.nUD_KeepMinCp.TabIndex = 24;
            this.nUD_KeepMinCp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_KeepMinCp.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cb_PrioritizeIvOverCp
            // 
            this.cb_PrioritizeIvOverCp.AutoSize = true;
            this.cb_PrioritizeIvOverCp.Location = new System.Drawing.Point(319, 47);
            this.cb_PrioritizeIvOverCp.Name = "cb_PrioritizeIvOverCp";
            this.cb_PrioritizeIvOverCp.Size = new System.Drawing.Size(127, 17);
            this.cb_PrioritizeIvOverCp.TabIndex = 17;
            this.cb_PrioritizeIvOverCp.Text = "Prioritize IV Over CP?";
            this.cb_PrioritizeIvOverCp.UseVisualStyleBackColor = true;
            // 
            // l_KeepMinIvPercentage
            // 
            this.l_KeepMinIvPercentage.AutoSize = true;
            this.l_KeepMinIvPercentage.Location = new System.Drawing.Point(6, 101);
            this.l_KeepMinIvPercentage.Name = "l_KeepMinIvPercentage";
            this.l_KeepMinIvPercentage.Size = new System.Drawing.Size(170, 13);
            this.l_KeepMinIvPercentage.TabIndex = 23;
            this.l_KeepMinIvPercentage.Text = "Keep all Pokemen with min. IV (%):";
            // 
            // cb_KeepPokemonsThatCanEvolve
            // 
            this.cb_KeepPokemonsThatCanEvolve.AutoSize = true;
            this.cb_KeepPokemonsThatCanEvolve.Location = new System.Drawing.Point(319, 70);
            this.cb_KeepPokemonsThatCanEvolve.Name = "cb_KeepPokemonsThatCanEvolve";
            this.cb_KeepPokemonsThatCanEvolve.Size = new System.Drawing.Size(182, 17);
            this.cb_KeepPokemonsThatCanEvolve.TabIndex = 2;
            this.cb_KeepPokemonsThatCanEvolve.Text = "Keep Pokemon that can evolve?";
            this.cb_KeepPokemonsThatCanEvolve.UseVisualStyleBackColor = true;
            // 
            // l_KeepMinDuplicatePokemon
            // 
            this.l_KeepMinDuplicatePokemon.AutoSize = true;
            this.l_KeepMinDuplicatePokemon.Location = new System.Drawing.Point(6, 49);
            this.l_KeepMinDuplicatePokemon.Name = "l_KeepMinDuplicatePokemon";
            this.l_KeepMinDuplicatePokemon.Size = new System.Drawing.Size(151, 13);
            this.l_KeepMinDuplicatePokemon.TabIndex = 14;
            this.l_KeepMinDuplicatePokemon.Text = "Keep min. duplicate Pokemon:";
            // 
            // l_KeepMinCp
            // 
            this.l_KeepMinCp.AutoSize = true;
            this.l_KeepMinCp.Location = new System.Drawing.Point(6, 75);
            this.l_KeepMinCp.Name = "l_KeepMinCp";
            this.l_KeepMinCp.Size = new System.Drawing.Size(157, 13);
            this.l_KeepMinCp.TabIndex = 1;
            this.l_KeepMinCp.Text = "Keep all Pokemen with min. CP:";
            // 
            // cb_TransferDuplicatePokemon
            // 
            this.cb_TransferDuplicatePokemon.AutoSize = true;
            this.cb_TransferDuplicatePokemon.Location = new System.Drawing.Point(9, 23);
            this.cb_TransferDuplicatePokemon.Name = "cb_TransferDuplicatePokemon";
            this.cb_TransferDuplicatePokemon.Size = new System.Drawing.Size(168, 17);
            this.cb_TransferDuplicatePokemon.TabIndex = 3;
            this.cb_TransferDuplicatePokemon.Text = "Transfer duplicate Pokemon? ";
            this.cb_TransferDuplicatePokemon.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.l_EvolveKeptPokemonsAtStorageUsagePercentage);
            this.groupBox3.Controls.Add(this.nUD_EvolveKeptPokemonsAtStorageUsagePercentage);
            this.groupBox3.Controls.Add(this.nUD_UseLuckyEggsMinPokemonAmount);
            this.groupBox3.Controls.Add(this.nUD_EvolveAboveIvValue);
            this.groupBox3.Controls.Add(this.cb_UseLuckyEggsWhileEvolving);
            this.groupBox3.Controls.Add(this.cb_EvolveAllPokemonWithEnoughCandy);
            this.groupBox3.Controls.Add(this.cb_EvolveAllPokemonAboveIv);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 127);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Evolve Pokemon Settings";
            // 
            // l_EvolveKeptPokemonsAtStorageUsagePercentage
            // 
            this.l_EvolveKeptPokemonsAtStorageUsagePercentage.AutoSize = true;
            this.l_EvolveKeptPokemonsAtStorageUsagePercentage.Location = new System.Drawing.Point(6, 98);
            this.l_EvolveKeptPokemonsAtStorageUsagePercentage.Name = "l_EvolveKeptPokemonsAtStorageUsagePercentage";
            this.l_EvolveKeptPokemonsAtStorageUsagePercentage.Size = new System.Drawing.Size(151, 13);
            this.l_EvolveKeptPokemonsAtStorageUsagePercentage.TabIndex = 31;
            this.l_EvolveKeptPokemonsAtStorageUsagePercentage.Text = "Keep min. duplicate Pokemon:";
            // 
            // nUD_EvolveKeptPokemonsAtStorageUsagePercentage
            // 
            this.nUD_EvolveKeptPokemonsAtStorageUsagePercentage.Location = new System.Drawing.Point(302, 96);
            this.nUD_EvolveKeptPokemonsAtStorageUsagePercentage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_EvolveKeptPokemonsAtStorageUsagePercentage.Name = "nUD_EvolveKeptPokemonsAtStorageUsagePercentage";
            this.nUD_EvolveKeptPokemonsAtStorageUsagePercentage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_EvolveKeptPokemonsAtStorageUsagePercentage.Size = new System.Drawing.Size(100, 20);
            this.nUD_EvolveKeptPokemonsAtStorageUsagePercentage.TabIndex = 24;
            this.nUD_EvolveKeptPokemonsAtStorageUsagePercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_EvolveKeptPokemonsAtStorageUsagePercentage.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // nUD_UseLuckyEggsMinPokemonAmount
            // 
            this.nUD_UseLuckyEggsMinPokemonAmount.Location = new System.Drawing.Point(302, 70);
            this.nUD_UseLuckyEggsMinPokemonAmount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUD_UseLuckyEggsMinPokemonAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_UseLuckyEggsMinPokemonAmount.Name = "nUD_UseLuckyEggsMinPokemonAmount";
            this.nUD_UseLuckyEggsMinPokemonAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_UseLuckyEggsMinPokemonAmount.Size = new System.Drawing.Size(100, 20);
            this.nUD_UseLuckyEggsMinPokemonAmount.TabIndex = 23;
            this.nUD_UseLuckyEggsMinPokemonAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_UseLuckyEggsMinPokemonAmount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nUD_EvolveAboveIvValue
            // 
            this.nUD_EvolveAboveIvValue.Location = new System.Drawing.Point(302, 18);
            this.nUD_EvolveAboveIvValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_EvolveAboveIvValue.Name = "nUD_EvolveAboveIvValue";
            this.nUD_EvolveAboveIvValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_EvolveAboveIvValue.Size = new System.Drawing.Size(100, 20);
            this.nUD_EvolveAboveIvValue.TabIndex = 22;
            this.nUD_EvolveAboveIvValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_EvolveAboveIvValue.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            // 
            // cb_UseLuckyEggsWhileEvolving
            // 
            this.cb_UseLuckyEggsWhileEvolving.AutoSize = true;
            this.cb_UseLuckyEggsWhileEvolving.Location = new System.Drawing.Point(9, 71);
            this.cb_UseLuckyEggsWhileEvolving.Name = "cb_UseLuckyEggsWhileEvolving";
            this.cb_UseLuckyEggsWhileEvolving.Size = new System.Drawing.Size(287, 17);
            this.cb_UseLuckyEggsWhileEvolving.TabIndex = 9;
            this.cb_UseLuckyEggsWhileEvolving.Text = "Use Luckyegg while Evolving? Min. Pokemon amount: ";
            this.cb_UseLuckyEggsWhileEvolving.UseVisualStyleBackColor = true;
            // 
            // cb_EvolveAllPokemonWithEnoughCandy
            // 
            this.cb_EvolveAllPokemonWithEnoughCandy.AutoSize = true;
            this.cb_EvolveAllPokemonWithEnoughCandy.Location = new System.Drawing.Point(9, 45);
            this.cb_EvolveAllPokemonWithEnoughCandy.Name = "cb_EvolveAllPokemonWithEnoughCandy";
            this.cb_EvolveAllPokemonWithEnoughCandy.Size = new System.Drawing.Size(219, 17);
            this.cb_EvolveAllPokemonWithEnoughCandy.TabIndex = 3;
            this.cb_EvolveAllPokemonWithEnoughCandy.Text = "Evolve all Pokemon with enough candy?";
            this.cb_EvolveAllPokemonWithEnoughCandy.UseVisualStyleBackColor = true;
            // 
            // cb_EvolveAllPokemonAboveIv
            // 
            this.cb_EvolveAllPokemonAboveIv.AutoSize = true;
            this.cb_EvolveAllPokemonAboveIv.Location = new System.Drawing.Point(9, 19);
            this.cb_EvolveAllPokemonAboveIv.Name = "cb_EvolveAllPokemonAboveIv";
            this.cb_EvolveAllPokemonAboveIv.Size = new System.Drawing.Size(258, 17);
            this.cb_EvolveAllPokemonAboveIv.TabIndex = 2;
            this.cb_EvolveAllPokemonAboveIv.Text = "Evolve all Pokemon above IV? IV Min. Value (%):";
            this.cb_EvolveAllPokemonAboveIv.UseVisualStyleBackColor = true;
            // 
            // tP_CatchSnipe
            // 
            this.tP_CatchSnipe.Controls.Add(this.groupBox6);
            this.tP_CatchSnipe.Controls.Add(this.groupBox11);
            this.tP_CatchSnipe.Location = new System.Drawing.Point(4, 22);
            this.tP_CatchSnipe.Name = "tP_CatchSnipe";
            this.tP_CatchSnipe.Padding = new System.Windows.Forms.Padding(3);
            this.tP_CatchSnipe.Size = new System.Drawing.Size(534, 545);
            this.tP_CatchSnipe.TabIndex = 4;
            this.tP_CatchSnipe.Text = "Catch And Snipe Pokemon Settings";
            this.tP_CatchSnipe.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.l_SnipingScanOffset);
            this.groupBox6.Controls.Add(this.tb_SnipingScanOffset);
            this.groupBox6.Controls.Add(this.nUD_MinPokeballsWhileSnipe);
            this.groupBox6.Controls.Add(this.l_MinPokeballsWhileSnipe);
            this.groupBox6.Controls.Add(this.cb_UseSnipeOnlineLocationServer);
            this.groupBox6.Controls.Add(this.nUD_MinDelayBetweenSnipes);
            this.groupBox6.Controls.Add(this.nUD_MinPokeballsToSnipe);
            this.groupBox6.Controls.Add(this.nUD_SnipeLocationServerPort);
            this.groupBox6.Controls.Add(this.l_SnipeLocationServerPort);
            this.groupBox6.Controls.Add(this.l_MinDelayBetweenSnipes);
            this.groupBox6.Controls.Add(this.l_SnipeLocationServer);
            this.groupBox6.Controls.Add(this.cb_SnipeIgnoreUnknownIv);
            this.groupBox6.Controls.Add(this.tb_SnipeLocationServer);
            this.groupBox6.Controls.Add(this.cb_UseTransferIvForSnipe);
            this.groupBox6.Controls.Add(this.cb_UseSnipeLocationServer);
            this.groupBox6.Controls.Add(this.cb_SnipeAtPokestops);
            this.groupBox6.Controls.Add(this.l_MinPokeballsToSnipe);
            this.groupBox6.Location = new System.Drawing.Point(6, 263);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(520, 195);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Snipe Settings";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(302, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 26);
            this.button4.TabIndex = 54;
            this.button4.Text = "Advanced Pokemon To Snipe";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // l_SnipingScanOffset
            // 
            this.l_SnipingScanOffset.AutoSize = true;
            this.l_SnipingScanOffset.Location = new System.Drawing.Point(321, 26);
            this.l_SnipingScanOffset.Name = "l_SnipingScanOffset";
            this.l_SnipingScanOffset.Size = new System.Drawing.Size(100, 13);
            this.l_SnipingScanOffset.TabIndex = 53;
            this.l_SnipingScanOffset.Text = "Sniping scan offset:";
            // 
            // tb_SnipingScanOffset
            // 
            this.tb_SnipingScanOffset.Location = new System.Drawing.Point(431, 23);
            this.tb_SnipingScanOffset.Name = "tb_SnipingScanOffset";
            this.tb_SnipingScanOffset.Size = new System.Drawing.Size(81, 20);
            this.tb_SnipingScanOffset.TabIndex = 52;
            this.tb_SnipingScanOffset.Text = "0.003";
            this.tb_SnipingScanOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nUD_MinPokeballsWhileSnipe
            // 
            this.nUD_MinPokeballsWhileSnipe.Location = new System.Drawing.Point(169, 122);
            this.nUD_MinPokeballsWhileSnipe.Name = "nUD_MinPokeballsWhileSnipe";
            this.nUD_MinPokeballsWhileSnipe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_MinPokeballsWhileSnipe.Size = new System.Drawing.Size(81, 20);
            this.nUD_MinPokeballsWhileSnipe.TabIndex = 51;
            this.nUD_MinPokeballsWhileSnipe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // l_MinPokeballsWhileSnipe
            // 
            this.l_MinPokeballsWhileSnipe.AutoSize = true;
            this.l_MinPokeballsWhileSnipe.Location = new System.Drawing.Point(8, 124);
            this.l_MinPokeballsWhileSnipe.Name = "l_MinPokeballsWhileSnipe";
            this.l_MinPokeballsWhileSnipe.Size = new System.Drawing.Size(133, 13);
            this.l_MinPokeballsWhileSnipe.TabIndex = 50;
            this.l_MinPokeballsWhileSnipe.Text = "Min. pokeballs while snipe:";
            // 
            // cb_UseSnipeOnlineLocationServer
            // 
            this.cb_UseSnipeOnlineLocationServer.AutoSize = true;
            this.cb_UseSnipeOnlineLocationServer.Location = new System.Drawing.Point(324, 49);
            this.cb_UseSnipeOnlineLocationServer.Name = "cb_UseSnipeOnlineLocationServer";
            this.cb_UseSnipeOnlineLocationServer.Size = new System.Drawing.Size(182, 17);
            this.cb_UseSnipeOnlineLocationServer.TabIndex = 49;
            this.cb_UseSnipeOnlineLocationServer.Text = "Use snipe online location server?";
            this.cb_UseSnipeOnlineLocationServer.UseVisualStyleBackColor = true;
            // 
            // nUD_MinDelayBetweenSnipes
            // 
            this.nUD_MinDelayBetweenSnipes.Location = new System.Drawing.Point(169, 148);
            this.nUD_MinDelayBetweenSnipes.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUD_MinDelayBetweenSnipes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_MinDelayBetweenSnipes.Name = "nUD_MinDelayBetweenSnipes";
            this.nUD_MinDelayBetweenSnipes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_MinDelayBetweenSnipes.Size = new System.Drawing.Size(81, 20);
            this.nUD_MinDelayBetweenSnipes.TabIndex = 48;
            this.nUD_MinDelayBetweenSnipes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_MinDelayBetweenSnipes.Value = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            // 
            // nUD_MinPokeballsToSnipe
            // 
            this.nUD_MinPokeballsToSnipe.Location = new System.Drawing.Point(169, 96);
            this.nUD_MinPokeballsToSnipe.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_MinPokeballsToSnipe.Name = "nUD_MinPokeballsToSnipe";
            this.nUD_MinPokeballsToSnipe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_MinPokeballsToSnipe.Size = new System.Drawing.Size(81, 20);
            this.nUD_MinPokeballsToSnipe.TabIndex = 47;
            this.nUD_MinPokeballsToSnipe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_MinPokeballsToSnipe.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nUD_SnipeLocationServerPort
            // 
            this.nUD_SnipeLocationServerPort.Location = new System.Drawing.Point(431, 125);
            this.nUD_SnipeLocationServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nUD_SnipeLocationServerPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_SnipeLocationServerPort.Name = "nUD_SnipeLocationServerPort";
            this.nUD_SnipeLocationServerPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_SnipeLocationServerPort.Size = new System.Drawing.Size(81, 20);
            this.nUD_SnipeLocationServerPort.TabIndex = 46;
            this.nUD_SnipeLocationServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_SnipeLocationServerPort.Value = new decimal(new int[] {
            16969,
            0,
            0,
            0});
            // 
            // l_SnipeLocationServerPort
            // 
            this.l_SnipeLocationServerPort.AutoSize = true;
            this.l_SnipeLocationServerPort.Location = new System.Drawing.Point(338, 127);
            this.l_SnipeLocationServerPort.Name = "l_SnipeLocationServerPort";
            this.l_SnipeLocationServerPort.Size = new System.Drawing.Size(29, 13);
            this.l_SnipeLocationServerPort.TabIndex = 18;
            this.l_SnipeLocationServerPort.Text = "Port:";
            // 
            // l_MinDelayBetweenSnipes
            // 
            this.l_MinDelayBetweenSnipes.AutoSize = true;
            this.l_MinDelayBetweenSnipes.Location = new System.Drawing.Point(6, 150);
            this.l_MinDelayBetweenSnipes.Name = "l_MinDelayBetweenSnipes";
            this.l_MinDelayBetweenSnipes.Size = new System.Drawing.Size(127, 13);
            this.l_MinDelayBetweenSnipes.TabIndex = 16;
            this.l_MinDelayBetweenSnipes.Text = "Min delay between snipe:";
            // 
            // l_SnipeLocationServer
            // 
            this.l_SnipeLocationServer.AutoSize = true;
            this.l_SnipeLocationServer.Location = new System.Drawing.Point(338, 102);
            this.l_SnipeLocationServer.Name = "l_SnipeLocationServer";
            this.l_SnipeLocationServer.Size = new System.Drawing.Size(69, 13);
            this.l_SnipeLocationServer.TabIndex = 16;
            this.l_SnipeLocationServer.Text = "Snipe server:";
            // 
            // cb_SnipeIgnoreUnknownIv
            // 
            this.cb_SnipeIgnoreUnknownIv.AutoSize = true;
            this.cb_SnipeIgnoreUnknownIv.Location = new System.Drawing.Point(9, 48);
            this.cb_SnipeIgnoreUnknownIv.Name = "cb_SnipeIgnoreUnknownIv";
            this.cb_SnipeIgnoreUnknownIv.Size = new System.Drawing.Size(145, 17);
            this.cb_SnipeIgnoreUnknownIv.TabIndex = 14;
            this.cb_SnipeIgnoreUnknownIv.Text = "Snipe ignore unknow IV?";
            this.cb_SnipeIgnoreUnknownIv.UseVisualStyleBackColor = true;
            // 
            // tb_SnipeLocationServer
            // 
            this.tb_SnipeLocationServer.Location = new System.Drawing.Point(431, 99);
            this.tb_SnipeLocationServer.Name = "tb_SnipeLocationServer";
            this.tb_SnipeLocationServer.Size = new System.Drawing.Size(81, 20);
            this.tb_SnipeLocationServer.TabIndex = 15;
            this.tb_SnipeLocationServer.Text = "localhost";
            this.tb_SnipeLocationServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_UseTransferIvForSnipe
            // 
            this.cb_UseTransferIvForSnipe.AutoSize = true;
            this.cb_UseTransferIvForSnipe.Location = new System.Drawing.Point(9, 71);
            this.cb_UseTransferIvForSnipe.Name = "cb_UseTransferIvForSnipe";
            this.cb_UseTransferIvForSnipe.Size = new System.Drawing.Size(145, 17);
            this.cb_UseTransferIvForSnipe.TabIndex = 13;
            this.cb_UseTransferIvForSnipe.Text = "Use transfer IV for snipe?";
            this.cb_UseTransferIvForSnipe.UseVisualStyleBackColor = true;
            // 
            // cb_UseSnipeLocationServer
            // 
            this.cb_UseSnipeLocationServer.AutoSize = true;
            this.cb_UseSnipeLocationServer.Location = new System.Drawing.Point(324, 72);
            this.cb_UseSnipeLocationServer.Name = "cb_UseSnipeLocationServer";
            this.cb_UseSnipeLocationServer.Size = new System.Drawing.Size(188, 17);
            this.cb_UseSnipeLocationServer.TabIndex = 10;
            this.cb_UseSnipeLocationServer.Text = "Use custom snipe location server?";
            this.cb_UseSnipeLocationServer.UseVisualStyleBackColor = true;
            // 
            // cb_SnipeAtPokestops
            // 
            this.cb_SnipeAtPokestops.AutoSize = true;
            this.cb_SnipeAtPokestops.Location = new System.Drawing.Point(9, 25);
            this.cb_SnipeAtPokestops.Name = "cb_SnipeAtPokestops";
            this.cb_SnipeAtPokestops.Size = new System.Drawing.Size(157, 17);
            this.cb_SnipeAtPokestops.TabIndex = 10;
            this.cb_SnipeAtPokestops.Text = "Enable snipe at pokestops?";
            this.cb_SnipeAtPokestops.UseVisualStyleBackColor = true;
            // 
            // l_MinPokeballsToSnipe
            // 
            this.l_MinPokeballsToSnipe.AutoSize = true;
            this.l_MinPokeballsToSnipe.Location = new System.Drawing.Point(8, 98);
            this.l_MinPokeballsToSnipe.Name = "l_MinPokeballsToSnipe";
            this.l_MinPokeballsToSnipe.Size = new System.Drawing.Size(118, 13);
            this.l_MinPokeballsToSnipe.TabIndex = 1;
            this.l_MinPokeballsToSnipe.Text = "Min. pokeballs to snipe:";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.nUD_UseMasterBallBelowCatchProbability);
            this.groupBox11.Controls.Add(this.l_UseMasterBallBelowCatchProbability);
            this.groupBox11.Controls.Add(this.nUD_UseUltraBallBelowCatchProbability);
            this.groupBox11.Controls.Add(this.l_UseUltraBallBelowCatchProbability);
            this.groupBox11.Controls.Add(this.nUD_UseGreatBallBelowCatchProbability);
            this.groupBox11.Controls.Add(this.l_UseGreatBallBelowCatchProbability);
            this.groupBox11.Controls.Add(this.nUD_UseMasterBallAboveCp);
            this.groupBox11.Controls.Add(this.l_UseMasterBallAboveCp);
            this.groupBox11.Controls.Add(this.nUD_UseUltraBallAboveIv);
            this.groupBox11.Controls.Add(this.l_UseUltraBallAboveIv);
            this.groupBox11.Controls.Add(this.nUD_UseUltraBallAboveCp);
            this.groupBox11.Controls.Add(this.l_UseUltraBallAboveCp);
            this.groupBox11.Controls.Add(this.nUD_UseGreatBallAboveIv);
            this.groupBox11.Controls.Add(this.l_UseGreatBallAboveIv);
            this.groupBox11.Controls.Add(this.nUD_UseGreatBallAboveCp);
            this.groupBox11.Controls.Add(this.l_UseGreatBallAboveCp);
            this.groupBox11.Controls.Add(this.nUD_MaxPokeballsPerPokemon);
            this.groupBox11.Controls.Add(this.l_MaxPokeballsPerPokemon);
            this.groupBox11.Controls.Add(this.button3);
            this.groupBox11.Controls.Add(this.cb_UsePokemonToNotCatchFilter);
            this.groupBox11.Location = new System.Drawing.Point(6, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(520, 251);
            this.groupBox11.TabIndex = 25;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Catch Pokemon Settings";
            // 
            // nUD_UseMasterBallBelowCatchProbability
            // 
            this.nUD_UseMasterBallBelowCatchProbability.Location = new System.Drawing.Point(227, 217);
            this.nUD_UseMasterBallBelowCatchProbability.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_UseMasterBallBelowCatchProbability.Name = "nUD_UseMasterBallBelowCatchProbability";
            this.nUD_UseMasterBallBelowCatchProbability.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_UseMasterBallBelowCatchProbability.Size = new System.Drawing.Size(81, 20);
            this.nUD_UseMasterBallBelowCatchProbability.TabIndex = 51;
            this.nUD_UseMasterBallBelowCatchProbability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_UseMasterBallBelowCatchProbability.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // l_UseMasterBallBelowCatchProbability
            // 
            this.l_UseMasterBallBelowCatchProbability.AutoSize = true;
            this.l_UseMasterBallBelowCatchProbability.Location = new System.Drawing.Point(14, 219);
            this.l_UseMasterBallBelowCatchProbability.Name = "l_UseMasterBallBelowCatchProbability";
            this.l_UseMasterBallBelowCatchProbability.Size = new System.Drawing.Size(207, 13);
            this.l_UseMasterBallBelowCatchProbability.TabIndex = 50;
            this.l_UseMasterBallBelowCatchProbability.Text = "Use masterball below catch probability (%):";
            // 
            // nUD_UseUltraBallBelowCatchProbability
            // 
            this.nUD_UseUltraBallBelowCatchProbability.Location = new System.Drawing.Point(227, 191);
            this.nUD_UseUltraBallBelowCatchProbability.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_UseUltraBallBelowCatchProbability.Name = "nUD_UseUltraBallBelowCatchProbability";
            this.nUD_UseUltraBallBelowCatchProbability.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_UseUltraBallBelowCatchProbability.Size = new System.Drawing.Size(81, 20);
            this.nUD_UseUltraBallBelowCatchProbability.TabIndex = 49;
            this.nUD_UseUltraBallBelowCatchProbability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_UseUltraBallBelowCatchProbability.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // l_UseUltraBallBelowCatchProbability
            // 
            this.l_UseUltraBallBelowCatchProbability.AutoSize = true;
            this.l_UseUltraBallBelowCatchProbability.Location = new System.Drawing.Point(14, 193);
            this.l_UseUltraBallBelowCatchProbability.Name = "l_UseUltraBallBelowCatchProbability";
            this.l_UseUltraBallBelowCatchProbability.Size = new System.Drawing.Size(196, 13);
            this.l_UseUltraBallBelowCatchProbability.TabIndex = 48;
            this.l_UseUltraBallBelowCatchProbability.Text = "Use ultraball below catch probability (%):";
            // 
            // nUD_UseGreatBallBelowCatchProbability
            // 
            this.nUD_UseGreatBallBelowCatchProbability.Location = new System.Drawing.Point(227, 166);
            this.nUD_UseGreatBallBelowCatchProbability.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_UseGreatBallBelowCatchProbability.Name = "nUD_UseGreatBallBelowCatchProbability";
            this.nUD_UseGreatBallBelowCatchProbability.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_UseGreatBallBelowCatchProbability.Size = new System.Drawing.Size(81, 20);
            this.nUD_UseGreatBallBelowCatchProbability.TabIndex = 47;
            this.nUD_UseGreatBallBelowCatchProbability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_UseGreatBallBelowCatchProbability.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // l_UseGreatBallBelowCatchProbability
            // 
            this.l_UseGreatBallBelowCatchProbability.AutoSize = true;
            this.l_UseGreatBallBelowCatchProbability.Location = new System.Drawing.Point(14, 168);
            this.l_UseGreatBallBelowCatchProbability.Name = "l_UseGreatBallBelowCatchProbability";
            this.l_UseGreatBallBelowCatchProbability.Size = new System.Drawing.Size(200, 13);
            this.l_UseGreatBallBelowCatchProbability.TabIndex = 46;
            this.l_UseGreatBallBelowCatchProbability.Text = "Use greatball below catch probability (%):";
            // 
            // nUD_UseMasterBallAboveCp
            // 
            this.nUD_UseMasterBallAboveCp.Location = new System.Drawing.Point(425, 131);
            this.nUD_UseMasterBallAboveCp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUD_UseMasterBallAboveCp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_UseMasterBallAboveCp.Name = "nUD_UseMasterBallAboveCp";
            this.nUD_UseMasterBallAboveCp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_UseMasterBallAboveCp.Size = new System.Drawing.Size(81, 20);
            this.nUD_UseMasterBallAboveCp.TabIndex = 45;
            this.nUD_UseMasterBallAboveCp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_UseMasterBallAboveCp.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // l_UseMasterBallAboveCp
            // 
            this.l_UseMasterBallAboveCp.AutoSize = true;
            this.l_UseMasterBallAboveCp.Location = new System.Drawing.Point(272, 133);
            this.l_UseMasterBallAboveCp.Name = "l_UseMasterBallAboveCp";
            this.l_UseMasterBallAboveCp.Size = new System.Drawing.Size(129, 13);
            this.l_UseMasterBallAboveCp.TabIndex = 44;
            this.l_UseMasterBallAboveCp.Text = "Use masterball above CP:";
            // 
            // nUD_UseUltraBallAboveIv
            // 
            this.nUD_UseUltraBallAboveIv.Location = new System.Drawing.Point(425, 105);
            this.nUD_UseUltraBallAboveIv.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_UseUltraBallAboveIv.Name = "nUD_UseUltraBallAboveIv";
            this.nUD_UseUltraBallAboveIv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_UseUltraBallAboveIv.Size = new System.Drawing.Size(81, 20);
            this.nUD_UseUltraBallAboveIv.TabIndex = 43;
            this.nUD_UseUltraBallAboveIv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_UseUltraBallAboveIv.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // l_UseUltraBallAboveIv
            // 
            this.l_UseUltraBallAboveIv.AutoSize = true;
            this.l_UseUltraBallAboveIv.Location = new System.Drawing.Point(272, 107);
            this.l_UseUltraBallAboveIv.Name = "l_UseUltraBallAboveIv";
            this.l_UseUltraBallAboveIv.Size = new System.Drawing.Size(128, 13);
            this.l_UseUltraBallAboveIv.TabIndex = 42;
            this.l_UseUltraBallAboveIv.Text = "Use ultraball above IV(%):";
            // 
            // nUD_UseUltraBallAboveCp
            // 
            this.nUD_UseUltraBallAboveCp.Location = new System.Drawing.Point(425, 79);
            this.nUD_UseUltraBallAboveCp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUD_UseUltraBallAboveCp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_UseUltraBallAboveCp.Name = "nUD_UseUltraBallAboveCp";
            this.nUD_UseUltraBallAboveCp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_UseUltraBallAboveCp.Size = new System.Drawing.Size(81, 20);
            this.nUD_UseUltraBallAboveCp.TabIndex = 41;
            this.nUD_UseUltraBallAboveCp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_UseUltraBallAboveCp.Value = new decimal(new int[] {
            1250,
            0,
            0,
            0});
            // 
            // l_UseUltraBallAboveCp
            // 
            this.l_UseUltraBallAboveCp.AutoSize = true;
            this.l_UseUltraBallAboveCp.Location = new System.Drawing.Point(272, 81);
            this.l_UseUltraBallAboveCp.Name = "l_UseUltraBallAboveCp";
            this.l_UseUltraBallAboveCp.Size = new System.Drawing.Size(118, 13);
            this.l_UseUltraBallAboveCp.TabIndex = 40;
            this.l_UseUltraBallAboveCp.Text = "Use ultraball above CP:";
            // 
            // nUD_UseGreatBallAboveIv
            // 
            this.nUD_UseGreatBallAboveIv.Location = new System.Drawing.Point(425, 53);
            this.nUD_UseGreatBallAboveIv.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_UseGreatBallAboveIv.Name = "nUD_UseGreatBallAboveIv";
            this.nUD_UseGreatBallAboveIv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_UseGreatBallAboveIv.Size = new System.Drawing.Size(81, 20);
            this.nUD_UseGreatBallAboveIv.TabIndex = 39;
            this.nUD_UseGreatBallAboveIv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_UseGreatBallAboveIv.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            // 
            // l_UseGreatBallAboveIv
            // 
            this.l_UseGreatBallAboveIv.AutoSize = true;
            this.l_UseGreatBallAboveIv.Location = new System.Drawing.Point(272, 55);
            this.l_UseGreatBallAboveIv.Name = "l_UseGreatBallAboveIv";
            this.l_UseGreatBallAboveIv.Size = new System.Drawing.Size(135, 13);
            this.l_UseGreatBallAboveIv.TabIndex = 38;
            this.l_UseGreatBallAboveIv.Text = "Use greatball above IV (%):";
            // 
            // nUD_UseGreatBallAboveCp
            // 
            this.nUD_UseGreatBallAboveCp.Location = new System.Drawing.Point(425, 27);
            this.nUD_UseGreatBallAboveCp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUD_UseGreatBallAboveCp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_UseGreatBallAboveCp.Name = "nUD_UseGreatBallAboveCp";
            this.nUD_UseGreatBallAboveCp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_UseGreatBallAboveCp.Size = new System.Drawing.Size(81, 20);
            this.nUD_UseGreatBallAboveCp.TabIndex = 37;
            this.nUD_UseGreatBallAboveCp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_UseGreatBallAboveCp.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // l_UseGreatBallAboveCp
            // 
            this.l_UseGreatBallAboveCp.AutoSize = true;
            this.l_UseGreatBallAboveCp.Location = new System.Drawing.Point(272, 29);
            this.l_UseGreatBallAboveCp.Name = "l_UseGreatBallAboveCp";
            this.l_UseGreatBallAboveCp.Size = new System.Drawing.Size(122, 13);
            this.l_UseGreatBallAboveCp.TabIndex = 36;
            this.l_UseGreatBallAboveCp.Text = "Use greatball above CP:";
            // 
            // nUD_MaxPokeballsPerPokemon
            // 
            this.nUD_MaxPokeballsPerPokemon.Location = new System.Drawing.Point(167, 27);
            this.nUD_MaxPokeballsPerPokemon.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nUD_MaxPokeballsPerPokemon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_MaxPokeballsPerPokemon.Name = "nUD_MaxPokeballsPerPokemon";
            this.nUD_MaxPokeballsPerPokemon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUD_MaxPokeballsPerPokemon.Size = new System.Drawing.Size(81, 20);
            this.nUD_MaxPokeballsPerPokemon.TabIndex = 33;
            this.nUD_MaxPokeballsPerPokemon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_MaxPokeballsPerPokemon.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // l_MaxPokeballsPerPokemon
            // 
            this.l_MaxPokeballsPerPokemon.AutoSize = true;
            this.l_MaxPokeballsPerPokemon.Location = new System.Drawing.Point(14, 29);
            this.l_MaxPokeballsPerPokemon.Name = "l_MaxPokeballsPerPokemon";
            this.l_MaxPokeballsPerPokemon.Size = new System.Drawing.Size(147, 13);
            this.l_MaxPokeballsPerPokemon.TabIndex = 32;
            this.l_MaxPokeballsPerPokemon.Text = "Max. pokeballs per Pokemon:";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(42, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 26);
            this.button3.TabIndex = 31;
            this.button3.Text = "Advanced To Not Catch Filter";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cb_UsePokemonToNotCatchFilter
            // 
            this.cb_UsePokemonToNotCatchFilter.AutoSize = true;
            this.cb_UsePokemonToNotCatchFilter.Location = new System.Drawing.Point(17, 73);
            this.cb_UsePokemonToNotCatchFilter.Name = "cb_UsePokemonToNotCatchFilter";
            this.cb_UsePokemonToNotCatchFilter.Size = new System.Drawing.Size(143, 17);
            this.cb_UsePokemonToNotCatchFilter.TabIndex = 21;
            this.cb_UsePokemonToNotCatchFilter.Text = "Use To Not Catch Filter?";
            this.cb_UsePokemonToNotCatchFilter.UseVisualStyleBackColor = true;
            // 
            // tp_About
            // 
            this.tp_About.Location = new System.Drawing.Point(4, 22);
            this.tp_About.Name = "tp_About";
            this.tp_About.Padding = new System.Windows.Forms.Padding(3);
            this.tp_About.Size = new System.Drawing.Size(534, 545);
            this.tp_About.TabIndex = 5;
            this.tp_About.Text = "About";
            this.tp_About.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SettingsTab);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(327, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 571);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::NecroBot_Setting_GUI.Properties.Resources.backpgo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.cb_TranslationLanguageCode);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.b_StartNecroBot);
            this.panel1.Controls.Add(this.l_TranslationLanguageCode);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.radioPTC);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.radioGoogle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 571);
            this.panel1.TabIndex = 4;
            // 
            // cb_TranslationLanguageCode
            // 
            this.cb_TranslationLanguageCode.FormattingEnabled = true;
            this.cb_TranslationLanguageCode.Items.AddRange(new object[] {
            "ca",
            "da",
            "de",
            "es",
            "et",
            "fr",
            "gr",
            "id",
            "it",
            "nl",
            "no",
            "pt-br",
            "pt-pt",
            "ru_RU",
            "sv",
            "th",
            "tr",
            "uk_UA",
            "zh_CN",
            "zh_tw"});
            this.cb_TranslationLanguageCode.Location = new System.Drawing.Point(243, 12);
            this.cb_TranslationLanguageCode.Name = "cb_TranslationLanguageCode";
            this.cb_TranslationLanguageCode.Size = new System.Drawing.Size(69, 21);
            this.cb_TranslationLanguageCode.TabIndex = 17;
            this.cb_TranslationLanguageCode.Text = "en";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(154, 246);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 4;
            // 
            // b_StartNecroBot
            // 
            this.b_StartNecroBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b_StartNecroBot.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.b_StartNecroBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_StartNecroBot.Location = new System.Drawing.Point(98, 319);
            this.b_StartNecroBot.Name = "b_StartNecroBot";
            this.b_StartNecroBot.Size = new System.Drawing.Size(124, 27);
            this.b_StartNecroBot.TabIndex = 2;
            this.b_StartNecroBot.Text = "Start NecroBot";
            this.b_StartNecroBot.UseVisualStyleBackColor = false;
            this.b_StartNecroBot.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // l_TranslationLanguageCode
            // 
            this.l_TranslationLanguageCode.AutoSize = true;
            this.l_TranslationLanguageCode.BackColor = System.Drawing.Color.Transparent;
            this.l_TranslationLanguageCode.Location = new System.Drawing.Point(179, 15);
            this.l_TranslationLanguageCode.Name = "l_TranslationLanguageCode";
            this.l_TranslationLanguageCode.Size = new System.Drawing.Size(58, 13);
            this.l_TranslationLanguageCode.TabIndex = 16;
            this.l_TranslationLanguageCode.Text = "Language:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(77, 284);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Password:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(77, 249);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 13);
            this.label25.TabIndex = 5;
            this.label25.Text = "Username:";
            // 
            // radioPTC
            // 
            this.radioPTC.AutoSize = true;
            this.radioPTC.BackColor = System.Drawing.Color.Transparent;
            this.radioPTC.Location = new System.Drawing.Point(164, 223);
            this.radioPTC.Name = "radioPTC";
            this.radioPTC.Size = new System.Drawing.Size(130, 17);
            this.radioPTC.TabIndex = 9;
            this.radioPTC.TabStop = true;
            this.radioPTC.Text = "Pokemon Trainer Club";
            this.radioPTC.UseVisualStyleBackColor = false;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(154, 281);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 6;
            // 
            // radioGoogle
            // 
            this.radioGoogle.AutoSize = true;
            this.radioGoogle.BackColor = System.Drawing.Color.Transparent;
            this.radioGoogle.Location = new System.Drawing.Point(45, 223);
            this.radioGoogle.Name = "radioGoogle";
            this.radioGoogle.Size = new System.Drawing.Size(102, 17);
            this.radioGoogle.TabIndex = 8;
            this.radioGoogle.TabStop = true;
            this.radioGoogle.Text = "Google Account";
            this.radioGoogle.UseVisualStyleBackColor = false;
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NecroBot Settings GUI";
            this.Load += new System.EventHandler(this.LauncherForm_Load);
            this.SettingsTab.ResumeLayout(false);
            this.tabPage_Loc.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MaxTravelDistanceInMeters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_DefaultAltitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_WalkingSpeedInKilometerPerHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MaxSpawnLocationOffset)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.tabPage_Bot.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_DelayBetweenPlayerActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_DelayBetweenPokemonCatch)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_WebSocketPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_AmountOfPokemonToDisplayOnStart)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_RecycleInventoryAtUsagePercentag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TotalAmountOfRevivesToKeep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TotalAmountOfPotionsToKeep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TotalAmountOfPokebalsToKeep)).EndInit();
            this.tp_Pokemon.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_FavoriteMinIvPercentage)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UpgradePokemonIvMinimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UpgradePokemonCpMinimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_GetMinStarDustForLevelUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_AmountOfTimesToUpgradeLoop)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_KeepMinIvPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_KeepMinDuplicatePokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_KeepMinCp)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_EvolveKeptPokemonsAtStorageUsagePercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseLuckyEggsMinPokemonAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_EvolveAboveIvValue)).EndInit();
            this.tP_CatchSnipe.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MinPokeballsWhileSnipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MinDelayBetweenSnipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MinPokeballsToSnipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_SnipeLocationServerPort)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseMasterBallBelowCatchProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseUltraBallBelowCatchProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseGreatBallBelowCatchProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseMasterBallAboveCp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseUltraBallAboveIv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseUltraBallAboveCp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseGreatBallAboveIv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UseGreatBallAboveCp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MaxPokeballsPerPokemon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_DefaultLongitude;
        private System.Windows.Forms.TextBox tb_DefaultLatitude;
        private System.Windows.Forms.Label l_MaxTravelDistanceInMeters;
        private System.Windows.Forms.Label l_WalkingSpeedInKilometerPerHour;
        private System.Windows.Forms.Label l_DefaultLongitude;
        private System.Windows.Forms.Label l_DefaultLatitude;
        private System.Windows.Forms.Label l_DefaultAltitude;
        private System.Windows.Forms.TabControl SettingsTab;
        private System.Windows.Forms.TabPage tabPage_Bot;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb_EvolveAllPokemonWithEnoughCandy;
        private System.Windows.Forms.CheckBox cb_EvolveAllPokemonAboveIv;
        private System.Windows.Forms.TabPage tp_Pokemon;
        private System.Windows.Forms.CheckBox cb_UseLuckyEggsWhileEvolving;
        private System.Windows.Forms.Label l_GpxFile;
        private System.Windows.Forms.TextBox tb_GpxFile;
        private System.Windows.Forms.CheckBox cb_UseGpxPathing;
        private System.Windows.Forms.CheckBox cb_UseEggIncubators;
        private System.Windows.Forms.CheckBox cb_UsePokemonToNotCatchFilter;
        private System.Windows.Forms.CheckBox cb_RenameOnlyAboveIv;
        private System.Windows.Forms.Label l_RenameTemplate;
        private System.Windows.Forms.TextBox tb_RenameTemplate;
        private System.Windows.Forms.CheckBox cb_PrioritizeIvOverCp;
        private System.Windows.Forms.Label l_KeepMinDuplicatePokemon;
        private System.Windows.Forms.CheckBox cb_TransferDuplicatePokemon;
        private System.Windows.Forms.CheckBox cb_KeepPokemonsThatCanEvolve;
        private System.Windows.Forms.Label l_KeepMinCp;
        private System.Windows.Forms.Label l_TranslationLanguageCode;
        private System.Windows.Forms.CheckBox cb_DumpPokemonStats;
        private System.Windows.Forms.CheckBox cb_AutoUpdate;
        private System.Windows.Forms.CheckBox cb_TransferConfigAndAuthOnUpdate;
        private System.Windows.Forms.Label l_AmountOfPokemonToDisplayOnStart;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label l_DelayBetweenPlayerActions;
        private System.Windows.Forms.Label l_DelayBetweenPokemonCatch;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label l_TotalAmountOfRevivesToKeep;
        private System.Windows.Forms.Label l_TotalAmountOfPotionsToKeep;
        private System.Windows.Forms.Label l_TotalAmountOfPokebalsToKeep;
        private System.Windows.Forms.CheckBox cb_StartupWelcomeDelay;
        private System.Windows.Forms.Label l_WebSocketPort;
        private System.Windows.Forms.Label l_SnipeLocationServerPort;
        private System.Windows.Forms.Label l_SnipeLocationServer;
        private System.Windows.Forms.TextBox tb_SnipeLocationServer;
        private System.Windows.Forms.CheckBox cb_UseSnipeLocationServer;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label l_MinDelayBetweenSnipes;
        private System.Windows.Forms.CheckBox cb_SnipeIgnoreUnknownIv;
        private System.Windows.Forms.CheckBox cb_UseTransferIvForSnipe;
        private System.Windows.Forms.CheckBox cb_SnipeAtPokestops;
        private System.Windows.Forms.Label l_MinPokeballsToSnipe;
        private System.Windows.Forms.TabPage tabPage_Loc;
        private System.Windows.Forms.RadioButton radioPTC;
        private System.Windows.Forms.RadioButton radioGoogle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button b_StartNecroBot;
        private System.Windows.Forms.TrackBar trackBar;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button b_FindLoc;
        private System.Windows.Forms.TextBox l_AdressBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nUD_WalkingSpeedInKilometerPerHour;
        private System.Windows.Forms.NumericUpDown nUD_DefaultAltitude;
        private System.Windows.Forms.NumericUpDown nUD_MaxTravelDistanceInMeters;
        private System.Windows.Forms.NumericUpDown nUD_AmountOfPokemonToDisplayOnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nUD_TotalAmountOfPotionsToKeep;
        private System.Windows.Forms.NumericUpDown nUD_TotalAmountOfRevivesToKeep;
        private System.Windows.Forms.NumericUpDown nUD_TotalAmountOfPokebalsToKeep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nUD_DelayBetweenPlayerActions;
        private System.Windows.Forms.NumericUpDown nUD_DelayBetweenPokemonCatch;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label l_KeepMinIvPercentage;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nUD_UseLuckyEggsMinPokemonAmount;
        private System.Windows.Forms.NumericUpDown nUD_EvolveAboveIvValue;
        private System.Windows.Forms.NumericUpDown nUD_KeepMinIvPercentage;
        private System.Windows.Forms.NumericUpDown nUD_KeepMinDuplicatePokemon;
        private System.Windows.Forms.NumericUpDown nUD_KeepMinCp;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cb_LevelUpByCPorIv;
        private System.Windows.Forms.CheckBox cb_AutomaticallyLevelUpPokemon;
        private System.Windows.Forms.NumericUpDown nUD_UseMasterBallBelowCatchProbability;
        private System.Windows.Forms.Label l_UseMasterBallBelowCatchProbability;
        private System.Windows.Forms.NumericUpDown nUD_UseUltraBallBelowCatchProbability;
        private System.Windows.Forms.Label l_UseUltraBallBelowCatchProbability;
        private System.Windows.Forms.NumericUpDown nUD_UseGreatBallBelowCatchProbability;
        private System.Windows.Forms.Label l_UseGreatBallBelowCatchProbability;
        private System.Windows.Forms.NumericUpDown nUD_UseMasterBallAboveCp;
        private System.Windows.Forms.Label l_UseMasterBallAboveCp;
        private System.Windows.Forms.NumericUpDown nUD_UseUltraBallAboveIv;
        private System.Windows.Forms.Label l_UseUltraBallAboveIv;
        private System.Windows.Forms.NumericUpDown nUD_UseUltraBallAboveCp;
        private System.Windows.Forms.Label l_UseUltraBallAboveCp;
        private System.Windows.Forms.NumericUpDown nUD_UseGreatBallAboveIv;
        private System.Windows.Forms.Label l_UseGreatBallAboveIv;
        private System.Windows.Forms.NumericUpDown nUD_UseGreatBallAboveCp;
        private System.Windows.Forms.Label l_UseGreatBallAboveCp;
        private System.Windows.Forms.NumericUpDown nUD_MaxSpawnLocationOffset;
        private System.Windows.Forms.Label l_MaxSpawnLocationOffset;
        private System.Windows.Forms.NumericUpDown nUD_MaxPokeballsPerPokemon;
        private System.Windows.Forms.Label l_MaxPokeballsPerPokemon;
        private System.Windows.Forms.TabPage tP_CatchSnipe;
        private System.Windows.Forms.TabPage tp_About;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.NumericUpDown nUD_FavoriteMinIvPercentage;
        private System.Windows.Forms.CheckBox cb_AutoFavoritePokemon;
        private System.Windows.Forms.CheckBox cb_RenamePokemon;
        private System.Windows.Forms.ComboBox cb_TranslationLanguageCode;
        private System.Windows.Forms.CheckBox cb_ShowPokeballCountsBeforeRecycle;
        private System.Windows.Forms.Label l_AmountOfTimesToUpgradeLoop;
        private System.Windows.Forms.Label l_GetMinStarDustForLevelUp;
        private System.Windows.Forms.NumericUpDown nUD_GetMinStarDustForLevelUp;
        private System.Windows.Forms.NumericUpDown nUD_AmountOfTimesToUpgradeLoop;
        private System.Windows.Forms.Label l_UpgradePokemonCpMinimum;
        private System.Windows.Forms.Label l_UpgradePokemonIvMinimum;
        private System.Windows.Forms.NumericUpDown nUD_UpgradePokemonIvMinimum;
        private System.Windows.Forms.NumericUpDown nUD_UpgradePokemonCpMinimum;
        private System.Windows.Forms.CheckBox cb_DisableHumanWalking;
        private System.Windows.Forms.NumericUpDown nUD_SnipeLocationServerPort;
        private System.Windows.Forms.NumericUpDown nUD_MinPokeballsToSnipe;
        private System.Windows.Forms.NumericUpDown nUD_MinDelayBetweenSnipes;
        private System.Windows.Forms.NumericUpDown nUD_WebSocketPort;
        private System.Windows.Forms.CheckBox cb_VerboseRecycling;
        private System.Windows.Forms.NumericUpDown nUD_RecycleInventoryAtUsagePercentag;
        private System.Windows.Forms.Label l_RecycleInventoryAtUsagePercentag;
        private System.Windows.Forms.CheckBox cb_UseIncenseConstantly;
        private System.Windows.Forms.CheckBox cb_UseLuckyEggConstantly;
        private System.Windows.Forms.CheckBox cb_UseSnipeOnlineLocationServer;
        private System.Windows.Forms.NumericUpDown nUD_MinPokeballsWhileSnipe;
        private System.Windows.Forms.Label l_MinPokeballsWhileSnipe;
        private System.Windows.Forms.TextBox tb_SnipingScanOffset;
        private System.Windows.Forms.Label l_SnipingScanOffset;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label l_EvolveKeptPokemonsAtStorageUsagePercentage;
        private System.Windows.Forms.NumericUpDown nUD_EvolveKeptPokemonsAtStorageUsagePercentage;
    }
}