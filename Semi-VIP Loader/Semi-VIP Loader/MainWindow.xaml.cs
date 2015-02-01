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
using MahApps.Metro.Controls;
using MySql.Data.MySqlClient;
using System.Data;

namespace Semi_VIP_Loader
{
  
    public partial class MainWindow : MetroWindow
    {
       
        public MainWindow()
        {
           
            InitializeComponent();
            Loaded += LoadHackInfo;
        }

        private void LoadHackInfo(object sender, RoutedEventArgs e)
        {
            VARIABLES.sqlconnection.ConnectionString = VARIABLES.connection;
            try
            {
                if (VARIABLES.sqlconnection.State == ConnectionState.Closed)
                {
                    VARIABLES.sqlconnection.Open();
                   
                    MySqlDataAdapter Adapter = new MySqlDataAdapter();
                    MySqlCommand CMD = new MySqlCommand();
                    DataTable TABLE = new DataTable("hack_info");

                    CMD.CommandText = VARIABLES.query;
                    CMD.Connection = VARIABLES.sqlconnection;

                    Adapter.SelectCommand = CMD;
                    Adapter.Fill(TABLE);
                  
                  DataGrid_Hacks.ItemsSource = TABLE.DefaultView;
                  DataGrid_Hacks.CanUserAddRows = false;
                  DataGrid_Hacks.Columns[1].Width = 140;
                  DataGrid_Hacks.Columns[2].Width = 85;
                  DataGrid_Hacks.Columns[3].Width = 70;
                 
                  for (int i = 1; i < 6; i++) DataGrid_Hacks.Columns[i].IsReadOnly = true;
                 
                     
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                this.Close();
            }
        }

        private void btn_Load_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }

    public class VARIABLES
    {
        
        public static string connection = "Server=localhost;User Id=root;Password=123456789qwer;Database=test";
        public static string query = "SELECT NAME,STATUS,TYPE,VERSION,AUTHOR FROM hack_info";
        public static MySqlConnection sqlconnection = new MySqlConnection();
    }
}
