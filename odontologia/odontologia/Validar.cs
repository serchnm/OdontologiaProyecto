using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odontologia
{
    class Validar
    {
        public static void SoloLetras (KeyPressEventArgs f)
        {
            if(Char.IsLetter(f.KeyChar))
            {
                f.Handled = false;
            }
            else if(Char.IsSeparator(f.KeyChar))
            {
                f.Handled = false;
            }
            else if(Char.IsControl(f.KeyChar))
            {
                f.Handled = false;
            }
            else
            {
                f.Handled = true;
                MessageBox.Show("Solo se admiten letras");
            }
        }
        public static void SoloNumeros(KeyPressEventArgs f )
        {
            if (Char.IsDigit(f.KeyChar))
            {
                f.Handled = false;
            }
            else if (Char.IsSeparator(f.KeyChar))
            {
                f.Handled = false;
            }
            else if (Char.IsControl(f.KeyChar))
            {
                f.Handled = false;
            }
            else
            {
                f.Handled = true;
                MessageBox.Show( "Solo se admiten numeros","Error");
            }
        }

    }
}
