using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_039_JA_02 : CardInfo
{
    public CardInfo_039_JA_02()
    {
        this.cardNo = "039_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒGƒ‹ƒT";
        this.cardName2 = "Žè‚Ì“à‚ðŒ©‚¹‚é‚í";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Challenger3 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
