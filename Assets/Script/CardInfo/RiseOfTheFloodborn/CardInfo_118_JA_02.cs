using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_118_JA_02 : CardInfo
{
    public CardInfo_118_JA_02()
    {
        this.cardNo = "118_JA_02";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ÉiÉ}Å[Éä";
        this.cardName2 = "ãwìG";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HedvigH_S;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
