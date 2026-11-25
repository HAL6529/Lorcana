using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_197_JA_13 : CardInfo
{
    public CardInfo_197_JA_13()
    {
        this.cardNo = "197_JA_13";
        this.inkCost = 10;
        this.availableInk = true;
        this.cardName1 = "大いなるヴァインズ";
        this.cardName2 = "邪悪の豆の木";
        this.power = 10;
        this.toughness = 10;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.NicholasKole;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.FloodBornShift7 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
