using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentDemo
{
    public partial class FmTransportEditor : Form
    {
        private bool createNew = true;
        public Transport transport { get; }

        public FmTransportEditor()
        {
            InitializeComponent();
        }

        public FmTransportEditor(Transport transport)
        {
            createNew = false;
        }

        private void FmTransportEditor_Load(object sender, EventArgs e)
        {
            if (createNew == true)
            {
                this.Text = "Добавление нового транспорта";
                btnOK.Text = "Создать";
            }
            else
            {
                this.Text = "Редактирование записи о транспорте";
                btnOK.Text = "Обновить";
            }

            FillComboBoxes();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void FillComboBoxes()
        {
            FillComboBox(ctlBrand, GetBrands());
            FillComboBox(ctlColor, GetColors());
            FillComboBox(ctlDrivingCategory, GetDrivingCategories());
            FillComboBox(ctlParking, GetParkings());
        }

        private void FillComboBox(ComboBox comboBox, IEnumerable<StandartdEntity> items)
        {
            comboBox.Items.Clear();
            foreach (var item in items)
            {
                comboBox.Items.Add(item.Title);
            }
        }

        private static IEnumerable<Brand> GetBrands()
        {
            return BrandDAO.GetBrands();
        }

        private static IEnumerable<Entities.Color> GetColors()
        {
            return ColorDAO.GetColors();
        }

        private static IEnumerable<DrivingCategory> GetDrivingCategories()
        {
            return DrivingCategoryDAO.GetDrivingCategories();
        }

        private static IEnumerable<Parking> GetParkings()
        {
            return ParkingDAO.GetParkings();
        }

        private static IEnumerable<Model> GetModels()
        {
            return ModelDAO.GetModels();
        }

        private void ctlBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Model> brandModels = GetModels().Select(m => m).Where(m => m.Brand.Title == ctlBrand.Text).ToList();
            FillComboBox(ctlModel, brandModels);
        }
    }
}
