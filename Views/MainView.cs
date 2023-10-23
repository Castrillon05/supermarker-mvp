using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            BtnPaymode.Click += delegate { ShowPadeModeView?.Invoke(this, EventArgs.Empty); };
        }
        public event EventHandler ShowPadeModeView;
        public event EventHandler ShowProductview;
        public event EventHandler ShowCostumersview;

    }
}
