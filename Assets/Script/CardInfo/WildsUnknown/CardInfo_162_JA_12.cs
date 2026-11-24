using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_162_JA_12 : CardInfo
{
    public CardInfo_162_JA_12()
    {
        this.cardNo = "162_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "首をはねるぞ！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.KatyaCyan;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
