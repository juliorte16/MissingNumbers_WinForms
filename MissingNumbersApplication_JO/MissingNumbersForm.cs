using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissingNumbersApplication_JO
{
    public partial class MissingNumbersForm : Form
    {
        private int n;
        private List<int> list1;
        private int m;
        private List<int> list2;
        private string list1Str;
        private string list2Str;
        private List<int> list3;
        private string list3Str;

        public MissingNumbersForm()
        {
            InitializeComponent();
        }

        private void MissingNumbersForm_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {           
            list1Str = "203 204 205 206 207 208 203 204 205 206";
            list1 = new List<int>();
            list1 = list1Str.Split(' ').Select(int.Parse).ToList();            
            list2 = new List<int>();
            list2Str = "203 204 204 205 206 207 205 208 203 206 205 206 204";
            list2 = list2Str.Split(' ').Select(int.Parse).ToList();
            n = list1.Count();
            TxbTamanoLista1.Text = n.ToString();
            TxbList1.Text = list1Str;
            m = list2.Count();
            TxbTamanoLista2.Text = m.ToString();
            TxbList2.Text = list2Str;
        }

        private void BtnMissingNumbers_Click(object sender, EventArgs e)
        {
            GetMissingNumbers();
        }

        private void GetMissingNumbers()
        {
                            
        }
    }
}
