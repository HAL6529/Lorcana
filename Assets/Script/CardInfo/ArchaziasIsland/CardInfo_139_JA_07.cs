using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_139_JA_07 : CardInfo
{
    public CardInfo_139_JA_07()
    {
        this.cardNo = "139_JA_07";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "グーフィー";
        this.cardName2 = "やりすぎアスリート";
        this.power = 7;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.TeresitaQAndSCG;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
