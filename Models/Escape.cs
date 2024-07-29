class Escape{
    //Atributos
    private static string[] incognitasSalas = new string[4];
    private static int estadoJuego = 1;

    //Métodos
    private static void InicializarJuego(){
        incognitasSalas[0] = "84747";
        incognitasSalas[1] = "gpcai";
        incognitasSalas[2] = "afrodita";
        incognitasSalas[3] = "bill";
        
    }

    public static int GetEstadoJuego(){
        return estadoJuego;
    }
    public static bool ResolverSala(int Sala, string Incognita){
        bool resuelto = false;
        if(incognitasSalas[0] == null){
            InicializarJuego();
        }
        if (Sala == estadoJuego && Incognita == incognitasSalas[Sala-1])
        {
            resuelto = true;
            estadoJuego++;
        }
        return resuelto;

    }
}