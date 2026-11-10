using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_177_JA_03 : CardInfo
{
    public CardInfo_177_JA_03()
    {
        this.cardNo = "177_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉLÅ[É_";
        this.cardName2 = "â§ë∞ÇÃêÌém";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarlosRuiz;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
