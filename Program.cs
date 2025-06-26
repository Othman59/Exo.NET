
// 1 Écrire un programme qui vérifie si un nombre donné est supérieur à 10.

/*Console.WriteLine("Entrez un nombre: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int nombre))
{
    if (nombre > 10)
    {
        Console.WriteLine("Le nombre est supérieur à 10.");
    }
    else
    {
        Console.WriteLine("Le nombre n'est pas supérieur à 10.");
    }
}
else
{
    Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entier.");
}




// 2 Vérifier si un nombre donné est positif, négatif ou nul.


Console.WriteLine("Entrez un nombre :");
input = Console.ReadLine();

if (double.TryParse(input, out double nombre2))
{
    if (nombre2 > 0)
    {
        Console.WriteLine("Le nombre est positif.");
    }
    else if (nombre2 < 0)
    {
        Console.WriteLine("Le nombre est négatif.");
    }
    else
    {
        Console.WriteLine("Le nombre est nul.");
    }
}
else
{
    Console.WriteLine("Entrée invalide. Veuillez entrer un nombre.");
}
;


// 3 Créer un programme qui affiche "Vous êtes mineur" si l’âge est inférieur à 18

Console.Write("Entrez votre âge : ");
string saisie = Console.ReadLine();

// Convertir la saisie en entier
if (int.TryParse(saisie, out int age))
{
    if (age < 18)
    {
        Console.WriteLine("Vous êtes mineur");
    }
    else
    {
        Console.WriteLine("Vous êtes majeur");
    }
}
else
{
    Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entier.");
}


// 4 Écrire un programme qui vérifie si une chaîne de caractères est vide ou non

Console.Write("Entrez une chaîne de caractères : ");
string input5 = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("La chaîne est vide.");
}
else
{
    Console.WriteLine("La chaîne n'est pas vide.");
}

// 5 Vérifier si un nombre est pair ou impair.

Console.Write("Entrez un nombre : ");
string? v = Console.ReadLine();

if (int.TryParse(saisie, out int nombre3))
//int.TryParse(...) vérifie que l'utilisateur entre bien un entier.
{
    if (nombre % 2 == 0)

    {
        Console.WriteLine("Le nombre est pair.");
    }
    else
    {
        Console.WriteLine("Le nombre est impair.");
    }
}
else
{
    Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entier.");
}

//6 Écrire un programme qui compare deux nombres et affiche le plus grand.

Console.Write("Entrez le deuxième nombre : ");
string input2 = Console.ReadLine();

if (double.TryParse(input, out double nombre1) && double.TryParse(input2, out double nombre4)) //Il permet d'accepter les nombres entiers ou décimaux.

{
    if (nombre1 > nombre2)
    {
        Console.WriteLine($"Le plus grand nombre est : {nombre1}");
    }
    else if (nombre2 > nombre1)
    {
        Console.WriteLine($"Le plus grand nombre est : {nombre2}");
    }
    else
    {
        Console.WriteLine("Les deux nombres sont égaux.");
    }
}
else
{
    Console.WriteLine("Entrée invalide. Veuillez entrer des nombres valides.");
}

//7 Vérifier si un nombre est divisible par 3 ou par 5.

Console.Write("Entrez un nombre : ");
string ? v1 = Console.ReadLine();

if (int.TryParse(saisie, out int nombre5))
{
    if (nombre % 3 == 0 || nombre % 5 == 0)
    {
        Console.WriteLine("Le nombre est divisible par 3 ou par 5.");
    }
    else
    {
        Console.WriteLine("Le nombre n'est divisible ni par 3 ni par 5.");
    }
}

//8 Demander à l'utilisateur un mot de passe et vérifier s'il correspond à "admin"

Console.Write("Entrez le mot de passe : ");
string motDePasse = Console.ReadLine();

if (motDePasse == "admin")
{
    Console.WriteLine("Mot de passe correct.");
}
else
{
    Console.WriteLine("Mot de passe incorrect.");
}

// 9 Créer un programme qui vérifie si une lettre est une voyelle ou une consonne.

Console.Write("Entrez une lettre : ");
string saisie3 = Console.ReadLine();

if (!string.IsNullOrEmpty(saisie) && char.IsLetter(saisie[0]) && saisie.Length == 1)
{
    char lettre = char.ToLower(saisie[0]); // pour simplifier la vérification

    if ("aeiouy".Contains(lettre))
    {
        Console.WriteLine("C'est une voyelle.");
    }
    else
    {
        Console.WriteLine("C'est une consonne.");
    }
}
else
{
    Console.WriteLine("Entrée invalide. Veuillez entrer une seule lettre.");
}

// 10 Calculer le nombre de caractères dans une chaîne de caractères, si le nombre de caractères est supérieur à 5, ne garder que les 5 premiers caractères

Console.Write("Entrez une chaîne de caractères : ");
string saisie4 = Console.ReadLine();

int longueur = saisie.Length;
Console.WriteLine($"Nombre de caractères : {longueur}");

if (longueur > 5)
{
    string tronquee = saisie.Substring(0, 5);
    Console.WriteLine($"Chaîne tronquée (5 premiers caractères) : {tronquee}");
}
else
{
    Console.WriteLine("Chaîne non tronquée : " + saisie);
}

//11 Écrire un programme qui vérifie si un nombre est compris entre 10 et 20.

Console.WriteLine("Entrez un nombre :");
string saisie5 = Console.ReadLine();

if (int.TryParse(input, out int nombre6)) ;

if (nombre >= 10 && nombre <= 20)

{
    Console.WriteLine("Le nombre n'est pas compris entre 10 et 20.");
}
        else
{
    Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entier.");
}

//12 Demander à l'utilisateur un âge et afficher s'il est un enfant (moins de 12 ans), un adolescent (entre 12 et 18 ans) ou un adulte (plus de 18 ans).

Console.WriteLine("Entrez votre age");
string saisis6 = Console.ReadLine();

if (int.TryParse(saisie, out int _) && age >= 0) //Il évite les âges négatifs
    // Il vérifie que la saisie est un entier.
{
    if (age < 12)
    {
        Console.WriteLine("Vous êtes un enfant.");
    }
    else if (age <= 18)
    {
        Console.WriteLine("Vous êtes un adolescent.");
    }
    else
    {
        Console.WriteLine("Vous êtes un adulte.");
    }
}
else
{
    Console.WriteLine("Âge invalide. Veuillez entrer un nombre entier positif.");
}

//13 Créer un programme qui vérifie si une année est bissextile ou non.

Console.Write("Entrez une année : ");
string saisie = Console.ReadLine();

if (int.TryParse(saisie, out int annee) && annee > 0)
{
    if ((annee % 4 = 0 && annee % 100 != 0) || (annee % 400 = 0))
    {
        Console.WriteLine($"{annee} est une année bissextile.");
    }
    else
    {
        Console.WriteLine($"{annee} n'est pas une année bissextile.");
    }
}
else
{
    Console.WriteLine("Entrée invalide. Veuillez entrer une année positive.");
}

//14 Vérifier si un nombre est positif et multiple de 5.

Console.Write("Entrez un nombre : ");
string? v1 = Console.ReadLine();

if (int.TryParse(saisie, out int nombre5))
{
    if (nombre > 0 && nombre % 5 == 0) //Il vérifie qu’il est un multiple de 5.
       //Il vérifie que le nombre est positif

    {
        Console.WriteLine("Le nombre est multiple par 5.");
    }
    else
    {
        Console.WriteLine("Le nombre n'est multiple par 5.");
    }
}

//15 Écrire un programme qui vérifie si une chaîne de caractères contient la lettre 'a'.

Console.Write("Entrez une chaîne de caractères : ");
string saisie = Console.ReadLine();

if (!string.IsNullOrEmpty(saisie))
{
    if (saisie.Contains('a'))
    {
        Console.WriteLine("La chaîne contient la lettre 'a'.");
    }
    else
    {
        Console.WriteLine("La chaîne ne contient pas la lettre 'a'.");
    }
}
else
{
    Console.WriteLine("Chaîne vide ou invalide.");
}


16//Vérifier si un nombre est divisible à la fois par 2 et par 3, mais pas par 9.

    Console.Write("Entrez un nombre : ");
int nombre = Convert.ToInt32(Console.ReadLine());

if (nombre % 2 == 0 && nombre % 3 == 0 && nombre % 9 != 0)
{
    Console.WriteLine("Le nombre est divisible par 2 et par 3, mais pas par 9.");
}
else
{
    Console.WriteLine("Le nombre ne remplit pas les conditions.");
}

17//Demander à l'utilisateur un nom d'utilisateur et un mot de passe, et vérifier si les deux sont corrects.

Console.Write("Nom d'utilisateur : ");
string nomUtilisateur = Console.ReadLine();

Console.Write("Mot de passe : ");
string motDePasse = Console.ReadLine();

if (nomUtilisateur == utilisateurCorrect && motDePasse == motDePasseCorrect)
{
    Console.WriteLine("Connexion réussie !");
}
else
{
    Console.WriteLine("Nom d'utilisateur ou mot de passe incorrect.");
}

18//Créer un programme qui vérifie si une chaîne de caractères est un palindrome.

Console.Write("Entrez une chaîne de caractères : ");
string saisie = Console.ReadLine();

if (!string.IsNullOrEmpty(saisie))
{
    string original = saisie.ToLower().Replace(" ", ""); 
    char[] tableau = original.ToCharArray();
    Array.Reverse(tableau);
    string inverse = new string(tableau);

    if (original == inverse)
    {
        Console.WriteLine("La chaîne est un palindrome.");
    }
    else
    {
        Console.WriteLine("La chaîne n'est pas un palindrome.");
    }
}
else
{
    Console.WriteLine("Chaîne vide ou invalide.");
}

19//Écrire un programme qui vérifie si un nombre est à la fois positif, pair et supérieur à 100.

Console.Write("Entrez une chaîne de caractères : ");
string saisie = Console.ReadLine();

if (!string.IsNullOrEmpty(saisie))
{
    string original = saisie.ToLower().Replace(" ", ""); // ignore casse et espaces
    char[] tableau = original.ToCharArray();
    Array.Reverse(tableau);
    string inverse = new string(tableau);

    if (original == inverse)
    {
        Console.WriteLine("La chaîne est un palindrome.");
    }
    else
    {
        Console.WriteLine("La chaîne n'est pas un palindrome.");
    }
}
else
{
    Console.WriteLine("Chaîne vide ou invalide.");
}

21//Afficher les nombres de 1 à 10 avec une boucle `for`

for (int i = 1; i <= 10; i++)
    //condition pour continuer la boucle jusqu'à 10

{
    Console.WriteLine(i);
}
    }

22//Afficher les nombres pairs entre 1 et 20

    Console.WriteLine("Nombres pairs entre 1 et 20 :");
for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }

23//Utiliser une boucle pour afficher chaque élément d'un tableau
        
        // Déclarer un tableau
      string[] voiture = { "Mercedes", "Bmw", "Mclaren", "Ferrari", "Audi" };
    
    // Afficher chaque élément du tableau
    for (int i = 0; i < voiture.Length; i++)
                        (donne le nombre d)
    {
        Console.WriteLine(voiture[i]);
    }
}

//24 Demander à l'utilisateur un nombre de 1 à 10 et afficher la table de multiplication.

Console.Write("Entrez un nombre entre 1 et 10 : ");
string saisie = Console.ReadLine();

if (int.TryParse(saisie, out int nombre) && nombre >= 1 && nombre <= 10)
{
    Console.WriteLine($"\nTable de multiplication de {nombre} :");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{nombre} x {i} = {nombre * i}");
    }
}
else
{
    Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entre 1 et 10.");
}

//25 Afficher les éléments d'une chaîne de caractères un par un.

Console.Write("Entrez une chaîne de caractères : ");
string texte = Console.ReadLine();

if (!string.IsNullOrEmpty(texte))
{
    Console.WriteLine("\nCaractères un par un :");
    foreach (char caractere in texte)
    {
        Console.WriteLine(caractere);
    }
}
else
{
    Console.WriteLine("Chaîne vide ou invalide.");
}

//26 Utiliser une boucle pour afficher les nombres de 0 à 100 avec un pas de 10.

Console.WriteLine("Affichage des nombres de 0 à 100 avec un pas de 10 :");

for (int i = 0; i <= 100; i += 10)
{
    Console.WriteLine(i);
}
    }

//27 Afficher les éléments d'une liste avec leurs indices.

List<string> couleurs = new List<string> { "Rouge", "Vert", "Bleu", "Jaune" };

Console.WriteLine("Liste des couleurs avec leurs indices :\n");

for (int i = 0; i < couleurs.Count; i++)
{
    Console.WriteLine($"Indice {i} : {couleurs[i]}");
}
*/
//28 Afficher les nombres de 10 à 1 en ordre décroissant avec une boucle.


