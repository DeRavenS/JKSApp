using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKSApp.DataLayer;

namespace JKSApp.BusinessLayer
{
    class Achievement
    {
        int achievementID;
        string achivementDescription;
        public Achievement()
        {
        }

        public Achievement(int achievementID, string achivementDescription)
        {
            this.AchievementID = achievementID;
            this.AchivementDescription = achivementDescription;
        }

        public int AchievementID { get => achievementID; set => achievementID = value; }
        public string AchivementDescription { get => achivementDescription; set => achivementDescription = value; }

        public List<Achievement> getAchievement()
        {
            DataHandler dh = new DataHandler();
            List<Achievement> lach = new List<Achievement>();
            foreach (Achievement ach in dh.GetAll(ObjectType.grading))
            {
                lach.Add(ach);
            }
            return lach;
        }
    }
}
