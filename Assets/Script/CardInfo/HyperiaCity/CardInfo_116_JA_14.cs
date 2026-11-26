using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_116_JA_14 : CardInfo
{
    public CardInfo_116_JA_14()
    {
        this.cardNo = "116_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ステイシー";
        this.cardName2 = "パワーラインの超ファン";
        this.power = 2;
        this.toughness = 2;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.VictorYanoCovarrubias;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
