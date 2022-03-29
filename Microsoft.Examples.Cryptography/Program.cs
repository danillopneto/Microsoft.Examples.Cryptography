// See https://aka.ms/new-console-template for more information
using Microsoft.Examples.Cryptography;
using System.Text;

const string key = "justasimplekeythathasmorethensixteencharacters";
const string wordToPlay = "Danillo Pinheiro Neto";

Console.WriteLine($"Master key: {key}");
Console.WriteLine();
Console.WriteLine($"Word to be encripted: {wordToPlay}");
Console.WriteLine();

var encripted = AuthenticatedEncryption.Encrypt(Encoding.ASCII.GetBytes(key), Encoding.ASCII.GetBytes(wordToPlay));
Console.WriteLine($"Message encripted: {Encoding.ASCII.GetString(encripted)}");
Console.WriteLine();

var decripted = AuthenticatedEncryption.Decrypt(Encoding.ASCII.GetBytes(key), encripted);
Console.WriteLine($"Message decripted: {Encoding.ASCII.GetString(decripted)}");
Console.WriteLine();

Console.ReadLine();