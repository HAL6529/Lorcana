using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_085_JA_02 : CardInfo
{
    public CardInfo_085_JA_02()
    {
        this.cardNo = "085_JA_02";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ルシファー";
        this.cardName2 = "ずるがしこい猫";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.IsabellaCeravolo;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
