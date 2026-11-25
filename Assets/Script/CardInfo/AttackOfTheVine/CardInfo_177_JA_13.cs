using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_177_JA_13 : CardInfo
{
    public CardInfo_177_JA_13()
    {
        this.cardNo = "177_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アラジン";
        this.cardName2 = "ヴァインズの創造物";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlejandroHernandez;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Vineling };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
