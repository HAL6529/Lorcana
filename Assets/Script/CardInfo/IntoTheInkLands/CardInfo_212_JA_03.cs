using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_212_JA_03 : CardInfo
{
    public CardInfo_212_JA_03()
    {
        this.cardNo = "212_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉAÅ[ÉXÉâ";
        this.cardName2 = "éµÇ¬ÇÃäCÇÃÈxÇµâÆ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MatthewRobertDavies;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
