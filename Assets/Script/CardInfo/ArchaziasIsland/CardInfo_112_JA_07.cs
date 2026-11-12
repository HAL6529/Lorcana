using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_112_JA_07 : CardInfo
{
    public CardInfo_112_JA_07()
    {
        this.cardNo = "112_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ダッチェス";
        this.cardName2 = "お上品キャット";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ThereseVildefall;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
