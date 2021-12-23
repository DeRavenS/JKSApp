using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JKSApp.BusinessLayer;
using System.Data;

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
            string item = "";
            int idPosition = 0;

            switch (objActiveView)
            {
                case ObjectType.events:
                    activeView = lvEvent;
                    idPosition = 2;
                    break;
                case ObjectType.achievement:
                    activeView = lvAchievement;
                    idPosition = 2;
                    break;
                case ObjectType.grading:
                    activeView = lvGrading;
                    idPosition = 2;
                    break;
                case ObjectType.qualification:
                    activeView = lvQual;
                    idPosition = 1;
                    break;
                default:
                    break;
            }


            if (activeView.SelectedItems.Count != 0)
            {
                item = activeView.SelectedItems[0].SubItems[idPosition].Text;
                if (MessageBox.Show("Are you sure you want to remove this Item", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {                   
                    if (member.DeleteMemberItem(objActiveView, item))
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

            if (lvGrading.Columns.Count == 3)
            {
                lvGrading.Columns.Add("AttemptedGrade", 0);
            }


            if (mem.getMemberQualifications() != null)
                foreach (DataRow row in mem.getMemberQualifications().Rows)
                {
                    ListViewItem li = new ListViewItem(row["QualificationDescription"].ToString());
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
                    lvEvent.Items.Add(li);
                }


            if (mem.getMemberGrading() != null)
                foreach (DataRow row in mem.getMemberGrading().Rows)
                {
                    ListViewItem li = new ListViewItem(row["GradingDescription"].ToString());
                    li.SubItems.Add(Convert.ToDateTime(row["GradingDate"]).ToString("yyyy/MM/dd"));
                    li.SubItems.Add(row["GradingID"].ToString());
                    li.SubItems.Add(row["AttemptedGrade"].ToString());
                    lvGrading.Items.Add(li);
                }
           
           
            if (lvGrading.Items.Count != 0)
            {
                if (mem.GetBeltDescr(lvGrading.Items[0].SubItems[2].Text) != null)
                {
                    lblBelt.Text = mem.GetBeltDescr(lvGrading.Items[0].SubItems[3].Text);
                }
            }
            else lblBelt.Text = mem.GetBeltDescr("1");


            lvGrading.Columns.Remove(lvGrading.Columns[3]);
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
    }
}
