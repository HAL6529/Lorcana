using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_158_JA_13 : CardInfo
{
    public CardInfo_158_JA_13()
    {
        this.cardNo = "158_JA_13";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "マリアン姫";
        this.cardName2 = "ヴァインズの創造物";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MatteoMarzocco;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Princess, EnumController.Class.Vineling };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
