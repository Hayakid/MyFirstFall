int[] Createsupa (int maxValue,int ssize, int minValue,int size)
{
    int[] Neappe = new int [size];
    for (int i = 0; i < size; i++)
    {
        Neappe[i] = new Random().Next(minValue, maxValue+1);
        
    }
        return Neappe;

}
void chetnoe (int numberrr)
{

    int[] Chet =  new int [ssize];
    for (int oo= 0; oo < ssize ; oo++)
    {
        Chet[oo] =  new Random().Next(ssize );
    }
    if (ssize%100=1 && ssize/ 2 = 1)
    {
        Console.WriteLine(ssize);

    }

}





void showarraye (int[] array )
{   
    Console.Write("-->{Accepted massive ---->    }");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine() ;
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input minimim soze ellement");
int min  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("max zn ellement");
int max = Convert.ToInt32(Console.ReadLine());
int[] myarray = Createsupa(a,min,max);
showarraye(myarray);