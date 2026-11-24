using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_025_JA_12 : CardInfo
{
    public CardInfo_025_JA_12()
    {
        this.cardNo = "025_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "プルート";
        this.cardName2 = "用心深い旅人";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
