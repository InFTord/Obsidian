﻿using Obsidian.API.Crafting;
using Obsidian.Serialization.Attributes;
using Obsidian.Utilities.Registry;

namespace Obsidian.Net.Packets.Play.Clientbound;

public partial class UpdateRecipesPacket : IClientboundPacket
{
    [Field(0)]
    public IDictionary<string, IRecipe> Recipes { get; }

    public int Id => 0x69;

    public static readonly UpdateRecipesPacket FromRegistry = new(Registry.Recipes);

    public UpdateRecipesPacket(IDictionary<string, IRecipe> recipes)
    {
        Recipes = recipes;
    }
}