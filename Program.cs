// See https://aka.ms/new-console-template for more information
// System.Console.WriteLine("Lütfen bir sayı giriniz:");
// int sayac=int.Parse(Console.ReadLine());
// for (int i = 1; i <= sayac; i++)
// {
//     if (i%2==1)
//     {
//         System.Console.WriteLine(i);
//     }
// }
int tekToplam=0;
int ciftToplam=0;
for (int i = 1; i < 998; i++)
{
    if(i%2==0)
        ciftToplam +=i;
    else
    tekToplam +=i;
}
System.Console.WriteLine("Tek Sayılar Toplamı: " + tekToplam);
System.Console.WriteLine("Çift Sayılar Toplamı: "+ ciftToplam);
for (int i = 1; i < 10; i++)
{
    if(i==4)
        break;
    System.Console.WriteLine(i);
}