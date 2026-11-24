using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_212_JA_12 : CardInfo
{
    public CardInfo_212_JA_12()
    {
        this.cardNo = "212_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ドナルドダック";
        this.cardName2 = "気まぐれな旅人";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
