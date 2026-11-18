using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_069_JA_08 : CardInfo
{
    public CardInfo_069_JA_08()
    {
        this.cardNo = "069_JA_08";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "マダム・ミム";
        this.cardName2 = "サイ";
        this.power = 6;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlibethZermeno;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift2 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
