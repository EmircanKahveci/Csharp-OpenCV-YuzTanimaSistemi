using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognition
{
    public partial class LoginScreen : Form
    {
        
        public LoginScreen()
        {
            InitializeComponent();
        }
        private void LoginScreen_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FaceInsertionForm faceInsertionForm = new FaceInsertionForm();
            faceInsertionForm.Show();
        }

    }
}
