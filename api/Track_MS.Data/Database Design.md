# Excercises 
[Table]
**Id(PK), Name, UserId, SessionId(FKC to `#Sessions`), CategoryId (FKC to `#Categories`), Unit (FKC to `#UnitOfMeasurements`), Sets, Reps, WeightValue, CardioValue**
1, "Bench press", 1, 10, 1, 3, 10, 50, NULL
2, "Running", 1, 10, 1, 3, NULL, NULL, NULL, 5

# Sessions
[Table]
**Id(PK), Name, UserId, State, Calories, Duration**
9, "Sunday", 1, 2, 360, 120
10, "Monday", 1, 2, 240, 60
11, "Tuesday", 1, 1, NULL, NULL *(Only one session open per one time)

State[Enum] {
    Current = 1, 
    Complete = 2, 
}

# Categories
[Table]
**Id (PKC), Name, UserId, ParentCategoryId**
1, "Cardio", NULL, NULL, *(as default)
2, "Weights", NULL, NULL, *(as default)

# UnitOfMeasurements
[Table]
**Id(PKC), Name, ParentCategoryId (FKC to `#Categories`), UserId**
1, "Kg", 2
2, "Pounds", 2,
3, "Km", 1,
4, "Minutes", 1
5, "Seconds, 1, 1 *(customer unit of measurement)
- Ability to add custom `#UnitOfMeasurements`