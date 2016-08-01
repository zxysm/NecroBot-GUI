using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using GMap.NET;
using GMap.NET.MapProviders;
using System.Globalization;
using System.Diagnostics;
using PokemonGo.RocketAPI.Enums;

namespace NecroBot_Settings_GUI
{
    public partial class LauncherForm : Form
    {
        private String _path = "";
        private String NecroBot = "";
        private GlobalSettings _globalSettings;

        public LauncherForm()
        {
            InitializeComponent();
            _path = Path.GetDirectoryName(Application.ExecutablePath); 
            if (System.IO.Directory.Exists(_path + "\\Necrobot"))
            {
                if (System.IO.File.Exists(_path + "\\Necrobot\\Necrobot.exe"))
                {
                    _path = _path + "\\Necrobot";
                    NecroBot = _path + "\\Necrobot.exe";
                }
            }
            else
            {
                if (System.IO.File.Exists(_path + "\\Necrobot.exe"))
                    NecroBot = _path + "\\Necrobot.exe";
            }
            if (NecroBot == "")
                b_StartNecroBot.Text = "Save Config";
        }


        private void loadSettings()
        {
            do
            {
                _globalSettings = GlobalSettings.Load(_path);
            } while (_globalSettings == null);

            gMapControl1.Position = new PointLatLng(double.Parse(_globalSettings.DefaultLatitude.ToString().Replace(",", "."), CultureInfo.InvariantCulture), double.Parse(_globalSettings.DefaultLongitude.ToString().Replace(",", "."), CultureInfo.InvariantCulture));

            cb_TranslationLanguageCode.Text = _globalSettings.TranslationLanguageCode.ToString();
            cb_AutoUpdate.Checked = _globalSettings.AutoUpdate;
            cb_TransferConfigAndAuthOnUpdate.Checked = _globalSettings.TransferConfigAndAuthOnUpdate;
            cb_StartupWelcomeDelay.Checked = _globalSettings.StartupWelcomeDelay;
            nUD_AmountOfPokemonToDisplayOnStart.Value = Convert.ToInt32(_globalSettings.AmountOfPokemonToDisplayOnStart);
            cb_ShowPokeballCountsBeforeRecycle.Checked = _globalSettings.ShowPokeballCountsBeforeRecycle;
            cb_AutomaticallyLevelUpPokemon.Checked = _globalSettings.AutomaticallyLevelUpPokemon;
            nUD_AmountOfTimesToUpgradeLoop.Value = Convert.ToInt32(_globalSettings.AmountOfTimesToUpgradeLoop);
            nUD_GetMinStarDustForLevelUp.Value = Convert.ToInt32(_globalSettings.GetMinStarDustForLevelUp);
            if (_globalSettings.LevelUpByCPorIv == "iv")
                cb_LevelUpByCPorIv.Checked = true;
            else
                cb_LevelUpByCPorIv.Checked = false;
            nUD_UpgradePokemonCpMinimum.Value = Convert.ToInt32(_globalSettings.UpgradePokemonCpMinimum);
            nUD_UpgradePokemonIvMinimum.Value = Convert.ToInt32(_globalSettings.UpgradePokemonIvMinimum);
            cb_DisableHumanWalking.Checked = _globalSettings.DisableHumanWalking;
            nUD_DefaultAltitude.Value = Convert.ToInt32(_globalSettings.DefaultAltitude);
            tb_DefaultLatitude.Text = _globalSettings.DefaultLatitude.ToString();
            tb_DefaultLongitude.Text = _globalSettings.DefaultLongitude.ToString();
            nUD_WalkingSpeedInKilometerPerHour.Value = Convert.ToInt32(_globalSettings.WalkingSpeedInKilometerPerHour);
            nUD_MaxSpawnLocationOffset.Value = Convert.ToInt32(_globalSettings.MaxSpawnLocationOffset);
            nUD_DelayBetweenPlayerActions.Value = Convert.ToInt32(_globalSettings.DelayBetweenPlayerActions);
            nUD_DelayBetweenPokemonCatch.Value = Convert.ToInt32(_globalSettings.DelayBetweenPokemonCatch);
            cb_DumpPokemonStats.Checked = _globalSettings.DumpPokemonStats;
            nUD_EvolveAboveIvValue.Value = Convert.ToInt32(_globalSettings.EvolveAboveIvValue);
            cb_EvolveAllPokemonAboveIv.Checked = _globalSettings.EvolveAllPokemonAboveIv;
            cb_EvolveAllPokemonWithEnoughCandy.Checked = _globalSettings.EvolveAllPokemonWithEnoughCandy;
            cb_KeepPokemonsThatCanEvolve.Checked = _globalSettings.KeepPokemonsThatCanEvolve;
            nUD_EvolveKeptPokemonsAtStorageUsagePercentage.Value = Convert.ToInt32(_globalSettings.EvolveKeptPokemonsAtStorageUsagePercentage * 100);
            cb_UseGpxPathing.Checked = _globalSettings.UseGpxPathing;
            tb_GpxFile.Text = _globalSettings.GpxFile.ToString();
            cb_VerboseRecycling.Checked = _globalSettings.VerboseRecycling;
            nUD_RecycleInventoryAtUsagePercentag.Value = Convert.ToInt32(_globalSettings.RecycleInventoryAtUsagePercentage*100);
            nUD_KeepMinCp.Value = Convert.ToInt32(_globalSettings.KeepMinCp);
            nUD_KeepMinDuplicatePokemon.Value = Convert.ToInt32(_globalSettings.KeepMinDuplicatePokemon);
            nUD_KeepMinIvPercentage.Value = Convert.ToInt32(_globalSettings.KeepMinIvPercentage);
            cb_PrioritizeIvOverCp.Checked = _globalSettings.PrioritizeIvOverCp;
            cb_UseEggIncubators.Checked = _globalSettings.UseEggIncubators;
            cb_UseLuckyEggConstantly.Checked = _globalSettings.UseLuckyEggConstantly;
            nUD_UseLuckyEggsMinPokemonAmount.Value = Convert.ToInt32(_globalSettings.UseLuckyEggsMinPokemonAmount);
            cb_UseLuckyEggsWhileEvolving.Checked = _globalSettings.UseLuckyEggsWhileEvolving;
            cb_UseIncenseConstantly.Checked = _globalSettings.UseIncenseConstantly;
            cb_UseSnipeOnlineLocationServer.Checked = _globalSettings.UseSnipeOnlineLocationServer;
            cb_UseSnipeLocationServer.Checked = _globalSettings.UseSnipeLocationServer;
            tb_SnipeLocationServer.Text = _globalSettings.SnipeLocationServer.ToString();
            nUD_SnipeLocationServerPort.Value = Convert.ToInt32(_globalSettings.SnipeLocationServerPort);
            nUD_MinPokeballsToSnipe.Value = Convert.ToInt32(_globalSettings.MinPokeballsToSnipe);
            nUD_MinPokeballsWhileSnipe.Value = Convert.ToInt32(_globalSettings.MinPokeballsWhileSnipe);
            nUD_MinDelayBetweenSnipes.Value = Convert.ToInt32(_globalSettings.MinDelayBetweenSnipes);
            tb_SnipingScanOffset.Text = _globalSettings.SnipingScanOffset.ToString();
            cb_SnipeAtPokestops.Checked = _globalSettings.SnipeAtPokestops;
            cb_SnipeIgnoreUnknownIv.Checked = _globalSettings.SnipeIgnoreUnknownIv;
            cb_UseTransferIvForSnipe.Checked = _globalSettings.UseTransferIvForSnipe;
            cb_RenamePokemon.Checked = _globalSettings.RenamePokemon;
            cb_RenameOnlyAboveIv.Checked = _globalSettings.RenameOnlyAboveIv;
            tb_RenameTemplate.Text = _globalSettings.RenameTemplate.ToString();
            nUD_MaxPokeballsPerPokemon.Value = Convert.ToInt32(_globalSettings.MaxPokeballsPerPokemon);
            nUD_MaxTravelDistanceInMeters.Value = Convert.ToInt32(_globalSettings.MaxTravelDistanceInMeters);
            nUD_TotalAmountOfPokebalsToKeep.Value = Convert.ToInt32(_globalSettings.TotalAmountOfPokebalsToKeep);
            nUD_TotalAmountOfPotionsToKeep.Value = Convert.ToInt32(_globalSettings.TotalAmountOfPotionsToKeep);
            nUD_TotalAmountOfRevivesToKeep.Value = Convert.ToInt32(_globalSettings.TotalAmountOfRevivesToKeep);
            nUD_UseGreatBallAboveCp.Value = Convert.ToInt32(_globalSettings.UseGreatBallAboveCp);
            nUD_UseUltraBallAboveCp.Value = Convert.ToInt32(_globalSettings.UseUltraBallAboveCp);
            nUD_UseMasterBallAboveCp.Value = Convert.ToInt32(_globalSettings.UseMasterBallAboveCp);
            nUD_UseGreatBallAboveIv.Value = Convert.ToInt32(_globalSettings.UseGreatBallAboveIv);
            nUD_UseUltraBallAboveIv.Value = Convert.ToInt32(_globalSettings.UseUltraBallAboveIv);
            nUD_UseGreatBallBelowCatchProbability.Value = Convert.ToInt32(_globalSettings.UseGreatBallBelowCatchProbability * 100);
            nUD_UseUltraBallBelowCatchProbability.Value = Convert.ToInt32(_globalSettings.UseUltraBallBelowCatchProbability * 100);
            nUD_UseMasterBallBelowCatchProbability.Value = Convert.ToInt32(_globalSettings.UseMasterBallBelowCatchProbability * 100);
            cb_TransferDuplicatePokemon.Checked = _globalSettings.TransferDuplicatePokemon;
            nUD_FavoriteMinIvPercentage.Value = Convert.ToInt32(_globalSettings.FavoriteMinIvPercentage);
            cb_AutoFavoritePokemon.Checked = _globalSettings.AutoFavoritePokemon;
            cb_UsePokemonToNotCatchFilter.Checked = _globalSettings.UsePokemonToNotCatchFilter;
            nUD_WebSocketPort.Value = Convert.ToInt32(_globalSettings.WebSocketPort);


            if (_globalSettings.Auth.AuthType.Equals(AuthType.Ptc))
            {
                radioPTC.Checked = true;
                username.Text = _globalSettings.Auth.PtcUsername;
                password.Text = _globalSettings.Auth.PtcPassword;
            }
            else
            {
                radioGoogle.Checked = true;
                username.Text = _globalSettings.Auth.GoogleUsername;
                password.Text = _globalSettings.Auth.GooglePassword;
            }

        }

