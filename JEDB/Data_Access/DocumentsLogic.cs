using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JEDB.Models;
using JEDB.JEDB_Data;


namespace JEDB.Data_access
{
    public class DocumentsSave
    {
        private DocumentDTO _documents = new DocumentDTO();

        public DocumentsSave(DocumentDTO documentDTO)
        {
            _documents = documentDTO;
        }

        public bool SaveDocumentsToFoldor()
        {
            return false;
        }

        public Guid SaveDocumentToDB()
        {
            try
            {
                Document document = new Document();

                document.Document_ID = _documents.DocumentID;
                document.Estate_ID = _documents.EstateID;
                document.Property_ID = _documents.PropertyID;
                document.Agreement_Lease = _documents.AgreementLeaseID;
                document.Agreement_GOV_ID = _documents.AgreementGOVID;
                document.Document_Type = _documents.DocumentType;
                document.Document_Name = _documents.DocumentName;
                document.File_Location = _documents.FileLocation;
                document.Backup_Location = _documents.BackupLocation;
                document.Remarks = _documents.Remarks;
                document.System_User_ID = _documents.SystemUserId;
                document.Entry_Date = _documents.EntryDate;


                DataAccessLogic.db.Documents.InsertOnSubmit(document);
                DataAccessLogic.SaveChangesToTheDB();

                return _documents.DocumentID;
            }
            catch { return Guid.Empty; }
        }
    }
}
