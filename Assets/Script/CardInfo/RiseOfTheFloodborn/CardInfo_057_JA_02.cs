using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_057_JA_02 : CardInfo
{
    public CardInfo_057_JA_02()
    {
        this.cardNo = "057_JA_02";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ƒsƒmƒLƒI";
        this.cardName2 = "“¦‘–’†";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.IsaiahMesq;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Pinocchio;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
