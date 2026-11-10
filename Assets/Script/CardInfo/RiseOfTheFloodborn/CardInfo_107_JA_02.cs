using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_107_JA_02 : CardInfo
{
    public CardInfo_107_JA_02()
    {
        this.cardNo = "107_JA_02";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "フェリシア";
        this.cardName2 = "いつも腹ペコ";
        this.power = 3;
        this.toughness = 1;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.Cookie;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
