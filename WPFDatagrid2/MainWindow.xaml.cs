using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDatagrid2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GRD_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            Song newsong= e.Row.DataContext as Song;
            AddNewSong(newsong);
        }
        void AddNewSong(Song s)
        {
            var file = @"G:\songs.csv";
            File.AppendAllText(file, $"{s.Id},{s.Title},{s.Genre},{s.Artists},{s.MovieTitle},{s.ResealeYear.Year},{s.URL}\n");
        }
    }
    public class Songs
    {
        public List<Song> SongList { get; set; } = GetSongs();
        public static List<Song> GetSongs()
        {
            var file = @"G:\songs.csv";
            var lines = File.ReadAllLines(file);
            var list = new List<Song>();
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Split(',');
                var g = line[2].Split(' ', '&', '-');
                var gr = g.Length > 1 ? g[0] + g[1] : g[0];

                List<Artist> artists = new List<Artist>();

                if(line.Length > 6)
                {
                    for (int j = 6; j < line.Length; j++)
                    {
                        var artist = new Artist()
                        {
                            Name = line[j],
                        };
                        artists.Add(artist);
                    }
                }
                var song = new Song()
                {
                    Id = int.Parse(line[0]),
                    Title = line[1],
                    Artist = line[3],
                    IsSoundtrack = line[4] == "Unknown" ? false : true,
                    MovieTitle = line[4],
                    Genre = (Genre)Enum.Parse(typeof(Genre), gr),
                    ResealeYear = DateTime.Parse(line[5] + ",1,1"),
                    URL = new Uri($"WWW.{line[3]}.com", UriKind.Relative),
                    Artists = artists,
                };
                list.Add(song);
            }
            return list;
        }
    }
    public class Artist
    {
        public string Name { get; set; }

    }
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public bool IsSoundtrack { get; set; }
        public string MovieTitle { get; set; }
        public Genre Genre { get; set; }
        public DateTime ResealeYear { get; set; }
        public Uri URL { get; set; }
        public List<Artist> Artists { get; set; }
    }
    public enum Genre
    {
        HeavyMetal,
        HardRock,
        SoftRock,
        ClassicRock,
        Rock,
        Pop,
        PopSoul,
        Soul,
        Blues,
        Jazz,
        RB,
        Country,
        Folk,
        Funk,
        Deeper
    }
}
