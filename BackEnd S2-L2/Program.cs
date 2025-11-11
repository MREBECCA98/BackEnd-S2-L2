
using BackEnd_S2_L2;
using BackEnd_S2_L2.Classi;


Console.WriteLine("""

    1. Crea il tuo curriculum

    """);
int scelta = int.Parse(Console.ReadLine());

List<CV> Info = new List<CV>();

switch (scelta)
{
    case 1:
        try
        {
            CV cv = new CV();
            Console.WriteLine("\nINFORMAZIONI PERSONALI");
            //nome
            do
            {
                Console.WriteLine("\nNome:");
                cv.InfoPersonali.Nome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(cv.InfoPersonali.Nome))
                {
                    Console.WriteLine("Campo vuoto, inserisci il tuo nome");
                }
            } while (string.IsNullOrWhiteSpace(cv.InfoPersonali.Nome));




            Console.WriteLine("\nCognome:");
            cv.InfoPersonali.Cognome = Console.ReadLine();

            Console.WriteLine("\nTelefono:");
            cv.InfoPersonali.Telefono = Console.ReadLine();

            Console.WriteLine("\nEmail:");
            cv.InfoPersonali.Email = Console.ReadLine();

            Info.Add(cv);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Errore nell'inserimento dei dati");
        }
        break;
}