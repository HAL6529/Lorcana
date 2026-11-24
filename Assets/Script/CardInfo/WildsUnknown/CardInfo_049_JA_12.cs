using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_049_JA_12 : CardInfo
{
    public CardInfo_049_JA_12()
    {
        this.cardNo = "049_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "Mrs.インクレディブル";
        this.cardName2 = "ゴム人間ママ";
        this.power = 5;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MaxGrecke;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
