/*int num1= 10;
double num2= num1;
Console.WriteLine(num2);


double num3= 10.5;
int num4 = (int)num3;
Console.WriteLine(num4);


string strNum="20";
int parsedNum = int.Parse(strNum);
Console.WriteLine(parsedNum);
int convertedNumber = Convert.ToInt32("20");


int num5= 30;
string strNum2 = num5.ToString();
Console.WriteLine(strNum2);

int num=500;
byte converted = (byte)num;

int number1 = int .Parse(Console.ReadLine());
Console.WriteLine($"The last {number1 % 10}");
Console.WriteLine($"The second last {number1 / 10 % 10}"); 
*/
/*
int number5 = 10;
double number6 = 20.1;
double result = number5 + number6;
Console.WriteLine(result);
*/

/*string value ="1o0";
int number;
int.TryParse(value,out number);
Console.WriteLine(number);*/

/*Console.WriteLine("Enter your durty number");
int age = Console.Read();
if(age>=18){
	Console.WriteLine("You are eligible to vote");
}*/
/*
int complement =8;
int total= 10;
if(complement==total){
	Console.WriteLine("Equal");
}
else{
		Console.WriteLine($"keep going! you have ({total-complement}) modules. ");

}
*/


/*decimal coursePrice= 100m;
bool hasdiscount = true;

if(hasdiscount){
	coursePrice *=0.9m;
}
Console.WriteLine($"The course price is: ${coursePrice}");*/

/*int x= 2;
int y=3;
int bigger= x>y ? x : y;
Console.WriteLine(bigger);*/

/*bool isAdmin = true;
bool isLoggedIn = false;
if(isAdmin && isLoggedIn){
	Console.WriteLine("Welcome Admin");
}
else{
	Console.WriteLine("You are not logged in");
}*/

/*string email = "kadirovkamoliddin24@gmail.com";
string password = "Kamol@9857";
bool isEmailValid = !string.IsNullOrEmpty(email);
bool isPasswordValid = password.Length>=6;

if(isEmailValid && isPasswordValid){
	Console.WriteLine("You are logged in");
}
else
{
	Console.WriteLine("Invalid email or password");
}*/

/*int score = Console.Read();
bool hasSubmittedProject = true;
if((score>=80 && hasSubmittedProject) || score>=90){
	Console.WriteLine("You passed the course");
}
else{
	Console.WriteLine("You failed the course");
}*/

/*char ch='i';
switch (ch){
	case 'a':
	Console.WriteLine("Vowel");
	break;
	case 'e':
	Console.WriteLine("Vowel");
	break;
	case 'i':
	Console.WriteLine("Vowel");
	break;
	case 'o':
	Console.WriteLine("Vowel");
	break;
	case 'u':
	Console.WriteLine("Vowel");
	break;
	default:
	Console.WriteLine("Not a vowel");
	break;
}*/

/*int number = 5;
string result = number switch{
	1=> "One",
	2=>"Two",
	3=>"Three",
	4=>"Four",
	5=>"Five",
	_=>"Unknown"
};
Console.WriteLine(result); */

