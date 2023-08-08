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


namespace financemanager
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            setProgramFiles();
            
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
                string[] content = File.ReadAllLines(path);

            }
            else {
                System.Windows.Forms.MessageBox.Show($"{path} does not exist! Cannot load file", "File not found!");
                return;
            }

            

        }
        static string programfiledirectory = System.IO.Path.Combine(AppContext.BaseDirectory, "programfiles");
        static string projectfiles = System.IO.Path.Combine(programfiledirectory, "projects.txt");
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
                Console.WriteLine(i);
                projects.Add(System.IO.Path.GetFileName(i));
            }
            OpenProjectsWindow openDlg = new OpenProjectsWindow(projects);
            openDlg.Show();

            openDlg.OpenProjectEvent += (s, args) =>
            {
                string projectname = args.arg;
                if (Directory.Exists(System.IO.Path.Combine(programfiledirectory, projectname)))
                { 
                    string path = System.IO.Path.Combine(programfiledirectory, projectname);
                    string[] fpffile = Directory.GetFiles(path, "*.fpf");
                    Console.WriteLine(fpffile[0]);
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

        }
    }

    
}
