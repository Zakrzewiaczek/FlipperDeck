using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipperDeck
{
    public class UserEventsManager
    {
        private readonly List<ComboBox> event_set_boxes = new();
        private readonly List<string> event_context = new(10);
        private readonly string user_events_file = "user_events.fds";

        public UserEventsManager(List<ComboBox> boxes)
        {
            for (int index = 0; index < 10; index++)
            {
                event_set_boxes.Add(index < boxes.Count ? boxes[index] : new ComboBox());
                event_context.Add(string.Empty);
            }
        }

        public void SaveUserEvent(int index, ComboBox box, string context)
        {
            event_set_boxes[index] = box;
            event_context[index] = context;
        }
        public (ComboBox, string) GetUserEvent(int index)
        {
            return (event_set_boxes[index], event_context[index]);
        }

        public void SaveUserEventsToFile()
        {
            using (StreamWriter sw = new(user_events_file))
            {
                for (int index = 0; index < event_set_boxes.Count; index++)
                {
                    sw.WriteLine(event_set_boxes[index].Text);
                    sw.WriteLine(event_context[index]);
                }

                sw.Close();
            };
        }
        public void LoadUserEventsFromFile()
        {
            if (!File.Exists(user_events_file))
                return;

            using (StreamReader sr = new(user_events_file))
            {
                for (int index = 0; sr.EndOfStream; index++)
                {
                    string box_text = sr.ReadLine() ?? string.Empty;
                    string context = sr.ReadLine() ?? string.Empty;

                    event_set_boxes[index].Text = box_text;
                    event_context.Add(context);
                }

                sr.Close();
            };
        }
    }
}
