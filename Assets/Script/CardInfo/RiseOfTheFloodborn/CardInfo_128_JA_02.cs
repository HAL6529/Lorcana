using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_128_JA_02 : CardInfo
{
    public CardInfo_128_JA_02()
    {
        this.cardNo = "128_JA_02";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ƒgƒDƒNƒgƒDƒN";
        this.cardName2 = "‚Ô‚¿‚©‚Ü‚·‘å‹Ê";
        this.power = 4;
        this.toughness = 5;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
