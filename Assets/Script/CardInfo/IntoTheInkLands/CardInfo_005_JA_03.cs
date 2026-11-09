using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_005_JA_03 : CardInfo
{
    public CardInfo_005_JA_03()
    {
        this.cardNo = "005_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ジョシュア・スウィート";
        this.cardName2 = "ドクター";
        this.power = 1;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JeannePlounevez;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