//29 Créer une boucle qui calcule la somme des nombres de 1 à 50



//Exo 5 

//Ce que le programme fait 

/*Console.WriteLine("Gestion des notes");
Console.WriteLine("Veuillez saisir 5 notes :");

//Déclarer les variables

int[] notes = new int[5];
int somme = 0;

for (int i = 0; i < 5; i++)
{
    Console.Write($" - Merci de saisir la note {i + 1} (sur /20) : ");

    while (!int.TryParse(Console.ReadLine(), out notes[i]) || notes[i] < 0 || notes[i] > 20)
    {
        Console.WriteLine("   Veuillez entrer une note valide (entre 0 et 20) : ");
    }
    somme += notes[i];
}

int meilleure = notes[0];
int pire = notes[0];

double moyenne = (double)somme / notes.Length;

//Vérifie que chaque note est bien entre 0 & 20

//Résultat

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nla meilleure note est {meilleure}/20");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"la moins bonne note est {pire}/20");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"la moyenne des notes est {moyenne:F1}/20");
    Console.WriteLine("\nAppuyez sur Entrer pour fermer le programme...");
    Console.ReadLine();

    }
}*/

//Exo7

/*Console.WriteLine("Trouver le nombre mystère ---\n");

Random random = new Random();
int nombreMystere = random.Next(1, 51); // entre 1 et 50 inclus
int tentative = 0;
int coups = 0;

do
{
    Console.Write("Veuillez saisir un nombre entre 1 et 50 : ");
    object console = null;
    string saisie = Console.ReadLine();

    if (!int.TryParse(saisie, out tentative) || tentative < 1 || tentative > 50)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entre 1 et 50.\n");
        Console.ResetColor();
        continue;
    }

    coups++;

    if (tentative < nombreMystere)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Le nombre mystère est plus grand.\n");
    }
    else if (tentative > nombreMystere)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Le nombre mystère est plus petit.\n");
    }

    Console.ResetColor();

} while (tentative != nombreMystere);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nBravo ! Vous avez trouvé le nombre mystère ({nombreMystere}) en {coups} coup(s).");
Console.ResetColor();*/


