using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_138_JA_14 : CardInfo
{
    public CardInfo_138_JA_14()
    {
        this.cardNo = "138_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "シンデレラ";
        this.cardName2 = "手縫いの仕立て屋";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AubreyArcher;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
