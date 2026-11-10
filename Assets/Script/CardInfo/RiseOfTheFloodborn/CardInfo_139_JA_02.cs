using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_139_JA_02 : CardInfo
{
    public CardInfo_139_JA_02()
    {
        this.cardNo = "139_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "バジル";
        this.cardName2 = "ベーカー街の探偵";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JakeParker;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
