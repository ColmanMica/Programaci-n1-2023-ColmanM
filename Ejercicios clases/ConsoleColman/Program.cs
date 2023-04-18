// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
/*
Console.WriteLine("Hola, me das tu año de naciemiento?");
string loQueElTipoPuso = Console.ReadLine();
// subrayado es porq esta en duda si esta bien o no, si aparece en rojo es que no anda- Hay que siempre definir el tipo que es la variable
// // si voy a calcular mas o menos la edad que tiene tomadon su año de nac.
int ElAnioDelTipoEnInt = int.Parse(LoQueElTipoPuso);
int ElAniDondeEstoyAhora = DateTime.Today;
int LaEdadDelFlaco = DateTime.Today - ElAnioDelTipoEnInt;


Console.WriteLine('vos tenes o vas a cumplir este año: ' + LaEdadDelFlaco);

string LoQueElFlacoPone;
LoQueElFlacoPone = Console.WriteLine('Hola,me das alguna cadena');
LoQueElFlacoPone =  Console.ReadLine();

if (LoQueElFlacoPone.Length>15)
{
Console.WriteLine("Mucho texto!!!");
}else
{ Console.WriteLine("bien, tiene poco!");
}


Console.WriteLine("Hola, te voy a ir poniendo los valores de los 12 meses");
// me creo una variable para poder ir llevando la suma de los montos de cada mes
int suma = 0;
for (int mes = 1; mes <= 12; mes++);
{
Console.WriteLine("pone el valor del mes: " + mes);
string valor = Console.ReadLine();
suma = suma + int.Parse(valor);
}

Console.WriteLine(suma);

//ejemplo de while donde pido valores hasta que pido cero, corta.

Console.WriteLine("Flaco poneme las ventas y cuando no tengas mas, poneme un 0");
Console.WriteLine('ingrese valor');
Int suma = 0;
string valor = Console.ReadLine();
int valorint = int.Parse(valor);

while (valorint > 0) ;
{
suma = suma + valorint;

Console.WriteLine("ingresar valor:");
valorint = Console.ReadLine();
valorint = int.Parse(valorint);
}
Console.WriteLine("al final de todo vendiste:" + suma);

//suma = 0
//valor ="10" ( a lo que ingreso por teclado)
// el 10 lo transformo en int valor =10
//va acumulando el 0 + 10 suma pasa a valer 10
// si agrego valor =20 suma pasa a valer =30 
// si agrego valor = 40 suma pasa a valer = 70
// si agrego valor = 0 corta porq la condicion es falsa
*/


// un alumno ingresará las notas de las 9 materias que tuvo durante el año, mostrar el promedio de las mismas.

/*
Console.WriteLine("Ingres las notas de las materias del año:");
Console.WriteLine("ingrese nota");
int suma = 0;
string NotaLeida = "";
int NotaEnint =0 ;

for (int ConNota = 1; ConNota <=9; ConNota++);
{
    Console.WriteLine("ingrese la nota en numero " + ConNota);
    NotaLeida = Console.ReadLine();
    NotaEnint = int.Parse(NotaLeida);
    suma = suma + NotaEnint ;
}

Console.WriteLine("el promedio de tus notas fue:"+ (suma / 9));

*/
//Para el ingreso a un sistema se necesita solicitar nombre de usuario y clave,
//repetir este ingreso hasta que el usuario ingrese la clave correcta: 667788

/*
Console.WriteLine("ingrese la clave ");
string clave = Console.ReadLine();

while (clave != "667788")
{
    Console.WriteLine("flaco, InsufficientExecutionStackException no es la clave, proba de nuevo");
    clave = Console.ReadLine();
}
Console.WriteLine("Perfecto pibe!");
*/


/*
Console.WriteLine("ingresa clave:");
    string? clave;

do
{ 
    clave= Console.ReadLine();
}while(clave!="667788");

Console.WriteLine("perfecto pibe");
Console.WriteLine("ingresa la clave, pibe");

Console.WriteLine("ingresa la clave:");
string? clave = Console.ReadLine();

while(clave!="667788")
{
    Console.WriteLine("flaco, esa no es la clave, proba de nuevo");
    clave = Console.ReadLine();
}
Console.WriteLine("perfecto!");
*/

//Se le solicitara ingresar un numero al usuario, se repetira el pedido
//hasta que ingrese un positivo

/*
Console.WriteLine("Ingrese un numero: ");
string? Num;
    
do
{
    Num = Console.ReadLine();
    int Numer = int.Parse(Num)
}while (Num < 0);
Console.WriteLine("");

*/
//Siguiendo con el ejercicio anterior, al ingresar el positivo se mostrara
//el promedio de los numeros negativos ingresados

/*

string Num;
int suma = 0;
int ConNum = 0;
int Numer;
do
{

    Console.WriteLine("Ingrese un numero: ");
    Num = Console.ReadLine();
     Numer = int.Parse(Num);
        suma = suma + Numer;
        ConNum = ConNum + 1;
  
    Console.WriteLine("el promedio de numeros:" + (suma / ConNum));


   
} while (Numer < 0);




//Se le solicitará ingresar números al usuario, se remetira el pedido hasta que 
//ingrese un número mayor a 3 cifras.



do
{
    Console.WriteLine("Ingrese número:");
    Num = Console.ReadLine();
    Numer = int.Parse(Num);
} while (Numer > 999);

Console.WriteLine("");


//Siguiendo con el ejecicio anterior, al ingresar uno mayor o menor a 3 cifras se 
//mostrará el promedio de los ingresos

do
{

    Console.WriteLine("Ingrese un numero: ");
    Num = Console.ReadLine();
    Numer = int.Parse(Num);
    suma = suma + Numer;
    ConNum = ConNum + 1;

    Console.WriteLine("el promedio de numeros:" + (suma / ConNum));
} while (Numer > 999);

Console.WriteLine();


*/

//WHILE
//El ususario ingresará valores positivos, cuando no tenga mas valores ingresará 0
//El sistema deberá informar la suma de los ingresados.
/*
Console.WriteLine("ingresar valores: ,ingresar cero si no hay más valores. ");
int Suma = 0;
string valor = Console.ReadLine();
int valorI = int.Parse(valor);

while (valorI > 0);
{
  Suma = Suma + valorI;
    Console.WriteLine("ingresar valor:");
    valorI = Console.ReadLine();
    valorI = int.Parse(valorI);
    
}
    Console.WriteLine("La suma de los ingresados es: " + Suma);

*/
//2.	Siguiendo el ejercicio anterior, calcular el promedio de los valores ingresados
/*
Console.WriteLine("ingresar valores: ,ingresar cero si no hay más valores. ");
int Suma = 0;
string valor = Console.ReadLine();
int valorI = int.Parse(valor);
int Contsu = 0;
while (valorI > 0) ;
{
    Suma = Suma + valorI;
    Console.WriteLine("ingresar valor:");
    valorI = Console.ReadLine();
    valorI = int.Parse(valorI);
    Contsu = Contsu + 1;
}
Console.WriteLine("La suma de los ingresados es: " + Suma/Contsu);

*/

//3.El usuario ingresará una lista de nombre de persona, cuando se ingresé un nombre vacío,
//sin datos; el sistema informará cuántos nombres de han ingresado.

