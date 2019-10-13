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
    public partial class MainForm : Form
    {
        IService1 DocSvc = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            docGrigView.AllowUserToAddRows = false;
            docGrigView.AllowUserToDeleteRows = false;
            docGrigView.ReadOnly = true;

            //Подключение к сервису
            EndpointAddress address = new EndpointAddress(new Uri("http://localhost:8733/Design_Time_Addresses/DocLib/Service1/"));
            BasicHttpBinding binding = new BasicHttpBinding();
            ChannelFactory<IService1> factory = new ChannelFactory<IService1>(binding, address);
            DocSvc = factory.CreateChannel();

            updateTable();
        }

        //Открытие формы для добавления документа
        private void addDocBtn_Click(object sender, EventArgs e)
        {
            AddDocForm addForm = new AddDocForm();

            addForm.Show();

        }

        //Обновление таблицы с документами
        private void updateTable()
        {
            DataSet data = new DataSet();

            data = DocSvc.GetAllData();

            docGrigView.DataSource = data.Tables["Docs"];

        }

        //Обработка двойного клика по строке таблицы
        private void docGrigView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int docNumber = Int32.Parse(docGrigView.SelectedRows[0].Cells[0].Value.ToString());
            ChangeDocForm changeForm = new ChangeDocForm(docNumber);
            changeForm.Show();

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            updateTable();

        }
    }
}
