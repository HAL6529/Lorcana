using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_035_JA_12 : CardInfo
{
    public CardInfo_035_JA_12()
    {
        this.cardNo = "035_JA_12";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "モルデュー";
        this.cardName2 = "プライド故に呪われし者";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JaviSalas;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
