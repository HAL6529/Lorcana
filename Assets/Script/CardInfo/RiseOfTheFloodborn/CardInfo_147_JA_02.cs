using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_147_JA_02 : CardInfo
{
    public CardInfo_147_JA_02()
    {
        this.cardNo = "147_JA_02";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ガストン";
        this.cardName2 = "パワフルなインテリ";
        this.power = 4;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.MatthewRobertDavies;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
