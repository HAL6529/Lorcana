using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_093_JA_08 : CardInfo
{
    public CardInfo_093_JA_08()
    {
        this.cardNo = "093_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "マッド・ドッグ";
        this.cardName2 = "カルナージの一等航海士";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LuisHuerta;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
