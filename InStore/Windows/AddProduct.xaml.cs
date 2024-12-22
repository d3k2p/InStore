using InStore.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InStore.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public AddProduct()
        {
            InitializeComponent();
            Category.ItemsSource = AppData.db.Категория_товара.ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Продукт product = new Продукт();

            product.Название = NameTXB.Text;
            product.Цена = int.Parse(PriceTXB.Text);
            product.id_Категории_товара = Category.Text;

           

            

            AppData.db.Продукт.Add(product);
            AppData.db.SaveChanges();
            MessageBox.Show("Продукт успешно добавлен!");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Products products = new Products();
            products.Show();
            this.Close();
        }
    }

}
