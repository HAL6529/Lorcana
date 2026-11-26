using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_077_JA_14 : CardInfo
{
    public CardInfo_077_JA_14()
    {
        this.cardNo = "077_JA_14";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "フック船長";
        this.cardName2 = "船長は心配性";
        this.power = 9;
        this.toughness = 9;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
