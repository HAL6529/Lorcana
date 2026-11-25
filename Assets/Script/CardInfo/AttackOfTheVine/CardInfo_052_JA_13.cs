using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_052_JA_13 : CardInfo
{
    public CardInfo_052_JA_13()
    {
        this.cardNo = "052_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ピート";
        this.cardName2 = "ヴァインズの創造物";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KamilMurzyn;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Vineling };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