//Exo 8 

// Saisie utilisateur
/*Console.Write("Entrez votre taille en cm : ");
int taille = Convert.ToInt32(Console.ReadLine());

Console.Write("Entrez votre poids en kg : ");
int poids = Convert.ToInt32(Console.ReadLine());

// Détermination de la taille
string tailleVetement = GetTailleVetement(taille, poids);

// Affichage du résultat
if (tailleVetement != null)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nVotre taille de vêtement est : {tailleVetement}");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nAucune taille ne vous correspond.");
}

Console.ResetColor();

    static string GetTailleVetement(int taille, int poids)
{
    // Taille 1
    if ((taille >= 151 && taille <= 163) && (poids >= 48 && poids <= 53))
        return "1";
    if ((taille >= 151 && taille <= 160) && (poids >= 54 && poids <= 59))
        return "1";

    // Taille 2
    if ((taille >= 160 && taille <= 169) && (poids >= 54 && poids <= 65))
        return "2";
    if ((taille >= 163 && taille <= 172) && (poids >= 60 && poids <= 65))
        return "2";

    // Taille 3
    if ((taille >= 166 && taille <= 183) && (poids >= 66 && poids <= 71))
        return "3";
    if ((taille >= 169 && taille <= 175) && (poids >= 72 && poids <= 77))
        return "3";

    // Si aucune correspondance
    return null;
}

//Exo 9

Console.Write("saisie la meilleure moyenne");
int moyenne = Convert.ToInt32(Console.ReadLine());

Console.Write("Entrez votre poids en kg : ");
int note = Convert.ToInt32(Console.ReadLine());

// Détermination de la moyenne
string meilleureMoyenne = GetTailleVetement(taille, poids);

//Exo 9

int choix;

do
{
    Console.Clear();
    Console.WriteLine("--- Menu - Gestion des Notes ---");
    Console.WriteLine("1. Saisir des notes");
    Console.WriteLine("0. Quitter");
    Console.Write("\nVotre choix : ");

    if (!int.TryParse(Console.ReadLine(), out choix))
    {
        choix = -1;
    }

    switch (choix)
    {
        case 1:
            Console.Clear();
            SaisirEtAnalyserNotes();
            break;

        case 0:
            Console.WriteLine("\nFermeture du programme...");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Choix invalide. Appuyez sur Entrée pour continuer.");
            Console.ReadLine();
            break;
    }

} while (true);

    static void SaisirEtAnalyserNotes()
{
    List<int> notes = new List<int>();
    string saisie;
    int note;

    Console.WriteLine("--- Saisie des notes ---");
    Console.WriteLine("Entrez vos notes sur 20 (tapez 0 pour terminer) :\n");

    do
    {
        Console.Write("Note : ");
        saisie = Console.ReadLine();

        if (int.TryParse(saisie, out note))
        {
            if (note == 0) break;

            if (note >= 1 && note <= 20)
            {
                notes.Add(note);
            }
            else
            {
                Console.WriteLine("Note invalide. Entrez un nombre entre 1 et 20.");
            }
        }
        else
        {
            Console.WriteLine("Veuillez entrer une valeur numérique valide.");
        }

    } while (true);

    Console.Clear();

    if (notes.Count == 0)
    {
        Console.WriteLine("Aucune note saisie.\nAppuyez sur Entrée pour revenir au menu...");
        Console.ReadLine();
        return;
    }

    int meilleure = notes[0];
    int pire = notes[0];
    int somme = 0;

    foreach (int n in notes)
    {
        if (n > meilleure) meilleure = n;
        if (n < pire) pire = n;
        somme += n;
    }

    double moyenne = (double)somme / notes.Count;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"✅ Meilleure note : {meilleure}/20");

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"❌ Moins bonne note : {pire}/20");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"📊 Moyenne : {moyenne:F1}/20");

    Console.ResetColor();
    Console.WriteLine("\nAppuyez sur Entrée pour revenir au menu...");
    Console.ReadLine();
}*/


