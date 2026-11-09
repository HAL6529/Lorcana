using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_155_JA_02 : CardInfo
{
    public CardInfo_155_JA_02()
    {
        this.cardNo = "155_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ƒmƒC";
        this.cardName2 = "ŒÇŽ™‚Ì“D–_";
        this.power = 1;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KristinaChori;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
