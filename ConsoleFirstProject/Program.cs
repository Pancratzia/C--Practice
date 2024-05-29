Console.WriteLine("La resta de 10 menos 5 da como resultado " + Sub(10, 5));


int Sub(int a, int b) //Función Pura. Siempre devuelve un el mismo valor bajo las mismas condiciones en su llamada
{
    return a - b;
}

DateTime GetTommorrow() //No es una función pura porque modifica el tiempo
{
    return DateTime.Now.AddDays(1);
}

DateTime GetTommorrowPure(DateTime date) //Función pura debido a que si se le pasa el mismo parametro todos los días, siempre dará el mismo valor
{
    return date.AddDays(1);
}