using System.Collections;

namespace Lecture_84
{

    public partial class Form1 : Form
    {
        ArrayList arrayList;
        public Form1()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            arrayList.Add(namEtextBox);
            MessageBox.Show("Name"+" "+namEtextBox.Text+" "+"Add Finish");
        }

        private void remove_Click(object sender, EventArgs e)
        {
           
            arrayList.Remove(namEtextBox);
            MessageBox.Show("Name" + " " + namEtextBox.Text + " " + "Remove Finsh");
        }

        private void showall_Click(object sender, EventArgs e)
        {
            // string naMe =string.Empty;
            foreach (int data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }
            

        }
    }
}
