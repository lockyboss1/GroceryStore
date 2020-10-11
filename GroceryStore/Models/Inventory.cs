using System;
using System.Collections.Generic;

namespace GroceryStore.Models
{
    public static class Inventory
    {
        public static List<GroceryItem> ToList()
        {
            return new List<GroceryItem>
      {
        new GroceryItem(name: "Apple", imgsrc: "images/apple.png", price: 2.99,
        desc: "Organic, delicious Honeycrisp Apple, grown and harvested at a local farm."),

        new GroceryItem(name: "Avocado", imgsrc: "images/avocado.png", price: 3.99,
        desc: "Delicious Avocados that have a buttery texture and rich flavor. Ripe and ready to eat!."),

        new GroceryItem(name: "Banana", imgsrc: "images/banana.png", price: 3.49,
        desc: "The banana is rich in fibre, potassium and some beneficial vitamins for health."),

        new GroceryItem(name: "Grapes", imgsrc: "images/grape.png", price: 5.49,
        desc: "It is a well-known fruit; it is eaten raw, although it is mainly used for making wine. Raw grapes are excellent as table dessert, " +
        "combined with other fruits in fruit salads."),

        new GroceryItem(name: "Guava", imgsrc: "images/guava.png", price: 2.99,
        desc: "Besides its unique flavour and fragrance, guava has been hailed as one of the super fruits due to the numerous health benefits it offers. It indeed is a powerhouse of nutrients. " +
        "This humble fruit is extraordinarily rich in vitamin C, lycopene and antioxidants that are beneficial for skin."),

         new GroceryItem(name: "Kiwi", imgsrc: "images/kiwi.png", price: 2.99,
        desc: "Kiwi is consumed as fresh fruit, in fruit salads, salads or as garnish for different dishes. In order to consume it as fruit, " +
        "it can be peeled or cut in half and eaten with a spoon."),

        new GroceryItem(name: "Lemon", imgsrc: "images/lemon.png", price: 4.99,
        desc: "The lemon is a round, slightly elongated fruit, it has a strong and resistant skin, with an intense bright yellow colour when it is totaly ripe, giving off a special aroma when it is cut. " +
        "The pulp is pale yellow, juicy and acid, divided in gores."),

        new GroceryItem(name: "Mango", imgsrc: "images/mango.png", price: 0.99,
        desc: "For its extraordinary taste, aroma, colour and texture it is ideal fruit to be eaten on its own, in fruit salads, to make sherbets, cakes and jam, " +
        "to mix in salads and even to cook it as seasoning for meat and fish."),

        new GroceryItem(name: "Orange", imgsrc: "images/orange.png", price: 1.99,
        desc: "Fresh oranges are low in calories and a source of fiber, potassium, vitamin C and folate."),

        new GroceryItem(name: "Pineapple", imgsrc: "images/pineapple.png", price: 3.49,
        desc: "Mature pineapples have a very singular fragrance, a beautiful colour and pleasant bittersweet taste. It is eaten raw or as an ingredient in juices, preserves, " +
        "liquors, etc. Both the fruit and the leaves are used to prepare medicinal compounds."),

        new GroceryItem(name: "Strawberry", imgsrc: "images/strawberry.png", price: 3.99,
        desc: "Strawberries are highly appreciated for their pleasant aroma and as an appetite stimulator, It is rich in basic minerals, " +
        "which confers it the property to stimulate the metabolism."),

        new GroceryItem(name: "Watermelon", imgsrc: "images/watermelon.png", price: 5.99,
        desc: "It is very rich in water; it hardly contains fats nor proteins, and therefore it is low in calories. Moreover, it is an important source of potassium and vitamin A. " +
        "It is a refreshing fruit with diuretic properties.")
      };
        }
    }
}
