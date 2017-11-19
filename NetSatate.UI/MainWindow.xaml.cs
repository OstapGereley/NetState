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

namespace NetSatate.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
            Items = new List<TestItemModel>();
            for (int i=1;i<10; i++)
            {
                Items.Add(new TestItemModel
                {
                    TestName = $"Test {i}",
                    Description = "Desc",
                    Errors = Environment.StackTrace
                });
            }
            Items.Add(new TestItemModel
            {
                TestName = $"Test 3",
                Description = "Desc",
                IsSuccess = false,
                Errors = Environment.StackTrace
            });
            Items.Add(new TestItemModel
            {
                TestName = $"Test 3",
                Description = "Desc",
                IsSuccess = true,
                Errors = Environment.StackTrace
            });
        }

        public List<TestItemModel> Items { get; set; }
    }
}
