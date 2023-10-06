// Challenge 1

/*se esta asignando un string a una variable bool
bool amProgrammer = "true";*/
bool amProgrammer = true;

/*se esta asignando un double a una variable int
int Age = 27.9;*/
double Age = 27.9;

List<string> Names = new List<string>();
/* se esta cambiando la lista por un string 
Names = "Monica";*/
Names.Add("Monica");

Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
/*se esta pasando como segundo parametro un int y cuando se declaro el diccionario se indico que iba almacenar como segundo parametro un string
MyDictionary.Add("Hi there", 0);*/
MyDictionary.Add("Hi there", "0");

// This is a tricky one! Hint: look up what a char is in C#
/* se esta declarando un string con comillas simples lo cual es incorrecto ya se debe declarar con comillas dobles
string MyName = 'MyName';*/
string MyName = "MyName";
Console.WriteLine(amProgrammer);
Console.WriteLine(Age);
Console.WriteLine(MyName);

// Challenge 2
/*se estaba declarando mal la sentencia for para que se recorra la lista*/
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = 0 ; i < Numbers.Count; i++){
    Console.WriteLine(Numbers[i]);
    }

// Challenge 3
/*no se estaba imprimiendo correctamente el valor de la lista que se estaba recorriendo*/
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers){
    Console.WriteLine(i);
}

// Challenge 4
/*No se podia asignar num=0 dentro de la condicional ya que "num" esta recorriendo la lista*/
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
foreach(int num in EvenMoreNumbers){
    if(num % 3 == 0){
        int num2 = 0;
        Console.WriteLine(num2);
    }
}
// Challenge 5
// What can we learn from this error message?
/*No se puede reemblazar una letra ya que es un string */
string MyString = "superduberawesome";
Console.WriteLine(MyString);
// MyString[7] = "p";

// Challenge 6
// Hint: some bugs don't come with error messages
/*Nunca entrara en la validacion ya que rand.Next(12) especifica que buscara un valor aleatorio de 0 a 11, no incluye a 12*/
Random rand = new Random();
int randomNum = rand.Next(12);
if(randomNum == 12){
    Console.WriteLine("Hello");
}

