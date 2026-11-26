using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_139_JA_14 : CardInfo
{
    public CardInfo_139_JA_14()
    {
        this.cardNo = "139_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ワサビ";
        this.cardName2 = "未来思考者";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FrenchCarlomagno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
