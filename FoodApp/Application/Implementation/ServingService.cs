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

            var dailyMenu = new DailyMenuDTO { Age = genderAge.Age, Gender = genderAge.Gender, FoodGroups = new List<FoodGroupDTO>() };
            foreach (var serving in selectedServings)
            {
                var selectedfoodGroups =  foodGroups.Where(c => c.FoodGroupId == serving.FoodGroupId);
                if (selectedfoodGroups == null) continue;

                var foodGroupDTO = new FoodGroupDTO
                {
                    FoodGroupId = serving.FoodGroupId,
                    ServingPerDay = serving.Servings,
                    Foods = new List<FoodDTO>(),
                    Directions = new List<DirectionDTO>()
                };

                foreach (var foodGroup in selectedfoodGroups)
                {
                    foodGroupDTO.FoodGroupName = foodGroup.FoodGroupName;

                    var food = foods.Where(c => c.FoodGroupId == serving.FoodGroupId && c.FoodGroupCategory == (foodGroup.FoodGroupCategoryId - 1))
                                      .OrderBy(r => Guid.NewGuid())
                                      .FirstOrDefault();
                    if (food != null)
                    {
                        foodGroupDTO.Foods.Add(new FoodDTO
                        {
                            FoodCategory = foodGroup.FoodGroupCategoryName,
                            Food = food.Foods,
                            ServingSize = food.ServingSize
                        });
                    }
                }

                var directions = statements.Where(c => c.FoodGroupId == serving.FoodGroupId)
                                               .ToList();
                foreach (var direction in directions)
                {
                    foodGroupDTO.Directions.Add(new DirectionDTO
                    {
                        Statement = direction.DirectionalStatement
                    });
                }
                dailyMenu.FoodGroups.Add(foodGroupDTO);
            }
            
            return dailyMenu;
        }
    }
}
