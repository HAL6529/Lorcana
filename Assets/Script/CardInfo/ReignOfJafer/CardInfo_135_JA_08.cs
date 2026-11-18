using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_135_JA_08 : CardInfo
{
    public CardInfo_135_JA_08()
    {
        this.cardNo = "135_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "レック・イット・ラルフ";
        this.cardName2 = "タンデムレーサー";
        this.power = 4;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JosephBuenning;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
