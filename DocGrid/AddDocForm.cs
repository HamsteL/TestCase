using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using DocLib;
using System.Collections;

namespace DocGrid
{
    public partial class AddDocForm : Form
    {
        IService1 DocSvc = null;
        public AddDocForm()
        {
            InitializeComponent();
        }

        private void AddDocForm_Load(object sender, EventArgs e)
        {
            //Проверка на пустоту для полей ввода
            addBtn.Enabled = !((numDocText.Text == string.Empty) ||
                               (statusList.Text == string.Empty) ||
                               (descText.Text == string.Empty));
            //Подключение к сервису
            EndpointAddress address = new EndpointAddress(new Uri("http://localhost:8733/Design_Time_Addresses/DocLib/Service1/"));
            BasicHttpBinding binding = new BasicHttpBinding();
            ChannelFactory<IService1> factory = new ChannelFactory<IService1>(binding, address);
            DocSvc = factory.CreateChannel();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Document doc = new Document();
                doc.NumberDoc = int.Parse(numDocText.Text);
                doc.DateDoc = DateTime.Now.ToString("dd/MM/yyyy");
                doc.DescDoc = descText.Text;
                doc.StatusDoc = statusList.Text;
                doc.SignDoc = false;

                if (DocSvc.AddNewDoc(doc))
                {
                    MessageBox.Show("Документ успешно добавлен!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Документ с таким номером уже существует");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show((ex).ToString());
            }


        }

        private void numDocText_TextChanged(object sender, EventArgs e)
        {
            //Проверка на пустоту для полей ввода
            addBtn.Enabled = !((numDocText.Text == string.Empty) ||
                               (statusList.Text == string.Empty) ||
                               (descText.Text == string.Empty));
        }

        private void statusList_TextChanged(object sender, EventArgs e)
        {
            //Проверка на пустоту для полей ввода
            addBtn.Enabled = !((numDocText.Text == string.Empty) ||
                               (statusList.Text == string.Empty) ||
                               (descText.Text == string.Empty));
        }

        private void descText_TextChanged(object sender, EventArgs e)
        {
            //Проверка на пустоту для полей ввода
            addBtn.Enabled = !((numDocText.Text == string.Empty) ||
                               (statusList.Text == string.Empty) ||
                               (descText.Text == string.Empty));
        }

        private void numDocText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Предотвращение ввода других символов кроме цифр
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == 8) return;
            else
                e.Handled = true;
        }
    }
}
