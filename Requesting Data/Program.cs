using Requesting_Data;

RetriveUrl retriveUrl = new RetriveUrl();  

Console.Write("inserisci un url: ");
string inputURL = Console.ReadLine();

Console.WriteLine("\nsto stampando il contenuto dell'URL:\n");
Console.WriteLine(await retriveUrl.GetDescription(inputURL));









