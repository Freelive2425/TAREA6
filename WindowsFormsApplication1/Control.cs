using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Control
    {
        public static List<Avion>aviones { get; set; }
        public static List<Vuelo> ListaVuelos { get; set; }

        public Control()
        {
            if(aviones==null)
            {
                aviones = new List<Avion>();
            }
            if(ListaVuelos==null)
            {
                ListaVuelos = new List<Vuelo>();
            }
        }
        public void Registrar_Avion(Avion obj)
        {
            if(Existe_Avion(obj.CODIGOAVION)==false)
            {
                aviones.Add(obj);
            }
            
        }
        public bool Existe_Avion(string codigo)
        {
            return aviones.Exists(delegate (Avion x) { return x.CODIGOAVION == codigo; });
        }
        public List<Avion> Listar_AvionesPorTipo(string TipoAvion)
        {

            //  List<Avion> LisatAux = aviones.FindAll(delegate(Avion x) { return x.TIPOAVION == TipoAvion; });
            List<Avion> ListaAux = aviones.FindAll(i => i.TIPOAVION == TipoAvion);
            return ListaAux;

        }
        public void Registrar_Vuelo(Vuelo objvuelo,string codigoAvion)
        {

            Avion auxiliar = aviones.Find(delegate (Avion x) { return x.CODIGOAVION == codigoAvion; });
            
            if(Existe_Vuelo(objvuelo.NUMEROVUELO)==false)
            {
                auxiliar.VUELOS.Add(objvuelo);
            }
            ListaVuelos.Add(objvuelo);

        }
        public bool Existe_Vuelo(string NumeroVuelo)
        {
            return ListaVuelos.Exists(delegate (Vuelo x) { return x.NUMEROVUELO == NumeroVuelo; });
        }
        public List<Avion> ListarAvionesDestino(string ciudadD)
        {
            List<Avion> avionesAux = new List<Avion>();

            // aviones.FindAll(i => i.VUELOS[i].CIUDAD_D == ciudadD); NOSE PUEDE EVALUAR EN DIFERENTES NIVELES
            foreach (Avion Aux in aviones)
            {

                foreach (Vuelo aux2 in Aux.VUELOS)
                {
                    if (aux2.CIUDAD_D == ciudadD)
                    {
                        avionesAux.Add(Aux);
                    }
                }
            }

            return avionesAux;
        }
        public List<Avion>ListarAvionesMenorVuelos()
        {
            int vaux = 9999;
            foreach(Avion aux in aviones)
            {
                if(aux.VUELOS.Count<vaux)
                {
                    vaux = aux.VUELOS.Count;
                }
            }
            List<Avion> avionesAux = aviones.FindAll(delegate(Avion x) { return x.VUELOS.Count == vaux; });
            return avionesAux;
        }
        public int TotalPasajeros(string origen, string destino)
        {
            int contador = 0;

            foreach(Avion x in aviones)
            {
                foreach(Vuelo y in x.VUELOS)
                {
                    if(y.CIUDAD_O==origen&&y.CIUDAD_D==destino)
                    {
                        if(x.TIPOAVION=="Boeing 737")
                        {
                            contador = contador + 117;
                        }
                        if(x.TIPOAVION=="Airbus A-310")
                        {
                            contador = contador + 265;
                        }
                        if(x.TIPOAVION=="Boeing 747")
                        {
                            contador = contador + 300;
                        }
                        if(x.TIPOAVION=="Airbus A-320")
                        {
                            contador = contador + 220;
                        }
                    }
                }
            }

            return contador;
        }


    }
}
