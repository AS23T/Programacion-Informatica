using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace pryPráctico6
{
    public partial class frmPráctico6 : Form
    {
        public frmPráctico6()
        {
            InitializeComponent();
        }

        //Posición y velocidad del Ovni
        float OvniX, OvniY;
        float OvniVelx = 5;
        float OvniVely = 0;

        //Posición y velocidad del Disparo
        float DispX, DispY;
        float DispVelx = 0;
        float DispVely = -30;

        //True si el disparo está dentro del Form
        bool DisparoSeFue = false;

        //Sonido del disparo del laser
        SoundPlayer SonidoDisparoLaser = new SoundPlayer(Properties.Resources.LaserShoot);

        //Sonido del golpe (acierto)
        SoundPlayer SonidoGolpeLaser = new SoundPlayer(Properties.Resources.LaserHit);

        //Número de aciertos
        int NumAciertos = 0;

        //Inicializar OvnixX y OvniY
        private void frmPráctico6_Load(object sender, EventArgs e)
        {
            OvniX = picOvni.Left;
            OvniY = picOvni.Top;
        }

        //Disparar
        private void frmPráctico6_KeyDown(object sender, KeyEventArgs e)
        {
            //Si el disparo está fuera del formulario, no se hace nada
            if (DisparoSeFue) return;

            //Ver si se presiona la tecla espacio
            if(e.KeyCode==Keys.Space)
            {
                //Disparar
                DisparoSeFue = true;
                DispX=(picCañon.Left+picCañon.Width/2)-(picDisparo.Width/2);
                DispY = picCañon.Top - picDisparo.Height;

                picDisparo.Left = (int)DispX;
                picDisparo.Top = (int)DispY;
                picDisparo.Visible = true;

                //Tocar el sonido del disparo
                SonidoDisparoLaser.Play();
            }
        }

        //Mover el Ovny y el disparo (si es que hay uno)
        private void movTimer_Tick(object sender, EventArgs e)
        {
            //MOVER EL OVNI
            OvniX += OvniVelx;
            OvniY += OvniVely;

            //Si se encuentra al extreme derecho del formulario
            //se mueve desde el extremo izquierdo
            if (OvniX > ClientSize.Width)
                OvniX = -picOvni.Width;
            picOvni.Left = (int)OvniX;
            picOvni.Top = (int)OvniY;

            //MOVER EL DISPARO
            //Ver si el disparo está en el formulario
            if (DisparoSeFue)
            {
                
                //Mover el disparo
                DispX += DispVelx;
                DispY += DispVely;

                picDisparo.Left = (int)DispX;
                picDisparo.Top = (int)DispY;

                //Ver si le acierta al Ovni
                bool falla = (
                    (picDisparo.Left > picOvni.Right) ||
                    (picDisparo.Right < picOvni.Left) ||
                    (picDisparo.Top > picOvni.Bottom) ||
                    (picDisparo.Bottom < picOvni.Top));
                if (!falla)
                {
                    SonidoGolpeLaser.Play();
                    NumAciertos++;
                    lblPuntaje.Text = NumAciertos.ToString();

                    picDisparo.Visible = false;
                    DisparoSeFue = false;
                }
                else if (picDisparo.Bottom < 0)
                {
                    DisparoSeFue = false;
                    //***MEJORAS**
                }
            }
        }
    }
}
