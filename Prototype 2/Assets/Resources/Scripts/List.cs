
public class List
{
    #region Elements List
    public static string[] numbers = new string[10] { "Qual o número do Hidrogênio?",
                                                      "Qual o elemento representa 16?",
                                                      "Qual o número do Cloro?",
                                                      "Qual o número do Carbono?",
                                                      "Qual o elemento representa 10?",
                                                      "Qual o número do Cálcio?",
                                                      "Qual o número do Alumínio?",
                                                      "Qual o elemento representa 19?",
                                                      "Qual o elemento representa 9?",
                                                      "Qual o número do Nitrogênio?" }; // perguntas

    public static string[] numbers_right = new string[10] { "1", "Enxofre", "17", "6", "Neônio", "20", "13", "Potássio", "Flúor", "7" }; // corretas
    public static string[] numbers_alt1 = new string[10] { "2", "Flúor", "18", "7", "Argônio", "12", "23", "Sódio", "Cloro", "9" }; // alternativas 1
    public static string[] numbers_alt2 = new string[10] { "3", "Oxigênio", "16", "8", "Nitrogênio", "38", "3", "Carbono", "Bromo", "5" }; // alternativas 2

    public static string[] symbols = new string[10] { "Qual o símbolo do Potássio?",
                                                      "Qual o elemento H representa?",
                                                      "Qual o símbolo do Sódio?",
                                                      "Qual o elemento B representa?",
                                                      "Qual o símbolo do Cobre?",
                                                      "Qual o símbolo do Ferro?",
                                                      "Qual o símbolo do Enxofre?",
                                                      "Qual o símbolo do Mercúrio?",
                                                      "Qual o símbolo do Cálcio?",
                                                      "Qual o símbolo do Neônio?" }; // perguntas

    public static string[] symbols_right = new string[10] { "K", "Hidrogênio", "Na", "Boro", "Cu", "Fe", "S", "Hg", "Ca", "Ne" }; // corretas
    public static string[] symbols_alt1 = new string[10] { "P", "Hélio", "S", "Berílio", "C", "F", "N", "Mo", "Cs", "N" }; // alternativas 1
    public static string[] symbols_alt2 = new string[10] { "Pt", "Háfnio", "K", "Bromo", "Co", "Fr", "P", "Mc", "C", "Nh" }; // alternativas 2

    public static string[] names = new string[10] { "Qual o nome do elemento H?",
                                                    "Qual o nome do elemento P?",
                                                    "Qual o nome do elemento C?",
                                                    "Qual elemento é radioativo?",
                                                    "Qual o nome do elemento N?",
                                                    "Transporta oxigênio pelas hemoglobinas",
                                                    "Qual o nome do elemento F?",
                                                    "Elemento essencial para respiração",
                                                    "Qual o nome do elemento K?",
                                                    "Qual o nome do elemento Pb?" }; // perguntas

    public static string[] names_right = new string[10] { "Hidrogênio", "Fósforo", "Carbono", "Urânio", "Nitrogênio", "Ferro", "Flúor", "Oxigênio", "Potássio", "Chumbo" }; // corretas
    public static string[] names_alt1 = new string[10] { "Helio", "Polônio", "Cobre", "Cobalto", "Neônio", "Carbono", "Fósforo", "Nitrogênio", "Cálcio", "Mercúrio" }; // alternativas 1
    public static string[] names_alt2 = new string[10] { "Háfnio", "Chumbo", "Cobalto", "Lítio", "Nióbio", "Potássio", "Ferro", "Hidrogênio", "Criptônio", "Platina" }; // alternativas 2

    public static string[] mass = new string[10] { "Qual a massa do Hidrogênio?",
                                                   "Qual a massa do Sódio?",
                                                   "Qual a massa do Carbono?",
                                                   "Qual a massa do Potássio?",
                                                   "Qual a massa do Oxigênio?",
                                                   "Qual a massa do Fósforo?",
                                                   "Qual a massa do Enxofre?",
                                                   "Qual a massa do Hélio?",
                                                   "Qual a massa do Nitrogênio?",
                                                   "Qual a massa do Cloro?" }; // perguntas

    public static string[] mass_right = new string[10] { "1", "23", "12", "39", "16", "31", "32", "4", "14", "35" }; // corretas
    public static string[] mass_alt1 = new string[10] { "2", "24", "6", "19", "8", "15", "31", "2", "7", "17" }; // alternativas 1
    public static string[] mass_alt2 = new string[10] { "3", "22", "7", "29", "32", "16", "30", "3", "28", "18" }; // alternativas 2

    public static string[] period = new string[10] { "Qual o período do Hidrogênio?",
                                                     "Qual o período do Potássio?",
                                                     "Qual o período do Carbono?",
                                                     "Qual o período do Ferro?",
                                                     "Qual o período do Hélio?",
                                                     "Qual o período do Cobre?",
                                                     "Qual o período do Oxigênio?",
                                                     "Qual o período do Fósforo?",
                                                     "Qual o período do Cálcio?",
                                                     "Qual o período do Mercúrio?"}; // perguntas

    public static int[] period_right = new int[10] { 1, 4, 2, 4, 1, 4, 2, 3, 4, 6 }; // corretas
    public static int[] period_alt1 = new int[10] { 2, 3, 3, 5, 3, 5, 3, 4, 5, 5 }; // alternativas 1
    public static int[] period_alt2 = new int[10] { 3, 2, 4, 6, 4, 6, 4, 5, 3, 7 }; // alternativas 2

    public static string[] family = new string[10] { "Representa os Metais Alcalinos",
                                                     "Qual a família do Cloro?",
                                                     "Representa os Metais Alcalinos Terrosos",
                                                     "Qual a família do Hélio?",
                                                     "Representa os Calcogênios",
                                                     "Qual a família do Carbono?",
                                                     "Representa os Gases Nobres",
                                                     "Qual a família do Boro?",
                                                     "Representa os Halogênios",
                                                     "Qual a família do Magnésio?"}; // perguntas

    public static string[] family_right = new string[10] { "1A", "7A", "2A", "8A", "6A", "4A", "8A", "3A", "7A", "2A" }; // corretas
    public static string[] family_alt1 = new string[10] { "2A", "6A", "3A", "1A", "5A", "5A", "7A", "2A", "8A", "3A" }; // alternativas 1
    public static string[] family_alt2 = new string[10] { "3A", "5A", "4A", "2A", "4A", "3A", "6A", "5A", "6A", "4A" }; // alternativas 2
    #endregion
}