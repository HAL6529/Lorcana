using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_088_JA_07 : CardInfo
{
    public CardInfo_088_JA_07()
    {
        this.cardNo = "088_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "トーマス・オマリー";
        this.cardName2 = "ハンサムキャット";
        this.power = 4;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KasiaBrzezinska;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
