using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Security.Permissions;
namespace Task2
{
    class Program
    {
        public static string FilePath;
        public static string TargetPath;
        public static string FileName { get; set; }
        static void Main(string[] args)
        {
            FilePath = @"C:\Users\Ghalia\Desktop\Study\dotnet-courses-2021-1\11-files\Files\FilesFolder1";
            TargetPath = @"C:\Users\Ghalia\Desktop\Study\dotnet-courses-2021-1\11-files\Files\ChangedFilesFolder";
            
            
            using FileSystemWatcher watcher = new FileSystemWatcher(FilePath);

            watcher.Path = FilePath;
            watcher.NotifyFilter = NotifyFilters.LastWrite
                | NotifyFilters.LastAccess
                | NotifyFilters.FileName
                | NotifyFilters.DirectoryName
                | NotifyFilters.Size;
            watcher.Filter = "*.txt";
            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;
            watcher.Deleted += OnChanged;
            watcher.Renamed += OnRenamed;

            watcher.EnableRaisingEvents = true;     

            


            Console.WriteLine("Press x to exit SpyApp \n" +
                "Press m to start monitoring directory\n" +
                "Press s to stop monitoring\n" +
                "Press r to recover changed files\n");
            while (true)
            {
                string action = Console.ReadLine();
                if (action == "x") Environment.Exit(0);
                if (action == "m") watcher.EnableRaisingEvents = true;
                if (action == "s") watcher.EnableRaisingEvents = false;
                if (action == "r")
                {
                    watcher.EnableRaisingEvents = false;
                    RestoreFiles();
                    Thread.Sleep(1500);
                    watcher.EnableRaisingEvents = true;
                }


            }


        }
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        
        void Copy(string FilePath, string storingPath)
        {
            Directory.CreateDirectory(storingPath);
            foreach (var file in Directory.GetFiles(FilePath))
                File.Copy(file, Path.Combine(storingPath, Path.GetFileName(file)));
            foreach (var directory in Directory.GetDirectories(FilePath))
                Copy(directory, Path.Combine(storingPath, Path.GetFileName(directory)));
        }
        public static void StoreCopies(DateTime changeDate)
        {
            
            string storedFolderName = changeDate.ToString().Replace(":", "-").Replace(@"/", "-");
            string storingPath = System.IO.Path.Combine(TargetPath, storedFolderName);
            
            string sourceFile = System.IO.Path.Combine(FilePath, FileName);
            string destFile = System.IO.Path.Combine(storingPath, FileName);
            Directory.CreateDirectory(storingPath);
            if (System.IO.Directory.Exists(FilePath))
            {
                string[] filesToCopy = System.IO.Directory.GetFiles(FilePath);
                foreach (string s in filesToCopy)
                {
                    FileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(storingPath, FileName);
                    System.IO.File.Copy(s, destFile, true);
                }

            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }

        }
        private static void WriteLine(string line)
        {
            System.IO.File.AppendAllText(@"C:\Users\Ghalia\Desktop\Study\dotnet-courses-2021-1\11-files\Files\ChangedFilesFolder\change.txt", Environment.NewLine + line);      //save changes in file
        }
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            WriteLine(e.FullPath + " " + e.ChangeType);
            StoreCopies(DateTime.Now);
            FileName = e.Name.ToString();
        }
        private static void OnCreated(object source, FileSystemEventArgs e)
        {
            WriteLine(e.FullPath + "Created" + e.Name);
            FileName = e.Name.ToString();
            StoreCopies(DateTime.Now);
        }
        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            WriteLine(e.OldName + " renamed to " + e.Name);
            StoreCopies(DateTime.Now);
            FileName = e.Name.ToString();
        }
        public static void RestoreFiles()
        {
            string folderName;
            string dateOfRecovery;

            Console.WriteLine("From which date you wish to recover changes?");
            dateOfRecovery = Console.ReadLine();
            folderName = TargetPath + @"\" + dateOfRecovery;
            if (!Directory.Exists(folderName))
            {
                Console.WriteLine("Not found!");
            }
            else
            {
                
                foreach (string originalfile in Directory.GetFiles(FilePath))
                {
                    File.Delete(originalfile);
                }
                foreach (string directoryPath in Directory.GetDirectories(folderName, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(directoryPath.Replace(folderName, FilePath));
                }
                foreach (string recoveredFolder in Directory.GetFiles(folderName, "*", SearchOption.AllDirectories))
                {
                    File.Copy(recoveredFolder, recoveredFolder.Replace(folderName, FilePath), true);
                }
                Console.WriteLine("Files recovered successfully");
                
            }
        }
    }
}
