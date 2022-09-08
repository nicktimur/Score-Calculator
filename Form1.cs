using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Linq.Expressions;
using System.Net.NetworkInformation;

namespace Not_Hesaplayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //path of data base
        string path = "database.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\database.db"; //database creat debug folder

        SQLiteDataReader dr;
        string lang = "TR";
        private void data_show()
        {
            var baglan = new SQLiteConnection(cs);
            baglan.Open();

            string stm = "SELECT * FROM data";
            var cmd = new SQLiteCommand(stm, baglan);
            dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetFloat(3));
                }
            }

            finally
            {
                dr.Close();
                baglan.Close();
            }

        }
        private int puan_hesapla(string SınavCevap, string OgrenciCevap)
        {

            int d = 0;
            int y = 0;
            int S = OgrenciCevap.Length;
            for (int i = 0; i < S; i++)
            {
                if (OgrenciCevap[i] == SınavCevap[i])
                {
                    d++;
                }
                else
                {
                    y++;
                }
            }
            int a = (100 / S);
            return a*d;
        }

        private void orta()
        {
            try
            {
                var baglan = new SQLiteConnection(cs);
                baglan.Open();

                string stm = "SELECT Score FROM data";
                var cmd = new SQLiteCommand(stm, baglan);
                dr = cmd.ExecuteReader();
                
                int toplamnot = 0;
                int ogrenci = 0;
                try
                {
                    while (dr.Read())
                    {
                        ogrenci++;
                        toplamnot += Int32.Parse(dr["Score"].ToString());
                    }
                    float ortalamaa = toplamnot / ogrenci;
                    ort.Text = ortalamaa.ToString();
                }

                finally
                {
                    dr.Close();
                    baglan.Close();
                }

            }
            catch (Exception)
            {
                if (lang == "TR")
                {
                    ort.Text = "Öğrenci Yok";
                }
                else
                {
                    ort.Text = "No Student";
                }
            }
        }

        private float enyukseknot()
        {
            var baglan = new SQLiteConnection(cs);
            baglan.Open();

            string stm = "SELECT Score FROM data";
            var cmd = new SQLiteCommand(stm, baglan);
            dr = cmd.ExecuteReader();
            float yukseknot = 0;
            while (dr.Read())
            {
               if (Int32.Parse(dr["Score"].ToString()) > yukseknot)
               {
                        yukseknot = float.Parse(dr["Score"].ToString());
               }
            }
            dr.Close();
            baglan.Close();
            return yukseknot;
        }
        private void enyukseknot2(float yukseknot)
        {
            var baglan = new SQLiteConnection(cs);
            baglan.Open();

            string stm = "SELECT NameSurname FROM data WHERE Score=" + yukseknot;
            var cmd = new SQLiteCommand(stm, baglan);
            dr = cmd.ExecuteReader();
            string isimler = "";
            while (dr.Read())
            {
                isimler = isimler + dr["NameSurname"] + ",";
            }
            if (isimler == "")
            {
                if (lang == "TR")
                {
                    isim2.Text = "Öğrenci Yok";
                }
                else
                {
                    isim2.Text = "No Student";
                }
            }
            else
            {
                isim2.Text = isimler;
            }
            dr.Close();
            baglan.Close();
        }

        private bool IsAvailable(string name, string cevap)
        {
            var baglan = new SQLiteConnection(cs);
            baglan.Open();

            string stm = "SELECT NameSurname FROM data";
            var cmd = new SQLiteCommand(stm, baglan);
            dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    if (dr["NameSurname"].ToString() == name)
                    {
                        dr.Close();
                        baglan.Close();
                        return IsAvailable2(name, cevap);
                    }

                }
            }
            finally
            {
                dr.Close();
                baglan.Close();
            }
            return true;
        }

        private bool IsAvailable2(string name, string cevap)
        {
            var baglan = new SQLiteConnection(cs);
            baglan.Open();
            string stm = "SELECT TestAnswers FROM data WHERE NameSurname="+ "'" + name + "'";
            var cmd = new SQLiteCommand(stm, baglan);
            dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    if (dr["TestAnswers"].ToString() == cevap)
                    {
                        if (lang == "TR")
                        {
                            MessageBox.Show("Bu öğrenci çoktan bu sınava girmiş.", "Hata", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("This student already took this exam.", "Error", MessageBoxButtons.OK);
                        }
                        dr.Close();
                        baglan.Close();
                        return false;
                    }

                }
            }
            finally
            {
                dr.Close();
                baglan.Close();
            }
            return true;
        }
        
        private bool keyctrl(string cevap)
        {
            if (cevap == "")
            {
                if (lang == "TR")
                {
                    MessageBox.Show("Cevap anahtarları boş.", "Hata", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Answer boxes are empty.", "Error", MessageBoxButtons.OK);
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool Ogrenci_lenctrl(int S, string OgrenciCevap)
        {
            if (OgrenciCevap.Length == S)
            {
                return true;
            }
            else
            {
                if (lang == "TR")
                {
                    MessageBox.Show("Soru Sayısı ve öğrencinin cevap anahtarı uzunluğu eşit değil.", "Hata", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    MessageBox.Show("Answer Key's lenght and Student's Answers lenght is not the same.", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
        }
        
        private bool Name_ctrl(string isim)
        {
            if (isim != null & isim != "" & isim != " ")
            {
                return true;
            }
            else
            {
                if (lang == "TR")
                {
                    MessageBox.Show("Lütfen isim kutusunu boş bırakmayınız.", "Hata", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    MessageBox.Show("Please do not leave Namebox blank.", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
        }

        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table data(NameSurname TEXT, Answers TEXT, TestAnswers TEXT, Score INT)";
                    SQLiteCommand command = new SQLiteCommand(sql,sqlite);
                    command.ExecuteNonQuery();
                    sqlite.Close();
                }
            }
            else
            {
                return;
            }
        }
        private void changeTR()
        {
            lang = "TR";
            this.Text = "Puan Hesaplayıcı";
            label1.Text = "Sınav Bilgileri";
            label2.Text = "Öğrencilerin Ortalaması:";
            label3.Text = "Cevap Anahtarı:";
            label4.Text = "Öğrenci Bilgileri";
            label5.Text = "Adı Soyadı:";
            label7.Text = "En yüksek notu alan kişi/ kişiler::";
            label6.Text = "Cevapları:";
            label8.Text = "Detaylar";
            Insert.Text = "Öğrenci Ekle";
            Update.Text = "Cevabı Düzenle";
            Delete.Text = "Öğrenci Sil";
            dataGridView1.Columns[0].HeaderText = "Adı Soyadı";
            dataGridView1.Columns[1].HeaderText = "Cevapları";
            dataGridView1.Columns[2].HeaderText = "Sınavı'nın Cevap Anahtarı";
            dataGridView1.Columns[3].HeaderText = "Puanı";
            isim2.Location = new Point(197, 409);
            isim2.Size = new Size(230, 20);
            CevapAnahtarı.Location = new Point(107, 76);
            CevapAnahtarı.Size = new Size(302, 20);
            label1.Location = new Point(98, 12);
            ort.Location = new Point(155, 375);
            label4.Location = new Point(85, 116);
            label5.Location = new Point(104, 185);
            label6.Location = new Point(111, 223);
            label8.Location = new Point(136, 303);

            orta();
            enyukseknot2(enyukseknot());
        }

        private void changeEN()
        {
            lang = "EN";
            this.Text = "Score Calculator";
            label1.Text = "Exam Info";
            label2.Text = "Average of Students:";
            label3.Text = "Answer Key:";
            label4.Text = "Student Info";
            label5.Text = "Name Surname:";
            label7.Text = "The Student/Students with the highest score:";
            label6.Text = "Answers:";
            label8.Text = "Details";
            Insert.Text = "Add a Student";
            Update.Text = "Update Answers";
            Delete.Text = "Delete Student";
            dataGridView1.Columns[0].HeaderText = "Name Surname";
            dataGridView1.Columns[1].HeaderText = "Answers";
            dataGridView1.Columns[2].HeaderText = "Exam's Answer Key";
            dataGridView1.Columns[3].HeaderText = "Score";
            isim2.Location = new Point(261, 409);
            isim2.Size = new Size(166, 20);
            CevapAnahtarı.Size = new Size(324, 20);
            CevapAnahtarı.Location = new Point(85, 76);
            label1.Location = new Point(120, 12);
            ort.Location = new Point(140, 375);
            label4.Location = new Point(100, 116);
            label5.Location = new Point(84, 185);
            label6.Location = new Point(120, 223);
            label8.Location = new Point(150, 305);

            orta();
            enyukseknot2(enyukseknot());

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            string a = Cevaplar.Text;
            if (a.Length > 0)
            {
                AltBilgi.Text = a.Length.ToString();
            }
            else
            {
                AltBilgi.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string a = CevapAnahtarı.Text;
            if (a.Length > 0)
            {
                UstBilgi.Text = a.Length.ToString();
            }
            else
            {
                UstBilgi.Text = "";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            changeEN();
            Create_db();
            data_show();
            CevapAnahtarı.CharacterCasing = CharacterCasing.Upper;
            Cevaplar.CharacterCasing = CharacterCasing.Upper;
            orta();
            enyukseknot2(enyukseknot());
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (Ogrenci_lenctrl(CevapAnahtarı.Text.Length, Cevaplar.Text) & Name_ctrl(isim.Text) & IsAvailable(isim.Text, CevapAnahtarı.Text) & keyctrl(CevapAnahtarı.Text))
                {
                var baglan = new SQLiteConnection(cs);
                baglan.Open();
                var cmd = new SQLiteCommand(baglan);
                try
                {
                    cmd.CommandText = "INSERT INTO data(NameSurname,Answers,TestAnswers,Score) Values(@NameSurname,@Answers,@TestAnswers,@Score)";
                    string ad = isim.Text;
                    string cevap = Cevaplar.Text;
                    string tcevap = CevapAnahtarı.Text;
                    float Puan = puan_hesapla(CevapAnahtarı.Text, Cevaplar.Text);

                    cmd.Parameters.AddWithValue("@NameSurname", ad);
                    cmd.Parameters.AddWithValue("@Answers", cevap);
                    cmd.Parameters.AddWithValue("@TestAnswers", tcevap);
                    cmd.Parameters.AddWithValue("@Score", Puan);


                    dataGridView1.ColumnCount = 4;
                    dataGridView1.Columns[0].Name = "Column1";
                    dataGridView1.Columns[1].Name = "Column2";
                    dataGridView1.Columns[2].Name = "Column3";
                    dataGridView1.Columns[3].Name = "Column4";
                    string[] row = new string[] { ad, cevap, tcevap, Puan.ToString() };
                    dataGridView1.Rows.Add(row);



                    cmd.ExecuteNonQuery();
                    baglan.Close();
                    isim.Clear();
                    Cevaplar.Clear();
                    AltBilgi.Clear();
                    orta();
                    enyukseknot2(enyukseknot());
                }
                catch (Exception)
                {
                    if (lang == "TR")
                    {
                        MessageBox.Show("Veri eklemesi başarısız.", "Hata", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Insert to database is failed.", "Error", MessageBoxButtons.OK);
                        return ;
                    }
                }
            }
        }
        private void Update_Click(object sender, EventArgs e)
        {
            var baglan = new SQLiteConnection(cs);
            baglan.Open();

            var cmd = new SQLiteCommand(baglan);
            try
            {
                if (Ogrenci_lenctrl(CevapAnahtarı.Text.Length, Cevaplar.Text) & Name_ctrl(isim.Text))
                {
                    cmd.CommandText = "UPDATE data Set Answers=@Answers, TestAnswers=@TestAnswers, Score=@Score where NameSurname =@NameSurname";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@NameSurname", isim.Text);
                    cmd.Parameters.AddWithValue("@Answers", Cevaplar.Text);
                    cmd.Parameters.AddWithValue("@TestAnswers", CevapAnahtarı.Text);
                    cmd.Parameters.AddWithValue("@Score", puan_hesapla(CevapAnahtarı.Text, Cevaplar.Text));

                    cmd.ExecuteNonQuery();
                    dataGridView1.Rows.Clear();
                    isim.Clear();
                    Cevaplar.Clear();
                    AltBilgi.Clear();
                    data_show();
                    orta();
                    enyukseknot2(enyukseknot());
                }
            }
            catch (Exception)
            {
                if (lang == "TR")
                {
                    MessageBox.Show("Veri güncellenemiyor.", "Hata", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show("Cannot update data", "Error", MessageBoxButtons.OK);
                    return;
                };
            }
            finally
            {
                baglan.Close();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var baglan = new SQLiteConnection(cs);
            baglan.Open();

            var cmd = new SQLiteCommand(baglan);
            
            if (Name_ctrl(isim.Text))
            {
                try
                {
                    cmd.CommandText = "DELETE FROM data where NameSurname =@NameSurname";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@NameSurname", isim.Text);

                    cmd.ExecuteNonQuery();
                    dataGridView1.Rows.Clear();
                    data_show();
                    isim.Clear();
                    Cevaplar.Clear();
                    AltBilgi.Clear();
                    orta();
                    enyukseknot2(enyukseknot());
                }
                catch (Exception)
                {
                    if (lang == "TR")
                    {
                        MessageBox.Show("Veri silinemedi.", "Hata", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Data couldn't be deleted.", "Error", MessageBoxButtons.OK);
                        return;
                    }
                }
                finally { baglan.Close(); }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {

                    dataGridView1.CurrentRow.Selected = true;
                    isim.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                    Cevaplar.Text = dataGridView1.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
                    CevapAnahtarı.Text = dataGridView1.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString();

                }
            }
            catch (Exception)
            {

            }
        }

        private void CevapAnahtarı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            if ((int)e.KeyChar == 65 || (int)e.KeyChar == 66 || (int)e.KeyChar == 67 || (int)e.KeyChar == 68 || (int)e.KeyChar == 69 || (int)e.KeyChar == 97 || (int)e.KeyChar == 98 || (int)e.KeyChar == 99 || (int)e.KeyChar == 100 || (int)e.KeyChar == 101)
            {
                e.Handled = false;//eğer ABCDE ise yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void Cevaplar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            if ((int)e.KeyChar == 65 || (int)e.KeyChar == 66 || (int)e.KeyChar == 67 || (int)e.KeyChar == 68 || (int)e.KeyChar == 69 || (int)e.KeyChar == 97 || (int)e.KeyChar == 98 || (int)e.KeyChar == 99 || (int)e.KeyChar == 100 || (int)e.KeyChar == 101)
            {
                e.Handled = false;//eğer ABCDE ise yazdır.
            }

            else if ((int)e.KeyChar == 8 || (int)e.KeyChar == 32)
            {
                e.Handled = false;//eğer basılan tuş backspace ve boşluk ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void isim2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            changeEN();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            changeTR();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ENback.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ENback.Visible = false;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            TRback.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            TRback.Visible = false;
        }
    }
}
