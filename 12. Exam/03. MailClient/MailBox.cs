using System.Diagnostics.Metrics;
using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }

        public int Capacity { get; set; }
        public List<Mail> Inbox { get; set; }
        public List<Mail> Archive { get; set; }

        public void IncomingMail(Mail mail)
        {
            if (Capacity > Inbox.Count)
            {
                Inbox.Add(mail);
            }
        }
        public bool DeleteMail(string sender)
        {
            return Inbox.Remove(Inbox.FirstOrDefault(m => m.Sender == sender));
        }
        public int ArchiveInboxMessages()
        {
            int counter = 0;
            for (int i = 0; i < Inbox.Count; i++)
            {
                Archive.Add(Inbox[i]);
                counter++;
            }
            Inbox.Clear();
            return counter;
        }
        public string GetLongestMessage()
        {
            return Inbox.MaxBy(m => m.Body.Length).ToString();
        }
        public string InboxView()
        {
            StringBuilder sb = new();
            sb.AppendLine("Inbox:");
            foreach (Mail mail in Inbox)
            {
                sb.AppendLine(mail.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }


}
