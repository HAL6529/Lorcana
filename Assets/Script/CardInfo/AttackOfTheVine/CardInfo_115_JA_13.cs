using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_115_JA_13 : CardInfo
{
    public CardInfo_115_JA_13()
    {
        this.cardNo = "115_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ガストン";
        this.cardName2 = "ヴァインズの創造物";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Vineling };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
