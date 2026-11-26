using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_141_JA_14 : CardInfo
{
    public CardInfo_141_JA_14()
    {
        this.cardNo = "141_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "キング・ルーイ";
        this.cardName2 = "アイスクリームの巨匠";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JustinRunfola;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
