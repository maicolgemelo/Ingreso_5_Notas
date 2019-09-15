using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingreso_5_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string Nota1 = txtNota1.Text;
            string Nota2 = txtNota2.Text;
            string Nota3 = txtNota3.Text;
            string Nota4 = txtNota4.Text;
            string Nota5 = txtNota5.Text;
            string promedio = lblRespuesta.Text;

            float Calif1 = float.Parse(Nota1);
            float Calif2 = float.Parse(Nota2);
            float Calif3 = float.Parse(Nota3);
            float Calif4 = float.Parse(Nota4);
            float Calif5 = float.Parse(Nota5);
            float prom = (Calif1 + Calif2 + Calif3 + Calif4 + Calif5)/5 ;


            if (prom > 5)
            {

                lblRespuesta.Text = "";
                lblMensaje.Text = "";
                MessageBox.Show("puede que halla sobre pasado el limite de calificación o el simbolo no es punto(.) sino (,), por favor verifique el error ");



            }
            else if (prom <= 1)
            {

                lblRespuesta.Text = prom.ToString();
                lblMensaje.Text = "lleba la materia sin lograr realizar proceso de recuperación ";
                lblRespuesta.Visible = true;
                lblMensaje.Visible = true;
                lblMensaje.ForeColor = Color.Red;
            }
            else if (prom < 3)
            {
                lblRespuesta.Text = prom.ToString();
                lblMensaje.Text = "Reprueba la materia y puede hacer la habilitación ";
                lblRespuesta.Visible = true;
                lblMensaje.Visible = true;
                lblMensaje.ForeColor = Color.Blue;

            }
            else if (prom < 4)
            {
                lblRespuesta.Text = prom.ToString();
                lblMensaje.Text = "Aprueba la materia con plan de mejora ";
                lblRespuesta.Visible = true;
                lblMensaje.Visible = true;
                lblMensaje.ForeColor = Color.Green;



            }
            else if (prom <= 4.5)
            {

                lblRespuesta.Text = prom.ToString();
                lblMensaje.Text = " buen Rendimiento ";
                lblRespuesta.Visible = true;
                lblMensaje.Visible = true;
                lblMensaje.ForeColor = Color.Green;




            }
            else if (prom < 5)
            {

                lblRespuesta.Text = prom.ToString();
                lblMensaje.Text = "Excelente ";
                lblRespuesta.Visible = true;
                lblMensaje.Visible = true;
                lblMensaje.ForeColor = Color.Green;





            }
            else {
                lblRespuesta.Text = prom.ToString();
                lblMensaje.Text = "Graduado con honores ";
                lblRespuesta.Visible = true;
                lblMensaje.Visible = true;
                lblMensaje.ForeColor = Color.Green;

            }

        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
            txtNota5.Text = "";
            lblMensaje.Text = "";
            lblRespuesta.Text = "";
        }


    }


}
