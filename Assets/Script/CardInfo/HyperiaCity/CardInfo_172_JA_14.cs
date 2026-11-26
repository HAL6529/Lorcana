using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_172_JA_14 : CardInfo
{
    public CardInfo_172_JA_14()
    {
        this.cardNo = "172_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アーサー";
        this.cardName2 = "マーリンの助手";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LauraDePascale;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
