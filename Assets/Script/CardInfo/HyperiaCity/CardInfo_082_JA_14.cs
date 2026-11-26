using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_082_JA_14 : CardInfo
{
    public CardInfo_082_JA_14()
    {
        this.cardNo = "082_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ホーレス";
        this.cardName2 = "あいかわらずドジ";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KevinSidharta;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
