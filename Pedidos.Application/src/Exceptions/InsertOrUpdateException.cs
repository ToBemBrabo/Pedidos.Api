namespace Pedidos.Application.src.Exceptions
{
    public class InsertOrUpdateException : Exception
    {
        private static string Error = "Ocorreu um erro ao salvar o objeto enviado: ";

        public InsertOrUpdateException(string error) : base(Error)
        {
            Error = Error + error;
        }
    }
}