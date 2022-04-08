using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograIMC

{
    public class ProgramImc
    {
        private const double KG = 2.2046;
        public String Nombre { get; set; }
        public int edad { get; set; }
        public int altura { get; set; }

        public char sexo { get; set; }
        public int peso { get; set; }
        public double imc { get; set; }


       
        public String prueba()
        {
            edad = 18;
            altura = 170;
            sexo = 'M';
            peso = 158;


            double pesoKG = this.peso / KG;
            double estaturaMts = (double)this.altura / 100;
            double altu = (Math.Pow(estaturaMts, 2));
            imc = pesoKG / altu;
            return this.imc.ToString();

        }
        public String Mensajes()
        {
            if (imc <= 18.5)
            {
                String mensaje = " OJO !!! SU PESO ES INSUFICIENTE, HAZ QUE CADA BOCADO CUENTE...";
                return mensaje;
            }
            else if (imc >= 18.5 & imc <= 24.9)
            {
                String mensaje = " PESO NORMAL Y SALUDABLE, BUEN TRABAJO, SIGUE ASÍ...";
                return mensaje;
            }
            else if (imc >= 25.0 & imc <=29.9)
            {
                String mensaje = "ORALESS! USTED TIENE SOBREPESO, BAJALE A LOS TORTILLAS AMIG@";
                return mensaje;
            }
            else if (imc >=30)
            {
                String mensaje = "USTED TIENE OBESIDAD, DEBE CUIDAR SU SALUD!!!";
                return mensaje;
            }
            return "";
        }


        public override string ToString()
        {
            String retorno = $"Altura={altura} \n peso={peso} imc {imc}";
            return retorno;
        }

        public string Sugerencias()
        {
            if (imc <= 18.5)
            {
                String Sugerencia = "-> COME CON MÁS FRECUENCIA DE 4 A 6 VECES AL DÍA. \n" +
                                    "-> CONSUME LICUADOS Y BATIDOS ALTOS EN CARBOHIDRATOS Y PROTEÍNA. \n" +
                                    "-> CARNE, LECHE, FRUTAS INCLUYELAS EN TU DIETA DIARIA. \n" +
                                    "-> HAZ EJERCICIO CON REGULARIDAD. \n" +
                                    "-> CONSULTA TU SITUACIÓN CON UN MEDICO O NUTRICIONISTA. ";
                return Sugerencia;
            }
            else if (imc >= 18.5 & imc <= 24.9)
            {
                String Sugerencia = "-> SIGUE UNA DIETA BALANCEADA EN CARBOHIDRATOS, PROTEÍNAS, LACTEOS. \n" +
                                    "-> CONSUME ALIMENTOS RICOS EN FIBRA. \n" +
                                    "-> HAZ EJERCICIO CON REGULARIDAD. \n" +
                                    "-> CONTROLA LAS GRASAS SATURADAS. \n" +
                                    "-> PUEDES CONSULTAR TU PROCESO CON UN NUTRICIONISTA.";
                return Sugerencia;
            }
            else if (imc >= 25.0 & imc <= 29.9)
            {
                String Sugerencia = "-> EVITA CONSUMIR FRITURAS. \n" +
                                    "-> TOMA DE 2 A 3 LITROS DE AGUA AL DÍA. \n" +
                                    "-> CONSUME UN MÁXIMO DE 500 CALORÍAS POR DÍAS. \n" +
                                    "-> HAZ UN EXTRICTA DIETA EN FRUTAS Y VERDURAS. \n" +
                                    "-> HAZ EJERCICIO SELECTIVO DIARIO. \n" +
                                    "-> CONSULTA TU SITUACIÓN CON TU MEDICO O NUTRICIONISTA.";
                return Sugerencia;
            }
            else if (imc >= 30)
            {
                String mensaje = "-> REDUCE LAS PORCIONES DE COMIDA EN CADA TIEMPO. \n" +
                                 "-> REDUCE EL CONSUMO DE CALORÍAS DE 350 A 450 DIARIAS. \n" +
                                 "-> TOMA 2 A 3 LITROS DE AGUA AL DÍA. \n" +
                                 "-> RECUDE LOS TIEMPOS DE COMIDA. \n" +
                                 "-> ELIMINA LAS GRASAS SATURADAS DE TU DIETA. \n" +
                                 "-> ELIMINA LA COMIDA CHATARRA DE TU DIETA. \n" +
                                 "-> DUERME UN MÍNIMO DE 8HRS DIARIAS. \n" +
                                 "-> CONSUME ALIMENTOS Y BEBIDAS ALTOS EN FIBRA. \n" +
                                 "-> PUEDES AYUDARTE CON ALGÚN MEDICAMENTO NATURAL INDICADO POR UN MEDICO. \n" +
                                 "-> TOMA TÉ´S LAXANTES. \n" +
                                 "-> SÉ ESTRICTO EN TU RUTINA DIARIA. \n" +
                                 "-> HAZ EJERCICIO INTENSO DIARIAMENTE. \n" +
                                 "-> CONSULTA TU SITUACIÓN CON TU MEDICO O NUTRICIONISTA.";
                return mensaje;
            }
            return "";
        

        }

    }
}
