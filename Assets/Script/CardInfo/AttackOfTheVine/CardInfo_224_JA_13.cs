using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_224_JA_13 : CardInfo
{
    public CardInfo_224_JA_13()
    {
        this.cardNo = "224_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ムーラン";
        this.cardName2 = "ヴァインズの創造物";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AubreyArcher;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Princess, EnumController.Class.Vineling };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
