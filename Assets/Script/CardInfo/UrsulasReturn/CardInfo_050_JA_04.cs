using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_050_JA_04 : CardInfo
{
    public CardInfo_050_JA_04()
    {
        this.cardNo = "050_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ñÇñ@ÇÃâ∆ê≠ïw";
        this.cardName2 = "âHÇ⁄Ç§Ç´";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.NataliaTrykowska;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
