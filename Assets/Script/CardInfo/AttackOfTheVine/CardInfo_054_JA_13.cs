using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_054_JA_13 : CardInfo
{
    public CardInfo_054_JA_13()
    {
        this.cardNo = "054_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ヘイヘイ";
        this.cardName2 = "ヴァインズの創造物";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OggyChristiansson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Vineling };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
