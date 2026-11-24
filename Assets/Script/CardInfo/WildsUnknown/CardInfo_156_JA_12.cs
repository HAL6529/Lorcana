using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_156_JA_12 : CardInfo
{
    public CardInfo_156_JA_12()
    {
        this.cardNo = "156_JA_12";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ブルーノ・マドリガル";
        this.cardName2 = "未来を見る者";
        this.power = 5;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlbertoBesi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
