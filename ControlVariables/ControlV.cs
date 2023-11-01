using System.Windows.Forms;

namespace RelojeriaColas.ControlVariables
{
    public static class ControlV
    {
        public static void AllowOnlyNumbers(KeyPressEventArgs e)
        {
            if (!IsANumber(e))
            {
                e.Handled = true;
            }
        }

        public static bool IsANumber(KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void AllowOnlyNumbersAndDigits(KeyPressEventArgs e)
        {
            if (!IsANumberOrDigit(e))
            {
                e.Handled = true;
            }
        }

        public static bool IsANumberOrDigit(KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
