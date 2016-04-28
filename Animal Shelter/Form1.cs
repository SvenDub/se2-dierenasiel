using System;
using System.Windows.Forms;
using Models;
using Models.Products;
using Repository;
using Repository.Data;

namespace Animal_Shelter
{
    public partial class Form1 : Form
    {
        private Reservation reservations =
            new Reservation(new AnimalShelterSQLContext());
        private Webshop webshop = new Webshop();

        public Form1()
        {
            InitializeComponent();
            this.RefreshControls();
        }

        private void cmbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBadHabits.Enabled = this.cmbSpecies.Text == "Cat";
        }

        private void RefreshControls()
        {
            lstAnimals.Items.Clear();
            foreach (Animal animal in this.reservations.Animals)
            {
                lstAnimals.Items.Add(animal);
            }

            btnAnimalReserve.Enabled = lstAnimals.SelectedItem != null;
            btnAnimalInWebshop.Enabled = lstAnimals.SelectedItem != null;

            lstWebshop.Items.Clear();
            foreach (ISellable product in this.webshop.Products)
            {
                lstWebshop.Items.Add(product);
            }
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            Gender gender = radMale.Checked ? Gender.Male : Gender.Female;

            if (this.cmbSpecies.Text == "Cat")
            {
                this.reservations.NewCat(
                    txtName.Text, gender, txtBadHabits.Text);
            }
            else if (this.cmbSpecies.Text == "Dog")
            {
                this.reservations.NewDog(txtName.Text, gender);
            }

            this.RefreshControls();
        }

        private void btnReserveAnimal_Click(object sender, EventArgs e)
        {
            Animal animal = lstAnimals.SelectedItem as Animal;

            if (animal != null)
            {
                animal.Reserve(txtReservor.Text);
                this.reservations.SaveAnimal(animal);
                this.RefreshControls();
            }
        }

        private void btnAnimalInWebshop_Click(object sender, EventArgs e)
        {
            Animal animal = lstAnimals.SelectedItem as Animal;

            if (animal != null)
            {
                webshop.Products.Add(animal);
                this.RefreshControls();
            }
        }

        private void lstAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            Animal animal = lstAnimals.SelectedItem as Animal;
            btnAnimalReserve.Enabled = animal != null;
            btnAnimalInWebshop.Enabled = animal != null;

            if (animal != null)
            {
                btnAnimalInWebshop.Enabled = animal.ReservedBy == null;
            }
        }

        private void btnFoodAdd_Click(object sender, EventArgs e)
        {
            this.webshop.AddProduct(new Food(txtFoodName.Text, nudFoodPrice.Value));
            this.RefreshControls();
        }

        private void btnWebshopRemove_Click(object sender, EventArgs e)
        {
            ISellable product = lstWebshop.SelectedItem as ISellable;
            if (product != null)
            {
                this.webshop.Products.Remove(product);

                if (product is Animal)
                {
                    this.reservations.Animals.Remove(product as Animal);
                }

                this.RefreshControls();
            }
        }

        private void lstWebshop_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnWebshopRemove.Enabled = lstWebshop.SelectedItem != null;
        }
    }
}
