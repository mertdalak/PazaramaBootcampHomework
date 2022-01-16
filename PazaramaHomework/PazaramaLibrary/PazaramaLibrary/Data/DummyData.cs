using PazaramaLibrary.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaramaLibrary.Data
{
    public static class DummyData
    {
        public static void Dummy(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<BooksContext>();
            context.Database.Migrate();

            var genres = new List<Genre>()
                        {
                            new Genre {Name="Macera", Books=
                                new List<Book>(){
                                    new Book {
                                        Title="Assassin's Creed Rönesans - Suikastçının İnancı",
                                        Description="İtalya'nın soylu ailelerinin ihanetine uğrayan genç bir adam destansı bir intikam yolculuğuna çıktı.",
                                        ImageUrl="1.jpg"
                                    },
                                    new Book {
                                        Title="Cehennem",
                                        Description="Avrupa’dan Türkiye’ye uzanan soluksuz bir maceraya atılmaya hazır mısınız? Dünyanın en çok satan romanlarının yazarı Dan Brown, Cehennem ile okurlarını bu kez de İstanbul sokaklarında bir gezintiye çıkarıyor. ",
                                        ImageUrl="2.jpg"
                                    },

                                }
                            },
                            new Genre {Name="Korku-Gerilim"},
                            new Genre {Name="Romantik"},
                            new Genre {Name="Polisiye"},
                            new Genre {Name="Bilim Kurgu"}
                        };
            var books = new List<Book>()
                        {
                            new Book {
                                Title="O",
                                Description="Amerikalı roman ve hikaye yazarı Stephen King’in 1986’da yayımlanan ölümsüz eseri O, dünya edebiyatında korku ve gerilim türünün en seçkin örnekleri arasında yer alıyor. Eser, kalın hacminin yanı sıra akıcı dili ve sürükleyici hikayesiyle okurlarını dolu dizgin bir maceraya sürüklüyor. Yazarın tamamlamak için üzerinde dört yıl boyunca çalıştığı eseri, elinize aldığınızda bir solukta okuyacaksınız.",
                                ImageUrl="3.jpg",
                                Genres = new List<Genre>() {genres[1] }
                            },
                            new Book {
                                Title="Yakarış Çemberi",
                                Description="Son yıllarda adından sıkça söz ettiren yazarlardan P. Djèlí Clark, Yakarış Çemberi’nde kaderini kendi eline almaya karar verip 20. yüzyıl Amerika’sının kötülüklerine karşı ön saflarda savaş veren üç siyah kadının hikâyesini anlatıyor.",
                                ImageUrl="4.jpg",
                                Genres = new List<Genre>() {genres[1] }
                            },
                            new Book {
                                Title="Aşk Hipotezi",
                                Description="“Okurlar, nükteli diyalogları  ve sevilesi yan karakterleriyle hem gerçekçi hem de eğlenceli olan bu kitabıellerinden bırakamayacaklar.”",
                                ImageUrl="5.jpg",
                                Genres = new List<Genre>() {genres[2]}
                            },
                                new Book {
                                Title="Buzdaki Kelebek",
                                Description="Milyonlarca okurun heyecanla romanlarını beklediği Sylvia Day’den, tutkulu, duygu yüklü bir aşk hikâyesi…",
                                ImageUrl="6.jpg",
                                Genres = new List<Genre>() {genres[2]}
                            },
                            new Book {
                                Title="Koloni",
                                Description="Biri yaşlı ve huysuz emekli bir polis, diğeri Çocuk Bürosu'nda görevli, ancak açığa alınmış uyuşturucu müptelası genç bir polis. Bu ikisi, gitgide hunharca bir hal alan ve peşpeşe işlenen cinayetlerin katilini veya katillerini bulmak için birlikte çalışmak zorundadır.",
                                ImageUrl="7.jpg",
                                Genres = new List<Genre>() {genres[3]}
                            },
                            new Book {
                                Title="Yabancı",
                                Description="Şehir parkında, vahşice katledilen on bir yaşındaki bir erkek çocuğunun cesedi bulunur. Görgü tanıklarının ifadelerine göre katil, İngilizce öğretmeni, şehrin Küçükler Beyzbol Ligi’nin koçu ve herkesin çok sevdiği Terry Maitland’dır. Parmak izi ve DNA sonuçlarıyla desteklenen diğer kanıtlar da tartışılmaz biçimde onu işaret etmektedir.",
                                ImageUrl="8.jpg",
                                Genres = new List<Genre>() {genres[3]}
                            },
                            new Book {
                                Title="Uzay Gezgini Tuf",
                                Description="Uzay Gezgini Tuf, çevrecilik ve mutlak güç üzerine kara komik bir meditasyon; galaksinin her yerinde yardıma ihtiyacı olan gezegenlerin yanında olmaya çalışan alışılmadık bir kahramanın, ilginç ve sevimli Haviland Tuf’ın hikâyesi...",
                                ImageUrl="9.jpg",
                                Genres = new List<Genre>() {genres[4]}
                            },
                            new Book {
                                Title="Kurtuluş Projesi",
                                Description="“Tehlike altındaki iki dünyası, işinin ehli bir adamı, işinin ehli bir uzaylısı, çözümlenmesi gereken bir sürü bilimsel sorunu ve meçhule giden insanlığıyla bu kitapta benim gibi eski usul bilimkurgu sevenler için her şey mevcut. ",
                                ImageUrl="10.jpg",
                                Genres = new List<Genre>() {genres[4]}
                            }
                        };

            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if(context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(genres);
                }

                if(context.Books.Count()== 0)
                {
                    context.Books.AddRange(books);
                }

                context.SaveChanges();
            }

        }
    }
}
