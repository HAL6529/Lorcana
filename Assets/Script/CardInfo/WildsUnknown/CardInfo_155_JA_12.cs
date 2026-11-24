using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_155_JA_12 : CardInfo
{
    public CardInfo_155_JA_12()
    {
        this.cardNo = "155_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "シンデレラ";
        this.cardName2 = "工夫上手の旅人";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
