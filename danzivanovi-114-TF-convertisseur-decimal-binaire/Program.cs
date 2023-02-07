namespace danzivanovi_114_TF_convertisseur_decimal_binaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Titre();

            Decimal();

            static void Titre()
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("- Convertisseur Décimal entier non signé en binaire -");
                Console.WriteLine("-----------------------------------------------------");
            }

            static void Decimal()
            {
                //Variable permettant de déterminer si le programme doit être répété ou non
                bool repeat = true;

                //Boucle permettant de répéter le programme tant que repeat est vrai
                while (repeat)
                {
                    //Demande à l'utilisateur d'entrer un nombre décimal
                    Console.Write("\nEntrez un nombre décimal :");

                    //Lecture de la réponse de l'utilisateur
                    string valeur = Console.ReadLine();

                    //Variable pour stocker le nombre décimal converti
                    decimal nbDecimal;

                    //Essaie de convertir la réponse de l'utilisateur en nombre décimal
                    if (decimal.TryParse(valeur, out nbDecimal))
                    {

                        //Conversion du nombre décimal en entier
                        int nbEntier = (int)nbDecimal;

                        //Conversion de l'entier en nombre binaire
                        string nbBinaire = Convert.ToString(nbEntier, 2);

                        //Affichage du résultat de la conversion
                        Console.WriteLine("\nLe décimal " + nbDecimal + " vaut " + nbBinaire + " en binaire.");

                        //Demande à l'utilisateur s'il veut recommencer le programme
                        Console.WriteLine("Voulez-vous recommencer ? Si oui, appuyez sur la touche Entrée.");

                        //Lecture de la réponse de l'utilisateur
                        ConsoleKeyInfo keyInfo = Console.ReadKey();

                        //Si l'utilisateur n'a pas appuyé sur Entrée, le programme ne doit pas être répété
                        if (keyInfo.Key != ConsoleKey.Enter)
                        {
                            repeat = false;
                        }
                    }
                    else
                    {
                        //Si la réponse de l'utilisateur ne peut pas être convertie en décimal, affiche un message d'erreur
                        Console.WriteLine("La valeur saisie est fausse. Veuillez ressayer.");
                    }
                }
            }


        }
    }
}