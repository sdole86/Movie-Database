using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Semester_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString=GetConnectionString();
            //string connectionString = "@Server=coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433;Initial Catalog=CSCI1630;User ID=rw1630;Password=Project!";


            List<Movie> movies = new List<Movie>();
            string sqlCommand = "SELECT  Id, Title,  Year , Director, Genre, RottenTomatoesScore, TotalEarned  FROM  Movies  ORDER   BY  Title";
            string[] genre = {"Animation", "Action", "Comedy", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var movie = new Movie();

                                movie.Id = reader.GetInt32(0);
                                
                                if (!reader.IsDBNull(1))
                                    movie.Title = reader.GetString(1);

                                if (!reader.IsDBNull(2))
                                    movie.Year = reader.GetInt32(2);
                                if (!reader.IsDBNull(3))
                                    movie.Director = reader.GetString(3);

                                if (!reader.IsDBNull(4))
                                {
                                    int genreNumber = reader.GetInt32(4);

                                    movie.Genre = genre[genreNumber];
                                }
                                if (!reader.IsDBNull(5))
                                    movie.TomatoScore = reader.GetInt32(5);
                                if (!reader.IsDBNull(6))
                                    movie.BoxOffice = reader.GetDecimal(6);

                            }
                        }
                        connection.Close();

                        dgvMovie.DataSource = movies;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed. Error {ex.Message}");
            }
        }

        private static string GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = @"coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433";
            builder.InitialCatalog = "CSCI1630";
            builder.UserID = "rw1630";
            builder.Password = "Project!";

            return builder.ConnectionString;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAddMovie_Click(object sender, EventArgs e)
        {
            AddMovieForm form = new AddMovieForm();
            form.ShowDialog();
        }

        private void mnuUpdateMovie_Click(object sender, EventArgs e)
        {
            UpdateMovieForm form = new UpdateMovieForm();
            form.ShowDialog();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.ShowDialog();
        }

        private void mnuDeleteMovie_Click(object sender, EventArgs e)
        {
            DeleteMovieForm form = new DeleteMovieForm();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
