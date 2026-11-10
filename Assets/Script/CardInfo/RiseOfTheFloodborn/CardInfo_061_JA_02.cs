using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_061_JA_02 : CardInfo
{
    public CardInfo_061_JA_02()
    {
        this.cardNo = "061_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ƒCƒYƒ}";
        this.cardName2 = "‰õ–°‚Å‚«‚¸";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.PabloHidalgo;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
