DateTime tarih = DateTime.Now;//Hesaplamak istediğiniz tarih
DateTime sonrakiTarihMonth = tarih.AddMonths(13); //13 ay sonrasını hesaplamak için AddMonths() metodu kullanılır
DateTime sonrakiTarihWeek = tarih.AddDays(1000); //7 günsonrasını hesaplamak için AddMonths() metodu kullanılır

Console.WriteLine("Bugun : " + tarih.ToString("dd/MM/yyyy")); //dd/MM/yyyy formatında tarihi yazdırır
Console.WriteLine("13 ay sonrası : " + sonrakiTarihMonth.ToString("dd/MM/yyyy")); 
Console.WriteLine("1000 gun sonrası : " + sonrakiTarihWeek.ToString("dd/MM/yyyy"));