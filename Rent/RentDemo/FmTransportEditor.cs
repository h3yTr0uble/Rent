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
        private Transport transport;

        public FmTransportEditor()
        {
            InitializeComponent();
        }

        public FmTransportEditor(Transport transport)
        {
            createNew = false;
            this.transport = transport;
            InitializeComponent();
        }

        private void FmTransportEditor_Load(object sender, EventArgs e)
        {
            FillComboBoxes();

            if (createNew == true)
            {
                this.Text = "Добавление нового транспорта";
                btnOK.Text = "Создать";
                transport = new Transport();
                txtCorrectCoef.ReadOnly = true;
                txtCorrectCoef.Text = "1";
            }
            else
            {
                this.Text = "Редактирование записи о транспорте";
                btnOK.Text = "Обновить";

                txtTitle.Text                   = transport.Title;
                ctlBrand.SelectedItem = transport.Brand;
                ctlModel.SelectedItem = transport.Model;
                txtYear.Text                    = transport.Year.ToString();
                ctlColor.SelectedItem = transport.Color;
                ctlDrivingCategory.SelectedItem = transport.DrivingCategory;
                if (transport.Parking != null)
                {
                    ctlParking.SelectedItem = transport.Parking;
                }

                txtCoef.Text                    = transport.Coef.ToString();
                txtCorrectCoef.Text             = transport.CorrectCoef.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == false)
            {
                return;
            }

            UpdateTransport(transport);

            if (createNew)
            {
                TransportDAO.Add(transport);
            }
            else
            {
                TransportDAO.Edit(transport);
            }
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
            comboBox.SelectedItem = null;
            comboBox.Items.Clear();
            foreach (var item in items)
            {
                comboBox.Items.Add(item);
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

        private void UpdateTransport(Transport transport)
        {
            transport.Title           = txtTitle.Text;
            transport.Brand           = (Brand)ctlBrand.SelectedItem;
            transport.Model           = (Model)ctlModel.SelectedItem;
            transport.Color           = (Entities.Color)ctlColor.SelectedItem;
            transport.Year            = int.Parse(txtYear.Text);
            transport.DrivingCategory = (DrivingCategory)ctlDrivingCategory.SelectedItem;
            transport.Parking         = (Parking)ctlParking.SelectedItem;
            transport.Coef            = double.Parse(txtCoef.Text);
            transport.CorrectCoef     = double.Parse(txtCoef.Text);
        }

        private double CalculateCoef(double brandCoef, double modelCoef, int year)
        {
            double itogCoef = brandCoef + modelCoef;
            int yearsOld = DateTime.Now.Year - year;
            itogCoef -= itogCoef * yearsOld / 100;

            return Math.Round(itogCoef, 2);
        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            FilltxtCoef();
        }

        private void FilltxtCoef()
        {
            if (!string.IsNullOrEmpty(txtYear.Text) && !string.IsNullOrEmpty(ctlBrand.Text) && !string.IsNullOrEmpty(ctlModel.Text))
            {
                double brandCoef = ((Brand)ctlBrand.SelectedItem).Coef;
                double modelCoef = ((Model)ctlModel.SelectedItem).Coef;
                int year = int.Parse(txtYear.Text);

                txtCoef.Text = CalculateCoef(brandCoef, modelCoef, year).ToString();
            }
        }

        private void ctlModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilltxtCoef();
        }
    }
}
