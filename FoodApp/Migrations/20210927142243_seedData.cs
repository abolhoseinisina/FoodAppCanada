using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodApp.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FoodGroups",
                columns: new[] { "Id", "FoodGroupCategoryId", "FoodGroupCategoryName", "FoodGroupId", "FoodGroupName" },
                values: new object[,]
                {
                    { 2L, 2, "Dark green vegetable", "vf", "Vegetables and Fruit" },
                    { 9L, 9, "Meat, fish, poultry and shellfish", "me", "Meat and Alternatives" },
                    { 8L, 8, "Meat Alternatives", "me", "Meat and Alternatives" },
                    { 7L, 7, "Milk Alternataives", "mi", "Milk and Alternatives" },
                    { 6L, 6, "Milk", "mi", "Milk and Alternatives" },
                    { 5L, 4, "Whole grain", "gr", "Grains" },
                    { 4L, 5, "Non whole grain", "gr", "Grains" },
                    { 3L, 3, "Orange vegetable", "vf", "Vegetables and Fruit" },
                    { 1L, 1, "Non dark green or orange vegetable", "vf", "Vegetables and Fruit" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "FoodGroupCategory", "FoodGroupId", "Foods", "ServingSize" },
                values: new object[,]
                {
                    { 108L, 4, "gr", "\"Rice cake, plain\"", "2 medium" },
                    { 107L, 4, "gr", "\"Rice, white\"", "\"125 mL, � cup cooked\"" },
                    { 106L, 4, "gr", "Polenta", "\"125 mL, � cup cooked\"" },
                    { 1L, 1, "vf", "Asparagus", "\"125 mL, � cup, 6 spears\"" },
                    { 104L, 4, "gr", "\"Pasta/noodles, white\"", "\"125 mL, � cup cooked\"" },
                    { 109L, 4, "gr", "\"Roll, white\"", "\"1 roll, 35 g\"" },
                    { 105L, 4, "gr", "\"Pita, white\"", "\"� pita, 35 g\"" },
                    { 110L, 3, "gr", "\"Crackers, whole wheat\"", "30 g" },
                    { 115L, 3, "gr", "\"English muffin, whole grain\"", "\"� muffin, 35 g\"" },
                    { 112L, 3, "gr", "\"Roll, whole wheat\"", "\"1 roll, 35 g\"" },
                    { 113L, 3, "gr", "\"Couscous, whole wheat\"", "\"125 mL, � cup - cooked\"" },
                    { 114L, 3, "gr", "\"Popcorn, without added fat or salt\"", "\"500 mL, 2 cups\"" },
                    { 103L, 4, "gr", "Pancake", "\"1 small, 35 g\"" },
                    { 116L, 6, "mi", "Buttermilk", "\"250 mL, 1 cup\"" },
                    { 117L, 6, "mi", "Fortified soy beverage (unsweetened) ", "\"250 mL, 1 cup\"" },
                    { 111L, 3, "gr", "\"Rice, wild\"", "\"125 mL, � cup cooked\"" },
                    { 102L, 4, "gr", "Naan", "\"� naan, 35 g\"" },
                    { 97L, 4, "gr", "Congee", "\"125 mL, � cup cooked\"" },
                    { 100L, 4, "gr", "\"Cracker, saltines\"", "\"10, 30 g\"" },
                    { 85L, 3, "gr", "\"Muffin, whole grain\"", "\"�, 35 g\"" },
                    { 86L, 3, "gr", "Quinoa", "\"125 mL, � cup cooked\"" },
                    { 87L, 3, "gr", "\"Rice, brown\"", "\"125 mL, � cup cooked\"" },
                    { 88L, 3, "gr", "\"Pasta/noodles, whole grain\"", "\"125 mL, � cup cooked\"" },
                    { 89L, 3, "gr", "\"Pita, whole wheat\"", "\"� pita, 35 g\"" },
                    { 90L, 4, "gr", "\"Tortilla, corn\"", "\"� piece, 35 g\"" },
                    { 91L, 3, "gr", "\"Tortilla, whole wheat\"", "\"� piece, 35 g\"" },
                    { 92L, 4, "gr", "Bannock", "\"1 medium, 35 g\"" },
                    { 93L, 4, "gr", "\"Baguette, French\"", "\"1 slice, 35 g\"" },
                    { 94L, 4, "gr", "\"Bread, white\"", "\"1 slice, 35 g\"" },
                    { 95L, 4, "gr", "\"Cereal, cold\"", "30 g" },
                    { 96L, 4, "gr", "\"Cereal, hot, for example: cream of wheat\"", "\"150 g, 175 mL, � cup cooked\"" },
                    { 118L, 5, "mi", "\"Milk, 1%, 2%, skim\"", "\"250 mL, 1 cup\"" },
                    { 98L, 4, "gr", "Cornbread", "\"1 slice, 35 g\"" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "FoodGroupCategory", "FoodGroupId", "Foods", "ServingSize" },
                values: new object[,]
                {
                    { 99L, 4, "gr", "Couscous", "\"125 mL, � cup cooked\"" },
                    { 101L, 4, "gr", "\"English muffin, white\"", "\"� muffin, 35 g\"" },
                    { 120L, 5, "mi", "\"Milk, goat, enriched\"", "\"250 mL, 1 cup\"" },
                    { 125L, 6, "mi", "\"Cheese, cottage or quark\"", "\"250 ml, 1 cup\"" },
                    { 122L, 5, "mi", "\"Milk, powdered\"", "\"250 mL, 1 cup reconstitued\"" },
                    { 142L, 8, "me", "Duck", "75 g (2� oz) / 125 mL (� cup)" },
                    { 143L, 8, "me", "\"Fish and shellfish, canned (example: crab, salmon, tuna)\"", "75 g (2� oz) / 125 mL (� cup)" },
                    { 144L, 8, "me", "\"Fish, fresh or frozen (example: herring, mackerel, trout, salmon, sardines, squid, tuna)\"", "75 g (2� oz) / 125 mL (� cup)" },
                    { 145L, 8, "me", "\"Game birds (example: ptarmigan, partridge, grouse, goose)\"", "75 g (2� oz) / 125 mL (� cup)" },
                    { 146L, 8, "me", "\"Game meats (example: deer, moose, caribou, elk)\"", "75 g (2� oz) / 125 mL (� cup)" },
                    { 147L, 8, "me", "Goat", "75 g (2� oz) / 125 mL (� cup)" },
                    { 141L, 8, "me", "\"Deli meat, low-fat, lower sodium\"", "75 g (2� oz) / 125 mL (� cup)" },
                    { 148L, 8, "me", "Ham", "75 g (2� oz) / 125 mL (� cup)" },
                    { 150L, 8, "me", "\"Organ meat (example: liver, kidney)\"", "75 g (2� oz) / 125 mL (� cup)" },
                    { 151L, 8, "me", "Pork", "75 g (2� oz) / 125 mL (� cup)" },
                    { 152L, 8, "me", "Rabbit /Hare", "75 g (2� oz) / 125 mL (� cup)" },
                    { 153L, 8, "me", "\"Shellfish, fresh or frozen (example: clams, crab, lobster, mussels, scallops, shrimp, prawns)\"", "75 g (2� oz) / 125 mL (� cup)" },
                    { 154L, 8, "me", "Turkey", "75 g (2� oz) / 125 mL (� cup)" },
                    { 155L, 8, "me", "Veal", "75 g (2� oz) / 125 mL (� cup)" },
                    { 149L, 8, "me", "Lamb", "75 g (2� oz) / 125 mL (� cup)" },
                    { 140L, 8, "me", "Chicken", "75 g (2� oz) / 125 mL (� cup)" },
                    { 139L, 8, "me", "Bison/Buffalo", "75 g (2� oz) / 125 mL (� cup)" },
                    { 138L, 8, "me", "Beef", "75 g (2� oz) / 125 mL (� cup)" },
                    { 123L, 5, "mi", "\"Milk, powdered\"", "\"25 g, 75 mL, 1/3 cup\"" },
                    { 124L, 6, "mi", "\"Cheese, block (Cheddar, Mozzarella, Swiss, feta)\"", "\"50 g, 1 , � oz\"" },
                    { 84L, 3, "gr", "\"Crackers, rye \"", "30 g" },
                    { 126L, 6, "mi", "\"Cheese, goat\"", "\"50 g, 1 , � oz\"" },
                    { 127L, 6, "mi", "Paneer", "\"50 g, 1 , � oz\"" },
                    { 128L, 6, "mi", "\"Yogurt, plain\"", "\"175 g, 175ml, � cup\"" },
                    { 129L, 5, "mi", "\"Milk, whole\"", "\"250 mL, 1 cup\"" },
                    { 130L, 6, "mi", "Kefir", "\"175 g, 175 mL, � cup\"" },
                    { 131L, 7, "me", "\"Beans, cooked and canned\"", "\"175 mL, � cup\"" },
                    { 132L, 7, "me", "Eggs", "2" },
                    { 133L, 7, "me", "Lentils", "\"175 mL, � cup\"" },
                    { 134L, 7, "me", "\"Nuts, shelled\"", "\"60 mL, � cup\"" },
                    { 135L, 7, "me", "Peanut butter or nut butters", "\"30 mL, 2 Tbsp\"" },
                    { 136L, 7, "me", "\"Seeds, shelled\"", "\"60 mL, � cup\"" },
                    { 137L, 7, "me", "Tofu", "\"150 g, 175 mL, � cup\"" },
                    { 121L, 5, "mi", "\"Milk, lactose reduced\"", "\"250 mL, 1 cup\"" },
                    { 83L, 3, "gr", "\"Cereal, hot, whole grain (example: oatmeal)\"", "\"150 g, 175 mL, � cup cooked\"" },
                    { 119L, 5, "mi", "\"Milk, evaporated, canned\"", "\"125 mL, � cup undiluted\"" },
                    { 81L, 1, "gr", "Bulgur", "\"125 mL, � cup cooked\"" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "FoodGroupCategory", "FoodGroupId", "Foods", "ServingSize" },
                values: new object[,]
                {
                    { 23L, 2, "vf", "Sweet potato", "\"125 mL, � cup\"" },
                    { 24L, 2, "vf", "Yam", "\"125 mL, � cup\"" },
                    { 25L, 0, "vf", "\"Apricot, fresh\"", "3 fruits" },
                    { 26L, 0, "vf", "Cantaloupe", "\"125 mL, � cup\"" },
                    { 27L, 0, "vf", "Mango", "\"125 mL, � cup, � fruit\"" },
                    { 28L, 0, "vf", "Nectarine", "1 fruit" },
                    { 29L, 0, "vf", "Papaya", "� fruit" },
                    { 30L, 0, "vf", "Peach", "1 medium" },
                    { 31L, 0, "vf", "Apple", "1 medium" },
                    { 32L, 0, "vf", "Avocado", "� fruit" },
                    { 33L, 0, "vf", "Bamboo shoots", "\"125 mL, � cup\"" },
                    { 34L, 0, "vf", "Banana", "1 medium" },
                    { 35L, 0, "vf", "\"Beans, yellow\"", "\"125 mL, � cup\"" },
                    { 36L, 0, "vf", "Beets", "\"125 mL, � cup\"" },
                    { 37L, 0, "vf", "Berries", "\"125 mL, � cup\"" },
                    { 38L, 0, "vf", "Bitter melon", "\"125 mL, � cup, � pod\"" },
                    { 39L, 0, "vf", "Cabbage", "\"125 mL, � cup\"" },
                    { 22L, 2, "vf", "Squash", "\"125 mL, � cup\"" },
                    { 40L, 0, "vf", "Cauliflower", "\"125 mL, � cup, 4 flowerets\"" },
                    { 21L, 1, "vf", "Spinach", "\"250 mL, 1 cup raw\"" },
                    { 19L, 1, "vf", "Seaweed", "\"125 mL, � cup\"" },
                    { 2L, 1, "vf", "\"Beans, green\"", "\"125 mL, � cup\"" },
                    { 3L, 1, "vf", "Bok choy/Chinese cabbage (Choi sum)", "\"125 mL, � cup cooked\"" },
                    { 4L, 1, "vf", "Broccoli", "\"125 mL, � cup\"" },
                    { 82L, 3, "gr", "\"Cereal, cold, whole grain\"", "30 g" },
                    { 6L, 2, "vf", "Carrots", "\"125 mL, � cup, 1 large\"" },
                    { 7L, 1, "vf", "Chard", "\"125 mL, � cup\"" },
                    { 8L, 1, "vf", "Dandelion greens", "\"250 mL, 1 cup raw\"" },
                    { 9L, 1, "vf", "Endive", "\"250 mL, 1 cup\"" },
                    { 10L, 1, "vf", "Fiddleheads", "\"125 mL, � cup\"" },
                    { 11L, 1, "vf", "Kale/collards", "\"250 mL, 1 cup raw\"" },
                    { 12L, 1, "vf", "Leeks", "\"125 mL, � cup, � leek\"" },
                    { 13L, 1, "vf", "\"Lettuce, romaine\"", "\"250 mL, 1 cup raw\"" },
                    { 14L, 1, "vf", "Mesclun mix", "\"250 mL, 1 cup raw\"" },
                    { 15L, 1, "vf", "Mustard greens", "\"250 mL, 1 cup raw\"" },
                    { 16L, 1, "vf", "Okra", "\"125 mL, � cup\"" },
                    { 17L, 1, "vf", "Peas", "\"125 mL, � cup\"" },
                    { 18L, 2, "vf", "Pumpkin", "\"125 mL, � cup\"" },
                    { 20L, 1, "vf", "Snow peas", "\"125 mL, � cup\"" },
                    { 41L, 0, "vf", "Celery", "1 medium stalk" },
                    { 5L, 1, "vf", "Brussels sprouts", "\"125 mL, � cup, 4 sprouts\"" },
                    { 43L, 0, "vf", "Cherries", "20" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "FoodGroupCategory", "FoodGroupId", "Foods", "ServingSize" },
                values: new object[,]
                {
                    { 64L, 0, "vf", "Plantain", "\"125 mL, � cup\"" },
                    { 65L, 0, "vf", "Plum", "1 fruit" },
                    { 66L, 0, "vf", "Potato", "\"125 mL, � cup, � medium\"" },
                    { 67L, 0, "vf", "Radishes", "\"125 mL, � cup\"" },
                    { 68L, 0, "vf", "Rhubarb", "\"125 mL, � cup\"" },
                    { 69L, 0, "vf", "Tomato", "\"125 mL, � cup\"" },
                    { 70L, 0, "vf", "Tomato sauce", "\"125 mL, � cup\"" },
                    { 71L, 0, "vf", "Turnip", "\"125 mL, � cup\"" },
                    { 72L, 0, "vf", "\"Vegetable juice, lower sodium\"", "\"125 mL, � cup\"" },
                    { 73L, 0, "vf", "Watermelon", "\"125 mL, � cup\"" },
                    { 74L, 1, "vf", "Zucchini", "\"125 mL, � cup\"" },
                    { 75L, 1, "vf", "\"Pepper, sweet, green\"", "\"125 mL, � cup, � medium\"" },
                    { 76L, 1, "vf", "Edemame (soy beans)", "\"125 mL, � cup\"" },
                    { 78L, 3, "gr", "\"Bagel, whole grain\"", "\"� bagel, 45 g\"" },
                    { 79L, 3, "gr", "\"Bread, pumpernickel or rye\"", "\"1 slice, 35 g\"" },
                    { 80L, 3, "gr", "\"Bread, whole grain\"", "\"1 slice, 35 g\"" },
                    { 42L, 0, "vf", "Chayote", "\"125 mL, � cup\"" },
                    { 63L, 0, "vf", "Pineapple", "\"125 mL, � cup, 1 slice\"" },
                    { 62L, 0, "vf", "\"Peppers, bell\"", "\"125 mL, � cup, � medium\"" },
                    { 77L, 3, "gr", "Barley", "\"125 mL, � cup cooked\"" },
                    { 60L, 0, "vf", "Orange", "1 medium" },
                    { 45L, 0, "vf", "Cucumber", "\"125 mL, � cup\"" },
                    { 46L, 0, "vf", "Dried fruit", "\"60 mL, � cup\"" },
                    { 44L, 0, "vf", "Corn", "\"1 ear, 125 mL, � cup\"" },
                    { 47L, 0, "vf", "Eggplant", "\"125 mL, � cup\"" },
                    { 48L, 0, "vf", "\"Fig, fresh\"", "2 medium" },
                    { 61L, 0, "vf", "Pear", "1 medium" },
                    { 50L, 0, "vf", "Grapes", "20 fruits" },
                    { 51L, 0, "vf", "Guava", "\"125 mL, � cup, 1 fruit\"" },
                    { 49L, 0, "vf", "Grapefruit", "� fruit" },
                    { 53L, 0, "vf", "100% fruit juice", "\"125 mL, 1/2 cup\"" },
                    { 54L, 0, "vf", "Kiwi", "1 large fruit" },
                    { 55L, 0, "vf", "Kohlrabi", "\"125 mL, � cup\"" },
                    { 56L, 0, "vf", "Lettuce (example: iceberg or butterhead)", "\"250 mL, 1 cup raw\"" },
                    { 57L, 0, "vf", "Lychee", "10 fruits" },
                    { 58L, 0, "vf", "Mixed vegetables", "\"125 mL, � cup\"" },
                    { 59L, 0, "vf", "Mushrooms", "\"125 mL, � cup\"" },
                    { 52L, 0, "vf", "Honeydew", "\"125 mL, � cup\"" }
                });

            migrationBuilder.InsertData(
                table: "Servings",
                columns: new[] { "Id", "Age", "FoodGroupId", "Gender", "Servings" },
                values: new object[,]
                {
                    { 46L, "51 to 70", "mi", "Male", "3" },
                    { 45L, "51 to 70", "mi", "Female", "3" },
                    { 44L, "31 to 50", "mi", "Male", "2" },
                    { 43L, "31 to 50", "mi", "Female", "2" }
                });

            migrationBuilder.InsertData(
                table: "Servings",
                columns: new[] { "Id", "Age", "FoodGroupId", "Gender", "Servings" },
                values: new object[,]
                {
                    { 42L, "19 to 30", "mi", "Male", "2" },
                    { 36L, "4 to 8", "mi", "Male", "2" },
                    { 40L, "14 to 18", "mi", "Male", "3 to 4" },
                    { 39L, "14 to 18", "mi", "Female", "3 to 4" },
                    { 38L, "9 to 13", "mi", "Male", "3 to 4" },
                    { 37L, "9 to 13", "mi", "Female", "3 to 4" },
                    { 47L, "71+", "mi", "Female", "3" },
                    { 35L, "4 to 8", "mi", "Female", "2" },
                    { 41L, "19 to 30", "mi", "Female", "2" },
                    { 48L, "71+", "mi", "Male", "3" },
                    { 57L, "19 to 30", "me", "Female", "2" },
                    { 50L, "2 to 3", "me", "Male", "1" },
                    { 34L, "2 to 3", "mi", "Male", "2" },
                    { 64L, "71+", "me", "Male", "3" },
                    { 63L, "71+", "me", "Female", "2" },
                    { 62L, "51 to 70", "me", "Male", "3" },
                    { 61L, "51 to 70", "me", "Female", "2" },
                    { 60L, "31 to 50", "me", "Male", "3" },
                    { 49L, "2 to 3", "me", "Female", "1" },
                    { 59L, "31 to 50", "me", "Female", "2" },
                    { 56L, "14 to 18", "me", "Male", "3" },
                    { 55L, "14 to 18", "me", "Female", "2" },
                    { 54L, "9 to 13", "me", "Male", "1 to 2" },
                    { 53L, "9 to 13", "me", "Female", "1 to 2" },
                    { 52L, "4 to 8", "me", "Male", "1" },
                    { 51L, "4 to 8", "me", "Female", "1" },
                    { 58L, "19 to 30", "me", "Male", "3" },
                    { 33L, "2 to 3", "mi", "Female", "2" },
                    { 18L, "2 to 3", "gr", "Male", "3" },
                    { 31L, "71+", "gr", "Female", "6" },
                    { 1L, "2 to 3", "vf", "Female", "4" },
                    { 2L, "2 to 3", "vf", "Male", "4" },
                    { 3L, "4 to 8", "vf", "Female", "5" },
                    { 4L, "4 to 8", "vf", "Male", "5" },
                    { 5L, "9 to 13", "vf", "Female", "6" },
                    { 6L, "9 to 13", "vf", "Male", "6" },
                    { 7L, "14 to 18", "vf", "Female", "7" },
                    { 8L, "14 to 18", "vf", "Male", "8" },
                    { 9L, "19 to 30", "vf", "Female", "7 to 8" },
                    { 32L, "71+", "gr", "Male", "7" },
                    { 11L, "31 to 50", "vf", "Female", "7 to 8" },
                    { 12L, "31 to 50", "vf", "Male", "8 to 10" }
                });

            migrationBuilder.InsertData(
                table: "Servings",
                columns: new[] { "Id", "Age", "FoodGroupId", "Gender", "Servings" },
                values: new object[,]
                {
                    { 13L, "51 to 70", "vf", "Female", "7" },
                    { 14L, "51 to 70", "vf", "Male", "7" },
                    { 10L, "19 to 30", "vf", "Male", "8 to 10" },
                    { 16L, "71+", "vf", "Male", "7" },
                    { 30L, "51 to 70", "gr", "Male", "7" },
                    { 15L, "71+", "vf", "Female", "7" },
                    { 28L, "31 to 50", "gr", "Male", "8" },
                    { 27L, "31 to 50", "gr", "Female", "6 to 7" },
                    { 26L, "19 to 30", "gr", "Male", "8" },
                    { 25L, "19 to 30", "gr", "Female", "6 to 7" },
                    { 29L, "51 to 70", "gr", "Female", "6" },
                    { 23L, "14 to 18", "gr", "Female", "6" },
                    { 22L, "9 to 13", "gr", "Male", "6" },
                    { 21L, "9 to 13", "gr", "Female", "6" },
                    { 20L, "4 to 8", "gr", "Male", "4" },
                    { 19L, "4 to 8", "gr", "Female", "4" },
                    { 17L, "2 to 3", "gr", "Female", "3" },
                    { 24L, "14 to 18", "gr", "Male", "7" }
                });

            migrationBuilder.InsertData(
                table: "Statements",
                columns: new[] { "Id", "DirectionalStatement", "FoodGroupId" },
                values: new object[,]
                {
                    { 8L, "\"Have meat alternatives such as beans, lentils and tofu often.\"", "me" },
                    { 7L, "Select lower fat milk alternatives.", "mi" },
                    { 6L, "\"Drink skim, 1%, or 2% milk each day.\"", "mi" },
                    { 5L, "\"Choose grain products that are lower in fat, sugar or salt.\"", "gr" },
                    { 2L, "\"Choose vegetables and fruit prepared with little or no added fat, sugar or salt.\"", "vf" },
                    { 3L, "Have vegetables and fruit more often than juice.", "vf" },
                    { 1L, "Eat at least one dark green and one orange vegetable each day.", "vf" },
                    { 9L, "Eat at least two Food Guide Servings of fish each week.", "me" },
                    { 4L, "Make at least half of your grain products whole grain each day.", "gr" },
                    { 10L, "Select lean meat and alternatives prepared with little or no added fat or salt.", "me" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Servings",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Statements",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Statements",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Statements",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Statements",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Statements",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Statements",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Statements",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Statements",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Statements",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Statements",
                keyColumn: "Id",
                keyValue: 10L);
        }
    }
}
