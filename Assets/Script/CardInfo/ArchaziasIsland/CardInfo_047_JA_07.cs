using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_047_JA_07 : CardInfo
{
    public CardInfo_047_JA_07()
    {
        this.cardNo = "047_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ç‡ïÛÇÃéÁåÏé“";
        this.cardName2 = "ïsãgÇ»ÇÈî‘êl";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlexandriaNeonakis;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
