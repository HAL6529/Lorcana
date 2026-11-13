using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_055_JA_07 : CardInfo
{
    public CardInfo_055_JA_07()
    {
        this.cardNo = "055_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ƒGƒ‹ƒT";
        this.cardName2 = "—Š‚ê‚éŽo";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AmberKommavongsa;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
