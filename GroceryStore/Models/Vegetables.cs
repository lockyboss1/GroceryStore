using System;
using System.Collections.Generic;

namespace GroceryStore.Models
{
    public static class MyVegetables
    {
        public static List<GroceryItem> Vegetables()
        {
            return new List<GroceryItem>
      {
        new GroceryItem(name: "Artichoke", imgsrc: "images/artichoke.png", price: 1.99,
        desc: "Our green Artichokes are produced year round, the highest quality with the freshest taste."),

        new GroceryItem(name: "Aubergine", imgsrc: "images/aubergine.png", price: 2.99,
        desc: "Mild, earthy-flavored Aubergine that has the most velvety texture inside."),

        new GroceryItem(name: "Broccoli", imgsrc: "images/broccoli.png", price: 3.99,
        desc: "Nutritious and low in calories! Fresh green Broccoli that has a satisfying crunch."),

        new GroceryItem(name: "Cabbage", imgsrc: "images/cabbage.png", price: 2.49,
        desc: "Crunchy cabbage is nutrient rich and a great source of vitamin C, vitamin K, fibre and folate. " +
        "Cabbage comes in many shapes and in a variety of colours including green, white and red."),

        new GroceryItem(name: "Carrot", imgsrc: "images/Carrot.png", price: 1.49,
        desc: "Carrot is a root vegetable often claimed to be the perfect health food. It is crunchy, tasty, and highly nutritious"),

        new GroceryItem(name: "Cauliflower", imgsrc: "images/cauliflower.png", price: 2.99,
        desc: "Cauliflower is a cruciferous vegetable that is naturally high in fiber and B-vitamins."),

        new GroceryItem(name: "Mushrooms", imgsrc: "images/mushrooms.png", price: 2.99,
        desc: "Mushrooms are edible fungus that can provide several important nutrients. The many kinds of mushroom " +
        "have varying compositions and nutritional profiles."),

        new GroceryItem(name: "Onion", imgsrc: "images/onion.png", price: 0.99,
        desc: "Onions vary in size, shape, color, and flavor. The most common types are red, yellow, and white onions. The taste of these " +
        "vegetables can range from sweet and juicy to sharp, spicy, and pungent."),

         new GroceryItem(name: "Potato", imgsrc: "images/potato.png", price: 1.99,
        desc: "Potatoes are a versatile root vegetable and a staple food in many households"),

        new GroceryItem(name: "Spinach", imgsrc: "images/spinach.png", price: 1.99,
        desc: "Spinach is a superfood. It is loaded with tons of nutrients in a low-calorie package. " +
        "Dark, leafy greens like spinach are important for skin, hair, and bone health."),

         new GroceryItem(name: "Sweet-Potato", imgsrc: "images/sweetpotato.png", price: 3.99,
        desc: "Sweet potatoes are sweet, starchy root vegetables that are grown worldwide. They come in a variety of sizes and colors — " +
        "including orange, white, and purple — and are rich in vitamins, minerals, antioxidants, and fiber."),

        new GroceryItem(name: "Tomato", imgsrc: "images/tomato.png", price: 0.49,
        desc: "A tomato is a nutrient-dense superfood that offers benefit to a range of bodily systems. Its nutritional content " +
        "supports healthful skin, weight loss, and heart health.")
        
      };
        }
    }
}
