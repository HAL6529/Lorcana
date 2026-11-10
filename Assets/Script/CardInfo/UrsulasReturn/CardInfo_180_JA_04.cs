using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_180_JA_04 : CardInfo
{
    public CardInfo_180_JA_04()
    {
        this.cardNo = "180_JA_04";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ヘラクレス";
        this.cardName2 = "大人気ヒーロー";
        this.power = 6;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard, EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
