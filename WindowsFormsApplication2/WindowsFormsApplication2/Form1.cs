using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Effects;
using Newtonsoft.Json.Linq;
using TextBox = System.Windows.Forms.TextBox;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        string StringA { get; set; }
        string StringB { get; set; }
        string MovieName { get; set; }
        int x = 10;
        int y = 10;
        private string currenPoster;
        private topTv temp = new topTv();




        public Form1()
        {
            
            InitializeComponent();
            button1.Hide();
            textBox2.BackColor = SystemColors.Window;
            textBoxAwards.BackColor = SystemColors.Window;
            textBoxRating.BackColor = SystemColors.Window;

            WebClient d = new WebClient();
            var data2 = d.DownloadString("https://api.themoviedb.org/3/movie/popular?api_key=91279627702045cd6f512cbbdce7c662");
            JObject m = JObject.Parse(data2);
            JArray title2 = (JArray)m["results"];

            WebClient c = new WebClient();
            var data3 = c.DownloadString("https://api.themoviedb.org/3/tv/popular?api_key=91279627702045cd6f512cbbdce7c662");
            JObject s = JObject.Parse(data3);
            JArray title3 = (JArray)s["results"];



            for (var i = 0; i < 9; i++)
            {
                JObject movie = title2[i].ToObject<JObject>();
                JObject tv = title3[i].ToObject<JObject>();
                movie["title"].ToString();
                tv["original_name"].ToString();



                //  Console.WriteLine(movie ["title"]);
                var film = movie.ToString();


                tabPage3popMovies.Controls.Add(getTextBox(x, y, movie["title"].ToString()));
                tabPage3popMovies.Controls.Add(getPictureBox(x, y, "http://image.tmdb.org/t/p/w300" + movie["poster_path"].ToString() ));
                tabPage4popTv.Controls.Add(getTextBoxTv(x, y, tv["original_name"].ToString()));
                tabPage4popTv.Controls.Add(getPictureBoxTv(x, y, "http://image.tmdb.org/t/p/w300" + tv["backdrop_path"]));
                StringB = movie["poster_path"].ToString();

            //    Console.WriteLine(StringB);
                



                IncrementBoxPosition();


            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Show();
            if (textBox1.TextLength <= 1)
            {
                button1.Hide();
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {




            string sok = textBox1.Text;

            WebClient c = new WebClient();
            var data = c.DownloadString("http://www.omdbapi.com/?t=" + sok + "&y&plot=short&r=json");
            JObject o = JObject.Parse(data);
            var poster = o["Poster"];
            var plot = o["Plot"];
            var resp = o["Response"];
            var error = o["Error"];
            var imdbId = o["imdbID"];
            var imdbRating = o["imdbRating"];
            var votes = o["imdbVotes"];
            var title = o["Title"];
            var year = o["Year"];
            var awards = o["Awards"];
            var released = o["Released"];
            var runtime = o["Runtime"];
            var genre = o["Genre"];
            var director = o["Director"];
            var writer = o["Writer"];


            var respString = resp.ToString();

            if (respString == "True")
            {
                var plott = plot.ToString();
                var rating = imdbRating.ToString();
                var imdbVotes = votes.ToString();
                var movieName = title.ToString();
                var yearMade = year.ToString();
                var movieAwards = awards.ToString();
                var movieReleased = released.ToString();
                var moveRuntime = runtime.ToString();
                var movieGenere = genre.ToString();
                var directedBy = director.ToString();
                var writtenBy = writer.ToString();
                richTextBox1.Text = plott;
                StringA = imdbId.ToString();

                var img = poster.ToString();
                var imgBig = "http://img.omdbapi.com/?i=" + StringA + "&apikey=9fae198a&h=500";

                pictureBox3.Load("http://sindredl.com/imdb-star2.png");
                pictureBox3.Load("../../graphic/imdb-star2.png");
                pictureBox4Awards.Load("../../graphic/awards.png");
                pictureBoxHR1.Load("../../graphic/hr2.png");
                pictureBoxHR2.Load("../../graphic/hr2.png");
                textBox2.Text = rating;
                textBox2.BorderStyle = BorderStyle.None;
                textBox3Title.Text = movieName + " (" + yearMade + ")";
                textBoxRating.Text = "Ratings " + rating + "/10 from " + imdbVotes + " users";
                textBoxAwards.Text = movieAwards;
                textBoxRuntimeGenere.Text = moveRuntime + " | " + movieGenere + " | " + movieReleased;
                textBoxDirector.Text = "Directed by: " + directedBy;
                textBoxWriter.Text = "Written by: " + writtenBy;


                if (img == "N/A")
                {
                    //Ikke posterbilde på film
                    pictureBox1.Load("../../graphic/no_img.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBox1.Load(img);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    if (RemoteFileExists(imgBig))
                    {
                        pictureBox2.Load(imgBig);
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        pictureBox2.Load("../../graphic/no_img.png");
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    }


                    // pictureBox1.Click += new EventHandler(pictureBox1_Click);
                }

            }
            else
            {
                // Ingen film på søkeordet
                var errorString = error.ToString();
                richTextBox1.Text = errorString;
                pictureBox1.Load("../../graphic/not-found.jpg");
                pictureBox2.Hide();
                pictureBox3.Hide();
                textBox2.Hide();
                StringA = null;
            }
            if (textBox2 != null)
            {
                textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(202)))), ((int)(((byte)(76)))));
                textBoxAwards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(164)))));

            }

        }

        private TextBox getTextBox(int x, int y, string title)
        {
            var tempBox = new TextBox();

            tempBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tempBox.Font = new System.Drawing.Font("", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tempBox.Location = new System.Drawing.Point(x, y);
            tempBox.Name = "textBox3Title";
            tempBox.Size = new System.Drawing.Size(277, 22);
            tempBox.TabIndex = 6;
            tempBox.Padding = new System.Windows.Forms.Padding(3);
            tempBox.Text = title;
            tempBox.Click += new System.EventHandler(textBox_Click);
            tempBox.Cursor = Cursors.Hand;
            return tempBox;
        }

        private PictureBox getPictureBox(int x, int y, string posterPath)
        {
            var picBox = new PictureBox();       
    
            picBox.Load(posterPath);
            picBox.Location = new System.Drawing.Point(x, y);
            picBox.Name = "picBox";
            picBox.Size = new System.Drawing.Size(90, 155);
            picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picBox.TabIndex = 7;
            picBox.TabStop = false;
            picBox.Click += new System.EventHandler(picBox_Click);
            return picBox;
        }

        private TextBox getTextBoxTv(int x, int y, string title)
        {
            var tvBox = new TextBox();

            tvBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tvBox.Font = new System.Drawing.Font("", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tvBox.Location = new System.Drawing.Point(x, y);
            tvBox.Name = "textBox3Title";
            tvBox.Size = new System.Drawing.Size(277, 22);
            tvBox.TabIndex = 6;
            tvBox.Padding = new System.Windows.Forms.Padding(3);
            tvBox.Text = title;
            tvBox.Click += new System.EventHandler(textBox_Click);
            tvBox.Cursor = Cursors.Hand;
            return tvBox;
        }

        private PictureBox getPictureBoxTv(int x, int y, string posterPath)
        {
            var picBoxTv = new PictureBox();       
    
            picBoxTv.Load(posterPath);
            picBoxTv.Location = new System.Drawing.Point(x, y);
            picBoxTv.Name = "picBox";
            picBoxTv.Size = new System.Drawing.Size(200, 150);
            picBoxTv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picBoxTv.TabIndex = 7;
            picBoxTv.TabStop = false;
            picBoxTv.Click += new System.EventHandler(picBox_Click);
            return picBoxTv;
        }


        private void IncrementBoxPosition()
        {
            x += 287;
            if (x > 600)
            {
                y += 160;
                x = 10;
            }
        }


        private bool RemoteFileExists(string url)
        {
            try
            {
                //Creating the HttpWebRequest
                var request = WebRequest.Create(url) as HttpWebRequest;
                //Setting the Request method HEAD, you can also use GET too.
                request.Method = "HEAD";
                //Getting the Web Response.
                var response = request.GetResponse() as HttpWebResponse;
                //Returns TRUE if the Status code == 200
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                //Any exception will returns false.
                return false;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (StringA != null)
            {
                Process.Start("http://www.imdb.com/title/" + StringA);
            }
            else
            {
                MessageBox.Show("Movie not found.");
            }

        }

        private void picBox_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            ImageBoxForm m = new ImageBoxForm(pic.Image);
            m.ShowDialog();
           // Console.WriteLine();
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            TextBox text = (TextBox) sender;
           // Console.WriteLine(text.Text);
            Process.Start("http://www.imdb.com/find?s=all&q=" + text.Text);

        }

        private void TopMovies(string element)
        {

        }

        private void tabPage3popMovies_Click(object sender, EventArgs e)
        {
            // Kalle på JSON top movies
        }


    }
}
