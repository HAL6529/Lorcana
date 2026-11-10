using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_216_JA_02 : CardInfo
{
    public CardInfo_216_JA_02()
    {
        this.cardNo = "216_JA_02";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ÉiÉ}Å[Éä";
        this.cardName2 = "í©ñ∂";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JennaGray;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
