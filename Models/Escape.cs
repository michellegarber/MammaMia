class Escape{
    //Atributos
    private static string[] incognitasSalas = new string[4];
    private static int estadoJuego;

    //Métodos
    private static void InicializarJuego(){
        incognitasSalas[0] = "21108";
        incognitasSalas[1] = "70189";
        incognitasSalas[2] = "56279";
        incognitasSalas[3] = "35791";
    }

    public static int GetEstadoJuego(){
        //si es necesario inicializarlo en 1
        return estadoJuego;
    }
    public static bool ResolverSala(int Sala, string Incognita){
        bool resuelto = false;
        if(incognitasSalas.Length == 0){
            InicializarJuego();
        }
        if (Sala == estadoJuego && Incognita == incognitasSalas[Sala-1])
        {
            resuelto = true;
        }
        return resuelto;

    }
}