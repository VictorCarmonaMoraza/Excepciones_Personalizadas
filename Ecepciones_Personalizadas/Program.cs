using System;

namespace Ecepciones_Personalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = { };
                int data = array[0];
            }
            catch (FormatException e)
            {

                String m = e.Message;
            }
            catch (IndexOutOfRangeException e)
            {
                //throw new ExcepcionPersonalizada("Se ha generado una excepcion personalizada");
                throw new ExcepcionPersonalizada(e.ToString());
                //String m = e.Message;
            }
            finally
            {
                Console.WriteLine("Hola a todos");
            }
        }
    }
}
