using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CustomerTextbox
{
    public class MainWindowViewModel
    {
        public Action OnDataEnter { get; set; }
        public MainWindowViewModel()
        {
            OnDataEnter = SpecificProperty; 
        }

        public void SpecificProperty()
        {
            MessageBox.Show("Only allowed to enter Numbers(1-10) and Alphabets - A and B");
        }
    }
}
