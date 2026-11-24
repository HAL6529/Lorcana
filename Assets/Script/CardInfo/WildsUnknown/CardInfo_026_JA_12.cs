using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_026_JA_12 : CardInfo
{
    public CardInfo_026_JA_12()
    {
        this.cardNo = "026_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "探検隊のリーダー";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LisanneKoeteeuw;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
