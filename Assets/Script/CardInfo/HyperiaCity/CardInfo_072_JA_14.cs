using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_072_JA_14 : CardInfo
{
    public CardInfo_072_JA_14()
    {
        this.cardNo = "072_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ゴー・ゴー・トマゴ";
        this.cardName2 = "徹底テスター";
        this.power = 2;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LaurenBarger;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
