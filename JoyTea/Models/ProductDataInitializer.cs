using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JoyTea.Models
{
    public class ProductDataInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CathegoryID = 1,
                    CategoryName = "Herbal Tea"
                },
                new Category
                {
                    CathegoryID = 2,
                    CategoryName = "Green Tea"
                },
                new Category
                {
                    CathegoryID = 3,
                    CategoryName = "Black Tea"
                },
                new Category
                {
                    CathegoryID = 4,
                    CategoryName = "Fruit Tea"
                }

            };
            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Healthy Edge",
                    Description = "Looking to up your game? We have specifically blended this fantastic tea with your best health in mind! With our fine quality pu'erh tea as the base, we've added some of the healthiest herbs to help you not only lose weight, but also to have an impeccable immune system, clear skin, and feel your best. Healthy Edge has a sweet and spicy, apple-cinnamon, raisin flavor that isn't overwhelming, but gentle and mild. Enjoy a cup and live on the edge!",
                    ImagePath = "healthy-edge.jpg",
                    UnitPrice = 5.74,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Pink Berry Moringa",
                    Description = "Pink Berry Moringa is a delightful blend with a delicate fresh harvested berries taste! Moringa (also known as Jacinto or Drumstick tree) is a small tree from India and Nepal that is a powerful antioxidant. It has been used for generations in the East to treat and prevent diseases such as diabetes, heart disease, anemia, arthritis, liver disease, and respiratory disorders, skin problems, and heal digestive disorders.",
                    ImagePath = "pink-berry-moringa.jpg",
                    UnitPrice = 4.51,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Holistic Health",
                    Description = "Breathe in, breathe out! Here is an herbal invitation to take some time for yourself, pull up a chair and relax!Our wellness and anti - inflammatory tea blend is created with your holistic health in mind.Ginger, fennel, liquorice, and turmeric steal the show as they soothe your irritated throat, aid in digestion, and provide wonderful anti - inflammatory properties.Naturally sweet cinnamon, and spicy black peppercorn, pair well with the gingery kick in this mild herbal wellness tea, to give it a light peppery freshness.Turmeric has been used for centuries in Traditional Ayurvedic medicine; as a natural anti - inflammatory, and natural pain killer, usually consumed in curry and other spiced dishes, here is just another wonderful way to add some to your day.",
                    ImagePath = "holistic-health.jpg",
                    UnitPrice = 4.10,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Bamboo Forest",
                    Description = "There is nothing quite like walking through a thick bamboo forest in Japan- a moment away from the hustle and bustle, a moment of pure serenity! Our Bamboo Forest is an inspired herbal blend featuring bamboo leaves and drumstick leaves, with lavender, lime and rose.",
                    ImagePath = "bamboo-forest.jpg",
                    UnitPrice = 4.51 ,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Tencha Mimoto Japanese",
                    Description = "A Tealyra North America exclusive, this rare Tencha Mimoto is produced organically in historical Kyoto, Japan. This is an incredible, fine deep emerald beauty. Tencha Mimoto is matcha in its un-powdered state. In processing tencha green tea, the leaves are shaded for 2-3 weeks before harvesting, afterward they are steamed, and dried without rolling- rather different than most traditional Japanese green teas. This tea is very nutritious, rich in theanine, producing a dark, rich infusion.",
                    ImagePath = "tencha-mimoto-japanese.jpg",
                    UnitPrice = 11.48,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Cui Ming Green",
                    Description = "A special spring harvested varietal of green tea grown in the highlands of Pu’erh, Yunnan and picked in the very earliest stages of growth. Cui Ming means  Bright Emerald  and is an appropriate name for this brilliant leaf! Rich in history and tea culture, the tea farmers in Pu’erh dedicate their lives to producing some of the finest tea in the world.",
                    ImagePath = "cui-ming-green.jpg",
                    UnitPrice = 6.97,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Gunpowder Temple of Heaven",
                    Description = "Chinese Gunpowder Temple of Heaven, or 平水珠茶 (Ping Shui Zhu Cha) is green tea that is traditionally grown and produced in Zhejiang province. It is unique in flavor and appearance, and instantly recognizable by its shiny, glossy, tightly rolled pellet shape. This is achieved by drying the tea leaves in rolling drums, causing the constantly rotated leaves to take on their signature spherical shape. Our organic Gunpowder Temple of Heaven tea is premium quality- its tightly rolled and shiny appearance are a clear indication of its superior quality! Producing a softer aroma than standard gunpowder offerings, our Gunpowder Temple of Heaven is less bitter than other gunpowder teas. Our Gunpowder Temple of Heaven has a gentle green aroma that is slightly smoky, once steeped its infusion has a bold, thick and strong flavor, with a smoky flavor note and an aftertaste that is slightly coppery. This is a green tea classic that is perfect to enjoy at any time of the day!",
                    ImagePath = "gunpowder-temple-of-heaven-organic.jpg",
                    UnitPrice =  3.89,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Japanese Cherry Green",
                    Description = "The perfect tea to accompany Hanami, which is the traditional practice of picnicking under a blooming sakura or 'ume' tree. Japanese Cherry is an organic green tea blend with rose petals and cherry. Traditional steamed green tea with slight astringency, the flavor of bright buttery greens, together with pure rose floral and a light natural cherry flavor that isn't artificial in any way. For your own Hanami inspired celebration wherever you call home- don't forget to pack your onigiri, and your Japanese parasol while you picnic! In Japan, cherry blossom season is looked forward to and celebrated by all, join in on the fun with our Japanese Cherry tea.",
                    ImagePath = "japanese-cherry-green.jpg",
                    UnitPrice = 4.10,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Wakoucha Japanese Black",
                    Description = "Wakoucha (meaning black tea grown and produced in Japan) is a rare and wonderful tea grown in Kagoshima prefecture. Japan is world famous for their distinctive and unmatched green teas- and their imited black tea varietals are just as unique and luxurious!",
                    ImagePath = "wakoucha-japanese-black.jpg",
                    UnitPrice = 4.92,
                    CategoryID = 3
                },

                 new Product
                {
                    ProductID = 10,
                    ProductName = "English Breakfast",
                    Description = "English Breakfast is one of the most popular tea blends, and an essential element in traditional British tea culture! Its origins vary, since drinking a blend of black teas for breakfast is a longstanding British custom, though the practice of referring to such a blend as English breakfast tea appears to have originated not in England but America, as far back as Colonial times! It is our pleasure here at Tealyra to be able to bring you this premium quality, organic English Breakfast.",
                    ImagePath = "english-breakfast-organic.jpg",
                    UnitPrice = 3.07,
                    CategoryID = 3
                },
                 new Product
                {
                    ProductID = 11,
                    ProductName = "Cream Irish Breakfast",
                    Description = "Here is an incredible bold and smooth tea inspired by classic Irish tea! The average Irish person consumes an impressive six cups of tea per day, leaving the British flagging behind! It is no wonder then, that the Irish are very particular about their tea, and this Cream Irish Breakfast is simply delicious! Truly a proper pure tea that delivers a robust brew that is both velvety smooth and has a natural hint of caramel sweetness!",
                    ImagePath = "cream-irish-breakfast.jpg",
                    UnitPrice = 3.69,
                    CategoryID = 3
                },
                  new Product
                {
                    ProductID = 12,
                    ProductName = "Earl Grey Classic",
                    Description = "Earl Grey is a refined English tea classic- and when you want a traditional flavor of the best English classic- there is absolutely no need to change something that is perfect as is!",
                    ImagePath = "earl-grey-classic.jpg",
                    UnitPrice = 3.28,
                    CategoryID = 3
                },

                 new Product
                {
                    ProductID = 13,
                    ProductName = "Pineapple Lemonade",
                    Description = "When life hands you lemons…you don’t just make any kind of lemonade. You steep up some Pineapple Lemonade! Pineapple Lemonade is such a fun herbal tea twist on a traditional lemonade, with the perfect combination of that classic tangy, sweet, tropical goodness that only pineapple can bring.",
                    ImagePath = "pineapple-lemonade.jpg",
                    UnitPrice = 4.10,
                    CategoryID = 4
                },
                 new Product
                {
                    ProductID = 14,
                    ProductName = "Pomegranate Raspberry",
                    Description = "A berry-licious fruit blend of poppin’ pomegranate and red raspberries! Our garden fresh blend has the perfect balance of sweet, tart, and fruity; and is perfect for the whole family. Pomegranates have been symbols of hope, prosperity, and abundance throughout history.They have inspired historical leaders, brilliant authors, famous artists, and now our inspiration for this lovely blend!",
                    ImagePath = "pomegranate-raspberry.jpg",
                    UnitPrice = 4.51,
                    CategoryID = 4
                },
                 new Product
                {
                    ProductID = 15,
                    ProductName = "Cherry Goddess",
                    Description = "Sweet, sweet cherries! Our Cherry Goddess is a rich fruity tisane with the unmistakeable succulent sweet flavor of pure late summer cherries! The perfect symphony of premium red berries, hibiscus, and fruit; Cherry Goddess is naturally flavored, yet has such a rich taste and mouthfeel, it makes an excellent alternative to sugary juice. The intoxicating aroma of natural cherry blends beautifully with the flavors of blackberry, cranberry and raspberry, with notes of elderberry, rosehips and tart hibiscus. Studies on hibiscus tea have shown to lower high blood pressure when consumed regularly, our Cherry Goddess is a way to change things up so you don’t get stuck in a hibiscus “rut”!  Sweet, satisfying, and amazing iced, try our Cherry Goddess if you’re a fan of bold tasting fruit tea!",
                    ImagePath = "cherry-goddess-fruity-tea.jpg",
                    UnitPrice = 4.51,
                    CategoryID = 4
                },
                  new Product
                {
                    ProductID = 16,
                    ProductName = "Florida Orange Juice",
                    Description = "There’s nothing quite like driving into Florida and taking in the aroma of orange oils in the warm breeze, or the taste of fresh Florida oranges! Our Florida Orange Juice blend has the pure taste of the sunshine state! Orange juice is Florida’s official state beverage- and naturally, we are proud to offer an herbal tea inspired by Florida’s precious citrus fruit!",
                    ImagePath = "florida-orange-juice.jpg",
                    UnitPrice = 4.10,
                    CategoryID =4
                }
            };
            return products;
        }
        
    }
}