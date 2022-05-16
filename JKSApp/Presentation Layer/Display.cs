using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JKSApp.BusinessLayer;
using System.Data;
using System.IO;
using System.Threading;

namespace JKSApp.Presentation_Layer
{
    class Display
    {
        public void RefreshDVG(DataGridView dvg,BindingSource source)
        {

            source.ResetBindings(true);
            dvg.Update();
            dvg.Refresh();
        }

        public void MemberListViews(ListView lvQual, ListView lvEvent, ListView lvGrading, ListView lvAchievement,ObjectType objActiveView, Member member)
        {
            ListView activeView = new ListView(); ;
            
            int idPosition = 0;
            string tblID = "";
            switch (objActiveView)
            {
                case ObjectType.events:
                    activeView = lvEvent;
                    idPosition = 2;
                    tblID = activeView.SelectedItems[0].SubItems[3].Text;
                    break;
                case ObjectType.achievement:
                    activeView = lvAchievement;
                    idPosition = 2;
                    break;
                case ObjectType.grading:
                    activeView = lvGrading;
                    idPosition = 2;
                    tblID = activeView.SelectedItems[0].SubItems[4].Text;
                    break;
                case ObjectType.qualification:
                    activeView = lvQual;
                    idPosition = 3;
                    break;
                default:
                    break;
            }


            if (activeView.SelectedItems.Count != 0)
            {
                string item = activeView.SelectedItems[0].SubItems[idPosition].Text;               
                
                if (MessageBox.Show("Are you sure you want to remove this Item", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {                   
                    if (member.DeleteMemberItem(objActiveView, item, tblID))
                    {
                        MessageBox.Show("Sucessfully Removed");
                    }
                    else MessageBox.Show("Operation failed");
                }
            }
            else MessageBox.Show("Select Item to remove");     
        }

        public void populateListViews(ListView lvQual, ListView lvEvent, ListView lvGrading, ListView lvAchievement,Label lblBelt)
        {
            Member mem = StaticBindingSource.source.Current as Member;
            lvQual.Items.Clear();
            lvAchievement.Items.Clear();
            lvEvent.Items.Clear();
            lvGrading.Items.Clear();
          
            if (mem.getMemberQualifications() != null)
                foreach (DataRow row in mem.getMemberQualifications().Rows)
                {
                    ListViewItem li = new ListViewItem(row["QualificationDescription"].ToString());
                    li.SubItems.Add(Convert.ToDateTime(row["SAQualificationDate"].ToString()).ToString("yyyy/MM/dd"));
                    li.SubItems.Add(Convert.ToDateTime(row["JAPQualificationDate"].ToString()).ToString("yyyy/MM/dd"));
                    li.SubItems.Add(row["QualificationID"].ToString());
                    lvQual.Items.Add(li);
                }

            if (mem.getMemberAchievements() != null)
                foreach (DataRow row in mem.getMemberAchievements().Rows)
                {
                    ListViewItem li = new ListViewItem(row["AchievementDescription"].ToString());
                    li.SubItems.Add(row["YearAchieved"].ToString());
                    li.SubItems.Add(row["AchievementID"].ToString());                   
                    lvAchievement.Items.Add(li);
                }

            if (mem.getMemberEvents() != null)
                foreach (DataRow row in mem.getMemberEvents().Rows)
                {
                    ListViewItem li = new ListViewItem(row["EventDescription"].ToString());
                    li.SubItems.Add(Convert.ToDateTime(row["EventDate"]).ToString("yyyy/MM/dd"));
                    li.SubItems.Add(row["EventID"].ToString());
                    li.SubItems.Add(row["MEID"].ToString());
                    lvEvent.Items.Add(li);
                }

            if (mem.getMemberGrading() != null)
                foreach (DataRow row in mem.getMemberGrading().Rows)
                {
                    ListViewItem li = new ListViewItem(row["GradingDescription"].ToString());
                    try
                    {
                        li.SubItems.Add(Convert.ToDateTime(row["GradingDate"]).ToString("yyyy/MM/dd"));
                    }
                    catch (Exception)
                    {
                        li.SubItems.Add("");
                    }                                                          
                    li.SubItems.Add(row["GradingID"].ToString());
                    li.SubItems.Add(row["AttemptedGrade"].ToString());
                    li.SubItems.Add(row["GIID"].ToString());
                    lvGrading.Items.Add(li);
                }

            lblBelt.Text = mem.GetBeltDescr(mem.BeltID.ToString());
        }

        public void achievementListView(ListView lvMembers)
        {
            lvMembers.Items.Clear();
            Achievement achievement = StaticBindingSource.source.Current as Achievement;          
                foreach (DataRow item in achievement.getAchievementMembers().Rows)
                {
                    ListViewItem itm = new ListViewItem(item["MemberFirstName"].ToString());
                    itm.SubItems.Add(item["MemberLastName"].ToString());
                    lvMembers.Items.Add(itm);
                }                    
        }

        public void categoryListView(ListView lvMembers)
        {
            lvMembers.Items.Clear();
            Category cat = StaticBindingSource.source.Current as Category;
            foreach (DataRow item in cat.getCategoryMembers().Rows)
            {
                ListViewItem itm = new ListViewItem(item["MemberFirstName"].ToString());
                itm.SubItems.Add(item["MemberLastName"].ToString());
                lvMembers.Items.Add(itm);
            }
        }

        public void dojoListView(ListView lvMembers)
        {
            lvMembers.Items.Clear();
            Dojo dojo = StaticBindingSource.source.Current as Dojo;
            foreach (DataRow item in dojo.getDojoMembers().Rows)
            {
                ListViewItem itm = new ListViewItem(item["MemberFirstName"].ToString());
                itm.SubItems.Add(item["MemberLastName"].ToString());
                lvMembers.Items.Add(itm);
            }
        }

        public void eventListView(ListView lvMembers)
        {
            lvMembers.Items.Clear();
            Event ev = StaticBindingSource.source.Current as Event;
            foreach (DataRow item in ev.getEventMembers().Rows)
            {
                ListViewItem itm = new ListViewItem(item["MemberFirstName"].ToString());
                itm.SubItems.Add(item["MemberLastName"].ToString());
                lvMembers.Items.Add(itm);
            }
        }

        public void gradingListView(ListView lvMembers)
        {
            lvMembers.Items.Clear();
            Grading gr = StaticBindingSource.source.Current as Grading;
            foreach (DataRow item in gr.getGradingMembers().Rows)
            {
                ListViewItem itm = new ListViewItem(item["MemberFirstName"].ToString());
                itm.SubItems.Add(item["MemberLastName"].ToString());
                lvMembers.Items.Add(itm);
            }
        }
        public void qualificationListView(ListView lvMembers)
        {
            lvMembers.Items.Clear();
            Qualification qual = StaticBindingSource.source.Current as Qualification ;
            foreach (DataRow item in qual.getQualificationMembers().Rows)
            {
                ListViewItem itm = new ListViewItem(item["MemberFirstName"].ToString());
                itm.SubItems.Add(item["MemberLastName"].ToString());
                lvMembers.Items.Add(itm);
            }
        }
        
        public void affiliationListViewID(ListView lvMembers)
        {
            lvMembers.Items.Clear();
            Member mem = new Member(); ;           
                foreach (Member item in mem.GetMember())
                {
                    ListViewItem itm = new ListViewItem(item.MemberID.ToString());
                    itm.SubItems.Add(item.MemberFirstName);
                    itm.SubItems.Add(item.MemberLastName);
                    lvMembers.Items.Add(itm);
                }
        }

        public List<string>[] populateAddressFilter()
        {
            List<string>[] lsub = new List<string>[4] {new List<string>(),new List<string>(), new List<string>(), new List<string>()};
            for (int i = 0; i < 4; i++)
            {
                lsub[i].Add("Any");
            }
            Member mem = new Member();
            foreach  (Member item in mem.GetMember())
            {                             
                if (!lsub[0].Contains(item.MemberSuburb))
                {
                    lsub[0].Add(item.MemberSuburb);
                }
                if (!lsub[1].Contains(item.MemberCity))
                {
                    lsub[1].Add(item.MemberCity);
                }
                if (!lsub[2].Contains(item.MemberProvince))
                {
                    lsub[2].Add(item.MemberProvince);
                }
                if (!lsub[3].Contains(item.MemberCountry))
                {
                    lsub[3].Add(item.MemberCountry);
                }
            }
            Dojo doj = new Dojo();
            foreach (Dojo item in doj.getDojo())
            {
                if (!lsub[0].Contains(item.Suburb))
                {
                    lsub[0].Add(item.Suburb);
                }
                if (!lsub[1].Contains(item.City))
                {
                    lsub[1].Add(item.City);
                }
                if (!lsub[2].Contains(item.Province))
                {
                    lsub[2].Add(item.Province);
                }
                if (!lsub[3].Contains(item.Country))
                {
                    lsub[3].Add(item.Country);
                }
            }
            return lsub;
        }

        public List<string> DojoNames()
        {
            Dojo doj = new Dojo();
            List<string> ldoj = new List<string>();
            ldoj.Add("Any");
            foreach (Dojo item in doj.getDojo())
            {
                ldoj.Add(item.Name);
            }
            return ldoj;
        }

        public List<string> CategoryNames()
        {
            Category cat = new Category();
            List<string> lcat = new List<string>();
            lcat.Add("Any");
            foreach (Category item in cat.getAll())
            {
                lcat.Add(item.CategoryDescription);
            }
            return lcat;
        }
        public List<string> AddNumbers()
        {
            List<string> lnum = new List<string>();
            lnum.Add("Any");
            for (int i = 1; i < 100; i++)
            {
                lnum.Add(i.ToString());
            }
            return lnum;
        }
        public List<string> BeltNames()
        {
            List<string> lbelt = new List<string>();
            if (ComponentController.activeForm.Enabled)
            {
                lbelt.Add("Any");
            }
            
            Belt belt = new Belt();
            foreach (Belt item in belt.getAll())
            {
                lbelt.Add(item.BeltName);
            }
            return lbelt;
        }

        public void RatificationInfo(int id, Label lblSADate, Label lblJAPDate)
        {
            lblSADate.Text = "N/A";
            lblJAPDate.Text = "N/A";
            Ratification rat = new Ratification();
            foreach (Ratification item in rat.getAll())
            {
                if (item.MemberID==id)
                {
                    lblSADate.Text = item.SADate.ToString("yyyy/MM/dd");
                    lblJAPDate.Text = item.JAPDate.ToString("yyyy/MM/dd");
                }
                break;
            }
        }
        
    }
}
