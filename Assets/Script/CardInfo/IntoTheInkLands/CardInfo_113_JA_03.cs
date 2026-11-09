using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_113_JA_03 : CardInfo
{
    public CardInfo_113_JA_03()
    {
        this.cardNo = "113_JA_03";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "マウイ";
        this.cardName2 = "空翔ける半神";
        this.power = 5;
        this.toughness = 2;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.RobDiSalvo;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
