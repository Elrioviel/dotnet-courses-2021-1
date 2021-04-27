using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Xml;
using System.Threading;

namespace Task2
{
    class SpyMode 
    {
        //private string _filePath;
        //private string _copyFilePath;

        //public SpyMode(string filePath, string copyFilePath)
        //{
        //    this._filePath = filePath;
        //    this._copyFilePath = copyFilePath;
        //}
        //static void WatchMode(string filePath)
        //{
        //    using var watcher = new FileSystemWatcher(filePath);

        //    watcher.NotifyFilter = NotifyFilters.Attributes
        //                         | NotifyFilters.CreationTime
        //                         | NotifyFilters.DirectoryName
        //                         | NotifyFilters.FileName
        //                         | NotifyFilters.LastAccess
        //                         | NotifyFilters.LastWrite
        //                         | NotifyFilters.Security
        //                         | NotifyFilters.Size;

        //    watcher.Changed += OnChanged;
        //    watcher.Created += OnCreated;
        //    watcher.Deleted += OnDeleted;
        //    watcher.Renamed += OnRenamed;
        //    watcher.Error += OnError;

        //    watcher.Filter = "*.txt";
        //    watcher.IncludeSubdirectories = true;
        //    watcher.EnableRaisingEvents = true;

        //}
        //private static void OnChanged(object sender, FileSystemEventArgs e)
        //{
        //    if (e.ChangeType != WatcherChangeTypes.Changed)
        //    {
        //        return;
        //    }
        //    Console.WriteLine($"Changed: {e.FullPath}");

        //    File.Copy(filePath, copyFilePath + Path.GetFileName(filePath));
        //}
        //private static void OnCreated(object sender, FileSystemEventArgs e)
        //{
        //    string value = $"Created: {e.FullPath}";
        //    Console.WriteLine(value);
        //}

        //private static void OnDeleted(object sender, FileSystemEventArgs e) =>
        //    Console.WriteLine($"Deleted: {e.FullPath}");

        //private static void OnRenamed(object sender, RenamedEventArgs e)
        //{
        //    Console.WriteLine($"Renamed:");
        //    Console.WriteLine($"    Old: {e.OldFullPath}");
        //    Console.WriteLine($"    New: {e.FullPath}");
        //}

        //private static void OnError(object sender, ErrorEventArgs e) =>
        //    PrintException(e.GetException());
        //private static void PrintException(Exception? ex)
        //{
        //    if (ex != null)
        //    {
        //        Console.WriteLine($"Message: {ex.Message}");
        //        Console.WriteLine("Stacktrace:");
        //        Console.WriteLine(ex.StackTrace);
        //        Console.WriteLine();
        //        PrintException(ex.InnerException);
        //    }
        //}

        //private readonly string PathToDirectory;
        //private const string PathForLog = @"C:\temp.xml";
        //private bool _flagSpy;
        //private static XmlDocument _xmlDoc;
        //private DirectoryInfo _dirInfo;
        //private int _dateTimeNegative;
        //private string _dateTimeToRestore;
        //public FileSystemWatcher fileMonitor;

        
        
        //public SpyMode(string pathToDirectory)
        //{
        //    if (!Directory.Exists(pathToDirectory))
        //    {
        //        throw new DirectoryNotFoundException(pathToDirectory);
        //    }

        //    PathToDirectory = pathToDirectory;

        //    Console.WriteLine("Monitoring directory...");
        //    Thread.Sleep(1500);
        //    OnSpyMode();

        //    if (_flagSpy)
        //    {
        //        try
        //        {
        //            var xmlWriter = new XmlTextWriter(PathForLog, Encoding.UTF8)
        //            {
        //                Formatting = Formatting.Indented,
        //                Indentation = 4
        //            };
        //        xmlWriter.WriteStartDocument();
        //        xmlWriter.WriteStartElement("Monitoring");
        //        xmlWriter.WriteEndElement();
        //        xmlWriter.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
        //    }
        //    var temp = new FileInfo(pathToDirectory);
        //    if (temp.IsReadOnly)
        //    {
        //        temp.IsReadOnly = false;
        //    }
        //    _xmlDoc = new XmlDocument();
        //    _xmlDoc.Load(PathForLog);

        //    Subscribe();
        //}

        //private void Subscribe()
        //{
        //    if (_flagSpy)
        //    {
        //        _dirInfo = new DirectoryInfo(PathToDirectory);
        //        fileMonitor = new FileSystemWatcher(_dirInfo.FullName);


        //        fileMonitor.Created += OnCreated;
        //        fileMonitor.Changed += OnChanged;
        //        fileMonitor.Deleted += OnDeleted;
        //        fileMonitor.Renamed += OnRenamed;

        //        fileMonitor.EnableRaisingEvents = true;
        //    }
        //    else
        //    {
        //        Console.Clear();
        //        var temp = DateTime.Now.ToString(CultureInfo.CurrentCulture);
        //        Console.WriteLine("Enter the date or time to restore one of the following changes {0} :", temp);
        //        _dateTimeToRestore = Console.ReadLine();
        //        try
        //        {
        //            _dateTimeNegative = _dateTimeToRestore.Length;
        //            DateTime.Parse(_dateTimeToRestore).ToString(CultureInfo.CurrentCulture);
        //            Thread.Sleep(1500);
        //            Console.Clear();
        //            Console.WriteLine("Restoration in process...");
        //            Restore();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //            Thread.Sleep(1500);
        //            Subscribe();
        //        }
        //    }
        //}

        //private void Restore()
        //{
        //    var restoration = new Restoration(_dateTimeToRestore, 9);
        //    Console.WriteLine();
        //    Console.WriteLine("Restoring files {0}....", restoration.list.Count);

        //    _dateTimeToRestore = _dateTimeToRestore.Substring(0, _dateTimeNegative);
            
        //    foreach (XmlElement elementXml in _xmlDoc.DocumentElement.ChildNodes.Cast<XmlElement>().Where(elementXml => elementXml.Attributes[0].Value.
        //    Contains(_dateTimeToRestore) && !elementXml.Name.Contains("elete")))
        //    {
        //        Console.WriteLine("element: {0} - {1}", elementXml.Name, elementXml.Attributes.Count > 0 ? elementXml.Attributes[0].Value : "null");
        //        foreach (XmlNode nodeXml in elementXml)
        //        {
        //            foreach (XmlNode elementXmlNode in nodeXml)
        //            {
        //                if (nodeXml.Name != "FullPath")
        //                {
        //                    Console.WriteLine("{0} - {1}", nodeXml.Name, nodeXml.InnerText);
        //                }
        //                foreach (XmlNode elnodexml in elementXmlNode)
        //                {
        //                    Console.WriteLine("{0} - {1}", elnodexml.Name, elnodexml.InnerText);
        //                    if (elnodexml.Name.Contains("reated"))
        //                    {
        //                        var tempInfo = new FileInfo(elnodexml.InnerText);
        //                        tempInfo.Delete();
        //                    }
        //                    else
        //                    {
        //                        bool f1 = File.Exists(elnodexml.InnerText);
        //                        bool f2 = Directory.Exists(elnodexml.InnerText);
        //                        bool f3 = elementXml.Name.Contains("named");
        //                        string path1 = nodeXml["FullPath"].InnerText;
        //                        string path2 = string.Format("{0}{1}", (nodeXml["FullPath"].InnerText.Substring(0, nodeXml["FullPath"].InnerText.Length - )))
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
