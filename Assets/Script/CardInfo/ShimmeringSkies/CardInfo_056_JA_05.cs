using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_056_JA_05 : CardInfo
{
    public CardInfo_056_JA_05()
    {
        this.cardNo = "056_JA_05";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ÉAÉi";
        this.cardName2 = "îMêSÇ»å©èKÇ¢";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
