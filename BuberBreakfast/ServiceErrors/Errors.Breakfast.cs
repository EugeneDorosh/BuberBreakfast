using ErrorOr;

namespace BuberBreakfast.ServiceErrors
{
    public static class Errors
    {
        public static class Breakfast
        {
            public static Error NotFound => Error.NotFound(
                code: "Breakfast.NotFound",
                description: "Breakfast not found"
                );

            public static Error InvalidName => Error.Validation(
                code: "Breakfast.Validation",
                description: $"Breakfast name must be at least {Models.Breakfast.MinNameLength} " +
                $"and max {Models.Breakfast.MaxNameLength}.");

            public static Error InvalidDescription => Error.Validation(
                code: "Breakfast.Validation",
                description: $"Breakfast description must be at least {Models.Breakfast.MinDescriptionLength} " +
                $"and max {Models.Breakfast.MaxDescriptionLength}.");
        }
    }
}
