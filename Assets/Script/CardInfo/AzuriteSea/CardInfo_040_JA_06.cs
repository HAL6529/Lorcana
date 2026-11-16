using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_040_JA_06 : CardInfo
{
    public CardInfo_040_JA_06()
    {
        this.cardNo = "040_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "îíÉoÉâ";
        this.cardName2 = "â‘âÄÇÃïÛêŒ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CoryGodbey;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
