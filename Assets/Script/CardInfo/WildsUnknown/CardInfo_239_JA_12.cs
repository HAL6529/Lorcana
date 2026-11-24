using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_239_JA_12 : CardInfo
{
    public CardInfo_239_JA_12()
    {
        this.cardNo = "239_JA_12";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "Mrs.インクレディブル";
        this.cardName2 = "決意の救出者";
        this.power = 5;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.ArchApolar;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
