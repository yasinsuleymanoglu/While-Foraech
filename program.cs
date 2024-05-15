using system
internal class Program
 static void Main()
 {
     #region While
     // Koşullar sağlandıkça komut satırlarının çalıştırılmasını sağlar. For döngüsünden farklı olarak iterasyon sayısı belli değildir.
     // 1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program.
     Console.WriteLine("Lütfen bir sayı giriniz:");
     int sayi = int.Parse(Console.ReadLine());
     int sayaç = 1;
     int toplam = 0;
     while (sayaç<=sayi)
     {
         toplam += sayaç;
         sayaç++;
     }
     Console.WriteLine(toplam/sayi);

     // a dan z ye kadar tüm harfleri console a yazdıralım.
     char character = 'a' ;
     
     while (character <= 'z') 
     {
         Console.WriteLine(character);
         character++;
     }
     #endregion
     #region Foreach
     string[] arabalar = { "BMW", "FORD", "TOYATA", "NİSSAN" };
     foreach(var araba in arabalar)
     {
         Console.WriteLine(araba);   
     }

     int[] sayiDizisi = { 2, 4, 5, 1, 2, 4 };
     int toplam1 = 0;

     foreach (int i in sayiDizisi)
     {
         toplam += i;
     }
     #endregion
