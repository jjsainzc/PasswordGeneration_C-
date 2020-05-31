using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace PasswordGeneration
{
    class PasswordGenerator
    {
        private static readonly string NUMEROS = "0123456789";
        private static readonly string MAYUSCULAS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly string MINUSCULAS = "abcdefghijklmnopqrstuvwxyz";
        private static readonly string ESPECIALES = "!.,;{}^*+$%&/()=?¿¡";

        [Serializable]
        class ExcepcionLongitud : System.Exception
        {
            public ExcepcionLongitud(String msg) : base(msg) { }
        };

        private static char getRandomChar(String key)
        {
            return (key[(int)(new Random().Next(0, key.Length))]);
        }

        private static StringBuilder makePass(StringBuilder pass, String src)
        {
            char c;
            int i = 0;
            try
            {
                do
                {
                    c = getRandomChar(src);
                    if (i++ > 500)
                    {
                        pass.Append(c);
                        break;
                    }
                    if (!pass.ToString().ToLower().Contains(new String(new char[] { c }).ToLower()))
                    {
                        pass.Append(c);
                        break;
                    }
                } while (true);
            }
            catch (Exception e)
            {

            }
            return pass;
        }

        public static String getPassword(int length, String src)
        {
            StringBuilder pass = new StringBuilder();

            if (length < 8)
            {
                throw new ExcepcionLongitud("ERROR longitud minima es 8");
            }

            if (String.IsNullOrEmpty(src))
            {
                src = "mMne";
            }
            else if (src.Length == 1)
            {
                throw new ExcepcionLongitud("ERROR criterios deben ser al menos 2");
            }

            bool toogle = true;
            bool ciclo = true;
            for (int i = 0; i < length; i++)
            {
                try
                {
                    if (!ciclo)
                    {
                        break;
                    }
                    if (toogle)
                    {
                        if (src.Contains("m") && !new Regex(@".+[a-z]$").Match(pass.ToString()).Success)
                        {
                            makePass(pass, MINUSCULAS);
                            if (pass.ToString().Length >= length)
                            {
                                break;
                            }
                        }
                    }
                    else if (src.Contains("M") && !new Regex(@".+[A-Z]$").Match(pass.ToString()).Success)
                    {
                        makePass(pass, MAYUSCULAS);
                        if (pass.ToString().Length >= length)
                        {
                            break;
                        }
                    }

                    char[] tipos = (toogle) ? new char[] { 'n', 'e' } : new char[] { 'e', 'n' };

                    foreach (char t in tipos)
                    {
                        pass = genT(t, src, pass, length);
                        if (pass.ToString().Length >= length)
                        {
                            ciclo = false;
                            break;
                        }
                    }
                    toogle = !toogle;
                }
                catch (Exception e)
                {

                }
            }
            return pass.ToString();
        }

        private static StringBuilder genT(char type, String src, StringBuilder pass, int length)
        {
            try
            {
                if ((type == 'n') && src.Contains("n"))
                {
                    if ((pass.ToString().Length < length) && !new Regex(@".+[0-9]$").Match(pass.ToString()).Success)
                    {
                        return makePass(pass, NUMEROS);
                    }
                }
                if ((type == 'e') && src.Contains("e"))
                {
                    if ((pass.ToString().Length < length) && !new Regex(@".+[" + ESPECIALES.Replace("([\\\\\\.\\[\\{\\(\\*\\+\\?\\^\\$\\|])", "\\\\$1") + "]$").Match(pass.ToString()).Success)
                    {
                        return makePass(pass, ESPECIALES);
                    }
                }
            }
            catch (Exception e)
            {

            }
            return pass;
        }

        public static Double checkPassword(String pass)
        {
            int count = pass.Length;
            double entropia = 0;

            // Si el password tiene menos de 6 caracteres
            if (count < 6)
            {
                return 0.0;
            }

            // Contamos cuantas mayusculas, minusculas, numeros y simbolos existen 
            int upper = 0;
            int lower = 0;
            int numeros = 0;
            int otros = 0;

            for (int i = 0; i < count; i++)
            {
                String c = Char.ToString(pass[i]);
                if (new Regex(@"[A-Z]").Match(c).Success)
                {
                    upper++;
                }
                else if (new Regex(@"[a-z]").Match(c).Success)
                {
                    lower++;
                }
                else if (new Regex(@"[0-9]").Match(c).Success)
                {
                    numeros++;
                }
                else
                {
                    otros++;
                }
            }

            // Calculamos la entropia
            entropia = (upper * 5.7) + (lower * 5.7) + (numeros * 3.322) + (otros * 6.55);

            /*
            if (entropia < 28) {
                return "Password muy debil";
            } else if (entropia < 36) {
                return "Password debil";
            } else if (entropia < 60) {
                return "Password Razonable";
            } else if (entropia < 128) {
                return "Password Fuerte";
            } else {
                return "Password Muy Fuerte";
            }
             */
            return entropia;
        }

    }

}
