
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
		newArray[i] = array[i] * array[i];
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

int[] array = { 2, 6, 7, 5, 3, 9 };

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

