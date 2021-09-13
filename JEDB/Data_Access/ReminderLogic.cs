using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JEDB.Models;
using JEDB.JEDB_Data;


namespace JEDB.Data_access
{
    public class ReminderLogic
    {
        private ReminderDTO _reminder = new ReminderDTO();

        public ReminderLogic(ReminderDTO reminderDTO)
        {
            _reminder = reminderDTO;
        }

        public bool SaveReminder()
        {
            Reminder reminder = new Reminder();

            reminder.Reminder_ID = _reminder.ReminderID;
            reminder.AddedDate = _reminder.AddedDate;
            reminder.Reminder_Type = _reminder.ReminderType;
            reminder.Document_ID = _reminder.DocumentID;
            reminder.Is_Reminder_Active = _reminder.IsReminderActive;
            reminder.Is_Reminder_Sent = _reminder.IsReminderSent;
            reminder.Reminder_Value = _reminder.ReminderValue;
            reminder.System_User_ID = _reminder.SystemUserID;
            reminder.Entry_Date = _reminder.EntryDate;

            try
            {
                DataAccessLogic.db.Reminders.InsertOnSubmit(reminder);
                DataAccessLogic.SaveChangesToTheDB();
                return true;
            }
            catch { return false; }
        }
    }
}
