/*
/////////////////////
/// Les arrays 1d ///
/////////////////////


int[] arrayInteger = { 1, 2, 3, 4 };
string[] arrayString = { "un", "deux", "trois", "quatre" };
bool[] arrayBoolean = { true, false, true, true, false };


Console.WriteLine("------- new int[] --------");

int[] arrayInteger2 = new int[4];
for(int i = 0; i < arrayInteger2.Length; i++)
    Console.WriteLine(arrayInteger2[i]);



Console.WriteLine("------- new string[] --------");

string[] arrayString2 = new string[4];
for(int i = 0; i < arrayString2.Length; i++)
    Console.WriteLine(arrayString2[i]);


Console.WriteLine("------- cw d'un [] --------");

//pour accèder au premier élement dans mes arrays ! c'est le 0 !
// mon array de int -> CONTIENT 4 élement -> numéroté comme suis -> 0, 1, 2, 3
Console.WriteLine(arrayInteger[0]); // -> "1"
Console.WriteLine(arrayString[3]); // -> "quatre"
Console.WriteLine(arrayBoolean[4]); // false (le dernier du tableau...)

//methodes et props des array exemples
Console.WriteLine("------- .Length --------");
Console.WriteLine(arrayInteger.Length); //version int de la longueur du array !

Console.WriteLine("------- .LongLength --------");
Console.WriteLine(arrayInteger.LongLength); //si array trop grand, on passe sur un long !


Console.WriteLine("------- .Last() --------");
Console.WriteLine(arrayInteger.Last()); //renvoi le last element du array

Console.WriteLine("------- .Average() --------");
Console.WriteLine(arrayInteger.Average()); //moyenne de tous ls éléments

Console.WriteLine("------- .Max() --------");
Console.WriteLine(arrayInteger.Max()); //sort le pluys grand élément !
*/


/////////////////////
/// les arrays XD ///
/////////////////////
/*
//les tableaux matricielle

//je connais tous mes éléments
int[,] multiInt = { { 0,1,2,3 }, { 4,5,6,7 } };

// si je veux accès à la valeur 6 par exemple
Console.WriteLine(multiInt[1, 2]);
//si je veux le 4
Console.WriteLine(multiInt[1, 0]);

//quand on ne connais pas encore les éléments
string[,] multiString = new string[3, 5];
multiString[1, 3] = "Loïc";

Console.WriteLine(multiString[1, 3]);


int[,] multiInt2 = new int[3, 5];
foreach(int item in multiInt2)
{
    Console.WriteLine(item);
}

*/

//les tableau orthogonaux
/*
int[][] arrayInt = { new int[] { 0, 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 9 } };
int[][] arrayInt2 = new int[2][];
arrayInt2[0] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
arrayInt2[1] = new int[] { 11, 12, 13, 14, 15, 16, 17 };

Console.WriteLine(arrayInt[1][2]);
Console.WriteLine(arrayInt2[1][4]);

for(int i = 0; i < arrayInt2.Length; i++)
{
    //Console.WriteLine(arrayInt2[i]);

    for(int j = 0; j < arrayInt2[i].Length; j++)
    {
        Console.Write(arrayInt2[i][j]);
    }
    Console.WriteLine();
}*/


/*
//les tableau orthogonaux pour ce marrer
int[][] arrayInt2 = new int[5][];
arrayInt2[0] = new int[] { 0, 0, 0, 0, 0 };
arrayInt2[1] = new int[] { 0, 1, 1, 1, 0 };
arrayInt2[2] = new int[] { 0, 1, 0, 1, 0 };
arrayInt2[3] = new int[] { 0, 1, 1, 1, 0 };
arrayInt2[4] = new int[] { 0, 0, 0, 0, 0 };


for (int i = 0; i < arrayInt2.Length; i++)
{
    for (int j = 0; j < arrayInt2[i].Length; j++)
        Console.Write(arrayInt2[i][j]);
    
    Console.WriteLine();
}

*/




///////////////////////
/// Les collections ///
///////////////////////
using System.Collections;
using System.Text.RegularExpressions;
/*
//Les ArrayList


ArrayList list = new ArrayList();

//pour ajouter des éléments à notre collection arrayList
object o = new object();

//permet d'ajouter un élément à notre collection arrayList
list.Add(5); //boxing
list.Add("Toto"); //...
list.Add(true);
list.Add(o);


//permet d'ajouter des élément à notre collection arrayList
list.AddRange(new object[] { 5, "tutu", true } );

//permet de vérifier si la collection contient tel élément, renvoie true ou false
Console.WriteLine(list.Contains("tutu"));

//permet de vérifier si la collection contient tel élément, son index, -1 si n'existe pas 
Console.WriteLine(list.IndexOf("efzefz"));


//permet de supprimer un élément donner en paramètre
list.Remove(o);

//permet de supprimer suivant l'index de l'élément à delete trouvé grace à indexOf par exemple
list.RemoveAt(1);


foreach (object item in list)
{
Console.WriteLine(item.ToString());
}


//permet de vider la collection
list.Clear();
//count donne le nombre d'éléments dans la collection
Console.WriteLine(list.Count);


//pour récupérer les éléments et les mettres dans une autre varialbe il faut box ou unbox
int elem = (int)list[0]; //unboxing
*/

//Les Hashtable
/*
Hashtable listH = new Hashtable();
object o = new object();

listH.Add(true, 5);
listH.Add(o, "Ceci est un object attention !!! :)...");
listH.Add("Tutu", "Toto");

Console.WriteLine(listH[true]);
Console.WriteLine(listH[o]);
Console.WriteLine(listH["Tutu"]);

int test = (int)listH[true];


foreach(DictionaryEntry a in listH)
{
    Console.WriteLine(a.Key.ToString());
    Console.WriteLine(a.Value.ToString());
}

*/