        private void LauncherForm_Load(object sender, EventArgs e)
        {
            loadSettings();

            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            gMapControl1.Manager.Mode = AccessMode.ServerOnly;
            GMapProvider.WebProxy = null;
            gMapControl1.Position = new PointLatLng(double.Parse(_globalSettings.DefaultLatitude.ToString().Replace(",", "."), CultureInfo.InvariantCulture), double.Parse(_globalSettings.DefaultLongitude.ToString().Replace(",", "."), CultureInfo.InvariantCulture));
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CenterPen = new Pen(Color.Red, 2);
            gMapControl1.MinZoom = trackBar.Maximum = 1;
            gMapControl1.MaxZoom = trackBar.Maximum = 20;
            trackBar.Value = 10;
            gMapControl1.Zoom = trackBar.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            b_StartNecroBot.Enabled = false;
            _globalSettings.TranslationLanguageCode = cb_TranslationLanguageCode.Text.ToLower();
            _globalSettings.AutoUpdate = cb_AutoUpdate.Checked;
            _globalSettings.TransferConfigAndAuthOnUpdate = cb_TransferConfigAndAuthOnUpdate.Checked;
            _globalSettings.StartupWelcomeDelay = cb_StartupWelcomeDelay.Checked;
            _globalSettings.AmountOfPokemonToDisplayOnStart = Convert.ToInt32(nUD_AmountOfPokemonToDisplayOnStart.Value);
            _globalSettings.ShowPokeballCountsBeforeRecycle = cb_ShowPokeballCountsBeforeRecycle.Checked;
            _globalSettings.AutomaticallyLevelUpPokemon = cb_AutomaticallyLevelUpPokemon.Checked;
            _globalSettings.AmountOfTimesToUpgradeLoop = Convert.ToInt32(nUD_AmountOfTimesToUpgradeLoop.Value);
            _globalSettings.GetMinStarDustForLevelUp = Convert.ToInt32(nUD_GetMinStarDustForLevelUp.Value);
            if (cb_LevelUpByCPorIv.Checked)
                _globalSettings.LevelUpByCPorIv = "iv";
            else
                _globalSettings.LevelUpByCPorIv = "cp";
            _globalSettings.UpgradePokemonCpMinimum = Convert.ToSingle(nUD_UpgradePokemonCpMinimum.Value);
            _globalSettings.UpgradePokemonIvMinimum = Convert.ToSingle(nUD_UpgradePokemonIvMinimum.Value);
            _globalSettings.DisableHumanWalking = cb_DisableHumanWalking.Checked;
            _globalSettings.DefaultAltitude = Convert.ToDouble(nUD_DefaultAltitude.Value);
            _globalSettings.DefaultLatitude = Convert.ToDouble(tb_DefaultLatitude.Text);
            _globalSettings.DefaultLongitude = Convert.ToDouble(tb_DefaultLongitude.Text);
            _globalSettings.WalkingSpeedInKilometerPerHour = Convert.ToDouble(nUD_WalkingSpeedInKilometerPerHour.Value);
            _globalSettings.MaxSpawnLocationOffset = Convert.ToInt32(nUD_MaxSpawnLocationOffset.Value);
            _globalSettings.DelayBetweenPlayerActions = Convert.ToInt32(nUD_DelayBetweenPlayerActions.Value);
            _globalSettings.DelayBetweenPokemonCatch = Convert.ToInt32(nUD_DelayBetweenPokemonCatch.Value);
            _globalSettings.DumpPokemonStats = cb_DumpPokemonStats.Checked;
            _globalSettings.EvolveAboveIvValue = Convert.ToSingle(nUD_EvolveAboveIvValue.Value);
            _globalSettings.EvolveAllPokemonAboveIv = cb_EvolveAllPokemonAboveIv.Checked;
            _globalSettings.EvolveAllPokemonWithEnoughCandy = cb_EvolveAllPokemonWithEnoughCandy.Checked;
            _globalSettings.KeepPokemonsThatCanEvolve = cb_KeepPokemonsThatCanEvolve.Checked;
            _globalSettings.EvolveKeptPokemonsAtStorageUsagePercentage = Convert.ToDouble(nUD_EvolveKeptPokemonsAtStorageUsagePercentage.Value) / 100;
            _globalSettings.UseGpxPathing = cb_UseGpxPathing.Checked;
            _globalSettings.GpxFile = tb_GpxFile.Text;
            _globalSettings.VerboseRecycling = cb_VerboseRecycling.Checked;
            _globalSettings.RecycleInventoryAtUsagePercentage = Convert.ToSingle(nUD_RecycleInventoryAtUsagePercentag.Value) / 100;
            _globalSettings.KeepMinCp = Convert.ToInt32(nUD_KeepMinCp.Value);
            _globalSettings.KeepMinDuplicatePokemon = Convert.ToInt32(nUD_KeepMinDuplicatePokemon.Value);
            _globalSettings.KeepMinIvPercentage = Convert.ToSingle(nUD_KeepMinIvPercentage.Value);
            _globalSettings.PrioritizeIvOverCp = cb_PrioritizeIvOverCp.Checked;
            _globalSettings.UseEggIncubators = cb_UseEggIncubators.Checked;
            _globalSettings.UseLuckyEggConstantly = cb_UseLuckyEggConstantly.Checked;
            _globalSettings.UseLuckyEggsMinPokemonAmount = Convert.ToInt32(nUD_UseLuckyEggsMinPokemonAmount.Value);
            _globalSettings.UseLuckyEggsWhileEvolving = cb_UseLuckyEggsWhileEvolving.Checked;
            _globalSettings.UseIncenseConstantly = cb_UseIncenseConstantly.Checked;
            _globalSettings.UseSnipeOnlineLocationServer = cb_UseSnipeOnlineLocationServer.Checked;
            _globalSettings.UseSnipeLocationServer = cb_UseSnipeLocationServer.Checked;
            _globalSettings.SnipeLocationServer = tb_SnipeLocationServer.Text;
            _globalSettings.SnipeLocationServerPort = Convert.ToInt32(nUD_SnipeLocationServerPort.Value);
            _globalSettings.MinPokeballsToSnipe = Convert.ToInt32(nUD_MinPokeballsToSnipe.Value);
            _globalSettings.MinPokeballsWhileSnipe = Convert.ToInt32(nUD_MinPokeballsWhileSnipe.Value);
            _globalSettings.MinDelayBetweenSnipes = Convert.ToInt32(nUD_MinDelayBetweenSnipes.Value);
            _globalSettings.SnipingScanOffset = Convert.ToDouble(tb_SnipingScanOffset.Text);
            _globalSettings.SnipeAtPokestops = cb_SnipeAtPokestops.Checked;
            _globalSettings.SnipeIgnoreUnknownIv = cb_SnipeIgnoreUnknownIv.Checked;
            _globalSettings.UseTransferIvForSnipe = cb_UseTransferIvForSnipe.Checked;
            _globalSettings.RenamePokemon = cb_RenamePokemon.Checked;
            _globalSettings.RenameOnlyAboveIv = cb_RenameOnlyAboveIv.Checked;
            _globalSettings.RenameTemplate = tb_RenameTemplate.Text;
            _globalSettings.MaxPokeballsPerPokemon = Convert.ToInt32(nUD_MaxPokeballsPerPokemon.Value);
            _globalSettings.MaxTravelDistanceInMeters = Convert.ToInt32(nUD_MaxTravelDistanceInMeters.Value);
            _globalSettings.TotalAmountOfPokebalsToKeep = Convert.ToInt32(nUD_TotalAmountOfPokebalsToKeep.Value);
            _globalSettings.TotalAmountOfPotionsToKeep = Convert.ToInt32(nUD_TotalAmountOfPotionsToKeep.Value);
            _globalSettings.TotalAmountOfRevivesToKeep = Convert.ToInt32(nUD_TotalAmountOfRevivesToKeep.Value);
            _globalSettings.UseGreatBallAboveCp = Convert.ToInt32(nUD_UseGreatBallAboveCp.Value);
            _globalSettings.UseUltraBallAboveCp = Convert.ToInt32(nUD_UseGreatBallAboveIv.Value);
            _globalSettings.UseMasterBallAboveCp = Convert.ToInt32(nUD_UseMasterBallAboveCp.Value);
            _globalSettings.UseGreatBallAboveIv = Convert.ToInt32(nUD_UseGreatBallAboveIv.Value);
            _globalSettings.UseUltraBallAboveIv = Convert.ToInt32(nUD_UseUltraBallAboveIv.Value);
            _globalSettings.UseGreatBallBelowCatchProbability = Convert.ToDouble(nUD_UseGreatBallBelowCatchProbability.Value) /100;
            _globalSettings.UseUltraBallBelowCatchProbability = Convert.ToDouble(nUD_UseUltraBallBelowCatchProbability.Value) /100;
            _globalSettings.UseMasterBallBelowCatchProbability = Convert.ToDouble(nUD_UseMasterBallBelowCatchProbability.Value) /100;
            _globalSettings.TransferDuplicatePokemon = cb_TransferDuplicatePokemon.Checked;
            _globalSettings.FavoriteMinIvPercentage = Convert.ToSingle(nUD_FavoriteMinIvPercentage.Value);
            _globalSettings.AutoFavoritePokemon = cb_AutoFavoritePokemon.Checked;
            _globalSettings.UsePokemonToNotCatchFilter = cb_UsePokemonToNotCatchFilter.Checked;
            _globalSettings.WebSocketPort = Convert.ToInt32(nUD_WebSocketPort.Value);



            if (radioPTC.Checked == true)
            {
                _globalSettings.Auth.AuthType = AuthType.Ptc;
                _globalSettings.Auth.PtcUsername = username.Text;
                _globalSettings.Auth.PtcPassword = password.Text;
            }
            else
            {
                _globalSettings.Auth.AuthType = AuthType.Google;
                _globalSettings.Auth.GoogleUsername = username.Text;
                _globalSettings.Auth.GooglePassword = password.Text;
            }


            _globalSettings.Save(_path + "\\config\\config.json");
            _globalSettings.Auth.Save(_path + "\\config\\auth.json");


            if (NecroBot != "")
            {
                Process.Start(NecroBot);
                this.Close();
            }

            b_StartNecroBot.Enabled = true;
        }

