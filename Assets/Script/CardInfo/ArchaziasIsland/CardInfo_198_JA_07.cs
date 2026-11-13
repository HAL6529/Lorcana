using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_198_JA_07 : CardInfo
{
    public CardInfo_198_JA_07()
    {
        this.cardNo = "198_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "バギーラ";
        this.cardName2 = "守護者のジャガー";
        this.power = 4;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
