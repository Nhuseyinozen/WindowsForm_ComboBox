using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_ComboBox
{
    public class database
    {
        public static List<product> products = new List<product>()
        {

            new product()
            {
                id = 1,
                productName = "Beyaz Diş",
                productCategory = "Roman",
                writer = "Jack London",
                stockQuantity = 10,
                productImage =  @"C:\Users\hozen\Desktop\KitapResimleri\1672987230.png",
                explanation = @"Kendi cinsinden ve insanlardan nefret gördüğü, hiç durmadan onlarla mücadele ettiği için büyümesi çabuk fakat tek yönlü oluyordu. İçindeki şefkat ve sevginin filizlenmesi olanaksızdı. 
                Böyle şeyler için en küçük bir umudu bile yoktu. Kuvvetliye boyun eğmek, zayıfı ezmek kuralını öğretmişti. Gri kunduz kuvvetli bir tanrıydı. Bu yüzden Beyaz Diş ona boyun eğiyordu. Fakat kendisinden küçük olan köpek, ezilmesi gereken zayıf bir yaratıktı.
                Onunki kuvvet yönünde bir gelişmeydi. Devamlı acı çekmek, hatta mahvolmak tehlikesine karşı koyabilmek için,m yırtıcı ve savunmacı özellikleri aşırı derecede gelişmişti. Diğer köpeklerden daha çabuk hareket ediyor, daha hızlı koşuyordu.
                Onlara oranla daha hileci, daha çevikti. Çelik gibi kasları, ipince sinirleri olan, cesur, zalim, yırtıcı ve akıllı bir hayvan olup çıktı. Bütün bu niteliklere sahip olması şarttı, aksi halde ne ayakta durabilecek ne de içinde bulunduğu bu düşman çevrede yaşayabilecekti."
            },

              new product()
              {
                id = 2,
                productName = "1984",
                productCategory = "Roman",
                writer = "George Orwel",
                stockQuantity = 10,
                productImage = @"C:\Users\hozen\Desktop\KitapResimleri\0000000064038-1.jpg",
                explanation = @"Politik ve dinî görüşlerini eserlerine yansıtan George Orwell'ın 1984 adlı romanı iktidar kavramını, diktatörlüğü ve halkın içinde bulunduğu durumu resmeder. 
                Hikâye; halkının duygularına önem vermeyen, bilimden teknolojiye kadar çeşitli gelişmeleri engelleyen despot bir liderin yönettiği ülkede geçiyor. Büyük Birader adıyla anılan liderin siyasi kararları ve bu kararların halkın sosyal hayatı üzerindeki etkileri gözler önüne seriliyor. Yazar, 1984'te varoluşun temellerine hatta aşka dahi müdahale eden bir yönetim varken mutluluğun mümkün olup olmadığını sorguluyor. 
                Katı kurallarla yönetilen bir ülkede bireylerin amaçlarının ve ideolojilerinin nasıl değiştiğini gösteriyor. 
                1984'ü okurken adaletsizliğin ve baskının hâkim olduğu bir ülkede bireylerin makineleştirilmesine, bireysellikten uzaklaştırılmasına ve köleleştirilmesine tanıklık edebilirsiniz. 1984'le insan haklarının önemi, özgürlük için verilen mücadele ve adalet duygusu üzerine fikir yürütebilir; yeni bakış açıları geliştirebilirsiniz."
              },

                new product()
                {
                id = 3,
                productName = "Beyaz Zambaklar Ülkesinde",
                productCategory = "Roman",
                writer = "Grigory Petrov",
                stockQuantity = 10,
                productImage = @"C:\Users\hozen\Desktop\KitapResimleri\0000000289056-1.jpg",
                explanation = @"Rus edebiyatının büyük yazarlarından Grigory Petrov tarafından kaleme alınan Beyaz Zambaklar Ülkesinde, her sayfasında altı çizilecek önemli dersler veriyor. Dünya klasikleri arasında yer alan roman, uzun yıllar farklı ülkelerin egemenliğinde yaşamış bir toplumun kendi ayakları üzerinde kalkınmasını konu ediniyor. Hayatının önemli bir kısmını Finlandiya’da yaşamış olan Petrov; eserinde ülkenin ekonomiden eğitime, sağlıktan tarıma kadar birçok farklı alandaki gelişimini destansı bir anlatımla ele alıyor.
                Beyaz Zambaklar Ülkesinde, medeniyete tuttuğu ışıkla her millet ve kültürden insanın okuması gereken eserler arasında yer alıyor. Cumhuriyetin kurucusu Mustafa Kemal Atatürk’ün de başucu kitaplarından olan eser, Türkiye’nin kurtuluş öyküsüne de ilham kaynağı oluyor. Atatürk’ün talimatıyla okulların müfredatına da dahil edilen kitap, vatan bilincinin oluşması ve toplumsal gelişim için önemli bir kılavuz niteliği taşıyor."
                },




        };


    }
}
