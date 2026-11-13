using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_075_JA_07 : CardInfo
{
    public CardInfo_075_JA_07()
    {
        this.cardNo = "075_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "パニック";
        this.cardName2 = "ビクビクしいの小悪魔";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AriannaRea;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
