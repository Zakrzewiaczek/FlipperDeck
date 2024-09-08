using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipperDeck
{
    public class UserEventsManager : IDisposable
    {
        private readonly List<string> boxesList = new(10);
        private readonly List<string> contentList = new(10);
        private bool _disposed;
        public UserEventsManager()
        {
            for (int i = 0; i < boxesList.Capacity; i++)
            {
                boxesList.Add("None");
                contentList.Add(string.Empty);
            }
        }

        public void SaveUserEvent(int index, string box, string content)
        {
            if (index >= 0 && index < boxesList.Count)
            {
                boxesList[index] = box;
                contentList[index] = content;
            }
        }

        public (string, string) GetUserEvent(int index)
        {
            if (index >= 0 && index < boxesList.Count)
            {
                return (boxesList[index], contentList[index]);
            }

            return (string.Empty, string.Empty);
        }

        public IEnumerable<string> GetAllSavedEventBoxes(bool[] isHeldChecked)
        {
            List<string> return_list = new(5);

            for(int index = 0; index < isHeldChecked.Length; index++)
            {
                int index_to_add = isHeldChecked[index] ? index + 4 : index;
                return_list.Add(boxesList[index_to_add]);
            }

            return return_list;
        }

        public IEnumerable<string> GetAllSavedEventContents(bool[] isHeldChecked)
        {
            List<string> return_list = new(5);

            for (int index = 0; index < isHeldChecked.Length; index++)
            {
                int index_to_add = isHeldChecked[index] ? index + 4 : index;
                return_list.Add(contentList[index_to_add]);
            }

            return return_list;
        }

        public void SaveUserEventsToFile()
        {
            using StreamWriter writer = new("user_events.txt");
            foreach (var (box, content) in boxesList.Zip(contentList, (b, c) => (b, c)))
            {
                writer.WriteLine($"{box},{content}");
            }
        }

        public void LoadUserEventsFromFile()
        {
            if (File.Exists("user_events.txt"))
            {
                boxesList.Clear();
                contentList.Clear();

                using StreamReader reader = new("user_events.txt");
                string line;
                while ((line = reader.ReadLine() ?? string.Empty) != string.Empty)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        boxesList.Add(parts[0]);
                        contentList.Add(parts[1]);
                    }
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                // Dispose managed resources
                boxesList.Clear();
                contentList.Clear();
            }

            _disposed = true;
        }
    }
}
