using MovieStore.WinUI.Customers;
using MovieStore.WinUI.Movies;
using MovieStore.WinUI.Rentals;
using MovieStore.WinUI.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieStore.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yeniKullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.MdiParent = this;
            newUserForm.WindowState = FormWindowState.Maximized;
            newUserForm.Show();
        }        

        private void kullanıcıDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new EditUserForm();
            editUserForm.MdiParent = this;
            editUserForm.WindowState = FormWindowState.Maximized;
            editUserForm.Show();
        }

        private void yeniMüşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomerForm newCustomerForm = new NewCustomerForm();
            newCustomerForm.MdiParent = this;
            newCustomerForm.WindowState = FormWindowState.Maximized;
            newCustomerForm.Show();
        }

        private void müşteriDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMovieForm editCustomerForm = new EditMovieForm();
            editCustomerForm.MdiParent = this;
            editCustomerForm.WindowState = FormWindowState.Maximized;
            editCustomerForm.Show();
        }

        private void yeniFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMovieForm newMovieForm = new NewMovieForm();
            newMovieForm.MdiParent = this;
            newMovieForm.WindowState = FormWindowState.Maximized;
            newMovieForm.Show();
        }

        private void filmDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMovieForm editMovieForm = new EditMovieForm();
            editMovieForm.MdiParent = this;
            editMovieForm.WindowState = FormWindowState.Maximized;
            editMovieForm.Show();
        }

        private void yeniFilmKiralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRentalForm newRentalForm = new NewRentalForm();
            newRentalForm.MdiParent = this;
            newRentalForm.WindowState = FormWindowState.Maximized;
            newRentalForm.Show();
        }

        private void düzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRentalForm editRentalForm = new EditRentalForm();
            editRentalForm.MdiParent = this;
            editRentalForm.WindowState = FormWindowState.Maximized;
            editRentalForm.Show();
        }
    }
}
