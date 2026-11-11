using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_048_JA_05 : CardInfo
{
    public CardInfo_048_JA_05()
    {
        this.cardNo = "048_JA_05";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉGÉãÉT";
        this.cardName2 = "ëÊ5ÇÃê∏óÏ";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LisanneKoeteeuw;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
