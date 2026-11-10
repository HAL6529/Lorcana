using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_026_JA_02 : CardInfo
{
    public CardInfo_026_JA_02()
    {
        this.cardNo = "026_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "èóâ§";
        this.cardName2 = "éxîzé“ÇÃÉIÅ[Éâ";
        this.power = 4;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MatthewRobertDavies;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift2 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
