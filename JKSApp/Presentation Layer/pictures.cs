using JKSApp.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKSApp.Presentation_Layer
{
    class pictures
    {
        public string UploadPhoto()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Images|*.jpg;*.png;*.jpeg", ValidateNames = true, Multiselect = false })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imageFileName = openFileDialog.FileName;                   
                    return imageFileName;
                }
                else return null;
            }
        }

        public void SavePhoto(string FileName)
        {
            
            Image img;
            try
            {
                img = Image.FromFile(FileName);
            }
            catch (Exception)
            {
                FileName = $@"{AppContext.BaseDirectory}Images\{FileName}";               
                img = Image.FromFile(FileName);
            }
            MessageBox.Show(FileName);
            MessageBox.Show(newFilePath(FileName));
            try
            {
                img.Save(newFilePath(FileName), ImageFormat.Png);
                img.Dispose();
            }
            catch (Exception)
            {

            }
               
        }
        public string newFilePath(string imageFileName)
        {
            int pos = imageFileName.LastIndexOf(@"\");
            string newFileName = AppContext.BaseDirectory + @"Images" + imageFileName.Substring(pos, imageFileName.Length - pos);          
            return newFileName;
        }
        public string picName(string filepath)
        {
            string picname;
            int pos = filepath.LastIndexOf(@"\") + 1;
            picname =filepath.Substring(pos,filepath.Length-pos);
            return picname;
        }
        public void loadPic(PictureBox pbxMemberPhoto,Member mem)
        {
            try
            {
                if (mem.MemberPhoto != null)
                {
                    pbxMemberPhoto.Image = Image.FromFile(AppContext.BaseDirectory + @"Images\" + mem.MemberPhoto);
                }
                else pbxMemberPhoto.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Load image\nDescription: " + ex.Message, "Members", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
