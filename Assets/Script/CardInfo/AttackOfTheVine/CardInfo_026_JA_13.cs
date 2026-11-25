using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_026_JA_13 : CardInfo
{
    public CardInfo_026_JA_13()
    {
        this.cardNo = "026_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "アースラ";
        this.cardName2 = "ヴァインズの創造物";
        this.power = 3;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.PaulineVoss;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Vineling };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