//Exo 1

/* Dans `Main`, déclarez un tableau `notes` contenant : `{ 10, 12, 15, 8 }`.
Calculez et affichez sa moyenne.
Prévoyez aussi le cas où le tableau serait vide.*/

/*class Program
{
    private static double sum;

    static void Main(string[] args)
    {
        // Déclaration et initialisation du tableau de notes
        int[] notes = { 10, 12, 15, 8 };

        // Verifie si le tableau est vide 
        for (int i = 0; i < notes.Length; i++)
        {
            Console.WriteLine("Le tableau de notes est vide.");

                {
                    int sum = 0;
                    //Parcour chaque note du tableau 
                    foreach (int note in notes)
                    {
                        sum += note;
                    }

                    double average = (double)sum / notes.Length;
                    Console.WriteLine("La moyenne des notes est : {average:F1}/20");
                }

                Console.WriteLine("\nAppuyez sur Entrée pour quitter...");
                Console.ReadLine();
            }
        }

    }
*/
//Exo 3 

/*class Program

    private static double sum;

static void Main(string[] args)

// Liste pour stocker les prénoms saisis
        List<string> prenoms = new List<string>();

Console.Write("Combien de prénoms souhaitez-vous saisir ? ");
int n;

// Lecture du nombre de prénoms à saisir
while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
{
    Console.Write("Veuillez entrer un nombre valide (≥ 1) : ");

    // Saisie des prénoms
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Entrez le prénom #{i + 1} : ");
        string prenom = Console.ReadLine();
        prenoms.Add(prenom);
    }
}*/

