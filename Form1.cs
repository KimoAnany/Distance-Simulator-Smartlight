using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SmartLightLibrary;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SL_Abstandssimluator
{
    public partial class Form1 : Form
    {
        SmartLight smartLight;
        public Form1()
        {
            InitializeComponent();
            smartLight = new SmartLight();
            smartLight.VirtualSmartLight = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtboxDistanz_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAuswerten_Click(object sender, EventArgs e)
        {
            //Deklaration name für Connection mit IDM
            string name = "Student001";

            //Verbindung zum Server mit meiner persönlichen IDM
            smartLight.ConnectionAddress = name;
            
            //Befehl für 100 % Helligkeit
            int brightness = Convert.ToInt32("100");

            // Deklaration der benötigten Variablen zum Schleife bilden:
            
            int Distanz = Convert.ToInt32(txtboxDistanz.Text);

          
            // Grau Phase, WENN Distanz >>echt größer<< 150

            if (Distanz >= 150)
            {

                smartLight.SetLedRGB(0, 0, 0);

            }
            // Grün Phase, WENN Distanz >>größer gleich<< 100 UND >>echt kleiner<< 150
            if (Distanz >= 100 && Distanz < 150 )
            {
               
            smartLight.SetLedRGB(0, 255, 0);

            }


            // Gelb Phase; WENN Distanz >>echt kleiner<< als 100 UND >>größer gleich<< 45 
            if (Distanz < 100 && Distanz >= 45)
            {

                smartLight.SetLedRGB(255, 255, 0);

            }

            // Rote Phase; Wenn Distanz >>echt kleiner<< 45, DANN 
            if(Distanz < 45)
            {

                smartLight.SetLedRGB(255, 0, 0);

            }
            /* 
             Aus zeittechnischen Gründen, belasse ich es dabei einfach nur Zahlen einzutragen, 
             normalerweise müsste ein zusätzlicher Testrun sowie Requirement und Testitem hinzugefügt werden 
             für das Eintragen von Buchstaben anstelle von Zahlen und daraus folgend die Fehlereingrenzung durch entsprechenden Programmcode.
             Dessen bin ich mir voll auf bewusst.
             */ 
            

        }

        private void txtboxIDMADRESSE_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDistanz_Click(object sender, EventArgs e)
        {

        }
    }
}
