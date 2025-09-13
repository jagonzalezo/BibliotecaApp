using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot.Axes;
using BibliotecaApp.Models;

namespace BibliotecaApp
{
    public partial class ReportesForm : Form
    {
        private List<Prestamo> prestamos;
        public ReportesForm(List<Prestamo> prestamos)
        {
            InitializeComponent();
            this.prestamos = prestamos ?? new List<Prestamo>();
            GenerarGraficos();
        }

        private void GenerarGraficos()
        {
            // === Gráfico 1: Libros más prestados ===
            var modeloLibros = new PlotModel { Title = "Libros más prestados" };
            var librosSeries = new BarSeries { Title = "Cantidad" };

            // Datos de ejemplo (reemplaza con datos reales)
            librosSeries.Items.Add(new BarItem { Value = 12 }); // Libro A
            librosSeries.Items.Add(new BarItem { Value = 8 });  // Libro B
            librosSeries.Items.Add(new BarItem { Value = 15 }); // Libro C

            modeloLibros.Series.Add(librosSeries);
            modeloLibros.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "Libros",
                ItemsSource = new[] { "Libro A", "Libro B", "Libro C" }
            });
            modeloLibros.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });

            var chartLibros = new PlotView
            {
                Model = modeloLibros,
                Dock = DockStyle.Top,
                Height = 250
            };

            // === Gráfico 2: Usuarios con más préstamos ===
            var modeloUsuarios = new PlotModel { Title = "Usuarios con más préstamos" };
            var usuariosSeries = new BarSeries { Title = "Cantidad" };

            usuariosSeries.Items.Add(new BarItem { Value = 5 });  // Usuario 1
            usuariosSeries.Items.Add(new BarItem { Value = 9 });  // Usuario 2
            usuariosSeries.Items.Add(new BarItem { Value = 3 });  // Usuario 3

            modeloUsuarios.Series.Add(usuariosSeries);
            modeloUsuarios.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "Usuarios",
                ItemsSource = new[] { "Usuario 1", "Usuario 2", "Usuario 3" }
            });
            modeloUsuarios.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });

            var chartUsuarios = new PlotView
            {
                Model = modeloUsuarios,
                Dock = DockStyle.Fill
            };

            // Agregar gráficos al formulario
            this.Controls.Add(chartUsuarios);
            this.Controls.Add(chartLibros);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}



