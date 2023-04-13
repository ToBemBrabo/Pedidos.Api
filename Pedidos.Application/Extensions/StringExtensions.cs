using System.Text.RegularExpressions;

namespace Pedidos.Application.Extensions
{
    public static class StringExtensions
    {
        #region Fields

        private static int nroCaracteresCep = 8;
        private static Regex numbersRegex = new Regex("[0-9]");

        #endregion Fields

        #region Public Methods

        public static bool ValidarCep(string cep)
        {
            if (string.IsNullOrEmpty(cep))
                return false;

            if (cep.Length == 9)
                cep = cep.Replace("-", string.Empty);

            if (!cep.ValidarOnlyNumbers())
                return false;

            return cep.Length == nroCaracteresCep;
        }

        public static bool ValidarOnlyNumbers(this string param)
        {
            if (string.IsNullOrEmpty(param))
                return false;

            return numbersRegex.IsMatch(param);
        }

        #endregion Public Methods
    }
}