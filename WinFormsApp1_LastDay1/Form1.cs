using Microsoft.EntityFrameworkCore;
using WinFormsApp1_LastDay1.Data;
using WinFormsApp1_LastDay1.Models;
namespace WinFormsApp1_LastDay1
{
    public partial class Form1 : Form
    {
        LastDay1Context db = new LastDay1Context();

        public async void FillData()
        {
            usersTableDg.DataSource = await db.Users.ToListAsync();
            roleAddComboBox.DataSource = await db.Roles.ToListAsync();
            roleAddComboBox.DisplayMember = "RoleName";
            roleAddComboBox.ValueMember = "RoleId";
            roleUpdateComboBox.DataSource = await db.Roles.ToListAsync();
            roleUpdateComboBox.DisplayMember = "RoleName";
            roleUpdateComboBox.ValueMember = "RoleId";
        }

        public Form1()
        {
            InitializeComponent();
            FillData();
        }

        private async void addUserBtn_Click(object sender, EventArgs e)
        {

                User user = new User()
                {
                    UserId = 0,
                    Login = loginAddTextBox.Text,
                    Password = passwordAddTextBox.Text,
                    IdRole = (int)roleAddComboBox.SelectedValue
                };
                db.Users.Add(user);
                await db.SaveChangesAsync();
                FillData();

           
        }

        private async void userUpdateBtn_Click(object sender, EventArgs e)
        {

            User user = await db.Users.FirstOrDefaultAsync(x => x.UserId == (int)usersTableDg.SelectedRows[0].Cells[0].Value);
            user.Login = loginUpdateTextBox.Text;
            user.Password = passwordUpdateTextBox.Text;
            user.IdRole = (int)roleUpdateComboBox.SelectedValue;
            db.Users.Update(user);
            await db.SaveChangesAsync();
            FillData();
        }

        private async void getUserBtn_Click(object sender, EventArgs e)
        {
            User user = await db.Users.FirstOrDefaultAsync(x => x.UserId == (int)usersTableDg.SelectedRows[0].Cells[0].Value);

            loginLabel.Text = user.Login.ToString();
            passwordLabel.Text = user.Password.ToString();


        }

        private async void geleteUserBtn_Click(object sender, EventArgs e)
        {
            User user = await db.Users.FirstOrDefaultAsync(x => x.UserId == (int)usersTableDg.SelectedRows[0].Cells[0].Value);
            db.Users.Remove(user);
            await db.SaveChangesAsync();
            FillData();
        }

        private async void searchUserBtn_Click(object sender, EventArgs e)
        {
            List<User> userList = await db.Users.ToListAsync();

            usersTableDg.DataSource = userList.Where(x => x.Login.Contains(searchTextBox.Text)).ToList();
        }
    }
}