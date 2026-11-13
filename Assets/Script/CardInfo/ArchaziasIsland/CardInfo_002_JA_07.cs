using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_002_JA_07 : CardInfo
{
    public CardInfo_002_JA_07()
    {
        this.cardNo = "002_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "パディータ";
        this.cardName2 = "いっしょに遊びましょ";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CecileCarre;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
