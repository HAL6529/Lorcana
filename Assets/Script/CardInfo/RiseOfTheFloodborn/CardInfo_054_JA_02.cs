using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_054_JA_02 : CardInfo
{
    public CardInfo_054_JA_02()
    {
        this.cardNo = "054_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "É}Å[ÉäÉì";
        this.cardName2 = "ÉäÉX";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