//Exo 4

// Dictionnaire pour stocker les couples pays / capitale

/*Dictionary<string, string> paysCapitales = new Dictionary<string, string>();
Console.WriteLine("=== Saisie des couples pays / capitale ===");
Console.WriteLine("Tapez \"fin\" comme nom de pays pour arrêter la saisie.\n");

string pays, capital;

while (true) ;

//Demandez le pays

Console.WriteLine("pays: ");
pays = Console.ReadLine();

// Vérifie si l'utilisateur veut arrêter
if (pays.ToLower() == "fin")
{

    // Demande de la capitale
    Console.Write("Capitale : ");
    capital = Console.ReadLine();

    // Ajoute au dictionnaire
    if (!paysCapitales.ContainsKey(pays))
    {
        string capitale = null;
        paysCapitales[pays] = capitale;
    }
    else
    {
        Console.WriteLine("Ce pays a déjà été saisi. Valeur mise à jour.");
        string capitale = null;
        paysCapitales[pays] = capitale;
        Console.WriteLine("\nAppuyez sur Entrée pour quitter.");
        Console.ReadLine();
        capital = Console.ReadLine();



        Console.Clear();
        // Affichage du menu
        Console.WriteLine("=== MENU ===");
        Console.WriteLine("1. Ajouter un pays et sa capitale");
        Console.WriteLine("2. Afficher tous les pays et capitales");
        Console.WriteLine("3. Chercher la capitale d’un pays");
        Console.WriteLine("0. Quitter");
        Console.Write("\nVotre choix : ");


        int choix;
        if (!int.TryParse(Console.ReadLine(), out choix))
        {
            choix = 1;
        }

        switch (choix)
        {

            case 1:
                Console.Clear();
                AjouterPaysCapitale(paysCapitales);
                break;

            case 2:
                Console.Clear();
                AfficherPaysEtCapitales(paysCapitales);
                break;

            case 3:
                Console.Clear();
                ChercherCapitale(paysCapitales);
                break;

            case 0:
                Console.WriteLine("\nFermeture du programme...");
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("❌ Choix invalide. Appuyez sur Entrée pour continuer...");
                Console.ReadLine();
                break;
        }

    }
}
static void AjouterPaysCapitale(Dictionary<string, string> dico)
{
    Console.Clear();
    Console.WriteLine("=== Ajouter un couple pays / capitale ===");
    Console.Write("Pays : ");
    string pays = Console.ReadLine();

    Console.Write("Capitale : ");
    string capitale = Console.ReadLine();

    if (!dico.ContainsKey(pays))
    {
        dico[pays] = capitale;
        Console.WriteLine("✅ Ajouté avec succès !");
    }
    else
    {
        Console.WriteLine("Ce pays existe déjà. Capitale mise à jour.");
        dico[pays] = capitale;
    }

    Console.WriteLine("\nAppuyez sur Entrée pour revenir au menu...");
    Console.ReadLine();
}

static void AfficherPaysEtCapitales(Dictionary<string, string> dico)
{
    Console.Clear();
    Console.WriteLine("=== Liste des pays et capitales ===");

    if (dico.Count == 0)
    {
        Console.WriteLine("Aucun pays enregistré.");
    }
    else
    {
        foreach (var couple in dico)
        {
            Console.WriteLine($"{couple.Key} → {couple.Value}");
        }
    }

    Console.WriteLine("\nAppuyez sur Entrée pour revenir au menu...");
    Console.ReadLine();
}

static void ChercherCapitale(Dictionary<string, string> dico)
{
    Console.Clear();
    Console.WriteLine("=== Recherche de capitale ===");
    Console.Write("Entrez le nom du pays : ");
    string pays = Console.ReadLine();

    if (dico.ContainsKey(pays))
    {
        Console.WriteLine($"La capitale de {pays} est : {dico[pays]}");
    }
    else
    {
        Console.WriteLine($"Le pays \"{pays}\" n'est pas enregistré.");
    }

    Console.WriteLine("\nAppuyez sur Entrée pour revenir au menu...");
    Console.ReadLine();
}*/


