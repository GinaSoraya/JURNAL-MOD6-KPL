using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace modul6_1302223070
{
    public class Program
    {
        public class SayaTubeVideo
        {
            private int id;
            private string title;
            private int playCount;

            public SayaTubeVideo(string title)
            {
                this.title = title;
                Debug.Assert(title.Length < 200 && title != null);
                random input = new random();
                id = input.id();
                playCount = 0;
            }
            public void IncreasePlayCount(int playCount)
            {
                Debug.Assert(playCount > 0 && playCount < 25000000);
                try
                {
                    this.playCount = playCount;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Penambahan PlayCount");
                }
            }
            public void PrintVideoDetails()
            {
                Console.WriteLine("id video : " + id);
                Console.WriteLine("judul video : " + this.title);
                Console.WriteLine("Play Count : " + this.playCount);
            }
            public string getTitle()
            {
                return title;
            }
        }
        class random
        {
            public int id()
            {
                Random input = new Random();
                return input.Next(10000, 99999);
            }
        }
        public class SayaTubeUser
        {
            private int id;
            private List<SayaTubeVideo> uploadedVideos;
            public string Username;

            public SayaTubeUser(string username)
            {
                this.Username = username;
                Debug.Assert(username.Length < 100 && username != null);
                this.uploadedVideos = new List<SayaTubeVideo>();
            }
            public  int GetTotalVideoPlayCount()
            {
                return uploadedVideos.Count;
            }
            public void AddVideo(SayaTubeVideo video)
            {
                uploadedVideos.Add(video);
                Debug.Assert(video != null);
            }
            public void PrintAllVideoPlayCount()
            {
                Console.WriteLine($"Username: {Username}");
                for (int i = 0; i < uploadedVideos.Count; i++)
                {
                    Console.WriteLine($"Video {i + 1} judul: {uploadedVideos.ElementAt(i).getTitle()}");
                }
            }
        }
        public static void Main(string[] args)
        {
            SayaTubeUser user = new SayaTubeUser("Gina");

            SayaTubeVideo judul = new SayaTubeVideo("Riview Film Titatic oleh Gina");
            user.AddVideo(judul);
            SayaTubeVideo judul1 = new SayaTubeVideo("Riview Film Titatic oleh Gina");
            user.AddVideo(judul1);
            SayaTubeVideo judul2 = new SayaTubeVideo("Riview Film Titatic oleh Gina");
            user.AddVideo(judul2);
            SayaTubeVideo judul3 = new SayaTubeVideo("Riview Film Titatic oleh Gina");
            user.AddVideo(judul3);
            SayaTubeVideo judul4 = new SayaTubeVideo("Riview Film Titatic oleh Gina");
            user.AddVideo(judul4);
            SayaTubeVideo judul5 = new SayaTubeVideo("Riview Film Titatic oleh Gina");
            user.AddVideo(judul5);
            SayaTubeVideo judul6 = new SayaTubeVideo("Riview Film Titatic oleh Gina");
            user.AddVideo(judul6);
            SayaTubeVideo judul7 = new SayaTubeVideo("Riview Film Titatic oleh Gina");
            user.AddVideo(judul7);
            SayaTubeVideo judul8 = new SayaTubeVideo("Riview Film Titatic oleh Gina");
            user.AddVideo(judul8);
            SayaTubeVideo judul9 = new SayaTubeVideo("Riview Film Titatic oleh Gina");
            user.AddVideo(judul9);
            user.PrintAllVideoPlayCount();
        }
    }
}
