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
            }
            else
            {
                this.Text = "Редактирование записи о транспорте";
                btnOK.Text = "Обновить";

                txtTitle.Text                   = transport.Title;
                ctlBrand.SelectedItem           = transport.Brand.Title;
                ctlModel.SelectedItem           = transport.Model.Title;
                txtYear.Text                    = transport.Year.ToString();
                ctlColor.SelectedItem           = transport.Color.Title;
                ctlDrivingCategory.SelectedItem = transport.DrivingCategory.Title;
                if (transport.Parking != null)
                {
                    ctlParking.SelectedItem     = transport.Parking.Title;
                }

                txtCoef.Text                    = transport.Coef.ToString();
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

        private void UpdateTransport(Transport transport)
        {
            transport.Title           = txtTitle.Text;
            transport.Brand           = GetBrands().Select(b => b).Where(b => b.Title == ctlBrand.Text).Single();
            transport.Model           = GetModels().Select(m => m).Where(m => m.Title == ctlModel.Text).Single();
            transport.Color           = GetColors().Select(c => c).Where(c => c.Title == ctlColor.Text).Single();
            transport.Year            = int.Parse(txtYear.Text);
            transport.DrivingCategory = GetDrivingCategories().Select(d => d).Where(d => d.Title == ctlDrivingCategory.Text).Single();
            transport.Parking         = GetParkings().Select(p => p).Where(p => p.Title == ctlParking.Text).Single();
            transport.Coef            = double.Parse(txtCoef.Text);
        }
    }
}