//30 Utiliser une boucle pour afficher les 5 premières lettres de l'alphabet.

/*using System;
using System.Runtime.ConstrainedExecution;
internal class Program
{
    private static void Main(string[] args)
    {
        static void Main()
        {
            Console.WriteLine("Les 5 premières lettres de l'alphabet :");

            for (char lettre = 'A'; lettre <= 'E'; lettre++)
            {
                Console.WriteLine(lettre);
            }

            Console.WriteLine("\nAppuyez sur Entrée pour quitter...");
            Console.ReadLine();
        }
}*/

//Exo 5 Parcours de collection variées *

/*class Program
{
    static void Main()
    {
        // 1. Tableau d'entiers avec 5 valeurs
        int[] nombres = { 5, 12, 8, 20, 3 };

        Console.WriteLine("Contenu du tableau d'entiers :");

        // Parcours avec la boucle foreach
        foreach (int nombre in nombres)
        {
            Console.WriteLine(nombre);
        }

        Console.WriteLine("\nAppuyez sur Entrée pour continuer...");
        Console.ReadLine();
    }
}
*/

/*static void AfficherSeparateur()
{
    Console.WriteLine(new string('-', 30));
}*/

//Exo 2 Fonction avec paramètres et retour

/*using System;

class Program
{
    // 1. Addition de deux entiers
    static int Additionner(int a, int b)
    {
        return a + b;
    }
    static bool EstPair(int nombre)
    {
        return nombre % 2 == 0;
    }
    static double CalculerPrixTTC(double prixHT, double tauxTVA = 0.20)
    {
        return prixHT * (1 + tauxTVA);
    }
    static void Main()
    {
        Console.WriteLine("Additionner(5, 3) = " + Additionner(5, 3));
        Console.WriteLine("Additionner(10, -4) = " + Additionner(10, -4));
        Console.WriteLine("Additionner(0, 0) = " + Additionner(0, 0));

        
    }
}

*///Exo 3 Utiliser la surcharge de fonctions

/*class Program
{
    // Surcharge 1 : Multiplie deux entiers
    static int Multiplier(int a, int b)
    {
        return a * b;
    }
    static int Multiplier(int a, int b, int c)
    {
        return a * b * c;
    }

    static void Main()
    {
       
        int resultat2 = Multiplier(2, 3);
        Console.WriteLine(Multiplier(2, 3, 4));

        Console.WriteLine("Appuyez sur Entrée pour quitter...");
        Console.ReadLine();
    }
}

*/

//Exo 5 Fonctions statiques vs Fonctions d’instance

/*static void BonjourGlobal()
{
    Console.WriteLine("Hello word");
}
//Methode non statique
class Salutations
{
    public void BonjourGlobal(string prenom)
    {
        Console.WriteLine($"Bonjour, {prenom}");
    }

     static void Main()
    {

        // Appel de la méthode statique via le nom de la classe (sans créer d’objet)
        
            Console.WriteLine(); // ligne vide pour séparer

            Salutations salut = new Salutations();
            salut.BonjourGlobal("Alice");

            Console.WriteLine("\nAppuyez sur Entrée pour quitter...");
            Console.ReadLine();
        }
    }
*/

//ExO 6 : Fonctions locales en pratique

// Fonction principale

/*    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tableauOriginal = { 5, 8, 13 };

            AnalyseNombres(tableauOriginal);
        }
        static void AnalyseNombres(int[] tableau)
        {
            bool EstPair(int x)
            {
                return x % 2 == 0;
            }
            foreach (int n in tableau)
            {
                Console.WriteLine($"{n} est {((EstPair(n) == true) ? "pair" : "impaire")}");
            }
        }
}*/

