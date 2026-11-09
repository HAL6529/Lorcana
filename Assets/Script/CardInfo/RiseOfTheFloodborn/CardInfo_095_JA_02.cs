using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_095_JA_02 : CardInfo
{
    public CardInfo_095_JA_02()
    {
        this.cardNo = "095_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ヴィラーナ";
        this.cardName2 = "ファングの長";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.ManeKandalyanMandersonAndLucaPinelli;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
