using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practice_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Rectangle rect = new Rectangle();
        Circle circle = new Circle();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void CreateCirlce_Click(object sender, RoutedEventArgs e)
        {
            circle.Perimetr = Convert.ToInt32(circlePerimetrInput.Text);
            circle.Square = Convert.ToInt32(circleSquareInput.Text);
        }

        private void CreateRectangle_Click(object sender, RoutedEventArgs e)
        {
            rect.Square = Convert.ToInt32(rectangleSquareInput.Text);
            rect.Perimetr = Convert.ToInt32(rectanglePerimetrInput.Text);

        }

        private void CompareFigures(object sender, RoutedEventArgs e)
        {
            if (circle.CompareTo(rect) == 1) MessageBox.Show("Круг больше прямоугольника");
            if (circle.CompareTo(rect) == -1) MessageBox.Show("Круг меньше прямоугольника");
            else MessageBox.Show("Фигуры равны");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИСП-31 Шестаков Артём \nСоздать интерфейс – фигура (площадь, периметр). Создать классы - прямоугольник, круг.Классы должны включать конструкторы, функцию для формирования строки информации о фигуре.Сравнение производить по площади.");
        }
    }
}
