using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_178_JA_13 : CardInfo
{
    public CardInfo_178_JA_13()
    {
        this.cardNo = "178_JA_13";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "巨人のウィリー";
        this.cardName2 = "ヴァインズの創造物";
        this.power = 6;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CaroWaro;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Giant, EnumController.Class.Vineling };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
