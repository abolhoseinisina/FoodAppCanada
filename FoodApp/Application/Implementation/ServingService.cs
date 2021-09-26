using FoodApp.Application.Interface;
using FoodApp.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using FoodApp.Application.Model;
using System;

namespace FoodApp.Application.Implementation
{
    public class ServingService : IServingService
    {
        public IServingRepository ServingRepository { get; }

        public IFoodGroupRepository FoodGroupRepository { get; }

        public IFoodRepository FoodRepository { get; }

        public IStatementRepository StatementRepository { get; }

        public ServingService(IServingRepository servingRepository,
                              IFoodGroupRepository foodGroupRepository,
                              IFoodRepository foodRepository,
                              IStatementRepository statementRepository)
        {
            ServingRepository = servingRepository;
            FoodGroupRepository = foodGroupRepository;
            FoodRepository = foodRepository;
            StatementRepository = statementRepository;
        }

        public async Task<ICollection<Serving>> GetProperServings(string gender, string ageRange)
        {
            var servings = await ServingRepository.GetServings();
            var properServingsForPerson = servings.Where(a => a.Gender == gender & a.Age == ageRange)
                                                  .ToList();
            return properServingsForPerson;
        }

        public async Task<ICollection<Serving>> GetAllServings()
        {
            var servings = await ServingRepository.GetServings();
            return servings;
        }

        public async Task<ICollection<string>> GetAgeRanges()
        {
            var servings = await ServingRepository.GetServings();
            var ageRange = servings.Select(c => c.Age)
                                   .Distinct()
                                   .ToList();
            return ageRange;
        }

        public async Task<ICollection<string>> GetGenderRanges()
        {
            var servings = await ServingRepository.GetServings();
            var genderRange = servings.Select(c => c.Gender)
                                      .Distinct()
                                      .ToList();
            return genderRange;
        }

        public async Task<DailyMenuDTO> GetDailyMenu(GenderAge genderAge)
        {
            var servings = await ServingRepository.GetServings();
            var selectedServings = servings.Where(c => c.Gender == genderAge.Gender && c.Age == genderAge.Age)
                                          .ToList();
            if (selectedServings == null) return null;
            var foodGroups = await FoodGroupRepository.GetFoodGroups();
            var foods = await FoodRepository.GetFoods();
            var statements = await StatementRepository.GetStatements();

            var dailyMenu = new DailyMenuDTO { Age = genderAge.Age, Gender = genderAge.Gender };
            var meals = new List<Meal>();
            foreach(var serving in selectedServings)
            {
                var selectedfoodGroups =  foodGroups.Where(c => c.FoodGroupId == serving.FoodGroupId)
                                     .Select(c => new { c.FoodGroupCategoryId , c.FoodGroupName, c.FoodGroupId });
                if (selectedfoodGroups == null) continue;
                foreach(var foodGroup in selectedfoodGroups)
                {
                    var food = foods.Where(c => c.FoodGroupId == serving.FoodGroupId && c.FoodGroupCategory == (foodGroup.FoodGroupCategoryId - 1))
                                      .OrderBy(r => Guid.NewGuid())
                                      .FirstOrDefault();
                    if (food == null) continue;
                    meals.Add(new Meal
                    {
                        FoodGroupId = foodGroup.FoodGroupId,
                        FoodGroup = foodGroup.FoodGroupName,
                        Food = food.Foods,
                        ServingSize = food.ServingSize
                    });
                }
            }
            dailyMenu.Meals = meals;

            var directions = new List<Direction>();
            foreach(var statement in statements)
            {
                directions.Add(new Direction
                {
                    FoodGroupId = statement.FoodGroupId,
                    Statement = statement.DirectionalStatement
                });
            }
            dailyMenu.Directions = directions;

            return dailyMenu;
        }
    }
}
