using Mushrooms.Core;
using Mushrooms.Core.Interfaces;
using Mushrooms.Database.Seeds.InfoCategories;

namespace Mushrooms.Database.Seeds
{
    public static class MainCategoriesSeed
    {
        public static void Seed(IApplicationDbContext dbContext)
        {
            MushroomDelightsSeed.Seed(dbContext);
            BooksGiftsAndSouvenirsSeed.Seed(dbContext);
            MushroomSpeciesSeed.Seed(dbContext);
            MedicinalMushroomsSeed.Seed(dbContext);
            MycorrhizaPlantFertilizerSeed.Seed(dbContext);
            MushroomCultivationSeed.Seed(dbContext);
        }
    }

    public static class InfoCategoriesSeed
    {
        public static void Seed(IApplicationDbContext dbContext)
        {
            AboutTheMashroomSeed.Seed(dbContext);
            CultivationSeed.Seed(dbContext);
            MycorrhizaSeed.Seed(dbContext);
            RecipesSeed.Seed(dbContext);
        }
    }
}
