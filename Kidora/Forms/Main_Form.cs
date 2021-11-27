using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kidora_Tool
{
    public partial class Main_Form : Form
    {
        string DateTi = DateTime.Now.ToString("yyyy/MM/dd hh-mm");
        public static bool MouseDwn = false;
        public Point LastLocation;
        public Main_Form()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            Panel_AddSilk.BringToFront();
            Deafult();

            Btn_addSilk.LineLeft = 20;
            Btn_addSilk.ForeColor = Color.Goldenrod;
            Btn_addSilk.BaseColor = Color.FromArgb(30, 30, 30);

            Btn_Guild_AddSilk.LineLeft = 0;
            Btn_Guild_AddSilk.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_Guild_AddSilk.BaseColor = Color.FromArgb(60, 60, 60);

            Btn_AddItems.LineLeft = 0;
            Btn_AddItems.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_AddItems.BaseColor = Color.FromArgb(60, 60, 60);

            Btn_Lock_UnLock.LineLeft = 0;
            Btn_Lock_UnLock.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_Lock_UnLock.BaseColor = Color.FromArgb(60, 60, 60);

            Btn_Ban_UnBan.LineLeft = 0;
            Btn_Ban_UnBan.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_Ban_UnBan.BaseColor = Color.FromArgb(60, 60, 60);
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            Panel_AddItems.BringToFront();
            Deafult();

            Btn_AddItems.LineLeft = 20;
            Btn_AddItems.ForeColor = Color.Goldenrod;
            Btn_AddItems.BaseColor = Color.FromArgb(30, 30, 30);

            Btn_addSilk.LineLeft = 0;
            Btn_addSilk.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_addSilk.BaseColor = Color.FromArgb(60, 60, 60);

            Btn_Guild_AddSilk.LineLeft = 0;
            Btn_Guild_AddSilk.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_Guild_AddSilk.BaseColor = Color.FromArgb(60, 60, 60);

            Btn_Lock_UnLock.LineLeft = 0;
            Btn_Lock_UnLock.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_Lock_UnLock.BaseColor = Color.FromArgb(60, 60, 60);

            Btn_Ban_UnBan.LineLeft = 0;
            Btn_Ban_UnBan.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_Ban_UnBan.BaseColor = Color.FromArgb(60, 60, 60);
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            Panel_Lock_UnLock.BringToFront();
            Deafult();

            Btn_Lock_UnLock.LineLeft = 20;
            Btn_Lock_UnLock.ForeColor = Color.Goldenrod;
            Btn_Lock_UnLock.BaseColor = Color.FromArgb(30, 30, 30);

            Btn_addSilk.LineLeft = 0;
            Btn_addSilk.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_addSilk.BaseColor = Color.FromArgb(60, 60, 60);

            Btn_Guild_AddSilk.LineLeft = 0;
            Btn_Guild_AddSilk.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_Guild_AddSilk.BaseColor = Color.FromArgb(60, 60, 60);

            Btn_AddItems.LineLeft = 0;
            Btn_AddItems.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_AddItems.BaseColor = Color.FromArgb(60, 60, 60);

            Btn_Ban_UnBan.LineLeft = 0;
            Btn_Ban_UnBan.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_Ban_UnBan.BaseColor = Color.FromArgb(60, 60, 60);
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            Panel_BanUnBan.BringToFront();
            Deafult();

            Btn_Ban_UnBan.LineLeft = 20;
            Btn_Ban_UnBan.ForeColor = Color.Goldenrod;
            Btn_Ban_UnBan.BaseColor = Color.FromArgb(30, 30, 30);

            Btn_addSilk.LineLeft = 0;
            Btn_addSilk.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_addSilk.BaseColor = Color.FromArgb(60, 60, 60);

            Btn_Guild_AddSilk.LineLeft = 0;
            Btn_Guild_AddSilk.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_Guild_AddSilk.BaseColor = Color.FromArgb(60, 60, 60);

            Btn_AddItems.LineLeft = 0;
            Btn_AddItems.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_AddItems.BaseColor = Color.FromArgb(60, 60, 60);

            Btn_Lock_UnLock.LineLeft = 0;
            Btn_Lock_UnLock.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_Lock_UnLock.BaseColor = Color.FromArgb(60, 60, 60);
        }

        private void gunaLineTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Silk_SilkWin.Text.Equals("Silk Amount") || Txt_Silk_SilkWin.Text.StartsWith(" "))
            {
                Txt_Silk_SilkWin.Text = "Silk Amount";
                Txt_Silk_SilkWin.ForeColor = Color.DarkGray;
            }
        }

        private void Txt_Char_SilkWin_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Char_SilkWin.Text.Equals("CharName") || Txt_Char_SilkWin.Text.StartsWith(" "))
            {
                Txt_Char_SilkWin.Text = "CharName";
                Txt_Char_SilkWin.ForeColor = Color.DarkGray;
            }
        }

        private void Btn_Guild_AddSilk_Click(object sender, EventArgs e)
        {
            DataGrid_SilkToGuild.BringToFront();
            Deafult();

            Btn_Guild_AddSilk.LineLeft = 20;
            Btn_Guild_AddSilk.ForeColor = Color.Goldenrod;
            Btn_Guild_AddSilk.BaseColor = Color.FromArgb(30, 30, 30);

            Btn_addSilk.LineLeft = 0;
            Btn_addSilk.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_addSilk.BaseColor = Color.FromArgb(60, 60, 60);

            Btn_Lock_UnLock.LineLeft = 0;
            Btn_Lock_UnLock.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_Lock_UnLock.BaseColor = Color.FromArgb(60, 60, 60);

            Btn_AddItems.LineLeft = 0;
            Btn_AddItems.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_AddItems.BaseColor = Color.FromArgb(60, 60, 60);

            Btn_Ban_UnBan.LineLeft = 0;
            Btn_Ban_UnBan.ForeColor = Color.FromArgb(30, 30, 30);
            Btn_Ban_UnBan.BaseColor = Color.FromArgb(60, 60, 60);
        }

        private void Txt_ID_SilkWin_TextChanged(object sender, EventArgs e)
        {
            if (Txt_ID_SilkWin.Text.Equals("ID") || Txt_ID_SilkWin.Text.StartsWith(" "))
            {
                Txt_ID_SilkWin.Text = "ID";
                Txt_ID_SilkWin.ForeColor = Color.DarkGray;
            }
        }

        private void Panel_AddSilk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_Char_SilkWin_Enter(object sender, EventArgs e)
        {
            if (Txt_Char_SilkWin.Text.Equals("CharName"))
            {
                Txt_Char_SilkWin.Clear();
                Txt_Char_SilkWin.ForeColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void Txt_Char_SilkWin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Char_SilkWin.Text))
            {
                Txt_Char_SilkWin.Text = "CharName";
                Txt_Char_SilkWin.ForeColor = Color.DarkGray;
            }
        }

        private void Txt_ID_SilkWin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_ID_SilkWin.Text))
            {
                Txt_ID_SilkWin.Text = "ID";
                Txt_ID_SilkWin.ForeColor = Color.DarkGray;
            }
        }

        private void Txt_ID_SilkWin_Enter(object sender, EventArgs e)
        {
            if (Txt_ID_SilkWin.Text.Equals("ID"))
            {
                Txt_ID_SilkWin.Clear();
                Txt_ID_SilkWin.ForeColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void Txt_Silk_SilkWin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Silk_SilkWin.Text))
            {
                Txt_Silk_SilkWin.Text = "Silk Amount";
                Txt_Silk_SilkWin.ForeColor = Color.DarkGray;
            }
        }

        private void Txt_Silk_SilkWin_Enter(object sender, EventArgs e)
        {
            if (Txt_Silk_SilkWin.Text.Equals("Silk Amount"))
            {
                Txt_Silk_SilkWin.Clear();
                Txt_Silk_SilkWin.ForeColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void Deafult()
        {

            Txt_Char_SilkWin.Text = "CharName";
            Txt_Char_SilkWin.ForeColor = Color.DarkGray;
            Txt_ID_SilkWin.Text = "ID";
            Txt_ID_SilkWin.ForeColor = Color.DarkGray;
            Txt_Silk_SilkWin.Text = "Silk Amount";
            Txt_Silk_SilkWin.ForeColor = Color.DarkGray;
            Txt_GuildName.Text = "GuildName";
            Txt_GuildName.ForeColor = Color.DarkGray;
            Txt_SilkAmount.Text = "Silk Amount";
            Txt_SilkAmount.ForeColor = Color.DarkGray;
            gunaLineTextBox2.Text = "CharName";
            gunaLineTextBox2.ForeColor = Color.DarkGray;
            gunaLineTextBox1.Text = "ItemCode";
            gunaLineTextBox1.ForeColor = Color.DarkGray;
            gunaLineTextBox4.Text = "CharName";
            gunaLineTextBox6.Text = "Units / 1";
            gunaLineTextBox7.Text = "Plus / 1";
            gunaLineTextBox4.ForeColor = Color.DarkGray;
            gunaLineTextBox3.Text = "ID";
            gunaLineTextBox3.ForeColor = Color.DarkGray;
            gunaLineTextBox5.Text = "CharName";
            gunaLineTextBox5.ForeColor = Color.DarkGray;
            gunaCheckBox1.Checked = false;
            gunaCheckBox2.Checked = false;
            gunaCheckBox3.Checked = false;
            gunaCheckBox4.Checked = false;
        }
        private void Btn_Clear_SilkWin_Click(object sender, EventArgs e)
        {
            Deafult();
            DataGrid_Logs.Rows.Clear();
        }

        private void Txt_SilkAmount_Enter(object sender, EventArgs e)
        {
            if (Txt_SilkAmount.Text.Equals("Silk Amount"))
            {
                Txt_SilkAmount.Clear();
                Txt_SilkAmount.ForeColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void Txt_SilkAmount_TextChanged(object sender, EventArgs e)
        {
            if (Txt_ID_SilkWin.Text.Equals("Silk Amount"))
            {
                Txt_ID_SilkWin.ForeColor = Color.DarkGray;
            }
        }

        private void Txt_SilkAmount_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_SilkAmount.Text))
            {
                Txt_SilkAmount.Text = "Silk Amount";
                Txt_SilkAmount.ForeColor = Color.DarkGray;
            }
        }

        private void Txt_GuildName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_GuildName.Text))
            {
                Txt_GuildName.Text = "GuildName";
                Txt_GuildName.ForeColor = Color.DarkGray;
            }
        }

        private void Txt_GuildName_TextChanged(object sender, EventArgs e)
        {
            if (Txt_GuildName.Text.Equals("GuildName"))
            {
                Txt_GuildName.ForeColor = Color.DarkGray;
            }
        }

        private void Txt_GuildName_Enter(object sender, EventArgs e)
        {
            if (Txt_GuildName.Text.Equals("GuildName"))
            {
                Txt_GuildName.Clear();
                Txt_GuildName.ForeColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void gunaLineTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (gunaLineTextBox2.Text.Equals("CharName"))
            {
                gunaLineTextBox2.ForeColor = Color.DarkGray;
            }
        }

        private void gunaLineTextBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gunaLineTextBox2.Text))
            {
                gunaLineTextBox2.Text = "CharName";
                gunaLineTextBox2.ForeColor = Color.DarkGray;
            }
        }

        private void gunaLineTextBox2_Enter(object sender, EventArgs e)
        {
            if (gunaLineTextBox2.Text.Equals("CharName"))
            {
                gunaLineTextBox2.Clear();
                gunaLineTextBox2.ForeColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (gunaLineTextBox2.Text.Equals("ItemCode"))
            {
                gunaLineTextBox2.ForeColor = Color.DarkGray;
            }
        }

        private void gunaLineTextBox1_Enter(object sender, EventArgs e)
        {
            if (gunaLineTextBox1.Text.Equals("ItemCode"))
            {
                gunaLineTextBox1.Clear();
                gunaLineTextBox1.ForeColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void gunaLineTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gunaLineTextBox1.Text))
            {
                gunaLineTextBox1.Text = "ItemCode";
                gunaLineTextBox1.ForeColor = Color.DarkGray;
            }
        }

        private void gunaLineTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (gunaLineTextBox4.Text.Equals("CharName"))
            {
                gunaLineTextBox4.ForeColor = Color.DarkGray;
            }
        }

        private void gunaLineTextBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gunaLineTextBox4.Text))
            {
                gunaLineTextBox4.Text = "CharName";
                gunaLineTextBox4.ForeColor = Color.DarkGray;
            }
        }

        private void gunaLineTextBox4_Enter(object sender, EventArgs e)
        {
            if (gunaLineTextBox4.Text.Equals("CharName"))
            {
                gunaLineTextBox4.Clear();
                gunaLineTextBox4.ForeColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void gunaCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void gunaCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void gunaLineTextBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (gunaLineTextBox3.Text.Equals("ID"))
            {
                gunaLineTextBox3.ForeColor = Color.DarkGray;
            }
        }

        private void gunaLineTextBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gunaLineTextBox3.Text))
            {
                gunaLineTextBox3.Text = "ID";
                gunaLineTextBox3.ForeColor = Color.DarkGray;
            }
        }

        private void gunaLineTextBox3_Enter(object sender, EventArgs e)
        {
            if (gunaLineTextBox3.Text.Equals("ID"))
            {
                gunaLineTextBox3.Clear();
                gunaLineTextBox3.ForeColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void gunaLineTextBox5_TextChanged(object sender, EventArgs e)
        {
            if (gunaLineTextBox5.Text.Equals("CharName"))
            {
                gunaLineTextBox5.ForeColor = Color.DarkGray;
            }
        }

        private void gunaLineTextBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gunaLineTextBox5.Text))
            {
                gunaLineTextBox5.Text = "CharName";
                gunaLineTextBox5.ForeColor = Color.DarkGray;
            }
        }

        private void gunaLineTextBox5_Enter(object sender, EventArgs e)
        {
            if (gunaLineTextBox5.Text.Equals("CharName"))
            {
                gunaLineTextBox5.Clear();
                gunaLineTextBox5.ForeColor = Color.FromArgb(60, 60, 60);
            }
        }
        public void refresh()
        {
            try
            {
                if (!File.Exists("Sql.ini"))
                {
                    StreamWriter sw = new StreamWriter("Sql.ini");
                    sw.WriteLine("Server:");
                    sw.WriteLine("ID:");
                    sw.WriteLine("PW:");
                    sw.WriteLine("Account_DB:");
                    sw.WriteLine("Shard_DB:");
                    sw.WriteLine("Proxy_DB:");
                    sw.Close();
                }
                else
                {
                    StreamReader sr = new StreamReader("Sql.ini");
                    Main_Qurys.Server = sr.ReadLine().Split(':')[1];
                    Main_Qurys.ID = sr.ReadLine().Split(':')[1];
                    Main_Qurys.pw = sr.ReadLine().Split(':')[1];
                    Main_Qurys.acc = sr.ReadLine().Split(':')[1];
                    Main_Qurys.shard = sr.ReadLine().Split(':')[1];
                    Main_Qurys.proxy = sr.ReadLine().Split(':')[1];
                    sr.Close();
                }
                Main_Qurys._Account = @"Data Source = " + Main_Qurys.Server + "; Initial Catalog = " + Main_Qurys.acc + "; User ID = " + Main_Qurys.ID + "; Password=" + Main_Qurys.pw;
                Main_Qurys._Shard = @"Data Source = " + Main_Qurys.Server + "; Initial Catalog = " + Main_Qurys.shard + "; User ID = " + Main_Qurys.ID + "; Password=" + Main_Qurys.pw;
                Main_Qurys._Proxy = @"Data Source = " + Main_Qurys.Server + "; Initial Catalog = " + Main_Qurys.proxy + "; User ID = " + Main_Qurys.ID + "; Password=" + Main_Qurys.pw;

                DataGrid_Logs.Rows.Add($"Refresh Successful AccountLink: {Main_Qurys._Account} ", "true", DateTi);
                DataGrid_Logs.Rows.Add($"Refresh Successful ShardLink: {Main_Qurys._Shard} ", "true", DateTi);
                DataGrid_Logs.Rows.Add($"Refresh Successful ProxyLink: {Main_Qurys._Proxy} ", "true", DateTi);
                return;
            }
            catch
            {
                DataGrid_Logs.Rows.Add($"Refresh Failed Server: [{Main_Qurys.Server}] ID: [ {Main_Qurys.ID} ] PW:[ {Main_Qurys.pw} ]  Acc:[ {Main_Qurys.acc} ]  Shard:[ {Main_Qurys.shard} ]  Proxy:[ {Main_Qurys.proxy} ]  ", "false", DateTi);
                return;
            }
        }
        private void Btn_Add_SilkWin_Click_1(object sender, EventArgs e)
        {
            if (Btn_addSilk.LineLeft.Equals(20))
            {
                //check number is digit
                foreach (char item in Txt_Silk_SilkWin.Text)
                {
                    if (!char.IsDigit(item))
                    {
                        return;
                    }
                }

                //Inser Silk By ID
                if (Txt_Char_SilkWin.Text == "CharName" && Txt_Silk_SilkWin.Text != "Silk Amount" && Txt_ID_SilkWin.Text != "ID")
                {
                    string User_ID = Main_Qurys.Reader(" Select JID from TB_User WHERE StrUserID = '" + Txt_ID_SilkWin.Text + "'", Main_Qurys._Account, 0, 0);
                    if (!string.IsNullOrEmpty(User_ID))
                    {
                        try
                        {
                            Main_Qurys.NonQuery("use SRO_VT_SHARD declare @UserName varchar(64) declare @SilkAmount varchar(64)  set @UserName  = '" + Txt_ID_SilkWin.Text + "' set @SilkAmount = '" + Txt_Silk_SilkWin.Text + "' exec [sro_vt_account].[cgi].[cgi_webpurchasesilk] @numsilk = @SilkAmount, @orderid = null, @pkgid = null, @price = null, @userid = @UserName", Main_Qurys._Shard);
                            DataGrid_Logs.Rows.Add($"insert [{Convert.ToInt16(Txt_Silk_SilkWin.Text)}] silks BY UserName [ {Txt_ID_SilkWin.Text} ]", "True", DateTi);
                            return;
                        }
                        catch
                        {
                            DataGrid_Logs.Rows.Add($"Failed to insert [ {Txt_ID_SilkWin.Text} ] Silks by CharName [ {Txt_Char_SilkWin.Text} ]", "false", DateTi);
                            return;
                        }
                    }
                }
                //Inser Silk By CharName
                else if (Txt_Char_SilkWin.Text != "CharName" && Txt_Silk_SilkWin.Text != "Silk Amount" && Txt_ID_SilkWin.Text == "ID")
                    try
                    {
                        Main_Qurys.NonQuery("use SRO_VT_SHARD declare @CharName16 varchar(64) declare @SilkAmount varchar(64) declare @UserName varchar(64) set @CharName16 = '" + Txt_Char_SilkWin.Text + "' set @SilkAmount = '" + Txt_Silk_SilkWin.Text + "' if exists (Select CharName16 from SRO_VT_SHARD.._Char where CharName16 = @CharName16) begin select @UserName = StrUserID from SRO_VT_ACCOUNT..TB_User u join SRO_VT_SHARD.._User ur on ur.UserJID = u.JID join SRO_VT_SHARD.._Char cr on cr.CharID = ur.CharID where CharName16 = @CharName16 exec [sro_vt_account].[cgi].[cgi_webpurchasesilk] null, @UserName, null, @price = null, @numsilk = @SilkAmount end", Main_Qurys._Shard);
                        DataGrid_Logs.Rows.Add($"insert [{Convert.ToInt16(Txt_Silk_SilkWin.Text)}] silks BY CharName [ {Txt_Char_SilkWin.Text} ]", "True", DateTi);
                        return;
                    }
                    catch
                    {
                        DataGrid_Logs.Rows.Add($"Failed to insert [ {Txt_ID_SilkWin.Text} ] Silks by CharName [ {Txt_Char_SilkWin.Text} ]", "false", DateTi);
                        return;
                    }
            }

            else if (Btn_Guild_AddSilk.LineLeft.Equals(20))
            {
                //check number is digit
                foreach (char item in Txt_SilkAmount.Text)
                {
                    if (!char.IsDigit(item))
                    {
                        return;
                    }
                }
                //Inser Silk By GuildName
                if (Txt_GuildName.Text != "GuildName" && Txt_SilkAmount.Text != "Silk Amount")
                {
                    try
                    {
                        string Guild_ID = Main_Qurys.Reader(" Select ID from _Guild WHERE Name = '" + Txt_GuildName.Text.Trim() + "'", Main_Qurys._Shard, 0, 0);
                        byte Members_Count = Convert.ToByte(Main_Qurys.Reader("SELECT COUNT(*)FROM _GuildMember where GuildID = " + Convert.ToInt32(Guild_ID) + "", Main_Qurys._Shard, 0, 0));

                        if (!string.IsNullOrEmpty(Guild_ID))
                        {
                            for (byte i = 0; i < Members_Count; i++)
                            {
                                string Member_Name = Main_Qurys.Reader("Select CharName from _GuildMember where GuildID = " + Convert.ToInt32(Guild_ID) + "", Main_Qurys._Shard, i, 0);
                                string Check = Main_Qurys.NonQuery("use SRO_VT_SHARD declare @CharName16 varchar(64) declare @SilkAmount varchar(64) declare @UserName varchar(64) set @CharName16 = '" + Member_Name + "' set @SilkAmount = '" + Txt_SilkAmount.Text + "' if exists (Select CharName16 from SRO_VT_SHARD.._Char where CharName16 = @CharName16) begin select @UserName = StrUserID from SRO_VT_ACCOUNT..TB_User u join SRO_VT_SHARD.._User ur on ur.UserJID = u.JID join SRO_VT_SHARD.._Char cr on cr.CharID = ur.CharID where CharName16 = @CharName16 exec [sro_vt_account].[cgi].[cgi_webpurchasesilk] null, @UserName, null, @price = null, @numsilk = @SilkAmount end", Main_Qurys._Shard);
                                DataGrid_Logs.Rows.Add($"insert [{Convert.ToInt32(Txt_SilkAmount.Text)}] silks to [{Member_Name}] BY GuildName [ {Txt_GuildName.Text} ]", Check, DateTi);
                            }
                        }
                    }
                    catch
                    {
                        DataGrid_Logs.Rows.Add($"Failed to insert [ {Txt_SilkAmount.Text} ] Silks BY GuildName [ {Txt_GuildName.Text} ] , Wrong GuildName", "false", DateTi);
                        return;
                    }

                }
            }

            else if (Btn_AddItems.LineLeft.Equals(20))
            {
                if (gunaLineTextBox2.Text != "CharName" && gunaLineTextBox1.Text != "ItemCode" && gunaLineTextBox6.Text != "Units / 1" && gunaLineTextBox7.Text != "Plus / 1")
                {
                    if (!Main_Qurys.Reader("select CharName16 from _Char where CharName16 = '" + gunaLineTextBox2.Text + "'", Main_Qurys._Shard, 0, 0).Equals(""))
                    {
                        string Check = Main_Qurys.NonQuery("exec _ADD_ITEM_EXTERN '" + gunaLineTextBox2.Text + "','" + gunaLineTextBox1.Text + "','" + gunaLineTextBox6.Text + "','" + gunaLineTextBox7.Text + "'", Main_Qurys._Shard);
                        DataGrid_Logs.Rows.Add($"Add Item [{gunaLineTextBox1.Text}] to [{gunaLineTextBox2.Text}] Has been Successful ", Check, DateTi);
                        return;
                    }
                    DataGrid_Logs.Rows.Add($"Failed to Add Item [{gunaLineTextBox1.Text}] to [{gunaLineTextBox2.Text}], Wrong CharName ", "false", DateTi);
                    return;
                }
            }

            else if (Btn_Lock_UnLock.LineLeft.Equals(20))
            {
                //Lock
                if (gunaLineTextBox4.Text != "CharName" && gunaCheckBox1.Checked == true && gunaCheckBox2.Checked == false)
                {
                    if (!Main_Qurys.Reader("select CharName16 from _Char where CharName16 = '" + gunaLineTextBox4.Text + "'", Main_Qurys._Shard, 0, 0).Equals(""))
                    {
                        string Check = Main_Qurys.NonQuery("delete from _lock where CharName16 = '" + gunaLineTextBox4.Text + "'; insert into _Lock values ('" + gunaLineTextBox4.Text + "', 01012454120, 1)", Main_Qurys._Proxy);
                        DataGrid_Logs.Rows.Add($"Lock [{gunaLineTextBox4.Text}] Has been Successful ", Check, DateTi);
                        return;
                    }
                    DataGrid_Logs.Rows.Add($"Failed to Lock [{gunaLineTextBox4.Text}] , Wrong CharName ", "false", DateTi);
                    return;
                }
                //UnLock
                else if (gunaLineTextBox4.Text != "CharName" && gunaCheckBox1.Checked == false && gunaCheckBox2.Checked == true)
                {
                    if (!Main_Qurys.Reader("select CharName16 from _Char where CharName16 = '" + gunaLineTextBox4.Text + "'", Main_Qurys._Shard, 0, 0).Equals(""))
                    {
                        string Check = Main_Qurys.NonQuery("delete from _lock where CharName16 = '" + gunaLineTextBox4.Text + "';", Main_Qurys._Proxy);
                        DataGrid_Logs.Rows.Add($"UnLock [{gunaLineTextBox4.Text}] Has been Successful ", Check, DateTi);
                        return;
                    }
                    DataGrid_Logs.Rows.Add($"Failed to UnLock [{gunaLineTextBox4.Text}] , Wrong CharName ", "false", DateTi);
                    return;
                }
            }

            else if (Btn_Ban_UnBan.LineLeft.Equals(20))
            {
                try
                {
                    //Ban By ID
                    if (gunaLineTextBox5.Text.Equals("CharName") && !string.IsNullOrEmpty(gunaLineTextBox3.Text) && gunaCheckBox3.Checked.Equals(false) && gunaCheckBox4.Checked.Equals(true))
                    {
                        int User_ID = Convert.ToInt32(Main_Qurys.Reader(" Select JID from TB_User WHERE StrUserID = '" + gunaLineTextBox3.Text + "'", Main_Qurys._Account, 0, 0));
                        if (!User_ID.Equals(""))
                        {
                            if (Main_Qurys.Reader("select UserJID from _Punishment where UserJID =" + Convert.ToInt32(User_ID) + "", Main_Qurys._Account, 0, 0).Equals(""))
                            {
                                string check = Main_Qurys.NonQuery("insert into _Punishment (UserJID,Type,Executor,Shard,CharName,CharInfo,PosInfo,Guide,Description,RaiseTime,BlockStartTime,BlockEndTime,PunishTime,Status) Values (" + Convert.ToInt32(User_ID) + ", '1', 'KidoraTool', '0', '', '', '','Banned By KidoraTool', 'Banned By KidoraTool', '" + DateTime.Now + "','" + DateTime.Now + "','2050-01-01','" + DateTime.Now + "', '0')",Main_Qurys._Account);
                                int SerialCode = Convert.ToInt32(Main_Qurys.Reader("select top 1 SerialNo from _Punishment order by SerialNo desc", Main_Qurys._Account, 0, 0));
                                string check2 = Main_Qurys.NonQuery("insert into _BlockedUser Values (" + Convert.ToInt32(User_ID) + ",'"+ gunaLineTextBox3.Text + "','1',"+SerialCode+",'" + DateTime.Now + "','2050-01-01' )", Main_Qurys._Account);
                                DataGrid_Logs.Rows.Add($"Ban User [{gunaLineTextBox3.Text}] has been Successful! ", check +" || "+ check2, DateTi);
                                return;
                            }
                            else { DataGrid_Logs.Rows.Add($"Ban User [{gunaLineTextBox3.Text}] has been failed, Already Banned! ", "false", DateTi); }
                            return;
                        }
                        else { DataGrid_Logs.Rows.Add($"Ban User [{gunaLineTextBox3.Text}] has been failed, Wrong ID! ", "false", DateTi); }
                        return;
                    }
                //Ban By CharName
                else if (!string.IsNullOrEmpty(gunaLineTextBox5.Text) && gunaLineTextBox3.Text.Equals("ID") && gunaCheckBox3.Checked.Equals(false) && gunaCheckBox4.Checked.Equals(true))
                    {
                        string User_ID = Main_Qurys.Reader(" declare @CharNameID varchar(64) set @CharNameID = ( Select CharID from _Char WHERE CharName16 = '" + gunaLineTextBox5.Text + "') Select UserJID from _User WHERE CharID =  @CharNameID", Main_Qurys._Shard, 0, 0);
                        string UserID = Main_Qurys.Reader("Select StrUserID from TB_User where JID = " + User_ID + "", Main_Qurys._Account, 0, 0);
                        if (!User_ID.Equals(""))
                        {
                            if (Main_Qurys.Reader("select UserJID from _Punishment where UserJID =" + Convert.ToInt32(User_ID) + "", Main_Qurys._Account, 0, 0).Equals(""))
                            {
                                string check = Main_Qurys.NonQuery("insert into _Punishment (UserJID,Type,Executor,Shard,CharName,CharInfo,PosInfo,Guide,Description,RaiseTime,BlockStartTime,BlockEndTime,PunishTime,Status) Values (" + Convert.ToInt32(User_ID) + ", '1', 'KidoraTool', '0', '', '', '','Banned By KidoraTool', 'Banned By KidoraTool', '" + DateTime.Now + "','" + DateTime.Now + "','2050-01-01','" + DateTime.Now + "', '0')", Main_Qurys._Account);
                                int SerialCode = Convert.ToInt32(Main_Qurys.Reader("select top 1 SerialNo from _Punishment order by SerialNo desc", Main_Qurys._Account, 0, 0));
                                string check2 = Main_Qurys.NonQuery("insert into _BlockedUser Values (" + Convert.ToInt32(User_ID) + ",'" + gunaLineTextBox3.Text + "','1'," + SerialCode + ",'" + DateTime.Now + "','2050-01-01' )", Main_Qurys._Account);
                                DataGrid_Logs.Rows.Add($"Ban User [{gunaLineTextBox5.Text}] has been Successful! ", check + " || " + check2, DateTi);
                                return;
                            }
                            else { DataGrid_Logs.Rows.Add($"Ban User [{gunaLineTextBox5.Text}] has been failed, Already Banned! ", "false", DateTi); }
                            return;
                        }
                        else { DataGrid_Logs.Rows.Add($"Ban User [{gunaLineTextBox5.Text}] has been failed, Wrong CharName! ", "false", DateTi); }
                        return;
                    }
                    //UnBan By ID
                    else if (gunaLineTextBox5.Text.Equals("CharName") && !string.IsNullOrEmpty(gunaLineTextBox3.Text) && gunaCheckBox3.Checked.Equals(true) && gunaCheckBox4.Checked.Equals(false))
                    {
                        string User_ID = Main_Qurys.Reader(" Select JID from TB_User WHERE StrUserID = '" + gunaLineTextBox3.Text + "'", Main_Qurys._Account, 0, 0);
                        if (!User_ID.Equals(""))
                        {
                            if (!Main_Qurys.Reader("select UserJID from _Punishment where UserJID =" + Convert.ToInt32(User_ID) + "", Main_Qurys._Account, 0, 0).Equals(""))
                            {
                                string check = Main_Qurys.NonQuery("delete from _Punishment where UserJID =  " + Convert.ToInt32(User_ID) + ";" +
                                                                   "delete from _BlockedUser where UserJID = " + Convert.ToInt32(User_ID) + "", Main_Qurys._Account);
                                DataGrid_Logs.Rows.Add($"UnBan User [{gunaLineTextBox3.Text}] has been Successful! ", check, DateTi);
                                return;
                            }
                            else { DataGrid_Logs.Rows.Add($"UnBan User [{gunaLineTextBox3.Text}] has been failed, User is Not Banned! ", "false", DateTi); }
                            return;
                        }
                        else { DataGrid_Logs.Rows.Add($"UnBan User [{gunaLineTextBox3.Text}] has been failed, Wrong ID! ", "false", DateTi); }
                        return;
                    }
                    //UnBan By CharName
                    else if (!string.IsNullOrEmpty(gunaLineTextBox5.Text) && gunaLineTextBox3.Text.Equals("ID") && gunaCheckBox3.Checked.Equals(true) && gunaCheckBox4.Checked.Equals(false))
                    {
                        string User_ID = Main_Qurys.Reader(" declare @CharNameID varchar(64) set @CharNameID = ( Select CharID from _Char WHERE CharName16 = '" + gunaLineTextBox5.Text + "') Select UserJID from _User WHERE CharID =  @CharNameID", Main_Qurys._Shard, 0, 0);
                        if (!User_ID.Equals(""))
                        {
                            if (!Main_Qurys.Reader("select UserJID from _Punishment where UserJID =" + Convert.ToInt32(User_ID) + "", Main_Qurys._Account, 0, 0).Equals(""))
                            {
                                string check = Main_Qurys.NonQuery("delete from _Punishment where UserJID = " + Convert.ToInt32(User_ID) + ";" +
                                                                   "delete from _BlockedUser where UserJID = " + Convert.ToInt32(User_ID) + "", Main_Qurys._Account);
                                DataGrid_Logs.Rows.Add($"UnBan User [{gunaLineTextBox5.Text}] has been Successful! ", check, DateTi);
                                return;
                            }
                            else { DataGrid_Logs.Rows.Add($"UnBan User [{gunaLineTextBox5.Text}] has been failed, User is Not Banned! ", "false", DateTi); }
                            return;
                        }
                        else { DataGrid_Logs.Rows.Add($"UnBan User [{gunaLineTextBox5.Text}] has been failed, Wrong CharName! ", "false", DateTi); }
                        return;
                    }
                }
                catch (Exception ex)
                {
                    DataGrid_Logs.Rows.Add($"Request Failed and returned false! ", "Reason: " + ex.Message, DateTi);
                    return;
                }
            }
        }

        private void gunaLineTextBox5_Enter_1(object sender, EventArgs e)
        {
            if (gunaLineTextBox5.Text.Equals("CharName"))
            {
                gunaLineTextBox5.Clear();
                gunaLineTextBox5.ForeColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void gunaLineTextBox6_TextChanged(object sender, EventArgs e)
        {
            if (gunaLineTextBox6.Text.Equals("Units / 1"))
            {
                gunaLineTextBox6.ForeColor = Color.DarkGray;
            }
        }

        private void gunaLineTextBox7_TextChanged(object sender, EventArgs e)
        {
            if (gunaLineTextBox7.Text.Equals("Plus / 1"))
            {
                gunaLineTextBox7.ForeColor = Color.DarkGray;
            }
        }

        private void gunaLineTextBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gunaLineTextBox6.Text))
            {
                gunaLineTextBox6.Text = "Units / 1";
                gunaLineTextBox6.ForeColor = Color.DarkGray;
            }
        }

        private void gunaLineTextBox7_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gunaLineTextBox7.Text))
            {
                gunaLineTextBox7.Text = "Plus / 1";
                gunaLineTextBox7.ForeColor = Color.DarkGray;
            }
        }

        private void gunaLineTextBox6_Enter(object sender, EventArgs e)
        {
            if (gunaLineTextBox6.Text.Equals("Units / 1"))
            {
                gunaLineTextBox6.Clear();
                gunaLineTextBox6.ForeColor = Color.FromArgb(60, 60, 60);
            }
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            #region ( Read )
            try
            {
                if (!File.Exists("Sql.ini"))
                {
                    StreamWriter sw = new StreamWriter("Sql.ini");
                    sw.WriteLine("Server:");
                    sw.WriteLine("ID:");
                    sw.WriteLine("PW:");
                    sw.WriteLine("Account_DB:");
                    sw.WriteLine("Shard_DB:");
                    sw.WriteLine("Proxy_DB:");
                    sw.Close();
                }
                else
                {
                    StreamReader sr = new StreamReader("Sql.ini");
                    Main_Qurys.Server = sr.ReadLine().Split(':')[1];
                    Main_Qurys.ID = sr.ReadLine().Split(':')[1];
                    Main_Qurys.pw = sr.ReadLine().Split(':')[1];
                    Main_Qurys.acc = sr.ReadLine().Split(':')[1];
                    Main_Qurys.shard = sr.ReadLine().Split(':')[1];
                    Main_Qurys.proxy = sr.ReadLine().Split(':')[1];
                    sr.Close();
                }
                Main_Qurys._Account = @"Data Source = " + Main_Qurys.Server + "; Initial Catalog = " + Main_Qurys.acc + "; User ID = " + Main_Qurys.ID + "; Password=" + Main_Qurys.pw;
                Main_Qurys._Shard = @"Data Source = " + Main_Qurys.Server + "; Initial Catalog = " + Main_Qurys.shard + "; User ID = " + Main_Qurys.ID + "; Password=" + Main_Qurys.pw;
                Main_Qurys._Proxy = @"Data Source = " + Main_Qurys.Server + "; Initial Catalog = " + Main_Qurys.proxy + "; User ID = " + Main_Qurys.ID + "; Password=" + Main_Qurys.pw;

                DataGrid_Logs.Rows.Add($"Successful Read AccountLink: {Main_Qurys._Account} ", "true", DateTi);
                DataGrid_Logs.Rows.Add($"Successful Read ShardLink: {Main_Qurys._Shard} ", "true", DateTi);
                DataGrid_Logs.Rows.Add($"Successful Read ProxyLink: {Main_Qurys._Proxy} ", "true", DateTi);
            }
            catch
            {
                DataGrid_Logs.Rows.Add($"Failed to Read AccountLink: {Main_Qurys._Account} ", "true", DateTi);
                DataGrid_Logs.Rows.Add($"Failed to Read ShardLink: {Main_Qurys._Shard} ", "true", DateTi);
                DataGrid_Logs.Rows.Add($"Failed to Read ProxyLink: {Main_Qurys._Proxy} ", "true", DateTi);

            }
            #endregion 
            Btn_addSilk.PerformClick();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDwn)
            {
                int Newx = (this.Location.X - LastLocation.X) + e.X;
                int Newy = (this.Location.Y - LastLocation.Y) + e.Y;
                this.Location = new Point(Newx, Newy);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDwn = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDwn = true;
            LastLocation = e.Location;
        }

        private void gunaLineTextBox7_Enter_1(object sender, EventArgs e)
        {
            if (gunaLineTextBox7.Text.Equals("Plus / 1"))
            {
                gunaLineTextBox7.Clear();
                gunaLineTextBox7.ForeColor = Color.FromArgb(60, 60, 60);
            }
        }
    }
}
