namespace Pedidos.Application.src.Exceptions
{
    public class InsertOrUpdateException : Exception
    {
        private const string Error = "Ocorreu um erro ao salvar o objeto enviado.";

        public InsertOrUpdateException() : base(Error)
        {
        }
    }
}