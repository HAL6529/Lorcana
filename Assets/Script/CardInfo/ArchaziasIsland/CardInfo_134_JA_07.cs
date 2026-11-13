using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_134_JA_07 : CardInfo
{
    public CardInfo_134_JA_07()
    {
        this.cardNo = "134_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒ‚ƒAƒi";
        this.cardName2 = "“‡‚Ì’TŒŸ‰Æ";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JackieDroujko;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
