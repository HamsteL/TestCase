using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DocLib
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool AddNewDoc(Document doc);

        [OperationContract]
        DataSet GetAllData();

        [OperationContract]
        bool ChangeStatus(int docNumber, string newStatus);

        [OperationContract]
        Document getDocument(int numDoc);

        [OperationContract]
        bool makeSign(int numDoc);
    }

    [DataContract]
    public class Document
    {
        int numberd;
        string dated;
        string descd;
        string statusd;
        bool signd;

        [DataMember]
        public int NumberDoc
        {
            get { return numberd; }
            set { numberd = value; }
        }
        [DataMember]
        public string DateDoc
        {
            get { return dated; }
            set { dated = value; }
        }
        [DataMember]
        public string DescDoc
        {
            get { return descd; }
            set { descd = value; }
        }
        [DataMember]
        public string StatusDoc
        {
            get { return statusd; }
            set { statusd = value; }
        }
        [DataMember]
        public bool SignDoc
        {
            get { return signd; }
            set { signd = value; }
        }
    }
}
