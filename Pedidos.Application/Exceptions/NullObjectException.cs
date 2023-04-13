namespace Pedidos.Application.Exceptions
{
    public class NullObjectException : Exception
    {
        private const string Error = "Objeto nulo é inválido";

        public NullObjectException() : base(Error)
        {
        }
    }
}