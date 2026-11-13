using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_192_JA_07 : CardInfo
{
    public CardInfo_192_JA_07()
    {
        this.cardNo = "192_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒJƒJƒ‚ƒ‰";
        this.cardName2 = "ŠC‘¯’‡ŠÔ‚¾";
        this.power = 1;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
