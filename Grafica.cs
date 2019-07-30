using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Multiberso
{
    public partial class Grafica : Form
    {
        private List<Indicador> indicadores;
        private List<string> material;
        private double esc = 10;
        private string[] AreaDrawingStyle = { "Circle", "Polygon" };
        private bool AreaSelected = false;
        private PrintDocument printdoc1 = new System.Drawing.Printing.PrintDocument();

        public Grafica(List<Indicador> DatosGrafica, List<string> Materiales)
        {
            indicadores = (DatosGrafica != null && DatosGrafica.Count != 0) ? DatosGrafica : new List<Indicador>();
            material = (Materiales != null && Materiales.Count != 0) ? Materiales : new List<string>();

            InitializeComponent();

            //Dibuja grafico 
            DrawChart();
            FillDataGridView();
        }
        private void BtnPrintImage_Click(object sender, EventArgs e)
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string pathImage = desktopPath + "\\grafico.png";

                chart1.SaveImage(pathImage, ChartImageFormat.Png);

                MessageBox.Show(this, "Imagen guardada en:\n " + pathImage,
                    "Imagen Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No se puede sobreescribir el archivo, cierrelo o elija otro nombre", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
                doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
                doc.Print();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No se puede sobreescribir el archivo, cierrelo o elija otro nombre", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            var pd = new System.Drawing.Printing.PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintChart);
            PrintDialog pdi = new PrintDialog();
            pdi.Document = pd;
            pdi.Document.Print();
        }
        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Panel grd = panel1;

            //Dibuja Texto Multiberso
            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 20);
            e.Graphics.DrawString("Multiberso", printFont, Brushes.Black, 60, 10);

            //Dibuja el logo 
            Bitmap image = new Bitmap(@"C:\Users\spart\source\repos\Multiberso\MainWindowsIco.jpeg");
            e.Graphics.DrawImage(image, new Rectangle(10, 10, 32, 32));

            //Crea BitMap del panel, el rectangulo que contiene y dibuja el panel
            Bitmap bmp = new Bitmap(grd.Width, grd.Height, grd.CreateGraphics());
            grd.DrawToBitmap(bmp, new Rectangle(0, 80, grd.Width, grd.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }

        //------------------------------------------------------------------------------------------------------------------
        void PrintChart(object sender, PrintPageEventArgs ev)
        {
            //Dibuja Texto Multiberso
            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 20);
            ev.Graphics.DrawString("Multiberso", printFont, Brushes.Black, 60, 10);

            //Dibuja el logo 
            Bitmap image = new Bitmap(@"C:\Users\spart\source\repos\Multiberso\MainWindowsIco.jpeg");
            ev.Graphics.DrawImage(image, new Rectangle(10, 10, 32, 32));

            //Crear el rectangulo que contiene y dibuja el chart
            System.Drawing.Rectangle myRec = new System.Drawing.Rectangle(20, 50, 800, 600);
            chart1.Printing.PrintPaint(ev.Graphics, myRec);
        }

        private void BtnForma_Click(object sender, EventArgs e)
        {
            if (AreaSelected)
                btnForma.Text = "Circulo";
            else
                btnForma.Text = "Poligono";

            AreaSelected = !AreaSelected;

            DrawChart();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillDataGridView()
        {
            dgvData.Columns.Clear();

            DataGridViewCell cell = new DataGridViewTextBoxCell();

            dgvData.Columns.Add(new DataGridViewColumn()
            {
                Name = "Indicador",
                HeaderText = "Indicador",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                CellTemplate = cell
            });

            foreach (string Serie in material)
            {
                dgvData.Columns.Add(new DataGridViewColumn()
                {
                    Name = Serie,
                    HeaderText = Serie,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    CellTemplate = cell
                });

                string[] x = indicadores.Where(m => m.Parametro.Equals(Serie)).Select(m => m.Nombre).ToArray();
                double[] y = indicadores.Where(m => m.Parametro.Equals(Serie)).
                    Select(m => (m.Inverso) ?
                      ((double)(m.Valor * esc) / (double)(m.Max))
                    : (esc - (double)(m.Valor * esc) / +(double)(m.Max))).ToArray();

                for (int i = 0; i < x.Length && i < y.Length; i++)
                {
                    dgvData.Rows.Add(x[i].ToString(), y[i].ToString("0.00"));
                }
            }
        }
        private void DrawChart()
        {
            chart1.Series.Clear();

            foreach (string Serie in material)
            {
                string[] x = indicadores.Where(m => m.Parametro.Equals(Serie)).Select(m => m.Nombre).ToArray();
                double[] y = indicadores.Where(m => m.Parametro.Equals(Serie)).
                    Select(m => (m.Inverso) ?
                      ((double)(m.Valor * esc) / (double)(m.Max))
                    : (esc - (double)(m.Valor * esc) / (double)(m.Max))).ToArray();


                //=10-((F21*10)/(F9)) Inverso
                //= ((F22 * 10) / F10) Tipica

                chart1.Series.Add(Serie);
                chart1.Series[Serie].Points.DataBindXY(x, y);

                chart1.Series[Serie].BorderWidth = 5;

                chart1.Series[Serie].ChartType = SeriesChartType.Radar;
                chart1.Series[Serie]["RadarDrawingStyle"] = "Line";
                chart1.Series[Serie]["AreaDrawingStyle"] = AreaDrawingStyle[(AreaSelected) ? 0 : 1];
                chart1.Series[Serie]["CircularLabelsStyle"] = "Horizontal";
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = esc;
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = esc;
                chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 1;
                chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 1;
                chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.LightGray;
                chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.LightGray;
                chart1.ChartAreas["ChartArea1"].AxisX.LineColor = chart1.BackColor;
                chart1.ChartAreas["ChartArea1"].AxisY.LineColor = Color.Black;
                chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = false;
            }
        }
    }
}
