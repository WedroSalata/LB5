using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LB5
{
    public partial class Form1 : Form
    {
        Container cont;
        public Form1()
        {
            InitializeComponent();
            cont = new Container(pb1);
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            string input = tbEnter.Text;
            string pattern1 = @"\w+[=]\d+";
            Regex regex1 = new Regex(pattern1);
            MatchCollection matchCol = regex1.Matches(input);
            string[] filter = new string[4] { "x", "y", "side1", "side2"};
            int[] mas1 = Equalaizer(matchCol,filter);

            cont.Add(-1, mas1[0], mas1[1], mas1[2], mas1[3], -1);
            LbItemList.Items.Add(cont[cont.GetList().Count-1].ToString());
            //LbItemList.DataSource = cont.GetList();
            //LbItemList.DisplayMember = "x";
        }

        
        public int[] Equalaizer(MatchCollection matchCol, string [] filter)
        {
            int[] mas1 = new int[filter.Length];
            for (int i = 0; i < matchCol.Count; i++)
            {
                for (int j = 0; j < filter.Length; j++)
                {
                    if (matchCol[i].Value.Contains(filter[j]))
                    {
                        mas1[j] = Convert.ToInt32(matchCol[i].Value.Substring(matchCol[i].Value.IndexOf("=") + 1));
                    }
                        
                }
            }

            for (int i = 0; i < mas1.Length; i++)
            {
                if (mas1[i] == 0) mas1[i] = -1;
            }

            return mas1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cont.Draw();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            pb1.Image = null;
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    LbItemList.Items.Clear();
        //    string input = tbEnter.Text;
        //    string pattern1 = @"\w+[=]\d+";
        //    Regex regex1 = new Regex(pattern1); 
        //    MatchCollection matchq = regex1.Matches(input);
        //    for (int i=0; i<matchq.Count;i++ )
        //    {
        //        LbItemList.Items.Add(matchq[i].Value);
        //    }
        //}

    }
}
