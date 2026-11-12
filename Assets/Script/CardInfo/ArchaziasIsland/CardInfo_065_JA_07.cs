using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_065_JA_07 : CardInfo
{
    public CardInfo_065_JA_07()
    {
        this.cardNo = "065_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "スヴェン";
        this.cardName2 = "眼光鋭いトナカイ";
        this.power = 2;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
