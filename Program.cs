
// 1 Écrire un programme qui vérifie si un nombre donné est supérieur à 10.

Console.WriteLine("Entrez un nombre: ");
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






