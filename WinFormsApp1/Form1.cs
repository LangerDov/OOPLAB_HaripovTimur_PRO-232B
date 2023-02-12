namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.update_tabs_list();
            this.tabControl1.Visible = true;
            this.button1.Visible = false;

        }

        private void update_tabs_list()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                listBox1.Items.Add(tabControl1.TabPages[i].Text);
            }
        }

        private void Create()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.TabCount >= this.listBox1.SelectedIndex && this.listBox1.SelectedIndex != -1)
            {
                this.tabControl1.TabPages.RemoveAt(this.listBox1.SelectedIndex);
            }
            this.update_tabs_list();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TabPage tb = new TabPage();
            tb.Text = "ß òàá!";
            this.tabControl1.TabPages.Add(tb);
            this.update_tabs_list();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.TabCount >= this.listBox1.SelectedIndex && this.listBox1.SelectedIndex != -1)
            {
                this.tabControl1.TabPages[this.listBox1.SelectedIndex].Text = this.textBox2.Text;
            }
            this.update_tabs_list();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.TabCount >= this.listBox1.SelectedIndex && this.listBox1.SelectedIndex != -1)
            {
                this.textBox2.Text = this.tabControl1.TabPages[this.listBox1.SelectedIndex].Text;
                update_tab_item_list();
            } else
                this.update_tabs_list();
        }

        private void update_tab_item_list()
        {
            int i = this.listBox1.SelectedIndex;
            TabPage page = this.tabControl1.TabPages[i];
            this.PageItems.Items.Clear();
            for (int j = 0;  j < page.Controls.Count; j++)
            {
                this.PageItems.Items.Add(page.Controls[j].Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.TabCount >= this.listBox1.SelectedIndex && this.listBox1.SelectedIndex != -1)
            {
                if (this.Itemstocrt.SelectedIndex == 0)
                {
                    // label
                    Label label = new Label();
                    label.Text = "ß ËÅÉÁÅË ÍÀÏÈÑÂÀÍÍÛÉ ÊÀÏÑÎÌ!!!!";
                    this.tabControl1.TabPages[this.listBox1.SelectedIndex].Controls.Add(label);
                } else if (this.Itemstocrt.SelectedIndex == 1)
                {
                    // button
                    Button button = new Button();
                    button.Text = "ß êíîïêà!!!!";
                    this.tabControl1.TabPages[this.listBox1.SelectedIndex].Controls.Add(button);
                }
                update_tab_item_list();
            }
        }

        private void PageItems_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            if (this.tabControl1.TabCount >= this.listBox1.SelectedIndex && this.listBox1.SelectedIndex != -1)
            {
                if (this.PageItems.SelectedIndex <= this.tabControl1.TabPages[this.listBox1.SelectedIndex].Controls.Count && this.PageItems.SelectedIndex != -1)
                {
                    
                }
            }*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.TabCount >= this.listBox1.SelectedIndex && this.listBox1.SelectedIndex != -1)
            {
                if (this.PageItems.SelectedIndex <= this.tabControl1.TabPages[this.listBox1.SelectedIndex].Controls.Count && this.PageItems.SelectedIndex != -1)
                {
                    this.tabControl1.TabPages[this.listBox1.SelectedIndex].Controls.RemoveAt(this.PageItems.SelectedIndex);
                }
            }
            update_tab_item_list();
        }
    }
}