//Exo 7 
/*
using System;

class Program
{
    static void Main()
    {
        // Déclaration d'une variable/lambda 
        Func<int, int> triple = nombre => nombre  * 3;

        List<int> nombres = new List<int> { 2, 5, 10 };

        int resultat = triple(10);
        Console.WriteLine($"triple(10) = {resultat}");
        nombres.RemoveAll(x => x % 2 != 0);
        Console.WriteLine(string.Join("-", nombres));


    }
}

*/

// Exo 8
/*using System;

class Program
{
    static void CalculerInfos(int a, int b, int c)
    {
        // Calcule la somme des 3 entiers
        int somme = a + b + c;
        Console.WriteLine($"Somme = {somme}");

        // Vérifie si tous les nombres sont positifs
        if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine("Tous positifs");

            // Calcule la moyenne
            double moyenne = (a + b + c) / 3.0;
            Console.WriteLine($"Moyenne = {moyenne}");
        }
    }

}*/

//Exo 9 

/*using System;

public class NotesUtil
{
    public List<int> Notes { get; set; }

    public NotesUtil(List<int> notes)
    {
        Notes = notes ?? new List<int>();
    }

    public void AfficherStats()
    {
        if (Notes.Count == 0)
        {
            Console.WriteLine("Aucune note à analyser.");
            return;
        }

        Console.WriteLine("===== Statistiques des notes =====");

        double moyenne = CalculerMoyenne(Notes);
        Console.WriteLine($"Moyenne : {moyenne:F2}");

        int max = Notes.Max();
        Console.WriteLine($"Note maximale : {max}");

        var triees = Notes.OrderByDescending(n => n).ToList();
        Console.WriteLine("Notes triées (décroissant) : " + string.Join(", ", triees));
    }

    // Méthode statique 
    public static double CalculerMoyenne(List<int> notes)
    {
        if (notes == null || notes.Count == 0)
            return 0;

        return (double)notes.Sum() / notes.Count;
    }
}*/

//Exo 36 Écrire une boucle qui affiche les nombres de 1 à 10, puis termine 

/*using System;

class Program
{
    static void Main()
    {
        // Boucle for pour afficher les nombres de 1 à 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Fin de la boucle.");
    }
}
*/

//Exo 37 Créer une boucle `while` qui décrémente un nombre à partir de 10 jusqu'à 0.

/*using System;

class Program
{
    static void Main()
    {
        int compteur = 10;

        // Boucle while qui décrémente jusqu'à 0
        while (compteur >= 0)
        {
            Console.WriteLine(compteur);
            compteur--; // Décrémentation
        }

        Console.WriteLine("Fin de la boucle.");
    }
}*/

//Exo 38 Demander un nombre à l'utilisateur et calculer sa factorielle avec une boucle `while`.

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Entrez un nombre entier positif : ");
        int nombre = int.Parse(Console.ReadLine());

        long factorielle = 1;
        int compteur = nombre;

        while (compteur > 1)
        {
            factorielle *= compteur;
            compteur--;
        }

        Console.WriteLine($"La factorielle de {nombre} est : {factorielle}");
    }
}
*/

//Exo 39 Afficher les nombres pairs de 2 à 200 si ils sont divisible par 3 avec une boucle while.

/*using System;

class Program
{
    static void Main()
    {
        int nombre = 2;

        while (nombre <= 200)
        {
            // Vérifie si le nombre est pair ET divisible par 3
            if (nombre % 2 == 0 && nombre % 3 == 0)
            {
                Console.WriteLine(nombre);
            }

            nombre++;
        }

        Console.WriteLine("Fin de la boucle.");
    }
}
*/

//Exo 40 Créer une tableau d'une certaine longueur, demander à l'utilisateur des nombres et les affecter au tableau tant qu'il n'est pas rempli entièrement.

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Entrez la taille du tableau : ");
        int taille = int.Parse(Console.ReadLine());

        int[] tableau = new int[taille];
        int index = 0;

        while (index < taille)
        {
            Console.Write($"Entrez un nombre pour l'élément {index + 1} : ");
            if (int.TryParse(Console.ReadLine(), out int valeur))
            {
                tableau[index] = valeur;
                index++;
            }
            else
            {
                Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entier.");
            }
        }

        Console.WriteLine("\nContenu du tableau :");
        foreach (int n in tableau)
        {
            Console.Write(n + " ");
        }
    }
}*/

//41  Utiliser une boucle pour afficher les nombres de 1 à 20, mais arrêter dès que vous atteignez 10.

