
void StampaArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.WriteLine("elemento " + (i + 1) + ":" + " " + array[i]);
	}
}

int Quadrato(int numero)
{
	return numero * numero;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
	int[] newArray;
	newArray = new int[array.Length];

	for (int i = 0; i < array.Length; i++)
	{
		newArray[i] = Quadrato(array[i]);
	}

	return	newArray;	
}

int sommaElementiArray(int[] array)
{
	int somma = 0;

	for (int i = 0; i < array.Length; i++)
	{
		somma = somma + array[i];	
	}

	return somma;
}
Console.WriteLine("Quanti numeri vuoi inserire?");
int N = Convert.ToInt32(Console.ReadLine());

int[] array;
array = new int[N];

for (int i = 0; i < N; i++)
{
	Console.WriteLine("inserisci elemento n. " + (i + 1));
	array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("stampa semplice dell'array");
StampaArray(array);

Console.WriteLine("stampa dell'array elevato al quadrato");
StampaArray(ElevaArrayAlQuadrato(array));

Console.WriteLine("stampa semplice dell'array originale");
StampaArray(array);

Console.WriteLine("stampa della somma degli elementi dell'array originale");
Console.WriteLine(sommaElementiArray(array));

Console.WriteLine("stampa della somma degli elementi dell'array elevato al quadrato");
Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(array)));

