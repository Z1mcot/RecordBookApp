using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordBookApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ToFriendsListBtn_Click(object sender, EventArgs e)
        {
            var friendsList = new FriendsList();
            friendsList.Show();
        }
    }
}
