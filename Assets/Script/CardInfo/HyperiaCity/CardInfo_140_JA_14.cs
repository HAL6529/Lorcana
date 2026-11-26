using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_140_JA_14 : CardInfo
{
    public CardInfo_140_JA_14()
    {
        this.cardNo = "140_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ベイマックス";
        this.cardName2 = "医師免許取得済";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Robot };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