/*using System.Threading.Tasks.Dataflow;

string performance = "Exellent";
string feedback = performance switch
{
	"Excellent" or "Exellent" => "Keep up the great work!",
	"Good" => "You're doing well, but you can improve.",
	"Fair" => "You're doing okay, but you need to improve.",
	"Bad" => "You need to improve your performance.",
	_ => "Invalid performance level."
};
Console.WriteLine(feedback);*/


   
			/*int score = Convert.ToInt32(Console.ReadLine());
        
        	if (score >= 90 && score <= 100) {
            Console.WriteLine("A");
        } else if (score >= 80 && score < 90) {
            Console.WriteLine("B");
        } else if (score >= 70 && score < 80) {
            Console.WriteLine("C");
        } else if (score >= 60 && score < 70) {
            Console.WriteLine("D");
        } else if (score < 60 && score >= 0) {
            Console.WriteLine("F");
        } else {
            Console.WriteLine("Error");
        }*/

	/* int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    int num3 = Convert.ToInt32(Console.ReadLine());
    int musbi=0, manfi=0, zero=0;
    if (num1 > 0) musbi++;
    if (num2 > 0) musbi++; 
    if (num3 > 0) musbi++;

    if (num1 < 0) manfi++;
    if (num2 < 0) manfi++; 
    if (num3 < 0) manfi++;

    if (num1 == 0) zero++;
    if (num2 == 0) zero++; 
    if (num3 == 0) zero++;

    
    Console.WriteLine($"Positive= {musbi}");
    Console.WriteLine($"Negative= {manfi}");
    Console.WriteLine($"Zero= {zero}");*/

	 /*int number = int.Parse(Console.ReadLine());
	 if(number%10==number/10%10){Console.WriteLine("YES");}
	 else{Console.WriteLine("NO");}*/


	  			/*int number = int.Parse(Console.ReadLine());
				if(number<0){Console.WriteLine("Negative");}
				else if(number>0){Console.WriteLine("Positive");}
				else{Console.WriteLine("Zero");}*/

		/*int number = Convert.ToInt32(Console.ReadLine());
		if(number>=1000 && number<=9999){
			Console.WriteLine((number/1000%10+number/100%10) +  (number/10%10+number%10));
		}

		else{Console.WriteLine("Error");}*/

		/*int number1 = Convert.ToInt32(Console.ReadLine());
		int number2 = Convert.ToInt32(Console.ReadLine());
		int number3 = Convert.ToInt32(Console.ReadLine());
		int Poss=0, Nega=0, Zero=0;

		if (number1 > 0) Poss++;
		if (number1 < 0) Nega++;	
		if (number1 == 0) Zero++;

		if (number2 > 0) Poss++;
		if (number2 < 0) Nega++;	
		if (number2 == 0) Zero++;

		if (number3 > 0) Poss++;
		if (number3 < 0) Nega++;	
		if (number3 == 0) Zero++;

		Console.WriteLine($"Positive={Poss}");
		Console.WriteLine($"Negative={Nega}");
		Console.WriteLine($"Zero={Zero}");*/

		/*int number = int.Parse(Console.ReadLine());
		if (number%10==number/10%10) Console.WriteLine("YES");
		else Console.WriteLine("NO");*/


		/*string[] fruits = {"Apple", "Banana", "Cherry"};
		foreach(string fruit in fruits)
		{
			Console.WriteLine(fruit);
		}*/

		/*string[] tables = {"alo", "asa", "asasa","asasaa"};
		foreach(string table in tables){
			Console.WriteLine(table);
		}*/

		/*int number = int.Parse(Console.ReadLine());
		for(int i=1;i<=10;i++){
			Console.WriteLine($"{number}*{i} ={number*i}");
		}*/

		/*int number = int.Parse(Console.ReadLine());
		for(int i=1;i<=number;i++){
			Console.WriteLine($"{i}");}*/

			/*int number1 = int.Parse(Console.ReadLine());
			int number2 = int.Parse(Console.ReadLine());

			for(int i=number1;i<=number2;i++){
				Console.WriteLine($"{i*i}");
			
			}*/

			/*int number3 = Convert.ToInt32(Console.ReadLine());
			int sumOfDigits=0;
			while(number3>0){
				sumOfDigits+=number3%10;
				number3/=10;
			}
			Console.Write($"{"The sum of elements = "} {sumOfDigits}");*/

			/*int number = int.Parse(Console.ReadLine());
			int maximum = number%10;
			while (number>1){
				int last = number %10;
				if(last>maximum)
				{
					maximum = last;
				}
				number/=10;

			}
			Console.WriteLine($"{"The maximum element = "} {maximum}"); */

			/*int number = int.Parse(Console.ReadLine());
			for(int i=0;i<=number;i+=2){
				Console.WriteLine(i+" ");
			}*/

			/*int[] age; 
			age = new int[5];
			var age1 = new int [5]{1,2,3,4,5};
			int[] numbers = {1,2,3,4,5};
			for(int i=0;i<5;i++){
				Console.WriteLine(numbers[i]);
			}*/

/*int [][] jaggedArray = new int[3][];
jaggedArray[0] = new int[3];
jaggedArray[1] = new int[2];
	for(int i=0; i < jaggedArray.Length; i++){

		if(jaggedArray[i] != null)
			{
				for(int j=0; j < jaggedArray[i].Length; j++)
				{
					Console.Write(jaggedArray[i][j] + " ");
				}
			}
			Console.WriteLine();

}*/
			

			
			//first way
			/*foreach (int i in number){
			Console.WriteLine( i);}

			//Second way 

			for (int i=0; i<number.Length; i++){
				Console.WriteLine(number[i]+ " ");
			}*/
using System;
public class Hello{
    public static void Main(){
			int[] number = new int[5] {5,4,8,2,10};
			int max=number[0];
			int bigIndex = 0;
			for (int i = 1; i <= number.Length; i++)
        {
            if (number[i] <= max)
            {
              	bigIndex = i;
            	max = number[i];
            }
            

        }
        Console.WriteLine(max);
}
} 

