using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiberso
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            //richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

            richTextBox1.Text = "SOBRE EL SOFTWARE " +
                "\nMULTIBERSO es un software que fomenta la evaluación de sistemas, tecnologías y procesos, incorporando" +
                " múltiples indicadores agrupados en parámetros base que se muestran en un gráfico radial.La intención de " +
                "esta evaluación, es generar análisis comparativos innovadores, incorporando indicadores de sostenibilidad," +
                " que permitan conocer fortalezas y debilidades de los parámetros estudiados.No es un sistema de evaluación" +
                " per se, al abordar cuestiones de sostenibilidad, se define como una herramienta de evaluación comparativa." +
                " La sencillez del software, coadyuva a generar evaluación multicriterio y de sostenibilidad, de forma eficaz" +
                " e inmediata.Está diseñado para su uso en los sectores empresarial, académico, rural, indígena y cualquiera para" +
                " el que resulte útil.Los autores pretenden que esta sea la primera versión interactiva de evaluación integrada." +
                "Su semblanza se muestra a continuación. " +

                "\n\n\n\n\t\t\t\t\t\t        Luis Bernardo López Sosa " +
                "\nEcotecnólogo de formación, cuenta con una Maestría en Ciencias en Ingeniería Física y estudios de Doctorado en " +
                "Metalurgia y Ciencia de los Materiales. Ha participado en la dirección y ejecución de diversos proyectos sobre" +
                " ecotecnologías para el sector rural. Es fundador y director del programa “Centro Juvenil para el Desarrollo de Ecotécnias”." +
                " Ha impartido más de 50 ponencias, conferencias y exposiciones sobre energía, medio ambiente y desarrollo sustentable." +
                "Ha sido profesor invitado en la Universidad Intercultural Indígena de Michoacán, la Universidad Tecnológica de la Construcción," +
                " la Escuela Nacional de Estudios Superiores de la UNAM Campus Morelia, y profesor visitante en la Universidad Carlos III" +
                " de Madrid en España y en el College of Technology de la Universidad de Houston en Texas. Ha publicados dos libros sobre tecnologías" +
                " solares térmicas; y, posee más de 30 publicaciones en revistas de alto impacto, memorias de congresos y artículos de divulgación" +
                " científica y tecnológica.También, cuenta con tres patentes en trámite sobre tecnologías sustentables.Actualmente forma parte" +
                " del núcleo académico básico de la Maestría en Ingeniería para la Sostenibilidad Energética. Sus líneas de investigación versan" +
                " en el desarrollo de materiales sustentables y ecotecnologías, implementación y monitoreo de tecnologías sostenibles, así como" +
                " sistemas energéticos comunitarios. Y ha sido acreedor a múltiples reconocimientos a nivel estatal, nacional e internacional, " +
                "entre los que destacan: el Premio Nacional al Mérito Ecológico, el Premio Nacional de la Juventud, el Premio Luis Elizondo Tecnológico de Monterrey, el Premio Universidad del Valle de México al desarrollo Social, el Premio Estatal de Ciencia, Tecnología e Innovación, entre otros." +

                "\n\n\n\n\t\t\t\t\t\t        Mario Morales Máximo" +
                "\nMaestro en Ciencias y Tecnología de la Madera, por la Universidad Michoacana de San Nicolás de Hidalgo(UMSNH).Actualmente estudia" +
                " el Doctorado en Ciencias y Tecnología de la Madera en la(UMSNH). Profesor y técnico académico en la Universidad Vasco de Quiroga(UVAQ)" +
                " Morelia, Michoacán.Forma parte del núcleo académico básico de la Maestría en Ciencias para la Sostenibilidad Energética(MISE)." +
                "Cuenta con varios reconocimientos y premios académicos. Así mismo cuenta con varias publicaciones en memorias en extenso." +
                " Actualmente las líneas de investigación que está llevando a cabo son: Aprovechamiento de la biomasa forestal maderable para" +
                " la generación de bioenergía.Caracterización de materiales densificados para biocombustibles sólidos.Diseño, Análisis y modelado " +
                "de viviendas sostenibles. Diseño y modelado de tecnologías sostenibles. Materiales sostenibles para interiorismo en viviendas convencionales.";

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
