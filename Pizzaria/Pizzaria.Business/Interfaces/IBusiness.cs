namespace Pizzaria.Business.Interfaces
{
    public interface IBusiness<T> where T : class
    {

        public static void Cria(T pedido)
        {

        }

        public static void Atualiza(T pedido)
        {

        }

        public static void Exclui(int id)
        {

        }

        public static void GetById(int id)
        {

        }
    }
}
