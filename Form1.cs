using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Multiberso
{
    public partial class Multiberso : Form
    {
        private List<string> Parametros;
        private List<Indicador> IndicadoresPrim;
        public Multiberso()
        {
            Parametros = new List<string>();
            IndicadoresPrim = new List<Indicador>();

            #region DataTemp
            //parameters.Add("Bloc de Cemento");
            //parameters.Add("Tabique Mecanizado");
            //parameters.Add("Tabique Indistrial");
            //indicadores = new List<Indicador>();
            //indicadores.Add(new Indicador() { Nombre = "Calentamiento global (Kg CO2-eq)", Min = 0, Max = 0.5, Valor = 0.3, Inverso = false, Parametro = "Bloc de Cemento" });
            //indicadores.Add(new Indicador() { Nombre = "Acidificación (Kg SO2-eq", Min = 0, Max = 350, Valor = 100, Inverso = false, Parametro = "Bloc de Cemento" });
            //indicadores.Add(new Indicador() { Nombre = "Etrofización (Kg PO4-eq)", Min = 0, Max = 300, Valor = 250, Inverso = false, Parametro = "Bloc de Cemento" });
            //indicadores.Add(new Indicador() { Nombre = "Costo de Materia Prima ($)", Min = 0, Max = 260.01, Valor = 83.19, Inverso = false, Parametro = "Bloc de Cemento" });
            //indicadores.Add(new Indicador() { Nombre = "Costo mano de obra por unidad funcional ($)", Min = 0, Max = 422.89, Valor = 43.46, Inverso = false, Parametro = "Bloc de Cemento" });
            ////indicadores.Add(new Indicador() { Nombre = "Conductividad térmica (w/m² K) espuma poliuretano", Min = 0, Max = 0.0326, Valor = 0.238, Inverso = false, Parametro = "Bloc de Cemento" });
            //indicadores.Add(new Indicador() { Nombre = "Resistencia mecánica compresión (kg/cm²)", Min = 0, Max = 200, Valor = 70, Inverso = true, Parametro = "Bloc de Cemento" });
            //indicadores.Add(new Indicador() { Nombre = "Aislamiento acústico (dBl)", Min = 5, Max = 3, Valor = 1, Inverso = true, Parametro = "Bloc de Cemento" });
            #endregion

            InitializeComponent();
            comboParametros.Items.AddRange(Parametros.ToArray());
        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            List<Indicador> IndicadoresFin = new List<Indicador>();
            List<string> CasoAnalisis = new List<string>();
            //Materiales.Add("hola");
            //IndicadoresFin.Add(new Indicador()
            //{
            //    Valor = 12,
            //    Inverso = false,
            //    Parametro = "hola",
            //    Min = 0,
            //    Max = 14,
            //    Nombre = "Item"
            //}); IndicadoresFin.Add(new Indicador()
            //{
            //    Valor = 120,
            //    Inverso = false,
            //    Parametro = "hola",
            //    Min = 0,
            //    Max = 140,
            //    Nombre = "Item3"
            //}); IndicadoresFin.Add(new Indicador()
            //{
            //    Valor = 120,
            //    Inverso = false,
            //    Parametro = "hola",
            //    Min = 0,
            //    Max = 200,
            //    Nombre = "Item2"
            //});

            TextDialog DialogM = new TextDialog("Introduce la cantidad de casos de análisis");
            DialogM.Text = "Casos de análisis";
            DialogM.checkBoxInvertir.Visible = false;
            int cantM = 0;

            if (DialogM.ShowDialog(this) == DialogResult.OK)
            {
                string result = DialogM.txtResult.Text;

                if (!result.Equals(""))
                {
                    int.TryParse(result, out cantM);
                }
            }
            else
            { return; }
            DialogM.Dispose();

            for (int i = 0; i < cantM; i++)
            {
                TextDialog DialogMat = new TextDialog("Nombre del caso de análisis");
                DialogM.Text = "Caso de análisis";
                DialogMat.checkBoxInvertir.Visible = false;
                if (DialogMat.ShowDialog(this) == DialogResult.OK)
                {
                    //Obtener valores de Dialog
                    string result = DialogMat.txtResult.Text;

                    if (result.Equals("") || CasoAnalisis.Contains(result))
                    {
                        MessageBox.Show("Ya existe el caso de análisis, introduzca otro nombre"); i--; continue;
                    }
                    else { CasoAnalisis.Add(result); }
                }
                else
                { return; }
                DialogMat.Dispose();
            }

            foreach (var mat in CasoAnalisis)
            {
                foreach (var item in IndicadoresPrim)
                {
                    TextDialog Dialog = new TextDialog("Caso de análisis: " + mat +
                        "\nParametro " + item.Parametro + " Indicador:" + item.Nombre + "\nIntroduce su valor");

                    Dialog.Text = "Valor del caso de análisis";

                    if (Dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        //Obtener valores de Dialog
                        bool inverso = Dialog.checkBoxInvertir.Checked;
                        string result = Dialog.txtResult.Text;

                        if (!result.Equals(""))
                        {
                            double inValue = 0;
                            double.TryParse(result, out inValue);
                            Indicador data = new Indicador()
                            {
                                Valor = inValue,
                                Inverso = inverso,
                                Parametro = mat,
                                Min = item.Min,
                                Max = item.Max,
                                Nombre = item.Nombre + "\n" + item.Parametro
                            };
                            IndicadoresFin.Add(data);
                        }
                    }
                    else
                    { return; }
                    Dialog.Dispose();
                }
            }
            Grafica grafica = new Grafica(IndicadoresFin, CasoAnalisis);
            grafica.ShowDialog(this);
            grafica.Dispose();
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Si tiene texto la caja agrega de lo contrario muestra mensaje
            if (!txtParam.Text.Equals(""))
            {
                //Obtiene parametro y agrega a lista 
                string param = txtParam.Text;
                Parametros.Add(param);
                txtParam.Clear();

                //Limpia DataGrid y actualiza con el nuevo parametro, muestra mensaje
                dgvParametros.Rows.Clear();
                foreach (var data in Parametros) { dgvParametros.Rows.Add(data); }

                comboParametros.Items.Clear();
                comboParametros.Items.AddRange(Parametros.ToArray());
                comboParametros.DropDownStyle = ComboBoxStyle.DropDownList;

                // MessageBox.Show(null, "Agregado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "No hay que agregar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //asignar focus a txtParam -> Seguir agregando parametros
            txtParam.Focus();
        }


        private void BtnAceptarIndicador_Click(object sender, EventArgs e)
        {
            //Si tiene texto la caja agrega de lo contrario muestra mensaje
            if (!txtIndicador.Text.Equals("") && !txtIndicadorMax.Text.Equals("") && !txtIndicadorMin.Text.Equals("") && comboParametros.SelectedItem != null)
            {
                //Obtiene parametro y agrega a lista 
                double inMax = 0, inMin = 0;
                double.TryParse(txtIndicadorMax.Text, out inMax);
                double.TryParse(txtIndicadorMin.Text, out inMin);
                string indicador = txtIndicador.Text;
                string param = comboParametros.GetItemText(comboParametros.SelectedItem);

                Indicador actual = new Indicador()
                {
                    Nombre = indicador,
                    Min = inMin,
                    Max = inMax,
                    Parametro = param
                };


                IndicadoresPrim.Add(actual);
                txtIndicador.Clear();
                txtIndicadorMax.Clear();
                txtIndicadorMin.Clear();
                //TODO reiniciar combo
                comboParametros.SelectedIndex = -1;

                //Limpia DataGrid y actualiza con el nuevo parametro, muestra mensaje
                dgvIndicadores.Rows.Clear();
                foreach (Indicador data in IndicadoresPrim) { dgvIndicadores.Rows.Add(data.Nombre, data.Min.ToString("0.000"), data.Max.ToString("0.000"), data.Parametro); }

                //MessageBox.Show(null, "Agregado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "No hay que agregar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //asignar focus a txtIndicador -> Seguir agregando indicadores
            txtIndicador.Focus();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int toDelete = 0;
            try
            {
                toDelete = dgvParametros.CurrentCell.RowIndex;
            }
            catch (NullReferenceException)
            { toDelete = -1; return; }

            Parametros.RemoveAt(toDelete);

            dgvParametros.Rows.Clear();
            foreach (var data in Parametros) { dgvParametros.Rows.Add(data); }

            comboParametros.Items.Clear();
            comboParametros.Items.AddRange(Parametros.ToArray());

            //MessageBox.Show(null, "Eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnEliminarIndicador_Click(object sender, EventArgs e)
        {
            int toDelete = 0;
            try
            {
                toDelete = dgvIndicadores.CurrentCell.RowIndex;
            }
            catch (NullReferenceException)
            { toDelete = -1; return; }

            IndicadoresPrim.RemoveAt(toDelete);

            dgvIndicadores.Rows.Clear();
            foreach (Indicador data in IndicadoresPrim) { dgvIndicadores.Rows.Add(data.Nombre, data.Min.ToString("0.000"), data.Max.ToString("0.000"), data.Parametro); }

            //MessageBox.Show(null, "Eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void TxtIndicadorMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.NumerosDecimales(e);
        }

        private void TxtIndicadorMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.NumerosDecimales(e);
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog(this);
            about.Dispose();
        }
    }
}
