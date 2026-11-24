using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_172_JA_12 : CardInfo
{
    public CardInfo_172_JA_12()
    {
        this.cardNo = "172_JA_12";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "シンドローム";
        this.cardName2 = "復讐に燃える宿敵";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Super, EnumController.Class.Villain, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
