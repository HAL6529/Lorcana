using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_122_JA_06 : CardInfo
{
    public CardInfo_122_JA_06()
    {
        this.cardNo = "122_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ピート";
        this.cardName2 = "ぶんどり船員";
        this.power = 5;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CelesteJamneckAndMarianaMoreno;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
