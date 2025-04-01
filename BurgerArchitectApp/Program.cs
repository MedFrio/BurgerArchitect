using BurgerArchitectApp.Builders;
using System;

var burger = new BurgerBuilder()
    .SetPain("Blanc")
    .SetViande("Bœuf")
    .AddAccompagnement("Fromage")
    .AddAccompagnement("Salade")
    .Build();

Console.WriteLine("Burger personnalisé :");
Console.WriteLine(burger);
