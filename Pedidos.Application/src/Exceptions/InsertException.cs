namespace Pedidos.Application.src.Exceptions
{
    public class InsertException : Exception
    {
        private const string Error = "Ocorreu um erro ao salvar o objeto enviado.";

        public InsertException() : base(Error)
        {
        }
    }
}