using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Lab3_30
{
    public class Observer
    {
        Form1 curForm;
        FileSystemWatcher watcher = new FileSystemWatcher();
           
        public Observer() 
        {
        }
        public void Start(string path, Form1 newForm)
        {
            curForm = newForm;
            // Console.WriteLine("Ожидание активности....");

            //watcher.SynchronizingObject = this;

            watcher.Path = path; //не забудьте поменять путь
                                                                 //watcher.Filter = Path.GetFileName(@"c:\a.txt");
            //watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.Size;

            watcher.Deleted += new System.IO.FileSystemEventHandler(OnDelete);
            watcher.Renamed += new System.IO.RenamedEventHandler(OnRenamed);
            watcher.Changed += new System.IO.FileSystemEventHandler(OnChanged);
            watcher.Created += new System.IO.FileSystemEventHandler(OnCreate);
           // watcher.EnableRaisingEvents = true;

           // Console.ReadLine();
        }
        public void Stop()
        {
            watcher.EnableRaisingEvents = false;
             watcher.Dispose();
        }
        public  void OnChanged(object source, FileSystemEventArgs e)
        {
            curForm.GetObserverMessage();
        }

        public  void OnRenamed(object source, RenamedEventArgs e)
        {
            curForm.GetObserverMessage();
        }

        public  void OnDelete(object source, FileSystemEventArgs e)
        {
            curForm.GetObserverMessage();
        }
        public  void OnCreate(object source, FileSystemEventArgs e)
        {
            curForm.GetObserverMessage();
        }

    }
}