/*class Program
{
    static void Main()
    {
        int i = 1;

        while (i <= 20)
        {
            Console.WriteLine(i);

            if (i == 10)
            {
                Console.WriteLine("Arrêt à 10 !");
                break; // Interrompt la boucle
            }

            i++;
        }
    }
}*/


//42.Créer une boucle qui demande un nombre et s'arrête si le nombre est 0.

/*class Program
{
    static void Main()
    {
        int nombre;

        do
        {
            Console.Write("Entrez un nombre (0 pour arrêter) : ");
            nombre = int.Parse(Console.ReadLine());

        } while (nombre != 0);

        Console.WriteLine("Boucle terminée car vous avez entré 0.");
    }
}*/

//43.Utiliser `continue` pour afficher uniquement les nombres impairs de 1 à 10.

/*class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }

            Console.WriteLine(i); // Affiche les impairs
        }
    }
}*/

//44. Écrire une boucle qui affiche les nombres de 1 à 20, mais saute les multiples de 3.

/*class Program
{
    static void Main()
    {
        for (int i = 1; i <= 20; i++)
        {
            if (i % 3 == 0)
            {
                continue; // Saute les multiples de 3
            }

            Console.WriteLine(i);
        }
    }
}*/


//45. Demander à l'utilisateur un nombre et afficher tous les nombres de 1 à ce nombre, sauf ceux divisibles par 4.

/*class Program
{
    static void Main()
    {
        Console.Write("Entrez un nombre : ");
        int limite = int.Parse(Console.ReadLine());

        for (int i = 1; i <= limite; i++)
        {
            if (i % 4 == 0)
            {
                continue;
            }

            Console.WriteLine(i);
        }
    }
}*/

//46.Créer une boucle qui affiche les éléments d'un tableau mais s'arrête dès qu'elle rencontre un élément spécifique.

/*class Program
{
    static void Main()
    {
        string[] mots = { "chien", "chat", "lapin", "souris", "arbre", "voiture" };

        foreach (string mot in mots)
        {
            if (mot == "stop")
            {
                Console.WriteLine("Mot d'arrêt rencontré. Fin de boucle.");
                break; // Arrête la boucle
            }

            Console.WriteLine(mot);
        }
    }
}*/

//47. Utiliser `break` pour quitter une boucle infinie après 5 itérations.
/*class Program
{
    static void Main()
    {
        int compteur = 0;

        while (true)
        {
            compteur++;
            Console.WriteLine($"Itération {compteur}");

            if (compteur == 5)
            {
                break; // Quitte la boucle après 5 itérations
            }
        }

        Console.WriteLine("Boucle terminée.");
    }
}*/

// 48. Utiliser `continue` pour ignorer les lettres 'a' et 'e' lors de l'affichage des lettres d'un mot.
/*class Program
{
    static void Main()
    {
        Console.Write("Entrez un mot : ");
        string mot = Console.ReadLine();

        foreach (char lettre in mot)
        {
            if (lettre == 'a' || lettre == 'e')
            {
                continue; // Ignore les lettres 'a' et 'e'
            }

            Console.Write(lettre);
        }

        Console.WriteLine(); // Pour aller à la ligne après l'affichage
    }
}*/

//49. Écrire une boucle qui demande à l'utilisateur de saisir un mot, mais qui s'arrête dès qu'il entre "stop".

/*class Program
{
    static void Main()
    {
        string mot;

        while (true)
        {
            Console.Write("Entrez un mot (ou 'stop' pour quitter) : ");
            mot = Console.ReadLine();

            if (mot.ToLower() == "stop")
            {
                Console.WriteLine("Arrêt du programme.");
                break;
            }

            Console.WriteLine($"Vous avez saisi : {mot}");
        }
    }
}*/

/*//50 Afficher les éléments d’une liste, arrêter la boucle si un même élément apparaît une deuxième fois.
class Program
{
    static void Main()
    {
        List<string> elements = new List<string> { "chat", "chien", "oiseau", "chat", "lapin" };
        HashSet<string> dejaVus = new HashSet<string>();

        foreach (string element in elements)
        {
            if (dejaVus.Contains(element))
            {
                Console.WriteLine($"Élément répété trouvé : {element}. Arrêt de la boucle.");
                break;
            }

            Console.WriteLine(element);
            dejaVus.Add(element);
        }
    }
}*/

// 51. Utiliser des boucles imbriquées pour afficher une pyramide de nombres.
/*class Program 
{
    static void Main()
    {
        int lignes = 5;

        for (int i = 1; i <= lignes; i++)
        {
            for (int espace = 1; espace <= lignes - i; espace++)
            {
                Console.Write(" ");
            }

            // Affiche les nombres croissants de 1 à i
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
      }
   }*/


























