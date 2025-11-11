
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

            //cognome
            do
            {
                Console.WriteLine("\nCognome:");
                cv.InfoPersonali.Cognome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(cv.InfoPersonali.Cognome))
                {
                    Console.WriteLine("Campo vuoto, inserisci il tuo cognome");
                }
            } while (string.IsNullOrWhiteSpace(cv.InfoPersonali.Cognome));

            //telefono
            do
            {
                Console.WriteLine("\nTelefono:");
                cv.InfoPersonali.Telefono = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(cv.InfoPersonali.Telefono))
                {
                    Console.WriteLine("Campo vuoto, inserisci il tuo numero di telefono");
                }
                else if (cv.InfoPersonali.Telefono.Length != 10)
                {
                    Console.WriteLine("Numero di telefono non valido");
                }
            } while (string.IsNullOrWhiteSpace(cv.InfoPersonali.Telefono) || cv.InfoPersonali.Telefono.Length != 10);

            //Email
            do
            {
                Console.WriteLine("\nEmail:");
                cv.InfoPersonali.Email = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(cv.InfoPersonali.Email))
                {
                    Console.WriteLine("Campo vuoto, inserisci il tuo nome");
                }
                else if (!cv.InfoPersonali.Email.Contains("@"))
                {
                    Console.WriteLine("Campo non valido, inserisci @");
                } ;
            } while (string.IsNullOrWhiteSpace(cv.InfoPersonali.Email) || !cv.InfoPersonali.Email.Contains("@"));




            Info.Add(cv);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Errore nell'inserimento dei dati");
        }
        break;
}