using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_071_JA_04 : CardInfo
{
    public CardInfo_071_JA_04()
    {
        this.cardNo = "071_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ディアブロ";
        this.cardName2 = "マレフィセントのスパイ";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EllieHorie;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
