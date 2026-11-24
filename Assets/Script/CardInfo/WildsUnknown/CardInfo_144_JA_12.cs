using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_144_JA_12 : CardInfo
{
    public CardInfo_144_JA_12()
    {
        this.cardNo = "144_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "キーダ";
        this.cardName2 = "入り口の番人";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.TimVanGalen;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
