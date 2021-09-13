using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JEDB.Models;
using JEDB.JEDB_Data;


namespace JEDB.Data_access
{
    public class PaymentLogic
    {
        private PaymentDTO _payment = new PaymentDTO();

        public PaymentLogic()
        {
        }

        public PaymentLogic(PaymentDTO paymentDTO)
        {
            _payment = paymentDTO;
        }

        public bool SavePayment()
        {
            Payment payment = new Payment();

            payment.Payment_ID = _payment.PaymentID;
            payment.Payment_Date = _payment.PaymentDate;
            payment.Reminder_ID = _payment.ReminderID;
            payment.Due_Payment_ID = _payment.DuePaymentID;
            payment.Payment_Value = _payment.PaymentValue;
            payment.Payment_Type = _payment.PaymentType;
            payment.Paid_By_Name = _payment.PaidByName;
            payment.Identification_Details = _payment.IdentificationDetails;
            payment.Payment_Remarks = _payment.PaymentRemarks;
            payment.System_User_ID = _payment.SystemUserID;
            payment.Entry_Date = _payment.EntryDate;

            try
            {
                DataAccessLogic.db.Payments.InsertOnSubmit(payment);
                DataAccessLogic.SaveChangesToTheDB();
                return true;
            }
            catch { return false; }
        }
    }
}
