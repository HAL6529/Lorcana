using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_087_JA_03 : CardInfo
{
    public CardInfo_087_JA_03()
    {
        this.cardNo = "087_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "スキッピー";
        this.cardName2 = "元気な子ウサギ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JeannePlounevez;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