// Queue //

/*
 * Client 3 -> third OUT
 * Client 2 -> second OUT
 * Client 1 -> first OUT 
 */

/*
Queue queueString = new Queue();

queueString.Enqueue("Client 1");
queueString.Enqueue("Client 2");
queueString.Enqueue("Client 3");



object[] arrayS = (object[])queueString.ToArray();

Console.WriteLine(queueString.Count);

Console.WriteLine(queueString.Dequeue());
string elem = (string)queueString.Dequeue();
Console.WriteLine(elem);

Console.WriteLine(queueString.Count);


Console.WriteLine(queueString.Count);

string elem = (string)queueString.Peek();
Console.WriteLine(elem);

Console.WriteLine(queueString.Count);
queueString.Clear();
Console.WriteLine(queueString.Count);
*/





// Stack //
/*
Stack stackS = new Stack();

stackS.Push("Assiette 1");
stackS.Push("Assiette 2");
stackS.Push("Assiette 3");

Console.WriteLine(stackS.Count);

Console.WriteLine(stackS.Pop());
string s = (string)stackS.Peek();
Console.WriteLine(s);

Console.WriteLine(stackS.Count);
*/



/*
// La liste générique ! //
List<string> listString = new List<string>();
listString.Add("String 1");
listString.Add("String 2");
listString.Add("String 3");
listString.Add("String 4");

foreach(string item in listString)
    Console.WriteLine(item);


// Le dictionnaire générique KVP //
Dictionary<int, string> dicoString = new Dictionary<int, string>();
dicoString.Add(1248, "Harry Potter");
dicoString.Add(1496, "Armageddon");
dicoString.Add(1977, "Star wars");

foreach(KeyValuePair<int, string> kvp in dicoString)
    Console.WriteLine("Le code : {0}, contient : {1}", kvp.Key, kvp.Value);


// la Queue Générique FIFO -> first in first out //
Queue<string> queueString = new Queue<string>();
//fonctionnement pareil que le Queue non générique


//Le stack générique LIFO -> last in first out //
Stack<string> stackString = new Stack<string>();
//fonctionnement pareil que le Stack non générique
*/


////////////////////////////////////////////
/// Résolutions exos Array et Collection ///
/// ////////////////////////////////////////

//Grâce à une boucle « while » et à l’aide d’une collection, calculez les nombres premiers inférieur à un nombre entier entré au clavier.
/*
ArrayList listPremier = new ArrayList();
int userInput = 175;

int value = 2;

while(value < userInput) //i s'arrêtera à 174 !!!!
{
    bool isPrime = true;

    int sqrt = (int)Math.Sqrt(value);

    int index = 0;

    while(sqrt > 1 && (int)listPremier[index] <= sqrt && isPrime)
    {
        if(value % (int)listPremier[index] == 0)
        {
            isPrime = false;
        }

        index++;
    }

    if(isPrime)
    {
        listPremier.Add(value);
    }

    value++;

}

foreach(object elem in listPremier)
{
    Console.WriteLine(elem);
}
*/


//Grâce à une boucle « for » et à l’aide d’une collection générique, calculez les x premiers nombres premiers (version optimisée).
/*
List<int> listPremier = new List<int>();
int userInput = 100000;


for(int value = 2, count = 0; count < userInput; value++ )
{
    bool isPrime = true;
    int sqrt = (int)Math.Sqrt(value);

    for(int index = 0; sqrt > 1 && listPremier[index] <= sqrt && isPrime; index++)
    {
        if (value % listPremier[index] == 0)
           isPrime = false;
    }

    if (isPrime)
    {
        listPremier.Add(value);
        count++;
    }
}


foreach (object elem in listPremier)
{
    Console.WriteLine(elem);
}
*/


//Demandez à l’utilisateur d’introduire deux nombres au clavier et faite l’addition
//de ces deux nombres en ne convertissant que caractère par
//caractère. (Méthode « ToCharArray() » de la classe « string »)
/*
Console.WriteLine((int)'0');
Console.WriteLine((int)'1');

string nb1;
do
{
    Console.Write("Veuillez saisir un nombre positif : ");
    nb1 = Console.ReadLine();
} while (Regex.IsMatch(nb1, "^d+$"));

string nb2;
do
{
    Console.Write("Veuillez saisir un second nombre positif : ");
    nb2 = Console.ReadLine();
} while (Regex.IsMatch(nb2, "^d+$"));



Stack<int> stringNumber1 = new Stack<int>();
foreach(char c in nb1)
{
    stringNumber1.Push(c - 48);
}


Stack<int> stringNumber2 = new Stack<int>();
foreach(char c in nb2)
{
    stringNumber2.Push(c - 48);
}

string result = "";
int report = 0;

while(stringNumber1.Count > 0 || stringNumber2.Count > 0)
{
    int chiffre1 = (stringNumber1.Count > 0) ? stringNumber1.Pop() : 0;
    int chiffre2 = (stringNumber2.Count > 0) ? stringNumber2.Pop() : 0;

    int addition = chiffre1 + chiffre2 + report;

    Console.WriteLine($"{chiffre1} + {chiffre2} + {report} = {addition % 10} avec un report de {addition / 10}");

    result = ((addition) % 10).ToString() + result;
    report = (addition) / 10;

    Console.WriteLine("Résultat : {0}", result);
}
*/



