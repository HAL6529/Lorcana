using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_070_JA_07 : CardInfo
{
    public CardInfo_070_JA_07()
    {
        this.cardNo = "070_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "キナイ";
        this.cardName2 = "魔法のクマ";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JeannePlounevez;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BrotherBear;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
