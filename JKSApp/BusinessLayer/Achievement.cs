using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKSApp.DataLayer;
using JKSApp.Presentation_Layer;
using System.Windows.Forms;
using System.Data;
namespace JKSApp.BusinessLayer
{
    class Achievement:table
    {
        int achievementID;
        string achievementDescription;
        public Achievement()
        {
        }

        public Achievement(int achievementID, string achivementDescription)
        {
            this.AchievementID = achievementID;
            this.AchievementDescription = achivementDescription;
        }

        public int AchievementID { get => achievementID; set => achievementID = value; }
        public string AchievementDescription { get => achievementDescription; set => achievementDescription = value; }

        public List<Achievement> getAchievement()
        {
            DataHandler dh = new DataHandler();
            List<Achievement> lach = new List<Achievement>();
            foreach (Achievement ach in dh.GetAll(ObjectType.achievement))
            {
                lach.Add(ach);
            }
            return lach;
        }

        public DataTable getAchievementMembers()
        {
            
            DataHandler dh = new DataHandler();
            return dh.AchievementMembers(achievementID.ToString());
        }

        public override void openInsertForm(CU op)
        {
            
            frmCreateAchievement frm = new frmCreateAchievement(op);
            frm.Show();
        }
        public override void openUpdateForm(Object ach)
        {

            frmCreateAchievement frm = new frmCreateAchievement(CU.Update,ach);
            frm.Show();
        }
        public bool InsertAchievement()
        {
            DataHandler dh = new DataHandler();
            if (dh.InsertItem("Achievement(AchievementDescription)", $"'{AchievementDescription}'"))
            {
                MessageBox.Show("Successfully added achievement");
                return true;
            }
            else
            {
                MessageBox.Show("Operation Failed");
                return false;
            }

        }
        public bool updateAchievement()
        {
            DataHandler dh = new DataHandler();
            if (dh.UpdateItem("Achievement", $"AchievementDescription='{AchievementDescription}'",achievementID.ToString()))
            {
                MessageBox.Show("Update Successful");
                return true;
            }
            else return false;
        }
        public override void DeleteItem()
        {
            DataHandler dh = new DataHandler();
            DialogResult dr = MessageBox.Show($"Are you sure you want to delete {AchievementDescription} and all its associated entries from the database?","Confirm",MessageBoxButtons.YesNo);
            if (dr==DialogResult.Yes)
            {
                if (dh.DeleteItem("MemberAchievement", $"AchievementID={achievementID}")&& dh.DeleteItem("Achievement", $"AchievementID={achievementID}"))
                {
                    MessageBox.Show("Delete Operation successful");
                }
                else
                {
                    MessageBox.Show("Could not delete all entries");
                }
            }                      
        }
    }
}
