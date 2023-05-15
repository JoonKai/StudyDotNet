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
            DG.ItemsSource = Songs.GetSongs();
        }
    }
    public class Songs
    {
        public static List<Song> GetSongs()
        {
            var file = @"C:\Users\thstj\OneDrive\문서\songs.csv";
            var lines=File.ReadAllLines(file);
            var list= new List<Song>();
            for (int i = 0; i<lines.Length; i++)
            {
                var line = lines[i].Split(',');
                var song = new Song()
                {
                    Id = int.Parse(line[0]),
                    Title = line[1],
                    Artist = line[3]
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
    }
}