        private void btnReloadSettings_Click(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void FindAdressButton_Click(object sender, EventArgs e)
        {

            gMapControl1.SetPositionByKeywords(l_AdressBox.Text);
            gMapControl1.Zoom += 2;
            trackBar.Value = Convert.ToInt32(gMapControl1.Zoom);
            double X = Math.Round(gMapControl1.Position.Lng, 6);
            double Y = Math.Round(gMapControl1.Position.Lat, 6);
            string longitude = X.ToString();
            string latitude = Y.ToString();
            tb_DefaultLatitude.Text = latitude;
            tb_DefaultLongitude.Text = longitude;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            gMapControl1.Zoom = trackBar.Value;
        }


        private void gMapControl1_DoubleClick(object sender, MouseEventArgs e)
        {
            Point localCoordinates = e.Location;
            gMapControl1.Position = gMapControl1.FromLocalToLatLng(localCoordinates.X, localCoordinates.Y);

            if (e.Clicks >= 2)
            {
                gMapControl1.Zoom += 5;
            }

            double X = Math.Round(gMapControl1.Position.Lng, 6);
            double Y = Math.Round(gMapControl1.Position.Lat, 6);
            string longitude = X.ToString();
            string latitude = Y.ToString();
            tb_DefaultLatitude.Text = latitude;
            tb_DefaultLongitude.Text = longitude;
        }


    }
}
