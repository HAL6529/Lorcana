using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_009_JA_07 : CardInfo
{
    public CardInfo_009_JA_07()
    {
        this.cardNo = "009_JA_07";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ミトンズ";
        this.cardName2 = "生意気な野良猫";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
