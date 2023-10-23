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
    public partial class PayModeView : Form IPayModeView
    {
        private object TxtPayModeId;
        private object TxtPayModeName;
        private object TxtPayModeObservation;
        private TabPage tabPagePayModeDetail;

        public string PayModeId
        {
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }
        }
        public string PayModeName
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }
        }
        public string PayModeobservation
        {
            get { return TxtPayModeObservation.Text; }
            set { TxtPayModeObservation.Text = value; }
        }
        public string searchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return IsEdit; }
            set { IsEdit = value; }
        }
        public bool IsSuccesful
        {
            get { return IsSuccesful; }
            set { IsSuccesful = value; }
        }
        public string Message
        {
            get { return Message; }
            set { Message = value; }
        }

        public PayModeView()
        {
            InitializeComponent();
            AsocciateAndRaiseView();

            tabControl1.TabPages.Remove(tabPagePayModeDetail);
        }

        private void AsocciateAndRaiseView()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void setpayModeListBildingsource(BindingSource payModeList)
        {
            DgPayMode.DataSource = payModeList;
        }
        // Ptron singleton para controlar solo una instancia del formulario
        private static PayModeView instance;

        public static PayModeView GetInstance()
        {
          if(instance == null || instance.IsDisposed)
            {
                instance = new PayModeView();
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
          return instance;
        }
    }
}
