namespace Pedidos.Application.src.Extensions
{
    public static class CpfCnpjExtensions
    {
        #region Fields

        private static int[] multiplicadorCnpj1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        private static int[] multiplicadorCnpj2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        private static int[] multiplicadorCpf1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        private static int[] multiplicadorCpf2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        #endregion Fields

        #region Public Methods

        public static bool CnpjIsValid(this string cnpj)
        {
            cnpj = ReturnOnlyNumbers(cnpj);

            if (!cnpj.IsCnpj())
                return false;

            string tempCnpj = cnpj.Substring(0, 12);

            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicadorCnpj1[i];

            int resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicadorCnpj2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        public static bool CpfIsValid(this string cpf)
        {
            cpf = ReturnOnlyNumbers(cpf);

            if (!cpf.IsCpf())
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicadorCpf1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicadorCpf2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        public static bool IsCnpj(this string cnpj)
        {
            cnpj = ReturnOnlyNumbers(cnpj);

            return cnpj.Length != 14;
        }

        public static bool IsCpf(this string cpf)
        {
            cpf = ReturnOnlyNumbers(cpf);

            return cpf.Length != 11;
        }

        #endregion Public Methods

        #region Private Methods

        private static string ReturnOnlyNumbers(string cpfCnpj)
        {
            return cpfCnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
        }

        #endregion Private Methods
    }
}