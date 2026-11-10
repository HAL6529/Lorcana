using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_122_JA_02 : CardInfo
{
    public CardInfo_122_JA_02()
    {
        this.cardNo = "122_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉâÅ[ÉÑ";
        this.cardName2 = "äÊå≈é“";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AmberKommavongsa;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
