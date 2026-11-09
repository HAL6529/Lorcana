using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_051_JA_02 : CardInfo
{
    public CardInfo_051_JA_02()
    {
        this.cardNo = "051_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "É}Å[ÉäÉì";
        this.cardName2 = "ÉÑÉM";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.S_ShawAndL_Giammichele;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
