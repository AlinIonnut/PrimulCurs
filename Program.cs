//Ex. 1: Scieti un program care citind de la tastatura cele trei dimensiuni ale unui paralelipiped dreptunghic, va afisa volumul lui.
Console.WriteLine("Ex. 1: Scieti un program care citind de la tastatura cele trei dimensiuni ale unui paralelipiped dreptunghic, va afisa volumul lui.");

Console.WriteLine("Enter the lenght:");
int Lenght = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the width");
int Width = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the height");
int Height = int.Parse(Console.ReadLine());

int VolumOfRenctangularParalelipiped = Lenght * Width * Height;

Console.WriteLine("The volum of the rectangular paralelipied is: " + VolumOfRenctangularParalelipiped);

//Ex. 2: Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura
Console.WriteLine("Ex. 2: Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura");

Console.WriteLine("Enter the first number:");
int FirstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number");
int SecondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the third number");
int ThirdNumber = int.Parse(Console.ReadLine());

double SumOfNumbers = (FirstNumber + SecondNumber + ThirdNumber)/3.00;

Console.WriteLine($"The arithemetic mean of the three numbers is: "+ SumOfNumbers);

//Ex. 3: Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastaura
Console.WriteLine("Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastaura");

Console.WriteLine("Enter a number: ");
int Number = int.Parse(Console.ReadLine());

int LastDigit = Number % 10;

Console.WriteLine("The last digit from the number " + Number + "is: " + LastDigit);

//Ex. 4: Scrieti un program care va afisa semnul unui numar citit de la tastatura: Daca numarul este pozitiv, va afisa “+”, Daca numarul este negativ, va afisa “-”, Daca numarul este 0, va afisa “0”
Console.WriteLine("Ex. 4: Scrieti un program care va afisa semnul unui numar citit de la tastatura: Daca numarul este pozitiv, va afisa “+”, Daca numarul este negativ, va afisa “-”, Daca numarul este 0, va afisa “0”");
int NumberSign = int.Parse(Console.ReadLine());

if (NumberSign > 0)
{
    Console.WriteLine("The number is pozitive.");
}
else if (NumberSign == 0)
{
    Console.WriteLine("The number is equal to 0.");
}
else
{
    Console.WriteLine("The number is negative.");
}

//Ex. 5: Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.
Console.WriteLine("Ex. 5: Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.");
Console.WriteLine("Enter two numbers: ");

int FirstNum = int.Parse(Console.ReadLine());
int SecondNum = int.Parse(Console.ReadLine());

int min = Math.Min(FirstNum, SecondNum);
int max = Math.Max(FirstNum, SecondNum);

Console.WriteLine("The numbers in ascending order are: " + min + ", " + max);

//Ex. 6: Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar
Console.WriteLine("Ex. 6: Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar");

Console.WriteLine("Enter a number: ");
int Num = int.Parse(Console.ReadLine());

if (Num % 2 == 0)
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd");
}

//Ex. 7: Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica daca x este divizibil cu y. 
Console.WriteLine("Ex. 7: Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica daca x este divizibil cu y");

Console.WriteLine("Enter two numbers:  ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());


if (x % y == 0)
{
    Console.WriteLine("The number " + x + " is divisible by " + y);
}
else
{
    Console.WriteLine("The number " + x + " is not divisible by " + y);
}

//Ex. 8: Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine descrescatoare.
Console.WriteLine("Ex. 8: Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine descrescatoare.");

Console.WriteLine("Enter three numbers: ");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int maxim = Math.Max(a, Math.Max(b, c));
int minim = Math.Min(a, Math.Min(b, c));
int mid = (a + b + c) - maxim - minim;

Console.WriteLine("The numbers in ascending order is" + minim + ", " + mid + ", "+ maxim);

//Ex. 9: Scrieti un program care interschimba valoarea a doua variabile intregi.
Console.WriteLine("Ex. 9: Scrieti un program care interschimba valoarea a doua variabile intregi.");

Console.WriteLine("Enter two numbers: ");

int NumFirst = int.Parse(Console.ReadLine());
int NumSecond = int.Parse(Console.ReadLine());

Console.WriteLine("a = " + NumFirst);
Console.WriteLine("b = " + NumSecond);

int reverse = NumFirst;
NumFirst = NumSecond;
NumSecond = reverse;

Console.WriteLine("After reverse");
Console.WriteLine("a = " + NumFirst);
Console.WriteLine("b = " + NumSecond);

//Ex. 10: Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la tastatura.
Console.WriteLine("Ex. 10: Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la tastatura.");

Console.WriteLine("Enter a number, not bigger than 2 digits: ");

int Value = int.Parse(Console.ReadLine());

int sum = 0;
int originalNumber = Value;

while(Value != 0)
{
    sum += Value % 10;

    Value /= 10;
}

Console.WriteLine("The sum of the digits of " + originalNumber + " is: " + sum);

// Ex. 11:  Ex 11 Folosind instructiunea “switch”, scrieti un program care citind de la tastatura un numar intreg va verifica urmatoarele: “unu” daca numarul citit este 1, “doi” daca numarul citit este 2
// , “trei” daca numarul citit este 3, “cinci” daca numarul citit este 5, “opt” daca numarul citit este 8, “neidentificat” pentru orice alt caz

Console.WriteLine("Ex 11: Folosind instructiunea “switch”, scrieti un program care citind de la tastatura un numar intreg va verifica urmatoarele: “unu” daca numarul citit este 1, “doi” daca numarul citit este 2, “trei” daca numarul citit este 3, “cinci” daca numarul citit este 5, “opt” daca numarul citit este 8, “neidentificat” pentru orice alt caz");

Console.WriteLine("Enter a number: ");

int NewNumber =  int.Parse(Console.ReadLine());

switch (NewNumber)
{
    case 1:
            Console.WriteLine("Unu");
            break;
    case 2: 
        Console.WriteLine("Two");
        break;
    case 3:
        Console.WriteLine("Three");
        break;
    case 5:
        Console.WriteLine("Five");
        break;
    case 8:
        Console.WriteLine("Eight");
        break;
    default:
        Console.WriteLine("Unidentified");
        break;
}