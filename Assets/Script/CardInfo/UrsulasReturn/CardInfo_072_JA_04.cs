using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_072_JA_04 : CardInfo
{
    public CardInfo_072_JA_04()
    {
        this.cardNo = "072_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "グンター";
        this.cardName2 = "インテリアデザイナー";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AndersonMahanski;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
