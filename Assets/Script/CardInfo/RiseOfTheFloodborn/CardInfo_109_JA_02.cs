using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_109_JA_02 : CardInfo
{
    public CardInfo_109_JA_02()
    {
        this.cardNo = "109_JA_02";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ê≥íºÉWÉáÉì";
        this.cardName2 = "åæÇ§ÇŸÇ«ê≥íºÇ∂Ç·Ç»Ç¢";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SandraRios;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Pinocchio;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
