using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_143_JA_12 : CardInfo
{
    public CardInfo_143_JA_12()
    {
        this.cardNo = "143_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "シンドローム";
        this.cardName2 = "悪の発明家";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Villain, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Alert };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
