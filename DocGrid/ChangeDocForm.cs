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

namespace DocGrid
{
    public partial class ChangeDocForm : Form
    {
        IService1 DocSvc = null;
        private string statusd = null;
        private int numd;
        public ChangeDocForm(int numd)
        {
            InitializeComponent();
            this.numd = numd;
        }

        private void ChangeDocForm_Load(object sender, EventArgs e)
        {
            Document doc = new Document();
            numText.Text = numd.ToString();


            //Подключение к сервису
            EndpointAddress address = new EndpointAddress(new Uri("http://localhost:8733/Design_Time_Addresses/DocLib/Service1/"));
            BasicHttpBinding binding = new BasicHttpBinding();
            ChannelFactory<IService1> factory = new ChannelFactory<IService1>(binding, address);
            DocSvc = factory.CreateChannel();

            //Заполение полей формы
            doc = DocSvc.getDocument(this.numd);
            statusd = doc.StatusDoc;
            statusText.Text = doc.StatusDoc;
            descText.Text = doc.DescDoc;
            dataText.Text = doc.DateDoc;

            //Кнопка подписать доступна только при статусе документа "Закрыть", и если он еще не подписан
            signBtn.Enabled = !(statusText.Text != "Закрыт") && !(doc.SignDoc == true);

            if (statusText.Text == "Закрыт")
                if (doc.SignDoc == true)
                    statusText.Enabled = false;

        }

        private void ChangeDocForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //При закрытии, если статусы не совпадают, то обновляем их.
            if (statusd != statusText.Text)
                DocSvc.ChangeStatus(Int32.Parse(numText.Text), statusText.Text);
        }

        private void signBtn_Click(object sender, EventArgs e)
        {
            //Обращение к сервису
            DocSvc.makeSign(Int32.Parse(numText.Text));
            DocSvc.ChangeStatus(Int32.Parse(numText.Text), statusText.Text);
            this.Close();
        }

        private void statusText_TextChanged(object sender, EventArgs e)
        {
            signBtn.Enabled = !(statusText.Text != "Закрыт");
        }

    }
}
