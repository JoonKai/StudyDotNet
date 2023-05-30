using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Documents;

namespace WPFDatagrid
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DG.ItemsSource = Songs.GetSongs();
        }
    }
    public class Songs
    {
        public List<Song> SongList { get; set; } = GetSongs();
        public static List<Song> GetSongs()
        {
            var file = @"csv\songs.csv";
            var lines=File.ReadAllLines(file);
            var list= new List<Song>();
            for (int i = 0; i<lines.Length; i++)
            {
                var line = lines[i].Split(',');
                var g = line[2].Split(' ', '&', '-');
                var gr = g.Length > 1 ? g[0] + g[1] : g[0];
                var song = new Song()
                {
                    Id = int.Parse(line[0]),
                    Title = line[1],
                    Artist = line[3],
                    IsSoundtrack = line[4]=="Unknown"?false:true,
                    MovieTitle = line[4],
                    Genre=(Genre)Enum.Parse(typeof(Genre), gr),
                    ResealeYear= DateTime.Parse(line[5]+",1,1"),
                    URL=new Uri($"WWW.{line[3]}.com",UriKind.Relative),
                };
                list.Add(song);
            }
            return list;
        }
    }
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public bool IsSoundtrack { get;set; }
        public string MovieTitle { get; set; }
        public Genre Genre { get; set; }
        public DateTime ResealeYear { get; set; }
        public Uri URL { get; set; }
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
