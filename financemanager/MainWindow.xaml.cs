using System;
using System.Collections.Generic;
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
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using financemanager.Datatypes;


namespace financemanager
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static string programfiledirectory = System.IO.Path.Combine(AppContext.BaseDirectory, "programfiles");
        static string projectfiles = System.IO.Path.Combine(programfiledirectory, "projects.txt");
        public string CurrentProject { get; set; }

        private List<string> EntrySaveBufferList = new List<string>();

        public void Add_Entry_To_Save_Buffer(string entryName, string fileFormat) {

            Console.WriteLine("MainWindow Add_Entry_To_Save_Buffer(string entryName): entryName = " + entryName);
            string entryPath = System.IO.Path.Combine(CurrentProject, entryName);
            string entryFileName = System.IO.Path.ChangeExtension(entryPath, fileFormat);
            if (System.IO.File.Exists(entryFileName)) {
                System.Windows.Forms.MessageBox.Show("File already exists!");
                return;
            }

            EntrySaveBufferList.Add(System.IO.Path.ChangeExtension(entryFileName, fileFormat));
        }
        
        public MainWindow()
        {
            InitializeComponent();
            setProgramFiles();
            /*Date date1 = new Date();
            Date date2 = new Date();
            
            date1.Day = 5;
            date1.setMonth(2);
            date1.setMonth(EMonth.April);
            date1.Year = 1901;

            Console.WriteLine(date1.toString());*/

           
            
        }

        public void setProgramFiles(){

            if (!Directory.Exists(programfiledirectory)) {
                Directory.CreateDirectory(programfiledirectory);
            }
            if (!File.Exists(projectfiles)) {
                File.Create(projectfiles);
            }
        }

        private void loadProject(string path) {

            if (File.Exists(path))
            {
                TreeViewItem baseItem = new TreeViewItem();
                baseItem.Header = System.IO.Path.GetFileNameWithoutExtension(path);
                balanceTree.Items.Add(baseItem);
                string[] content = File.ReadAllLines(path);
                if(content.Length == 0) { return; }
                foreach (string i in content) {
                    TreeViewItem newItem = new TreeViewItem();
                    newItem.Header = System.IO.Path.GetFileNameWithoutExtension(i);
                    baseItem.Items.Add(newItem);
                }
                
            }
            else {
                System.Windows.Forms.MessageBox.Show($"{path} does not exist! Cannot load file", "File not found!");
                return;
            }
        }

        private void createEntryFile(string name, string extension) { }

        
        
        //EVENT HANDLER

        private void on_new_click(object sender, EventArgs e)
        {
            balanceTree.Items.Clear();
            string path = string.Empty;
            AddProjectWindow addProDlg = new AddProjectWindow();
            addProDlg.Show();
            addProDlg.AddProjectEvent += (s, el) => {

                if (string.IsNullOrEmpty(el.arg)) { return; }

                path = System.IO.Path.Combine(programfiledirectory, el.arg);

                if (Directory.Exists(path))
                {
                    System.Windows.Forms.MessageBox.Show(
                        $"'{System.IO.Path.GetFileName(path)}' already exists! Chose other name!",
                        "Duplicate error");

                }
                else
                {
                    System.IO.Directory.CreateDirectory(path);
                    CurrentProject = path;
                    System.IO.File.CreateText(
                        System.IO.Path.ChangeExtension(System.IO.Path.Combine(path,
                        System.IO.Path.GetFileName(path)), ".fpf"));
                    StreamWriter wr = System.IO.File.AppendText(projectfiles);
                    wr.WriteLine(System.IO.Path.ChangeExtension(System.IO.Path.Combine(path,
                        System.IO.Path.GetFileName(path)), ".fpf"));
                    wr.Close();

                    TreeViewItem newItem = new TreeViewItem();
                    newItem.Header = System.IO.Path.GetFileName(path);
                    balanceTree.Items.Add(newItem);
                    addProDlg.Close();
                    
                }       
            };
           

            
            
        }
        private void on_open_click(object sender, RoutedEventArgs e)
        {   
            List<string> projects = new List<string>();
            foreach (string i in Directory.GetDirectories(programfiledirectory))
            {
                projects.Add(System.IO.Path.GetFileName(i));
            }
            OpenProjectsWindow openDlg = new OpenProjectsWindow(projects);
            openDlg.Show();

            openDlg.OpenProjectEvent += (s, args) =>
            {
                string projectname = args.arg;
                if (Directory.Exists(System.IO.Path.Combine(programfiledirectory, projectname)))
                {
                    balanceTree.Items.Clear();
                    CurrentProject = System.IO.Path.Combine(programfiledirectory, projectname);
                    string[] fpffile = Directory.GetFiles(CurrentProject, "*.fpf");
                    loadProject(fpffile[0]);
                }
                else {
                    System.Windows.Forms.MessageBox.Show($"'{args.arg}' does not exist!", "Project not found");        
                }
            };
        }
        private void on_save_click(object sender, RoutedEventArgs e)
        {

        }
        private void on_save_as_click(object sender, RoutedEventArgs e)
        {

        }
        private void on_exit_click(object sender, RoutedEventArgs e)
        {

        }

        private void on_add_entry_click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(CurrentProject)) { return; }

            AddEntryWindow addEntryWindow = new AddEntryWindow();
            addEntryWindow.Show();
            addEntryWindow.AddEntryEvent += (s, eventargs) => {
                
                string header = eventargs.arg[0];
                Add_Entry_To_Save_Buffer(eventargs.arg[0], eventargs.arg[1]);
                TreeViewItem newItem = new TreeViewItem();
                newItem.Header = header;
                newItem.MouseDoubleClick += openTab;
                TreeViewItem parentItem = (TreeViewItem)balanceTree.Items[0];
                parentItem.Items.Add(newItem);
                parentItem.ExpandSubtree();
            };
        }

        private void openTab(object sender, MouseButtonEventArgs e)
        {
            try
            {
                TreeViewItem newItem = (TreeViewItem)sender;
                string headername = newItem.Header.ToString();
                CloseableTab newtab = new CloseableTab(headername);
                YearTabControl.Items.Add(newtab);


            }
            catch (InvalidCastException ex)
            {   
                System.Windows.Forms.MessageBox.Show("Invalid Cast Exception", "Exception throwed!");
            }
                
         
        }

        private void on_load_entry_click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog fileDialog = new System.Windows.Forms.OpenFileDialog();
            fileDialog.Filter = "CSV | *.csv";
            fileDialog.InitialDirectory = "C://";

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                Console.WriteLine("File Extension: " + System.IO.Path.GetExtension(fileDialog.FileName));

                string[] content = (string[])File.ReadAllLines(fileDialog.FileName);
                TreeViewItem parentItem = (TreeViewItem)balanceTree.Items[0];
                TreeViewItem newItem = new TreeViewItem();
                newItem.Header = System.IO.Path.GetFileNameWithoutExtension(fileDialog.FileName);
                parentItem.Items.Add(newItem);

                if (System.IO.Path.GetExtension(fileDialog.FileName) == ".csv") {

                    try
                    {
                        string[] header = content[0].Split(';');
                        Console.WriteLine(header);
                        Console.WriteLine(content[0]);
                        
                    }
                    catch (IndexOutOfRangeException ex) {
                        System.Windows.Forms.MessageBox.Show("Index out of range!", "Exception error");
                    }
                    
                }

            }
        }

        private void load_entry_to_tab(string path) {

            string[] content = (string[])File.ReadLines(path);
            

        }

        private void add_entry_to_project(string path) {
            
        }

       
    }
}
