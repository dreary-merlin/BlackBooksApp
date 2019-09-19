using BlackBooksApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackBooksApp.DAL
{
    public class BookshopInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BookshopContext>
    {
        protected override void Seed(BookshopContext context)
        {
            var types = new List<Models.Type>
            {
                new Models.Type { Category = "Художественная литература", Description = "Классическая и современная проза, детектив/боевик/триллер, фантастика/фэнтези, романтика, поэзия, биография/мемуары, исторический роман, приключения, комиксы, юмор/сатира, афоризмы/цитаты/изречения, фольклор." },
                new Models.Type { Category = "Книги для детей", Description = "Детская художественная литература, детская научно-популярная литература, детское творчество и досуг, детская религиозная литература." },
                new Models.Type { Category = "Образование", Description = "Подготовка к школе, начальная школа, средняя школа, педагогика." },
                new Models.Type { Category = "Наука и техника", Description = "Технические науки, прикладные науки/медицина, естественные науки/математика, гуманитарные науки." },
                new Models.Type { Category = "Общество", Description = "Общественные науки в целом, культура, история, военное дело, право/юридические науки, политика/социология, демография/статистика." },
                new Models.Type { Category = "Деловая литература", Description = "Экономика/экономическая теория, бухгалтерский и налоговый учёт/аудит, управление финансами, менеджмент, маркетинг/реклама, бизнес/торговля." },
                new Models.Type { Category = "Красота, здоровье, спорт", Description = "Здоровый образ жизни/фитнес, спорт/самооборона, популярная медицина, внешность/имидж/этикет." },
                new Models.Type { Category = "Увлечения", Description = "Мой дом, рукоделие/ремёсла, кулинария, досуг/хобби, туризм, личный транспорт." },
                new Models.Type { Category = "Психология", Description = "История и теория психологии, общая психология, детская психология, социальная психология, прикладная отраслевая социология, психоанализ, практическая психология/психотерапия." },
                new Models.Type { Category = "Эзотерика", Description = "Теория и история эзотерических учений, астрология/гороскопы, гадания/толкование снов/толкование имени, предсказания/пророки/ченнелинг, магия/колдовство/суеверия, парапсихология/экстрасенсорика, таинственные явления/уфология." },
                new Models.Type { Category = "Философия и религия", Description = "Философия, религия." },
                new Models.Type { Category = "Искусство", Description = "Архитектура, изобразительное искусство, декоративно-прикладное искусство/мода, зрелищные виды искусства, музыка." },
                new Models.Type { Category = "Подарочные издания", Description = "Книги – открытки, художественная литература, родителям и детям, красота/здоровье/психология, досуг/увлечения, наука/техника, деловая книга, искусство, философия/религия, миниатюрные издания." },
                new Models.Type { Category = "Книги на иностранных языках", Description = "На английском языке, на немецком языке, на французском языке, на испанском языке, на итальянском языке, на прочих языках." }
            };
            types.ForEach(s => context.Types.Add(s));
            context.SaveChanges();

            var publhouses = new List<PublishingHouse>
            {
                new PublishingHouse { Name = "АСТ", Address = "г. Москва, Пресненская наб., 6, стр. 2", Phone = "+7 (499) 951‑60-00" },
                new PublishingHouse { Name = "Истари Комикс", Address = "121615, г. Москва, Рублёвское ш., д.16к4, этаж 1, пом. 1А, ком. 2", Phone = "+7 (961) 853‑72-98" },
                new PublishingHouse { Name = "Эксмо", Address = "123308, г. Москва, ул. Зорге, д.1", Phone = "+7 (495) 411-68-86" },
                new PublishingHouse { Name = "Альпина нон-фикшн", Address = "123007, г. Москва, ул. 4-ая Магистральная, д.5, 3 подъезд, 3 этаж", Phone = "+7 (495) 980-53-54" },
                new PublishingHouse { Name = "Азбука СПб", Address = "191123, г. Санкт-Петербург, Воскресенская набережная, д. 12, лит. А", Phone = "+7 (812) 327-04-55" },
                new PublishingHouse { Name = "Livebook", Address = "г. Москва, Переведеновский пер., 18, стр. 11", Phone = "+7 (495) 114-52-45" },
                new PublishingHouse { Name = "МИФ (Манн, Иванов и Фербер)", Address = "г. Москва, Большой Козихинский пер., 7, стр. 2", Phone = "8 (800) 775‑67-41" },
                new PublishingHouse { Name = "Рипол-Классик", Address = "109052, Москва, Нижегородская ул., 29-33", Phone = "+7 (495) 259-62-06" },
                new PublishingHouse { Name = "Амфора, ООО", Address = "г. Санкт-Петербург, наб. Адмирала Лазарева, 20", Phone = "8 (812) 331-16-91" },
                new PublishingHouse { Name = "Алгоритм", Address = "г. Москва, Малая Семёновская, 9, к.3, офис: 278", Phone = "+7 (495) 617-08-25" }
            };
            publhouses.ForEach(s => context.PublishingHouses.Add(s));
            context.SaveChanges();

            var suppliers = new List<Supplier>
            {
                new Supplier { Name = "Топ-Книга", ContactPerson = "Звонников Юрий Григорьевич", Position = "Секретарь", Address = "г. Москва, Ткацкая ул., 5, стр.7", Phone = "+7 (499) 166-03-61", AboutCompany = "Книги, медиапродукция, канцтовары, открытки, игрушки и пресса" },
                new Supplier { Name = "Доставкин", ContactPerson = "Бизюкина Нина Владимировна", Position = "Секретарь", Address = "г. Казань, ул. Татарская, д. 16", Phone = "+7 (843) 967-90-75", AboutCompany = "Автоперевозка грузов от 1 кг по России" },
                new Supplier { Name = "Книжный Аутлет", ContactPerson = "Беляева Екатерина Генадьевна", Position = "Секретарь", Address = "г. Москва, Автомобильный проезд, 10", Phone = "+7 (499) 394-53-52", AboutCompany = "Детские книги и раскраски" },
                new Supplier { Name = "Искра", ContactPerson = "Стрелкова Дарья Ивановна", Position = "Секретарь", Address = "109390, г. Москва, улица Артюхиной, дом 20, корпус 2", Phone = "8 (499) 179-53-41", AboutCompany = "Учебно-методические материалы" },
                new Supplier { Name = "Премьер-Книга", ContactPerson = "Примак Александр Алексеевич", Position = "Директор", Address = "295022, Республика Крым, г. Симферополь, Кечкеметская улица, дом 27", Phone = "8 (978) 809-63-40", AboutCompany = "Книжная продукция, канцтовары, игры и игрушки" },
                new Supplier { Name = "Алфавит Омск", ContactPerson = "Зюбан Олег Алексеевич", Position = "Директор", Address = "644042, г. Омск, проспект Карла Маркса, 18/4", Phone = "8 (913) 667-74-89", AboutCompany = "Учебная литература" },
                new Supplier { Name = "Дэвар Медиа", ContactPerson = "Иванов Юрий Владимирович", Position = "Директор", Address = "300041, г. Тула, ул. Каминского, 24 литера В", Phone = "8 (950) 907-24-09", AboutCompany = "Инновационные развивающие книги и раскраски с дополненной реальностью" },
                new Supplier { Name = "Дарито", ContactPerson = "Ахметов Ренат Рустамович", Position = "Директор", Address = "111123, г. Москва, Шоссе Энтузиастов, дом 60, стр.1, кв. 136", Phone = "8 (903) 797-13-17", AboutCompany = "Подарочные книги" },
                new Supplier { Name = "Концептуал", ContactPerson = "Гришечкина Анастасия Дмитриевна", Position = "Директор", Address = "г. Москва, м. Комсомольская, Комсомольская площадь, д. 1а, строение 15", Phone = "+7 (495) 755-44-13", AboutCompany = "Книги по психологии, философии, истории, образованию, социологии, для детей и всей семьи" },
                new Supplier { Name = "Alpha-book", ContactPerson = "Захаров Денис Григорьевич", Position = "Директор", Address = "г. Москва, Красного Маяка, 16/3", Phone = "+7 495 120-11-50", AboutCompany = "Книги, канцелярия, игры" }
            };
            suppliers.ForEach(s => context.Suppliers.Add(s));
            context.SaveChanges();

            var books = new List<Book>
            {
                new Book { PublishingHouseId = 3, SupplierId = 1, ISBN = "9785699099399", Name = "Герой нашего времени", Author = "Лермонтов М.Ю.", TypeId = 1, Genre = "Классическая и современная проза", PublishingYear = 2015, Pages = 672, CoverType = "Твердая бумажная", BookPrice = 246, SupplyDate = "20.03.2017", Rest = 10 },
                new Book { PublishingHouseId = 1, SupplierId = 1, ISBN = "9785170817993", Name = "Поющие в терновнике", Author = "Маккалоу К.", TypeId = 1, Genre = "Романтика", PublishingYear = 2016, Pages = 605, CoverType = "Твердая бумажная", BookPrice = 301, SupplyDate = "10.07.2017", Rest = 197 },
                new Book { PublishingHouseId = 1, SupplierId = 1, ISBN = "9785170661022", Name = "Мастер и Маргарита", Author = "Булгаков М.", TypeId = 1, Genre = "Классическая и современная проза", PublishingYear = 2010, Pages = 571, CoverType = "Твердая бумажная", BookPrice = 861, SupplyDate = "16.04.2012", Rest = 200 },
                new Book { PublishingHouseId = 7, SupplierId = 2, ISBN = "9785000570081", Name = "Удовольствие от х", Author = "Строгац С.", TypeId = 4, Genre = "Математика", PublishingYear = 2018, Pages = 304, CoverType = "Твердая бумажная", BookPrice = 702, SupplyDate = "08.01.2018", Rest = 299 },
                new Book { PublishingHouseId = 4, SupplierId = 2, ISBN = "9785916713183", Name = "Величайшие математические задачи", Author = "Стюарт И.", TypeId = 4, Genre = "Математика", PublishingYear = 2017, Pages = 460, CoverType = "Твердая глянцевая", BookPrice = 504, SupplyDate = "24.07.2017", Rest = 250 },
                new Book { PublishingHouseId = 5, SupplierId = 5, ISBN = "9785389151413", Name = "Генералы песчаных карьеров", Author = "Амаду Ж.", TypeId = 1, Genre = "Современная проза", PublishingYear = 2018, Pages = 320, CoverType = "Суперобложка", BookPrice = 330, SupplyDate = "27.08.2018", Rest = 248 },
                new Book { PublishingHouseId = 3, SupplierId = 10, ISBN = "9785040976379", Name = "Великий Гэтсби", Author = "Фицджеральд Ф.", TypeId = 1, Genre = "Классическая и современная проза", PublishingYear = 2018, Pages = 256, CoverType = "Мягкая бумажная", BookPrice = 311, SupplyDate = "08.10.2018", Rest = 198 },
                new Book { PublishingHouseId = 1, SupplierId = 3, ISBN = "9785171100841", Name = "Все о шифрах и кодах: в мире математики и криптографии", Author = "Душкин Р.", TypeId = 2, Genre = "Детская научно-популярная литература", PublishingYear = 2018, Pages = 448, CoverType = "Твердая бумажная", BookPrice = 298, SupplyDate = "12.10.2018", Rest = 400 },
                new Book { PublishingHouseId = 1, SupplierId = 10, ISBN = "9785171059668", Name = "Спящие красавицы", Author = "Кинг С., Кинг О.", TypeId = 1, Genre = "Фэнтези", PublishingYear = 2018, Pages = 768, CoverType = "Твердая бумажная", BookPrice = 587, SupplyDate = "12.10.2018", Rest = 1000 },
                new Book { PublishingHouseId = 1, SupplierId = 5, ISBN = "9785170965595", Name = "Собор Парижской Богоматери", Author = "Гюго В.", TypeId = 1, Genre = "Классическая и современная проза", PublishingYear = 2016, Pages = 512, CoverType = "Твердая бумажная", BookPrice = 237, SupplyDate = "12.10.2018", Rest = 35 },
                new Book { PublishingHouseId = 1, SupplierId = 3, ISBN = "9785170828791", Name = "Хоббит", Author = "Толкин Дж.", TypeId = 2, Genre = "Детская художественная литература", PublishingYear = 2015, Pages = 304, CoverType = "Твердая бумажная", BookPrice = 539, SupplyDate = "12.10.2018", Rest = 742 },
                new Book { PublishingHouseId = 1, SupplierId = 1, ISBN = "9785170921928", Name = "Тимур и его команда", Author = "Гайдар А.", TypeId = 3, Genre = "Средняя школа", PublishingYear = 2015, Pages = 317, CoverType = "Твердая бумажная", BookPrice = 170, SupplyDate = "12.10.2018", Rest = 666 },
                new Book { PublishingHouseId = 3, SupplierId = 2, ISBN = "9785699801305", Name = "Список Шиндлера", Author = "Кенилли Т.", TypeId = 1, Genre = "Исторический роман", PublishingYear = 2016, Pages = 480, CoverType = "Твердая бумажная", BookPrice = 475, SupplyDate = "12.10.2018", Rest = 321 },
                new Book { PublishingHouseId = 1, SupplierId = 2, ISBN = "9785170607778", Name = "Просто вместе", Author = "Гавальда А.", TypeId = 1, Genre = "Классическая и современная проза", PublishingYear = 2009, Pages = 573, CoverType = "Твердая бумажная", BookPrice = 356, SupplyDate = "12.10.2018", Rest = 57 },
                new Book { PublishingHouseId = 3, SupplierId = 1, ISBN = "9785699649327", Name = "Кафка на пляже", Author = "Мураками Х.", TypeId = 1, Genre = "Классическая и современная проза", PublishingYear = 2013, Pages = 736, CoverType = "Мягкая глянцевая", BookPrice = 171, SupplyDate = "12.10.2018", Rest = 89 },
                new Book { PublishingHouseId = 3, SupplierId = 3, ISBN = "9785699878727", Name = "Шляпа, полная неба", Author = "Пратчетт Т.", TypeId = 2, Genre = "Детская художественная литература", PublishingYear = 2016, Pages = 400, CoverType = "Твердая бумажная", BookPrice = 360, SupplyDate = "12.10.2018", Rest = 267 },
                new Book { PublishingHouseId = 1, SupplierId = 10, ISBN = "9785170843022", Name = "Океан в конце дороги", Author = "Гейман Н.", TypeId = 1, Genre = "Фэнтези", PublishingYear = 2015, Pages = 288, CoverType = "Твердая бумажная", BookPrice = 317, SupplyDate = "12.10.2018", Rest = 890 },
                new Book { PublishingHouseId = 1, SupplierId = 10, ISBN = "9785170616497", Name = "История с кладбищем", Author = "Гейман Н.", TypeId = 2, Genre = "Детская художественная литература", PublishingYear = 2009, Pages = 320, CoverType = "Мягкая бумажная", BookPrice = 251, SupplyDate = "12.10.2018", Rest = 456 },
                new Book { PublishingHouseId = 3, SupplierId = 5, ISBN = "9785699773015", Name = "Кошка, шляпа и кусок веревки", Author = "Харрис Дж.", TypeId = 1, Genre = "Классическая и современная проза", PublishingYear = 2015, Pages = 384, CoverType = "Мягкая глянцевая", BookPrice = 154, SupplyDate = "12.10.2018", Rest = 1000 },
                new Book { PublishingHouseId = 8, SupplierId = 1, ISBN = "9785386083960", Name = "Один день", Author = "Николс Д.", TypeId = 1, Genre = "Классическая и современная проза", PublishingYear = 2015, Pages = 576, CoverType = "Твердая бумажная", BookPrice = 420, SupplyDate = "12.10.2018", Rest = 2500 },
                new Book { PublishingHouseId = 3, SupplierId = 2, ISBN = "9785699373802", Name = "Над кукушкиным гнездом", Author = "Кизи К.", TypeId = 1, Genre = "Классическая и современная проза", PublishingYear = 2009, Pages = 384, CoverType = "Мягкая глянцевая", BookPrice = 191, SupplyDate = "12.10.2018", Rest = 655 }
            };
            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();

            var deliveries = new List<Delivery>
            {
                new Delivery { Name = "BoxBerry", Phone = "8 (800) 222-80-00", Cost = 201 },
                new Delivery { Name = "PickPoint", Phone = "8 (800) 700-79-09", Cost = 227 },
                new Delivery { Name = "СДЭК", Phone = "8 (800) 250-04-05", Cost = 250 }
            };
            deliveries.ForEach(s => context.Deliveries.Add(s));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee { Name = "Иванцов Михаил Викторович", Birthday = "18.10.1980", Address = "603000, г. Нижний Новгород, ул. Белинского, 32, 20", Phone = "+7 (999) 423-89-93", Position = "Гениральный директор" },
                new Employee { Name = "Ковалёва Людмила Александровна", Birthday = "21.12.1989", Address = "603105, г. Нижний Новгород, ул. Ошарская, 78, 5", Phone = "+7 (910) 555-38-03", Position = "Продавец-кассир" },
                new Employee { Name = "Фролов Павел Сергеевич", Birthday = "05.06.1990", Address = "603032, г. Нижний Новгород, ул. Вали Котика, 15, 10", Phone = "+7 (962) 666-11-10", Position = "Продавец-консультант" },
                new Employee { Name = "Никитина Ольга Ивановна", Birthday = "11.04.1975", Address = "603002, г. Нижний Новгород, ул. Луначарского, 8, 2", Phone = "+7 (905) 311-44-10", Position = "Старший продавец" },
                new Employee { Name = "Степаненко Татьяна Викторовна", Birthday = "30.12.1968", Address = "603009, г. Нижний Новгород, Гагарина проспект, 74, 18", Phone = "+7 (910) 555-03-30", Position = "Уборщица" },
                new Employee { Name = "Скобелев Степан Николаевич", Birthday = "17.07.1963", Address = "603005, г. Нижний Новгород, ул. Пискунова, 24, 33", Phone = "+7 (980) 713-51-08", Position = "Кладовщик" }
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

            var clients = new List<Client>
            {
                new Client { Name = "Лимаренко Анастасия Алексеевна", Birthday = "25.05.1998", Address = "603022, г. Нижний Новгород, проспект Гагарина, 1, 105", Phone = "8 (999) 137-31-17" },
                new Client { Name = "Климашевская Анастасия Владимировна", Birthday = "26.11.1998", Address = "603022, г. Нижний Новгород, проспект Гагарина, 1, 105", Phone = "8 (999) 138-27-42" },
                new Client { Name = "Баранов Святослав Николаевич", Birthday = "31.08.1999", Address = "г. Орел, ул. Максима Горького, 115, 425", Phone = "8 (919) 260-70-01" },
                new Client { Name = "Беляев Денис Михайлович", Birthday = "11.01.1998", Address = "Владимирская обл., ул. Карла Маркса, 71, 1", Phone = "8 (999) 710-06-28" },
                new Client { Name = "Сафронов Дмитрий Владимирович", Birthday = "18.08.2000", Address = "Брянская обл., г. Клинцы, пер. Зайцев, 5, 24", Phone = "8 (930) 734-01-54" }
            };
            clients.ForEach(s => context.Clients.Add(s));
            context.SaveChanges();

            var orders = new List<Purchase>
            {
                new Purchase { Id = 12275568, EmployeeId = 2, ClientId = 1, DeliveryId = 1, Ordate = "08.10.2018", Address = "603022, г.Нижний Новгород, проспект Гагарина, 1, 105", Delcost = 201, Saledate = "12.10.2018" },
                new Purchase { Id = 12676924, EmployeeId = 3, ClientId = 2, DeliveryId = 2, Ordate = "15.10.2018", Address = "603022, г.Нижний Новгород, проспект Гагарина, 1, 105", Delcost = 227, Saledate = "12.11.2018" },
                new Purchase { Id = 17557820, EmployeeId = 2, ClientId = 3, DeliveryId = 3, Ordate = "13.10.2018", Address = "г. Орел, ул. Максима Горького, 115, 425", Delcost = 250, Saledate = "12.11.2018" },
                new Purchase { Id = 16759665, EmployeeId = 2, ClientId = 4, DeliveryId = 1, Ordate = "01.10.2018", Address = "Владимирская обл., г. Муром, ул. Карла Маркса, 71, 1", Delcost = 201, Saledate = "02.10.2018" },
                new Purchase { Id = 13250641, EmployeeId = 3, ClientId = 5, DeliveryId = 2, Ordate = "17.10.2018", Address = "Брянская обл., г. Клинцы, пер. Зайцев, 5, 24", Delcost = 227, Saledate = "12.11.2018" }
            };
            orders.ForEach(s => context.Purchases.Add(s));
            context.SaveChanges();

            var ordered = new List<Purchased>
            {
                new Purchased { Id = 1050, PurchaseId = 12275568, BookId = 1, OrderPrice = 246, Number = 1 },
                new Purchased { Id = 4022, PurchaseId = 17557820, BookId = 2, OrderPrice = 301, Number = 3 },
                new Purchased { Id = 1045, PurchaseId = 12676924, BookId = 3, OrderPrice = 861, Number = 1 },
                new Purchased { Id = 3141, PurchaseId = 13250641, BookId = 4, OrderPrice = 702, Number = 1 },
                new Purchased { Id = 2021, PurchaseId = 12275568, BookId = 5, OrderPrice = 504, Number = 1 },
                new Purchased { Id = 1100, PurchaseId = 12275568, BookId = 6, OrderPrice = 330, Number = 1 },
                new Purchased { Id = 3050, PurchaseId = 12275568, BookId = 7, OrderPrice = 311, Number = 2 },
                new Purchased { Id = 1075, PurchaseId = 12676924, BookId = 8, OrderPrice = 298, Number = 1 },
                new Purchased { Id = 2000, PurchaseId = 12676924, BookId = 9, OrderPrice = 587, Number = 1 },
                new Purchased { Id = 2025, PurchaseId = 17557820, BookId = 10, OrderPrice = 237, Number = 2 },
                new Purchased { Id = 2525, PurchaseId = 17557820, BookId = 11, OrderPrice = 539, Number = 1 },
                new Purchased { Id = 3010, PurchaseId = 16759665, BookId = 12, OrderPrice = 170, Number = 5 },
                new Purchased { Id = 3205, PurchaseId = 16759665, BookId = 13, OrderPrice = 475, Number = 1 },
                new Purchased { Id = 4045, PurchaseId = 16759665, BookId = 14, OrderPrice = 356, Number = 1 },
                new Purchased { Id = 4510, PurchaseId = 13250641, BookId = 15, OrderPrice = 171, Number = 2 },
                new Purchased { Id = 5000, PurchaseId = 13250641, BookId = 16, OrderPrice = 360, Number = 1 }
            };
            ordered.ForEach(s => context.PurchasedBooks.Add(s));
            context.SaveChanges();
        }
    }
}