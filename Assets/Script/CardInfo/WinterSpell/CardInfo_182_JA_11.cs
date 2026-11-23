using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_182_JA_11 : CardInfo
{
    public CardInfo_182_JA_11()
    {
        this.cardNo = "182_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "デューク・ウィーゼルトン";
        this.cardName2 = "しかめっ面のチンピラ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AndreaFemerstrand;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
