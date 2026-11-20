
using System.Security.Cryptography;

namespace GeneradorContraseñas.Models
{
    public class Password
    {
        public int Largo { get; set; } = 10;

        public bool Mayusculas { get; set; }

        public bool Minusculas { get; set; }

        public bool Numeros { get; set; }

        public bool Simbolos { get; set; }

        public string Resultado { get; set; } = "";

        public string Generar()
        {
            string caracteres = "";
                
                      if (Mayusculas)
                    {
                        caracteres += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    }

                     if (Minusculas)
                    {
                        caracteres += "abcdefghijklmnopqrstuvwxyz";
                    }

                     if (Numeros)
                    {
                        caracteres += "0123456789";
                    }

                       if (Simbolos)
                    {
                        caracteres += "@#$%&*?!";
                    }

                    Resultado = "";

                       for (int i = 0; i < Largo; i++)
                    {
                        int posicion = RandomNumberGenerator.GetInt32(caracteres.Length);

                        Resultado += caracteres[posicion];
                    }

            return Resultado;
        }
    }
}
