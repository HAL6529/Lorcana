using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_108_JA_08 : CardInfo
{
    public CardInfo_108_JA_08()
    {
        this.cardNo = "108_JA_08";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ドン・カルナージ";
        this.cardName2 = "空の海賊の首領";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Prince, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
